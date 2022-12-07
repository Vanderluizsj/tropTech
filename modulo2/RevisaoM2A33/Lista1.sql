CREATE DATABASE TropTechModasDB

USE TropTechModasDB

CREATE TABLE Endereco
(
    Id INT IDENTITY(1,1) NOT NULL,
    Rua VARCHAR(100) NOT NULL,
    Numero INT NOT NULL,
    Cidade VARCHAR(100) NOT NULL,
    Estado VARCHAR(50) NOT NULL,
    Pais VARCHAR(50) NOT NULL,
    CONSTRAINT PK_ENDERECO PRIMARY KEY (ID)
)

CREATE TABLE Cliente
(
    CadastroUnico VARCHAR(20) NOT NULL,
    Nome VARCHAR(150) NOT NULL,
    Telefone VARCHAR(15) NOT NULL,
    EnderecoId INT NULL,
    TipoPessoa INT NOT NULL,
    CONSTRAINT PK_CLIENTE PRIMARY KEY (CadastroUnico),
    CONSTRAINT FK_CLIENTE_ENDERECO FOREIGN KEY (EnderecoId) REFERENCES Endereco (Id)
)



INSERT INTO Endereco 
VALUES ('Rua Samambaia', 55, 'Curumirim', 'São Paulo', 'Brasil'),
 ('R. Coqueiro', 78, 'Curumirim', 'São Paulo', 'Brasil'),
 ('Flor de Liz', 998, 'Bom Jardim', 'Santa Catarina', 'Brasil'),
 ('R. das Camélias', 435, 'Bom Jardim', 'Santa Catarina', 'Brasil'),
 ('Rua Piauí', 554, 'Lages', 'Santa Catarina', 'Brasil'),
 ('R. dos Índios', 123, 'Vacaria', 'Rio Grande do Sul', 'Brasil'),
 ('Rua Cocal', 223, 'Vacaria', 'Rio Grande do Sul', 'Brasil')


INSERT INTO Cliente
VALUES
('09834566777', 'Maria José da Silva', '11 99988-9382', NULL, 1),
('09555667766', 'Roselinda Pereira', '54 99988-9382', 6, 1),
('77834566000', 'Matheus Silva', '49 9997-4545', 5, 1),
('08726426344', 'Josuel Silveira', '49 8887-4545', 7, 1),
('09488775534', 'Ana Clara Pereira', '49 9997-7888', 3, 1),
('79834566888767', 'João de Santo Cristo ME', '11 9887-3455', 2, 2),
('45632000000156', 'Romaria Viagens', '48 3224-7878', NULL, 2),
('97943794857777', 'Maçãs MALQUE', '48 3227-0009', NULL, 2),
('98754398574885', 'Amigos do Peito LTDA', '49 3224-8800', 4, 2),
('22232000000150', 'DOCES MALUCOS ME', '49 3224-5558', 1, 2)


DECLARE @EnderecoId int; 
SELECT @EnderecoId = EnderecoId From Cliente WHERE CadastroUnico = '22232000000150'

DELETE FROM Cliente WHERE CadastroUnico = '22232000000150'
DELETE FROM Endereco WHERE Id = @EnderecoId



DELETE FROM Cliente WHERE CadastroUnico = '97943794857777'



DECLARE @EnderecoIdParaAtualizar int; 
SELECT @EnderecoIdParaAtualizar = EnderecoId From Cliente 
WHERE CadastroUnico = '98754398574885'

UPDATE Endereco SET Rua = 'Rua Amazonas', Cidade = 'Lages', Numero = 444, Estado = 'Santa Catarina' 
WHERE Id = @EnderecoIdParaAtualizar


INSERT INTO Endereco VALUES
 ('Rua Paraíba', 444, 'Lages', 'Santa Catarina', 'Brasil')

DECLARE @NovoEnderecoId INT;
SET @NovoEnderecoId =  SCOPE_IDENTITY();

UPDATE Cliente SET EnderecoId = @NovoEnderecoId WHERE CadastroUnico = '09834566777'

UPDATE Cliente SET EnderecoId = NULL WHERE EnderecoId = 8
DELETE FROM Endereco WHERE ID = 8


SELECT * FROM CLIENTE C LEFT JOIN Endereco E ON E.Id = C.EnderecoId


SELECT * FROM CLIENTE WHERE NOME LIKE 'Maria%'

SELECT * FROM CLIENTE WHERE NOME LIKE '%Clara%'



