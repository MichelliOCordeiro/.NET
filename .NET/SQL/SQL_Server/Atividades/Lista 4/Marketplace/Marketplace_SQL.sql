SELECT
Usuarios.Nome AS Nome,
Compras.FK_Produto AS Produtos
FROM Usuarios
LEFT JOIN Compras ON Usuarios.Id = Compras.FK_Comprador

SELECT * FROM Produtos
WHERE Preco BETWEEN 5 AND 15

SELECT * FROM Usuarios
WHERE Endereco LIKE '%Rua%'

SELECT
Usuarios.Nome AS Nome,
AVG(Produtos.Preco) AS Media
FROM Usuarios
INNER JOIN Compras ON Usuarios.Id = Compras.FK_Comprador
INNER JOIN Produtos ON Compras.FK_Produto = Produtos.Id
GROUP BY Usuarios.Nome

SELECT * FROM Produtos
WHERE Produtos.NomeProduto IN ('Livro Mindset', 'Celular Xiaomi');