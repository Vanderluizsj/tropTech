CREATE DATABASE ControleDeRemedios;

CREATE TABLE CONTROLE_DE_REMEDIOS(
    NomePaciente NVARCHAR(5) NULL,
    DataInicio INT NOT NULL,
    QuantidadeDeDias FLOAT NOT NULL,
    QuantidadeDeVezesAoDia INT NOT NULL,
    Dose NVARCHAR(30) NOT NULL,
    Nome NVARCHAR(30) NOT NULL
);

EXEC sp_rename 'CONTROLE_DE_REMEDIOS.DataInicio', 'DataDeInicio', 'COLUMN';
EXEC sp_rename 'CONTROLE_DE_REMEDIOS.Dose', 'Dosagem', 'COLUMN';
EXEC sp_rename 'CONTROLE_DE_REMEDIOS.Nome', 'NomeDoRemedio', 'COLUMN';

ALTER TABLE CONTROLE_DE_REMEDIOS ALTER COLUMN NomePaciente NVARCHAR(100) NOT NULL;
ALTER TABLE CONTROLE_DE_REMEDIOS ALTER COLUMN DataDeInicio DATETIME NOT NULL;
ALTER TABLE CONTROLE_DE_REMEDIOS ALTER COLUMN QuantidadeDeDias INT NOT NULL;