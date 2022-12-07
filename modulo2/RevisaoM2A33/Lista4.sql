USE TropTechModasDB

SELECT SUM(V.Valor) FROM VENDA V 
INNER JOIN CLIENTE C ON C.CadastroUnico = v.CadastroUnicoCliente
INNER JOIN Endereco E on e.Id = c.EnderecoId
WHERE E.Estado = 'Santa Catarina'

SELECT SUM(V.Valor) FROM VENDA V 
INNER JOIN CLIENTE C ON C.CadastroUnico = v.CadastroUnicoCliente
INNER JOIN Endereco E on e.Id = c.EnderecoId
WHERE E.Estado = 'São Paulo'

SELECT SUM(V.Valor) FROM VENDA V 
INNER JOIN CLIENTE C ON C.CadastroUnico = v.CadastroUnicoCliente
INNER JOIN Endereco E on e.Id = c.EnderecoId
WHERE E.Estado = 'Rio Grande do Sul'
=
SELECT e.Estado, SUM(V.Valor) FROM VENDA V 
INNER JOIN CLIENTE C ON C.CadastroUnico = v.CadastroUnicoCliente
INNER JOIN Endereco E on e.Id = c.EnderecoId
GROUP BY E.Estado

=
CREATE TABLE Pais (
    Id INT IDENTITY(1,1) NOT NULL,
    Nome VARCHAR(50) NOT NULL,
    CONSTRAINT PK_Pais PRIMARY KEY (Id) 
)


CREATE TABLE Estado (
    Id INT IDENTITY(1,1) NOT NULL,
    Nome VARCHAR(50) NOT NULL,
    PaisId INT NOT NULL,
    CONSTRAINT PK_Estado PRIMARY KEY (Id) ,
    CONSTRAINT FK_Estado_PAIS FOREIGN KEY (PaisId) REFERENCES Pais 
)

INSERT INTO PAIS (Nome)  
SELECT DISTINCT(PAIS) FROM Endereco

INSERT INTO Estado (Nome, PaisId)  
SELECT DISTINCT(E.Estado), P.ID FROM Endereco AS E 
INNER JOIN PAIS P ON P.Nome = E.PAIS 

ALTER TABLE Endereco
ADD EstadoId int NULL 

ALTER TABLE Endereco
ADD FOREIGN KEY (EstadoId) REFERENCES Estado(Id); 

UPDATE Endereco 
SET Endereco.EstadoId = Estado.Id
FROM Endereco as Endereco
INNER JOIN Estado AS Estado ON Endereco.Estado = Estado.nome

ALTER TABLE Endereco 
DROP COLUMN Estado

ALTER TABLE Endereco 
DROP COLUMN Pais

ALTER TABLE Endereco 
ALTER COLUMN EstadoId INT NOT NULL