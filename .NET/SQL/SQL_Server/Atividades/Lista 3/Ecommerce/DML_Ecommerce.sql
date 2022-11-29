CREATE DATABASE db_ecommerce

CREATE TABLE Usuario(
	Id INT PRIMARY KEY NOT NULL,
	Nome VARCHAR(100) NOT NULL,
	Email VARCHAR(50) NOT NULL,
	Senha VARCHAR(50) NOT NULL,
	Endereco VARCHAR(50) NOT NULL
)

CREATE TABLE Produtos(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	Tipo VARCHAR(50) NOT NULL,
	Preco FLOAT NOT NULL,
	Quantidade INT NOT NULL
	
)

CREATE TABLE Compras(
	FK_Usuario INT NOT NULL,
	FK_Produtos INT NOT NULL,
	FOREIGN KEY (FK_Usuario) REFERENCES Usuario(Id),
	FOREIGN KEY (FK_Produtos) REFERENCES Produtos(Id),
)

INSERT INTO Usuario
VALUES 
(1, 'Michelli Oliveira', 'mi', '1234','Rua das Flores, 12'),
(2, 'Leonardo Sena', 'leo', '12345','Rua das Orquideas, 21'),
(3, 'Bob Cordeiro', 'bob', '123456','Rua das Pedras, 55')

INSERT INTO Produtos
VALUES
('Livro', 55, 1),
('Celular', 250, 2),
('Bolsa', 150, 10)

INSERT INTO Compras
VALUES 
(1, 1),
(1, 2),
(2, 1)

SELECT * FROM Usuario
WHERE Nome LIKE '%le%'

SELECT * FROM Produtos
WHERE Preco BETWEEN 10 AND 500