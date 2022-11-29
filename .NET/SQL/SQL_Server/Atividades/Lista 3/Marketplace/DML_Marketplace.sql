CREATE DATABASE db_marketplace

CREATE TABLE Usuarios(
	Id INT PRIMARY KEY NOT NULL,
	Nome VARCHAR(50) NOT NULL,
	Email VARCHAR(50) NOT NULL,
	Senha VARCHAR(100) NOT NULL,
	Endereco VARCHAR(100) NULL
)

CREATE TABLE Categorias(
	Id INT PRIMARY KEY NOT NULL,
	Descricao VARCHAR(50)
)

CREATE TABLE Produtos(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	NomeProduto VARCHAR(50) NOT NULL,
	Descricao VARCHAR(150) NOT NULL,
	Preco FLOAT NULL,
	FK_Criador INT NOT NULL,
	FK_Categoria INT NOT NULL,
	FOREIGN KEY (FK_Criador) REFERENCES Usuarios (Id),
	FOREIGN KEY (FK_Categoria) REFERENCES Categorias (Id)
)

CREATE TABLE Compras(
	FK_Comprador INT NOT NULL,
	FK_Produto INT NOT NULL,
	FOREIGN KEY (FK_Comprador) REFERENCES Usuarios (Id),
	FOREIGN KEY (FK_Produto) REFERENCES Produtos (Id)
)

INSERT INTO Usuarios
VALUES
(1, 'Michelli Oliveira', 'mi@email.com', '11344', 'Rua das Flores , 16 - SP'),
(2,  'Leonardo Sena', 'leo@email.com', '1346552', 'Rua dos Laranjas, 26 - SP'),
(3, 'Bob Cordeiro', 'bob@email.com', '134655892', 'Rua dos Indios, 357 - SP')

INSERT INTO Categorias
VALUES
(1, 'Livro'),
(2, 'Eletronicos')

INSERT INTO Produtos
VALUES
('Livro Mindset', 'O mais vendido', 55, 3, 1),
('Celular Iphone', 'Iphone 13', 7000.00, 3, 1),
('Celular Xiaomi', 'Xiaomi 12', 5000.00, 2, 1)

INSERT INTO Compras
VALUES
(1, 3),
(2, 1),
(2, 2),
(2, 2)

SELECT * FROM Usuarios
WHERE Endereco LIKE '%indi%'

SELECT * FROM Produtos
WHERE Preco BETWEEN 5 AND 300