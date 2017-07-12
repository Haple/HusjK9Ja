-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           5.6.15-log - MySQL Community Server (GPL)
-- OS do Servidor:               Win32
-- HeidiSQL Versão:              9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Copiando estrutura do banco de dados para trailer_paulista
CREATE DATABASE IF NOT EXISTS `trailer_paulista` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `trailer_paulista`;

-- Copiando estrutura para tabela trailer_paulista.lanches
CREATE TABLE IF NOT EXISTS `lanches` (
  `cod` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(200) DEFAULT NULL,
  `preco` decimal(7,2) DEFAULT NULL,
  `ingredientes` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`cod`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;


CREATE TABLE IF NOT EXISTS `produtos` (
  `cod` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(200) DEFAULT NULL,
  `preco` decimal(7,2) DEFAULT NULL,
  marca varchar(200),
  categoria varchar (200),
  fornecedor varchar(200),
  
  PRIMARY KEY (`cod`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

CREATE TABLE IF NOT EXISTS `fornecedores` (
  `cod` int(11) NOT NULL AUTO_INCREMENT,
  `fornecedor` varchar(200) DEFAULT NULL,
  `telefone` varchar(100) DEFAULT NULL,
  cpf varchar(100),
  cnpj varchar (100),
  
  PRIMARY KEY (`cod`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela trailer_paulista.lanches: 3 rows
/*!40000 ALTER TABLE `lanches` DISABLE KEYS */;
INSERT INTO `lanches` (`cod`, `nome`, `preco`, `ingredientes`) VALUES
	(1, 'teste', 12.00, 'teste'),
	(2, 'Teste do nome do lanche', 12.00, 'Ingredientes '),
	(3, 'teste com muitos ingredientes', 11.00, 'Ingredientes Ingredientes Ingredientes Ingredientes Ingredientes Ingredientes Ingredientes Ingredientes Ingredientes Ingredientes Ingredientes Ingredientes Ingredientes Ingredientes Ingredientes Ingredientes Ingredientes Ingredientes ');
/*!40000 ALTER TABLE `lanches` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
