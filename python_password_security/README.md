# Sistema de verificación de contraseñas seguras

## Objetivo
Este proyecto implementa un sistema básico de seguridad para validar contraseñas y proteger información sensible con criptografía simple y almacenamiento en SQL Server.

## Idea general
- La contraseña se valida con reglas de complejidad.
- El hash se calcula con PBKDF2-HMAC-SHA256 usando sal aleatoria.
- La conexión a SQL Server se hace con pyodbc.
- El contenido sensible puede cifrarse con Fernet para almacenamiento o transporte seguro.

## Objetivos
1. Detectar contraseñas débiles antes de guardar información.
2. Guardar hashes en lugar de texto plano.
3. Usar sal para prevenir ataques por tablas arcoíris y diccionarios.
4. Registrar eventos de seguridad en la base de datos.
5. Demostrar fundamentos de ciberseguridad aplicados a Python.

## Algoritmos y técnicas
- Verificación de longitud y complejidad: longitud, mayúsculas, minúsculas, números, caracteres especiales.
- PBKDF2-HMAC-SHA256: derivación segura de clave para contraseñas.
- Sal aleatoria: `os.urandom(16).hex()`.
- Cifrado simétrico simple: `Fernet` de cryptography.
- SQL Server: almacenamiento persistente para usuarios, historial y auditoría.

## Estructura del proyecto
- `password_security.py`: lógica principal.
- `db/sql_server_schema.sql`: esquema de base de datos.
- `tests/test_password_security.py`: pruebas funcionales.
- `requirements.txt`: dependencias.

## Instalación
```bash
cd python_password_security
python -m pip install -r requirements.txt
```

## Ejecutar la demo
```bash
python password_security.py
```

## Prueba rápida
```bash
pytest -q
```

## Requisitos de SQL Server
Debe existir un servidor SQL Server con un driver ODBC compatible, por ejemplo:
- ODBC Driver 17 for SQL Server

En Windows, normalmente funciona si el servicio SQL Server está activo y la máquina tiene el driver instalado.
