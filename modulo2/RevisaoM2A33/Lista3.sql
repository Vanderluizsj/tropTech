SELECT COUNT(*) FROM Venda

SELECT COUNT(DISTINCT CadastroUnicoCliente) FROM Venda

SELECT COUNT(*) FROM Cliente C 
LEFT JOIN Venda V ON V.CadastroUnicoCliente = C.CadastroUnico
WHERE V.Id is null

SELECT MAX(Valor) from Venda

SELECT C.Nome, C.Telefone FROM Cliente C LEFT JOIN Endereco E ON E.Id = C.EnderecoId
WHERE E.ID IS NULL

SELECT CONCAT('R$', SUM(Valor)) FROM Venda

SELECT CONCAT('R$', SUM(Valor)) FROM Venda 
WHERE CadastroUnicoCliente = '09834566777'

SELECT COUNT(*) as QtdPessoaFisica FROM Cliente WHERE TipoPessoa = 1
SELECT COUNT(*) as QtdPessoaJuridica FROM Cliente WHERE TipoPessoa = 2

SELECT 
(SELECT COUNT(*) FROM Cliente WHERE TipoPessoa = 1) AS PessoaFisica,
(SELECT COUNT(*) FROM Cliente WHERE TipoPessoa = 2) AS PessoaJuridica
