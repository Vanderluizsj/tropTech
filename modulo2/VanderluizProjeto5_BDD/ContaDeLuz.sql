CREATE DATABASE ContaDeLuz;

CREATE TABLE CONTA_DE_LUZ(
    DataDaLeitura INT NULL,
    Numero INT NOT NULL,
    QuantidadeKw DECIMAL (3, 0) NOT NULL,
    Val FLOAT NOT NULL,
    Datap DATETIME NOT NULL,
    MediaDeConsumo FLOAT NOT NULL
);

EXEC sp_rename 'CONTA_DE_LUZ.Val', 'Valor', 'COLUMN';
EXEC sp_rename 'CONTA_DE_LUZ.Datap', 'DataDePagamento', 'COLUMN';
EXEC sp_rename 'CONTA_DE_LUZ.Numero', 'NumeroDaFatura', 'COLUMN';

ALTER TABLE CONTA_DE_LUZ ALTER COLUMN DataDaLeitura DATETIME NOT NULL;
ALTER TABLE CONTA_DE_LUZ ALTER COLUMN QuantidadeKw DECIMAL (5, 2) NOT NULL;
ALTER TABLE CONTA_DE_LUZ ALTER COLUMN MediaDeConsumo DECIMAL (5, 2) NOT NULL;


