
CREATE DATABASE SistemaVendas;

USE SistemaVendas
CREATE TABLE Clientes(
    Id INT IDENTITY(1,1) NOT NULL,
    Nome VARCHAR(100) NOT NULL,
    Telefone VARCHAR(11) NOT NULL,
    Endereco VARCHAR(100) NOT NULL,
    CONSTRAINT PK_Cliente PRIMARY KEY (Id)
);

USE SistemaVendas
CREATE TABLE Lojas(
    Id INT IDENTITY(1,1) NOT NULL,
    Nome VARCHAR(100) NOT NULL,
    Cidade VARCHAR(100) NOT NULL,
    Telefone VARCHAR(11) NOT NULL,
    Cnpj VARCHAR(14) NOT NULL,
    CONSTRAINT PK_Loja PRIMARY KEY (Id)
);

USE SistemaVendas
CREATE TABLE Pedidos(
    Id INT IDENTITY(1,1) NOT NULL,
    Numero INT NOT NULL,
    [Data] DATETIME NOT NULL,
    Valor FLOAT,
    ClienteId INT NOT NULL,
    LojaId INT NOT NULL,
    CONSTRAINT PK_Pedido PRIMARY KEY (Id),
    CONSTRAINT FK_Cliente FOREIGN KEY (ClienteId) REFERENCES Clientes (Id),
    CONSTRAINT FK_Loja FOREIGN KEY (LojaId) REFERENCES Lojas (Id),
);

USE SistemaVendas
INSERT INTO Clientes (Nome, Telefone, Endereco) 
VALUES 
('João Roberto', '49999885566', 'Rua das Flores - 43'), 
('Marcia da Silva', '49999513455', 'Rua Catanduvas - 56'), 
('Guilherme dos Santos', '49995244896', 'Rua Jorge Lacerda - 66'), 
('Maria Oliveira', '49999009078', 'Rua Jardim da Camélias - 788'), 
('Joana Vargas', '49999122273', 'Rua Batalha - 556');

USE SistemaVendas
INSERT INTO Lojas (Nome, Cidade, Telefone, Cnpj) 
VALUES 
('Filial 1', 'Florianópolis', '49990055545', '24062914000145'), 
('Filial 2', 'São Paulo', '49995689400', '46805439000192'), 
('Filial 3', 'Curitiba', '49995254590', '62730329000165'), 
('Filial 4', 'Porto Alegre', '49995659055', '49332339000184');

USE SistemaVendas
INSERT INTO Pedidos (Numero, [Data], Valor, ClienteId, LojaId) 
VALUES 
(123, '2022-10-11', 250.00, 1, 1), 
(456, '2022-10-08', 700.00, 3, 2), 
(789, '2022-10-10', 854.36, 2, 1), 
(812, '2022-01-21', 168.33, 4, 3),
(745, '2022-02-14', 1235.22, 5, 4),
(756, '2022-03-15', 12.22, 1, 4), 
(951, '2022-04-18', 987.65, 2, 2), 
(647, '2022-04-26', 124.33, 5, 2), 
(318, '2022-09-11', 987.33, 3, 3),
(987, '2022-10-29', 456.27, 3, 2);


USE SistemaVendas
SELECT MAX(Valor) FROM Pedidos


USE SistemaVendas
SELECT MIN(Valor) FROM Pedidos

USE SistemaVendas
SELECT AVG(Valor) FROM Pedidos

USE SistemaVendas
SELECT SUM(Valor) FROM Pedidos


USE SistemaVendas
SELECT COUNT(Numero) FROM Pedidos p 
    INNER JOIN Lojas l on (p.LojaId = l.Id)  
    WHERE Cidade = 'Florianópolis'

USE SistemaVendas
SELECT COUNT(Numero) FROM Pedidos p 
    INNER JOIN Lojas l on (p.LojaId = l.Id)  
    WHERE Cidade = 'São Paulo'

USE SistemaVendas
SELECT COUNT(Numero) FROM Pedidos p 
    INNER JOIN Lojas l on (p.LojaId = l.Id)  
    WHERE Cidade = 'Curitiba'

USE SistemaVendas
SELECT COUNT(Numero) FROM Pedidos p 
    INNER JOIN Lojas l on (p.LojaId = l.Id)  
    WHERE Cidade = 'Porto Alegre'


USE SistemaVendas
SELECT CONCAT(Nome, '-', Cidade) FROM Lojas

USE SistemaVendas
SELECT MONTH([Data]) FROM Pedidos