create database projeto_restaurante;
use projeto_restaurante;

create table mesa (
	NRO_MESA int Primary Key,
	Estado varchar(30)
);


create table consumacao(
NRO_ITEM int primary key auto_increment,
NRO_MESA int,
PRODUTO varchar(40),
VALOR dec(8,2),
QUANTIDADE int,
TOTAL dec(8,2),
foreign key (NRO_MESA) references mesa(NRO_MESA)
);

CREATE TABLE PRODUTOS(
	COD INT PRIMARY KEY AUTO_INCREMENT,
	NOME VARCHAR(100),
	VALOR DEC(5,2)
);



insert into mesa values(1,"OCUPADA"),(2,"DISPONIVEL"),(3,"RESERVADA");


insert into consumacao values (1,1,"REFRIGERANTE",3,4.50,13.50),
										(2,1,"ÁGUA",2,3.80,7.60),
										(3,1,"PORÇÃO-FRITAS",1,25.00,25.00);
										
										
INSERT INTO PRODUTOS (NOME, VALOR) VALUES ("REFRIGERANTE", 4.5),
														("ÁGUA", 3.8),
														("PORÇÃO-FRITAS", 25.0);