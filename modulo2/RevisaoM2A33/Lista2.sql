CREATE TABLE Venda(
    Id INT IDENTITY(1,1) NOT NULL,
    Descricao varchar(500) NOT NULL,
    Valor DECIMAL NOT NULL,
    CadastroUnicoCliente VARCHAR(20) NOT NULL,
    CONSTRAINT PK_VENDA PRIMARY KEY (Id),
    CONSTRAINT FK_VENDA_CLIENTE FOREIGN KEY (CadastroUnicoCliente) REFERENCES Cliente,
)

-- CRUD

INSERT INTO Venda VALUES
('1 un camiseta polo', 150.00, '08726426344'),
('2 un vestido vermelho', 325.90, '08726426344'),
('1 un camiseta polo', 150.00, '09488775534'),
('1 un camiseta polo', 150.00, '09555667766'),
('1 un calça jeans', 270.00, '09555667766'),
('1 un meia colorida', 27.90, '09834566777'),
('2 un pantufas', 100.00, '45632000000156'),
('3 un cintos', 75.00, '79834566888767'),
('2 un meias', 30.00, '45632000000156'),
('3 un cintos', 75.00, '98754398574885')

DELETE FROM Venda WHERE ID = 2

DELETE FROM Venda WHERE CadastroUnicoCliente = '98754398574885'
DELETE FROM Cliente WHERE CadastroUnico = '98754398574885'


select * from venda
UPDATE Venda SET Descricao = '2 un calça jeans' where Id = 5

SELECT c.Nome, c.Telefone,v.* FROM Venda V INNER JOIN Cliente C on c.CadastroUnico = v.CadastroUnicoCliente


SELECT * FROM Venda WHERE CadastroUnicoCliente =  '08726426344'

SELECT v.Valor, c.Nome, CONCAT_WS(',', E.Rua, E.Numero, E.Cidade, E.Estado, E.Pais) AS Endereco FROM Venda V 
INNER JOIN Cliente C ON C.CadastroUnico = v.CadastroUnicoCliente
LEFT JOIN Endereco E on E.Id = C.EnderecoId

