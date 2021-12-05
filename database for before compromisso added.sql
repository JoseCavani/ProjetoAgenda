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
-- Table structure for table `tb_convidado`
--

DROP TABLE IF EXISTS `tb_convidado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_convidado` (
  `id_convidado` int NOT NULL AUTO_INCREMENT,
  `id_evento` int NOT NULL,
  `e_mail` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_convidado`),
  KEY `fk_tb_convidado_tb_evento1_idx` (`id_evento`),
  CONSTRAINT `fk_tb_convidado_tb_evento1` FOREIGN KEY (`id_evento`) REFERENCES `tb_evento` (`id_evento`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_convidado`
--

LOCK TABLES `tb_convidado` WRITE;
/*!40000 ALTER TABLE `tb_convidado` DISABLE KEYS */;
INSERT INTO `tb_convidado` VALUES (5,4,'ffff');
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
  `titulo` varchar(45) DEFAULT NULL,
  `descricao` varchar(255) DEFAULT NULL,
  `dataHoraInicio` datetime DEFAULT NULL,
  `dataHoraFim` datetime DEFAULT NULL,
  `local` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_evento`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_evento`
--

LOCK TABLES `tb_evento` WRITE;
/*!40000 ALTER TABLE `tb_evento` DISABLE KEYS */;
INSERT INTO `tb_evento` VALUES (4,'zzz','rwerwe','2021-12-02 00:00:00','2021-12-02 00:00:00','sadas'),(13,'dsf','fsdfs','2021-10-04 21:21:28','0202-02-02 02:02:00','dfd');
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
  `titulo` varchar(45) DEFAULT NULL,
  `descricao` varchar(255) DEFAULT NULL,
  `dataHoraInicio` datetime DEFAULT NULL,
  `dataHoraFim` datetime DEFAULT NULL,
  PRIMARY KEY (`id_lembrete`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_lembrete`
--

LOCK TABLES `tb_lembrete` WRITE;
/*!40000 ALTER TABLE `tb_lembrete` DISABLE KEYS */;
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
  `tempo` int DEFAULT NULL,
  `unidade` char(1) DEFAULT NULL,
  `tipo` char(1) DEFAULT NULL,
  `id_compromisso` int DEFAULT NULL,
  `tipo_compromisso` char(1) DEFAULT NULL COMMENT 'E -evento\nT-tarefa\nL-lembrete',
  PRIMARY KEY (`id_notificacao`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_notificacao`
--

LOCK TABLES `tb_notificacao` WRITE;
/*!40000 ALTER TABLE `tb_notificacao` DISABLE KEYS */;
INSERT INTO `tb_notificacao` VALUES (2,8,'M','T',0,'E'),(5,5,'S','N',13,'E'),(6,0,'H','N',1,NULL);
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
  `titulo` varchar(45) DEFAULT NULL,
  `descricao` varchar(255) DEFAULT NULL,
  `dataHoraInicio` datetime DEFAULT NULL,
  `dataHoraFim` datetime DEFAULT NULL,
  `prioridade` char(1) DEFAULT NULL,
  PRIMARY KEY (`id_tarefa`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_tarefa`
--

LOCK TABLES `tb_tarefa` WRITE;
/*!40000 ALTER TABLE `tb_tarefa` DISABLE KEYS */;
INSERT INTO `tb_tarefa` VALUES (1,'dfg','dfgdfgd','2021-12-03 00:00:00','2021-12-03 00:00:00','N');
/*!40000 ALTER TABLE `tb_tarefa` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-12-04 19:19:55
