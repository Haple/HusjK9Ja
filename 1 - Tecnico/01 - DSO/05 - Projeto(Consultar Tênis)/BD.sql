create database projeto_tennis;
use projeto_tennis;
create table tennis(
	COD INT PRIMARY KEY,
	MARCA VARCHAR (300),
	MODELO VARCHAR (300),
	PRECO VARCHAR (300),
	CORES VARCHAR (300)
);

INSERT INTO TENNIS (COD, MODELO, PRECO, CORES)
VALUES  
(1, "ADIDAS", "MODELO 1", "R$100,00", "PRETO"),
(2, "ADIDAS", "MODELO 2", "R$120,00", "BRANCO"),
(3, "ADIDAS", "MODELO 3", "R$140,00", "BRANCO E PRETO"),
(4, "NIKE", "MODELO 1", "R$100,00", "PRETO"),
(5, "NIKE", "MODELO 2", "R$100,00", "BRANCO"),
(6, "NIKE", "MODELO 3", "R$100,00", "BRANCO E VERMELHO");