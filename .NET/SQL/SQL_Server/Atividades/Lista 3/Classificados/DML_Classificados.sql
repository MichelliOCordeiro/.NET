CREATE DATABASE db_classificados 

USE db_classificados

CREATE TABLE Usuarios(
	Id_Usuario INT PRIMARY KEY IDENTITY NOT NULL,
	Nome VARCHAR(100) NOT NULL,
	Email VARCHAR(50) NOT NULL,
	Senha VARCHAR(100) NOT NULL,
	Foto IMAGE NULL
) 

CREATE TABLE Anuncio (
	Id_Anuncio INT PRIMARY KEY IDENTITY NOT NULL,
	Descricao VARCHAR(100) NOT NULL,
	Preco REAL NOT NULL,
	Contato VARCHAR(50) NOT NULL,
	FK_Usuario INT NOT NULL,
	FOREIGN KEY (FK_Usuario) REFERENCES Usuarios (Id_Usuario)
)

INSERT INTO Usuarios
VALUES
('Michelli Oliveira','Mi','1234','12333'),
('Leonardo Sena','Leo','12345','123'),
('Bob Cordeiro','Bob','123456','123');


INSERT INTO Anuncio
VALUES
('Livro Mindset',50,'2222-1111',1),
('Fone de ouvido',80,'2222-1111',1),
('Garrafa',25,'2222-1111',1)

SELECT * FROM Anuncio
SELECT * FROM Anuncio WHERE Id_Anuncio = 3

SELECT * FROM Anuncio
WHERE Preco  BETWEEN 5 AND 50