SELECT
Usuarios.Nome AS Nome,
Anuncio.Id_Anuncio AS Anuncio
FROM Usuarios 
RIGHT JOIN Anuncio
ON Usuarios.Id_Usuario = Anuncio.FK_Usuario

SELECT * FROM Usuarios
WHERE Email LIKE '%eo%'

SELECT Usuarios.Nome AS Nome, COUNT(*) AS 'Quantidade de Anuncios'
FROM Usuarios
INNER JOIN Anuncio ON Usuarios.Id_Usuario = Anuncio.Id_Anuncio
GROUP BY Usuarios.Nome