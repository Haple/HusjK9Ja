create database projeto_cidade;
use projeto_cidade;
create table postos(
	COD INT PRIMARY KEY,
	POSTO VARCHAR (30),
	CIDADE VARCHAR (30),
	ENDERECO VARCHAR (50),
	FONE CHAR(9)
	
);

INSERT INTO POSTOS (COD, POSTO, CIDADE, ENDERECO, FONE) 
VALUES (1010, "Posto Campos Elísios", "Paulínia", "Av. Ipiranga, 766", "3874-8982"),
(1020, "Posto Jardins Suspensos da Babilônia", "Paulínia", "Rua Rio de Janeiro, 72", "3874-3457"),
(1030, "Posto UPA", "Sumaré", "Centro, 4000", "3722-6477"),
(1040, "Posto Esfinge", "Santa Bárbara", "Av. Ipiranga, 777", "3666-3476");