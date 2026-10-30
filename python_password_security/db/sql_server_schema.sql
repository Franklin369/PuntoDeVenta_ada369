USE master;
GO
IF DB_ID('PasswordSecurityDB') IS NULL
BEGIN
    CREATE DATABASE PasswordSecurityDB;
END
GO

USE PasswordSecurityDB;
GO

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
GO

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
GO

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
GO

SELECT 'Database and schema ready.' AS Status;
