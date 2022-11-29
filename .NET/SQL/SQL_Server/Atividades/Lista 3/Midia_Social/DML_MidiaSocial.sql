CREATE DATABASE db_redesocial

CREATE TABLE Usuarios(
	Id INT PRIMARY KEY NOT NULL,
	Nome VARCHAR(50) NOT NULL,
	Email VARCHAR(50) NOT NULL,
	Senha VARCHAR(100) NOT NULL
)

CREATE TABLE Grupo(
	Id INT PRIMARY KEY NOT NULL,
	Tema VARCHAR(50) NOT NULL,
	Descricao VARCHAR(100) NOT NULL,
	FK_Usuario INT NOT NULL,
	FOREIGN KEY (FK_Usuario) REFERENCES Usuarios(Id) 
)

CREATE TABLE Postagens(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	Titulo VARCHAR(50) NOT NULL,
	Imagem VARCHAR(200) NULL,
	Descricao VARCHAR(100) NOT NULL,
	FK_Usuario INT NOT NULL,
	FK_Comunidade INT NOT NULL,
	FOREIGN KEY (FK_Usuario) REFERENCES Usuarios(Id),
	FOREIGN KEY (FK_Comunidade) REFERENCES Grupo(Id)
)

INSERT INTO Usuarios
VALUES
(1, 'Michelli Oliveira', 'mi@email.com', '1234'),
(2, 'Leonardo Sena', 'leo@email.com', '12345'),
(3, ' Bob Cordeiro', 'bob@email.com', '123456')

INSERT INTO Grupo
VALUES 
(1, 'Mulheres', 'Só mulheres', 1),
(2, 'Eu gosto', 'Compartilhe o que gosta de fazer', 3),
(3, 'Homens', 'Só homens aqui', 2)

INSERT INTO Postagens
VALUES
('Mulheres são incriveis', 'foto','	O poder das mulheres', 3, 2),
('Eu gosto de comer', 'foto','Comer faz bem', 3, 2),
('Dicas para homens', 'foto','Como se vestir melhor', 3, 2)


SELECT * FROM Postagens
WHERE Descricao LIKE '%com%'

SELECT * FROM Grupo
WHERE FK_Usuario LIKE '%2%'