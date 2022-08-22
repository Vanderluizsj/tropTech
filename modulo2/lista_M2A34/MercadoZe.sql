CREATE DATABASE MERCADO_DO_ZE
GO
USE MERCADO_DO_ZE
GO
CREATE TABLE PRODUTO(
    ID INT IDENTITY(1,1) NOT NULL,
    NOME NVARCHAR(250) NOT NULL,
    DESCRICAO NVARCHAR(250) NOT NULL,
    DATA_VENCIMENTO DATE NOT NULL,
    PRECO_UNITARIO DECIMAL(11,2) NOT NULL,
    UNIDADE VARCHAR(150) NOT NULL,
    QTD_ESTOQUE INT NOT NULL,
    CONSTRAINT PK_PRODUTO PRIMARY KEY(ID_PRODUTO)
)