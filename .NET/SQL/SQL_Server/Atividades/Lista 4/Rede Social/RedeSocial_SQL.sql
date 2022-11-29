SELECT *
FROM Usuarios
FULL JOIN Postagens ON Usuarios.Id = Postagens.FK_Usuario
FULL JOIN Grupo ON Postagens.Id = Grupo.FK_Usuario

SELECT * FROM Postagens
WHERE Nome LIKE '%mi%'

SELECT
Postagens.FK_Usuario AS Usuario,
COUNT (*) AS 'Qtde de posts'
FROM Postagens
FULL JOIN Usuarios ON Postagens.FK_Usuario = Usuarios.Id
GROUP BY Postagens.FK_Usuario