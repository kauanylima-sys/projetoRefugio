-- MySQL dump 10.13  Distrib 8.0.46, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: banco_refugio
-- ------------------------------------------------------
-- Server version	5.5.5-10.11.16-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `animais_resgatados`
--

DROP TABLE IF EXISTS `animais_resgatados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `animais_resgatados` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `id_categoria` int(11) NOT NULL,
  `especie` varchar(100) NOT NULL,
  `sexo` char(1) DEFAULT NULL,
  `idade` int(11) DEFAULT NULL,
  `situacao` varchar(50) NOT NULL,
  `local_resgate` varchar(100) DEFAULT NULL,
  `data_resgate` datetime DEFAULT curdate(),
  PRIMARY KEY (`id`),
  KEY `id_categoria` (`id_categoria`),
  CONSTRAINT `animais_resgatados_ibfk_1` FOREIGN KEY (`id_categoria`) REFERENCES `categorias_animais` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `animais_resgatados`
--

LOCK TABLES `animais_resgatados` WRITE;
/*!40000 ALTER TABLE `animais_resgatados` DISABLE KEYS */;
INSERT INTO `animais_resgatados` VALUES (1,'Fabio',3,'Trinca-Ferro','M',2,'Em tratamento','Boa Esperança MG','2026-11-20 00:00:00'),(4,'zézinho',7,'Macaco prego','M',0,'Berçário / Amamentação','Poços de caldas - Mg','2026-10-18 00:00:00'),(5,'Guaraná',2,'Lobo do guára','F',2,'Reabilitação Comportamental','Alfenas - Mg','2026-11-23 00:00:00'),(6,'Crowley',3,'Coruja','M',4,'Apto para Soltura ','Machado - Mg','2026-12-01 00:00:00'),(7,'Joca',3,'Papagaio','M',6,'quarentena','Machado - MG','2026-11-24 00:00:00');
/*!40000 ALTER TABLE `animais_resgatados` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-11-25  9:12:20
