import hashlib
import hmac
import os
import re
from datetime import datetime
from typing import Dict, List, Optional, Tuple

import pyodbc
from cryptography.fernet import Fernet


def generate_salt() -> str:
    return os.urandom(16).hex()


def hash_password(password: str, salt: str, iterations: int = 200_000) -> str:
    if not password:
        raise ValueError("La contraseña no puede estar vacía.")
    return hashlib.pbkdf2_hmac(
        "sha256",
        password.encode("utf-8"),
        salt.encode("utf-8"),
        iterations,
    ).hex()


def verify_password(password: str, stored_hash: str, salt: str, iterations: int = 200_000) -> bool:
    computed_hash = hash_password(password, salt, iterations)
    return hmac.compare_digest(computed_hash, stored_hash)


def password_policy(password: str) -> Dict[str, object]:
    checks = {
        "longitud": len(password) >= 12,
        "mayuscula": bool(re.search(r"[A-Z]", password)),
        "minuscula": bool(re.search(r"[a-z]", password)),
        "numero": bool(re.search(r"\d", password)),
        "especial": bool(re.search(r"[^A-Za-z0-9]", password)),
        "comun": password.lower() not in {"password", "123456", "qwerty", "admin", "welcome"},
    }

    errors = [name for name, ok in checks.items() if not ok]
    score = round((sum(checks.values()) / len(checks)) * 100)

    return {
        "is_valid": not errors,
        "score": score,
        "errors": errors,
        "recommendation": (
            "La contraseña es fuerte." if not errors else "Mejora la longitud, mayúsculas, números o caracteres especiales."
        ),
    }


def generate_encryption_key() -> bytes:
    return base64_urlsafe(os.urandom(32))


def base64_urlsafe(raw: bytes) -> bytes:
    import base64

    return base64.urlsafe_b64encode(raw)


def encrypt_data(plaintext: str, key: bytes) -> str:
    fernet = Fernet(key)
    return fernet.encrypt(plaintext.encode("utf-8")).decode("utf-8")


def decrypt_data(ciphertext: str, key: bytes) -> str:
    fernet = Fernet(key)
    return fernet.decrypt(ciphertext.encode("utf-8")).decode("utf-8")


def get_sql_connection(
    server: Optional[str] = None,
    database: Optional[str] = None,
    username: Optional[str] = None,
    password: Optional[str] = None,
    driver: str = "ODBC Driver 17 for SQL Server",
):
    server = server or os.getenv("SQL_SERVER_SERVER", "localhost")
    database = database or os.getenv("SQL_SERVER_DATABASE", "PasswordSecurityDB")
    username = username or os.getenv("SQL_SERVER_USERNAME")
    password = password or os.getenv("SQL_SERVER_PASSWORD")

    if username and password:
        conn_str = (
            f"DRIVER={{{driver}}};SERVER={server};DATABASE={database};"
            f"UID={username};PWD={password};Encrypt=yes;TrustServerCertificate=yes;"
        )
    else:
        conn_str = (
            f"DRIVER={{{driver}}};SERVER={server};DATABASE={database};"
            "Trusted_Connection=yes;Encrypt=yes;TrustServerCertificate=yes;"
        )

    return pyodbc.connect(conn_str)


def ensure_sql_tables(connection) -> None:
    with connection.cursor() as cursor:
        cursor.execute(
            """
            IF OBJECT_ID(N'dbo.Users', N'U') IS NULL
            BEGIN
                CREATE TABLE dbo.Users (
                    UserId INT IDENTITY(1,1) PRIMARY KEY,
                    Username VARCHAR(50) NOT NULL UNIQUE,
                    PasswordHash VARCHAR(255) NOT NULL,
                    Salt VARCHAR(64) NOT NULL,
                    CreatedAt DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
                    IsActive BIT NOT NULL DEFAULT 1
                );
            END
            """
        )
        cursor.execute(
            """
            IF OBJECT_ID(N'dbo.PasswordHistory', N'U') IS NULL
            BEGIN
                CREATE TABLE dbo.PasswordHistory (
                    HistoryId INT IDENTITY(1,1) PRIMARY KEY,
                    UserId INT NOT NULL,
                    PasswordHash VARCHAR(255) NOT NULL,
                    ChangedAt DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
                    CONSTRAINT FK_PasswordHistory_Users FOREIGN KEY (UserId) REFERENCES dbo.Users(UserId)
                );
            END
            """
        )
        cursor.execute(
            """
            IF OBJECT_ID(N'dbo.SecurityAudit', N'U') IS NULL
            BEGIN
                CREATE TABLE dbo.SecurityAudit (
                    AuditId INT IDENTITY(1,1) PRIMARY KEY,
                    UserId INT NULL,
                    Username VARCHAR(50) NULL,
                    EventType VARCHAR(50) NOT NULL,
                    EventTime DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
                    IsSuccess BIT NOT NULL,
                    Details VARCHAR(500) NULL,
                    CONSTRAINT FK_SecurityAudit_Users FOREIGN KEY (UserId) REFERENCES dbo.Users(UserId)
                );
            END
            """
        )
        connection.commit()


