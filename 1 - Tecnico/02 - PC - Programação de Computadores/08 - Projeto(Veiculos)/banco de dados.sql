CREATE DATABASE PROJETO_VEICULOS;
USE PROJETO_VEICULOS;

CREATE TABLE VEICULO(
	PLACA CHAR(8) PRIMARY KEY,
	CHASSI INT,
	MODELO VARCHAR(30),
	COR VARCHAR(20),
	FABRICANTE VARCHAR(25)
);