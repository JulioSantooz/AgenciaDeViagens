IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Feeddback] (
    [Id_feedback] int NOT NULL IDENTITY,
    [Descricao] nvarchar(300) NOT NULL,
    [Data] DATE NOT NULL,
    CONSTRAINT [PK_Feeddback] PRIMARY KEY ([Id_feedback])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211218171952_MigracaoUm', N'5.0.13');
GO

COMMIT;
GO

