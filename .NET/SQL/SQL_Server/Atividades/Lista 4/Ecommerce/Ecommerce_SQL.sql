SELECT
Usuario.Nome AS Nome,
Usuario.Endereco AS Endereco,
Compras.FK_Usuario AS Compras
FROM Usuario
INNER JOIN Compras ON Usuario.Id =  Compras.FK_Usuario
INNER JOIN Produtos ON Usuario.Id = Produtos.Id

SELECT 
Usuario.Nome AS NOME,
COUNT(*) AS 'Quantidade comprada'
FROM Usuario
INNER JOIN Compras ON Usuario.Id = Compras.FK_produtos
GROUP BY Usuario.Nome