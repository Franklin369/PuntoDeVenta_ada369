from password_security import (
    decrypt_data,
    encrypt_data,
    generate_encryption_key,
    hash_password,
    password_policy,
    verify_password,
)


def test_password_policy_strong_password():
    policy = password_policy("MiContraseñaSegura#2026")
    assert policy["is_valid"] is True
    assert policy["score"] >= 80


def test_password_policy_weak_password():
    policy = password_policy("123456")
    assert policy["is_valid"] is False
    assert "longitud" in policy["errors"] or "numero" in policy["errors"]


def test_hash_and_verify_password():
    salt = "salt-demo-seguro"
    hashed = hash_password("MiClaveSegura!2026", salt)
    assert verify_password("MiClaveSegura!2026", hashed, salt) is True
    assert verify_password("OtraClave", hashed, salt) is False


def test_encrypt_and_decrypt_data():
    key = generate_encryption_key()
    ciphertext = encrypt_data("token-secreto-123", key)
    plaintext = decrypt_data(ciphertext, key)
    assert plaintext == "token-secreto-123"


def test_generate_encryption_key_is_bytes():
    key = generate_encryption_key()
    assert isinstance(key, bytes)
    assert len(key) > 0