def register_user(connection, username: str, password: str) -> Dict[str, object]:
    username = username.strip()
    if not username:
        raise ValueError("El nombre de usuario no puede estar vacío.")

    policy = password_policy(password)
    if not policy["is_valid"]:
        raise ValueError(f"Contraseña insegura: {policy['errors']}")

    with connection.cursor() as cursor:
        cursor.execute("SELECT UserId FROM dbo.Users WHERE Username = ?", (username,))
        if cursor.fetchone():
            raise ValueError("El usuario ya existe.")

        salt = generate_salt()
        password_hash = hash_password(password, salt)
        cursor.execute(
            "INSERT INTO dbo.Users (Username, PasswordHash, Salt) VALUES (?, ?, ?)",
            (username, password_hash, salt),
        )
        user_id = cursor.execute("SELECT CAST(SCOPE_IDENTITY() AS INT)").fetchone()[0]
        cursor.execute(
            "INSERT INTO dbo.SecurityAudit (UserId, Username, EventType, IsSuccess, Details) VALUES (?, ?, ?, ?, ?)",
            (user_id, username, "REGISTER", 1, "Usuario registrado con política de contraseña validada."),
        )
        connection.commit()

    return {"user_id": user_id, "username": username, "status": "registered"}


def login_user(connection, username: str, password: str) -> Dict[str, object]:
    username = username.strip()
    with connection.cursor() as cursor:
        cursor.execute(
            "SELECT UserId, Username, PasswordHash, Salt FROM dbo.Users WHERE Username = ? AND IsActive = 1",
            (username,),
        )
        row = cursor.fetchone()
        if not row:
            cursor.execute(
                "INSERT INTO dbo.SecurityAudit (Username, EventType, IsSuccess, Details) VALUES (?, ?, ?, ?)",
                (username, "LOGIN_FAILED", 0, "Intento de acceso con usuario inexistente."),
            )
            connection.commit()
            return {"status": "failed", "message": "Credenciales inválidas."}

        user_id, stored_username, stored_hash, salt = row
        if verify_password(password, stored_hash, salt):
            cursor.execute(
                "INSERT INTO dbo.SecurityAudit (UserId, Username, EventType, IsSuccess, Details) VALUES (?, ?, ?, ?, ?)",
                (user_id, stored_username, "LOGIN_SUCCESS", 1, "Acceso correcto."),
            )
            connection.commit()
            return {"status": "success", "user_id": user_id, "username": stored_username}

        cursor.execute(
            "INSERT INTO dbo.SecurityAudit (UserId, Username, EventType, IsSuccess, Details) VALUES (?, ?, ?, ?, ?)",
            (user_id, stored_username, "LOGIN_FAILED", 0, "Contraseña incorrecta."),
        )
        connection.commit()
        return {"status": "failed", "message": "Credenciales inválidas."}


if __name__ == "__main__":
    print("Sistema de validación de contraseñas seguras")
    print("1. Registrar usuario")
    print("2. Iniciar sesión")
    option = input("Selecciona una opción: ").strip()

    try:
        connection = get_sql_connection()
        ensure_sql_tables(connection)

        if option == "1":
            username = input("Usuario: ")
            password = input("Contraseña: ")
            result = register_user(connection, username, password)
            print(result)
        elif option == "2":
            username = input("Usuario: ")
            password = input("Contraseña: ")
            result = login_user(connection, username, password)
            print(result)
        else:
            print("Opción no válida.")
    except Exception as exc:  # pragma: no cover - CLI guard
        print(f"Error: {exc}")
    finally:
        try:
            connection.close()
        except Exception:
            pass
