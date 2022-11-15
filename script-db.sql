create database cuidadoresdb;
use cuidadoresdb;

CREATE TABLE `cuidadores` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `senha` varchar(45) DEFAULT NULL,
  `datanascimento` datetime DEFAULT NULL,
  `especialidades` varchar(500) DEFAULT NULL,
  `sexo` varchar(1) DEFAULT NULL,
  `logradouro` varchar(45) DEFAULT NULL,
  `numero` varchar(10) DEFAULT NULL,
  `cidade` varchar(45) DEFAULT NULL,
  `estado` varchar(2) DEFAULT NULL,
  `bairro` varchar(45) DEFAULT NULL,
  `cep` varchar(10) DEFAULT NULL,
  `telefone` varchar(12) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `idosos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) DEFAULT NULL,
  `sexo` varchar(1) DEFAULT NULL,
  `datanascimento` datetime DEFAULT NULL,
  `necessidades` varchar(500) DEFAULT NULL,
  `idUsuario` int DEFAULT NULL,
  `logradouro` varchar(45) DEFAULT NULL,
  `numero` varchar(10) DEFAULT NULL,
  `cidade` varchar(45) DEFAULT NULL,
  `estado` varchar(2) DEFAULT NULL,
  `bairro` varchar(45) DEFAULT NULL,
  `cep` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `servicos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `idcuidador` int DEFAULT NULL,
  `ididoso` int DEFAULT NULL,
  `datahorainicio` datetime DEFAULT NULL,
  `datahorafim` datetime DEFAULT NULL,
  `valor` decimal(10,2) DEFAULT NULL,
  `observacoes` varchar(500) DEFAULT NULL,
  `cancelado` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `usuarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `email` varchar(45) DEFAULT NULL,
  `senha` varchar(45) DEFAULT NULL,
  `nome` varchar(45) DEFAULT NULL,
  `telefone` varchar(12) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
