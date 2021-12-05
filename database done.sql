-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: db_agenda
-- ------------------------------------------------------
-- Server version	8.0.26

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
-- Table structure for table `compromisso`
--

DROP TABLE IF EXISTS `compromisso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `compromisso` (
  `id` int NOT NULL AUTO_INCREMENT,
  `titulo` varchar(45) NOT NULL,
  `descricao` varchar(255) NOT NULL,
  `dataHoraInicio` datetime NOT NULL,
  `dataHoraFim` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=63 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compromisso`
--

LOCK TABLES `compromisso` WRITE;
/*!40000 ALTER TABLE `compromisso` DISABLE KEYS */;
INSERT INTO `compromisso` VALUES (61,'fds','sdfs','2021-10-04 21:21:28','0202-02-02 02:02:00'),(62,'v','gf','2021-10-04 21:21:28','0101-01-01 01:01:00');
/*!40000 ALTER TABLE `compromisso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_convidado`
--

DROP TABLE IF EXISTS `tb_convidado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_convidado` (
  `id_convidado` int NOT NULL AUTO_INCREMENT,
  `id_evento` int NOT NULL,
  `e_mail` varchar(45) NOT NULL,
  PRIMARY KEY (`id_convidado`),
  UNIQUE KEY `e_mail_UNIQUE` (`e_mail`),
  KEY `fk_tb_convidado_tb_evento1_idx` (`id_evento`),
  CONSTRAINT `fk_tb_convidado_tb_evento1` FOREIGN KEY (`id_evento`) REFERENCES `tb_evento` (`id_evento`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_convidado`
--

LOCK TABLES `tb_convidado` WRITE;
/*!40000 ALTER TABLE `tb_convidado` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_convidado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_evento`
--

DROP TABLE IF EXISTS `tb_evento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_evento` (
  `id_evento` int NOT NULL AUTO_INCREMENT,
  `Compromisso_id` int NOT NULL,
  `local` varchar(45) NOT NULL,
  PRIMARY KEY (`id_evento`),
  KEY `fk_tb_evento_Compromisso1_idx` (`Compromisso_id`),
  CONSTRAINT `fk_tb_evento_Compromisso1` FOREIGN KEY (`Compromisso_id`) REFERENCES `compromisso` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=55 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_evento`
--

LOCK TABLES `tb_evento` WRITE;
/*!40000 ALTER TABLE `tb_evento` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_evento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_lembrete`
--

DROP TABLE IF EXISTS `tb_lembrete`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_lembrete` (
  `id_lembrete` int NOT NULL AUTO_INCREMENT,
  `Compromisso_id` int NOT NULL,
  `tempoLembrete` datetime NOT NULL,
  `tipoLembrete` char(1) NOT NULL,
  `diaLembrete_domingo` tinyint(1) DEFAULT NULL,
  `diaLembrete_segunda` tinyint(1) DEFAULT NULL,
  `diaLembrete_terca` tinyint(1) DEFAULT NULL,
  `diaLembrete_quarta` tinyint(1) DEFAULT NULL,
  `diaLembrete_quinta` tinyint(1) DEFAULT NULL,
  `diaLembrete_sexta` tinyint(1) DEFAULT NULL,
  `diaLembrete_sabado` tinyint(1) DEFAULT NULL,
  `tempopara` int DEFAULT NULL,
  `datepara` datetime DEFAULT NULL,
  PRIMARY KEY (`id_lembrete`),
  KEY `fk_tb_lembrete_Compromisso1_idx` (`Compromisso_id`),
  CONSTRAINT `fk_tb_lembrete_Compromisso1` FOREIGN KEY (`Compromisso_id`) REFERENCES `compromisso` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_lembrete`
--

LOCK TABLES `tb_lembrete` WRITE;
/*!40000 ALTER TABLE `tb_lembrete` DISABLE KEYS */;
INSERT INTO `tb_lembrete` VALUES (4,62,'2021-12-05 18:26:33','M',0,0,0,0,0,0,0,5,'0001-01-01 00:00:00');
/*!40000 ALTER TABLE `tb_lembrete` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_notificacao`
--

DROP TABLE IF EXISTS `tb_notificacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_notificacao` (
  `id_notificacao` int NOT NULL AUTO_INCREMENT,
  `Compromisso_id` int NOT NULL,
  `tempo` int NOT NULL,
  `unidade` char(1) NOT NULL,
  `tipo` char(1) NOT NULL,
  PRIMARY KEY (`id_notificacao`),
  KEY `fk_tb_notificacao_Compromisso1_idx` (`Compromisso_id`),
  CONSTRAINT `a1` FOREIGN KEY (`Compromisso_id`) REFERENCES `compromisso` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_notificacao`
--

LOCK TABLES `tb_notificacao` WRITE;
/*!40000 ALTER TABLE `tb_notificacao` DISABLE KEYS */;
INSERT INTO `tb_notificacao` VALUES (24,61,4,'H','N'),(25,62,4,'H','N');
/*!40000 ALTER TABLE `tb_notificacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_tarefa`
--

DROP TABLE IF EXISTS `tb_tarefa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_tarefa` (
  `id_tarefa` int NOT NULL AUTO_INCREMENT,
  `Compromisso_id` int NOT NULL,
  `propriedade` char(1) NOT NULL,
  PRIMARY KEY (`id_tarefa`),
  KEY `fk_tb_tarefa_Compromisso1_idx` (`Compromisso_id`),
  CONSTRAINT `fk_tb_tarefa_Compromisso1` FOREIGN KEY (`Compromisso_id`) REFERENCES `compromisso` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_tarefa`
--

LOCK TABLES `tb_tarefa` WRITE;
/*!40000 ALTER TABLE `tb_tarefa` DISABLE KEYS */;
INSERT INTO `tb_tarefa` VALUES (14,61,'A');
/*!40000 ALTER TABLE `tb_tarefa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'db_agenda'
--

--
-- Dumping routines for database 'db_agenda'
--
/*!50003 DROP PROCEDURE IF EXISTS `dias` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `dias`()
BEGIN
SELECT B.id_lembrete AS Lembrete,
B.compromisso_id AS Compromisso, 
titulo AS Titulo, descricao AS Descrição,
dataHoraInicio AS Inicio, dataHoraFim AS Fim,
B.tempoLembrete AS Horario_Inicio, B.tipoLembrete AS tipo,
B.diaLembrete_domingo AS domingo, B.diaLembrete_segunda AS segunda, B.diaLembrete_terca AS terça,
B.diaLembrete_quarta AS quarta, B.diaLembrete_quinta AS quinta, B.diaLembrete_sexta AS sexta,
B.diaLembrete_sabado AS sabado, B.tempopara AS Tempo_para, B.datepara AS data_para FROM compromisso A
                                            Inner join tb_lembrete B on B.compromisso_id=A.id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-12-05 18:39:40
