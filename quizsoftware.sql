-- MariaDB dump 10.19  Distrib 10.4.32-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: quizsoftware
-- ------------------------------------------------------
-- Server version	10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `landinfo`
--

DROP TABLE IF EXISTS `landinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `landinfo` (
  `landID` int(11) NOT NULL AUTO_INCREMENT,
  `land` varchar(100) DEFAULT NULL,
  `hauptstadt` varchar(100) DEFAULT NULL,
  `flagge` varchar(40) DEFAULT NULL,
  `kontinent` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`landID`)
) ENGINE=InnoDB AUTO_INCREMENT=77 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `landinfo`
--

LOCK TABLES `landinfo` WRITE;
/*!40000 ALTER TABLE `landinfo` DISABLE KEYS */;
INSERT INTO `landinfo` VALUES (1,'Deutschland','Berlin','de.png','Europa'),(3,'Frankreich','Paris','fr.png','Europa'),(4,'Spanien','Madrid','es.png','Europa'),(5,'Italien','Rom','it.png','Europa'),(6,'Österreich','Wien','at.png','Europa'),(7,'Niederlande','Amsterdam','nl.png','Europa'),(8,'Belgien','Brüssel','be.png','Europa'),(9,'Portugal','Lissabon','pt.png','Europa'),(10,'Schweiz','Bern','ch.png','Europa'),(11,'Dänemark','Kopenhagen','dk.png','Europa'),(12,'Schweden','Stockholm','se.png','Europa'),(13,'Norwegen','Oslo','no.png','Europa'),(14,'Finnland','Helsinki','fi.png','Europa'),(15,'Griechenland','Athen','gr.png','Europa'),(16,'Tschechien','Prag','cz.png','Europa'),(17,'Japan','Tokio','jp.png','Asien'),(18,'China','Peking','cn.png','Asien'),(19,'Indien','Neu-Delhi','in.png','Asien'),(20,'Indonesien','Jakarta','id.png','Asien'),(21,'Thailand','Bangkok','th.png','Asien'),(22,'Vietnam','Hanoi','vn.png','Asien'),(23,'Südkorea','Seoul','kr.png','Asien'),(24,'Malaysia','Kuala Lumpur','my.png','Asien'),(25,'Philippinen','Manila','ph.png','Asien'),(26,'Saudi-Arabien','Riad','sa.png','Asien'),(27,'USA','Washington, D.C.','us.png','Nordamerika'),(28,'Kanada','Ottawa','ca.png','Nordamerika'),(29,'Mexiko','Mexiko-Stadt','mx.png','Nordamerika'),(30,'Guatemala','Guatemala-Stadt','gt.png','Nordamerika'),(31,'Kuba','Havanna','cu.png','Nordamerika'),(32,'Honduras','Tegucigalpa','hn.png','Nordamerika'),(33,'Panama','Panama-Stadt','pa.png','Nordamerika'),(34,'Costa Rica','San José','cr.png','Nordamerika'),(35,'El Salvador','San Salvador','sv.png','Nordamerika'),(36,'Jamaika','Kingston','jm.png','Nordamerika'),(37,'Brasilien','Brasília','br.png','Südamerika'),(38,'Argentinien','Buenos Aires','ar.png','Südamerika'),(39,'Kolumbien','Bogotá','co.png','Südamerika'),(40,'Peru','Lima','pe.png','Südamerika'),(41,'Venezuela','Caracas','ve.png','Südamerika'),(42,'Chile','Santiago','cl.png','Südamerika'),(43,'Ecuador','Quito','ec.png','Südamerika'),(44,'Bolivien','Sucre','bo.png','Südamerika'),(45,'Paraguay','Asunción','py.png','Südamerika'),(46,'Uruguay','Montevideo','uy.png','Südamerika'),(47,'Nigeria','Abuja','ng.png','Afrika'),(48,'Ägypten','Kairo','eg.png','Afrika'),(49,'Südafrika','Pretoria','za.png','Afrika'),(50,'Kenia','Nairobi','ke.png','Afrika'),(51,'Äthiopien','Addis Abeba','et.png','Afrika'),(52,'Ghana','Accra','gh.png','Afrika'),(53,'Tansania','Dodoma','tz.png','Afrika'),(54,'Marokko','Rabat','ma.png','Afrika'),(55,'Uganda','Kampala','ug.png','Afrika'),(56,'Senegal','Dakar','sn.png','Afrika'),(57,'Australien','Canberra','au.png','Australien'),(58,'Neuseeland','Wellington','nz.png','Australien'),(59,'Fidschi','Suva','fj.png','Australien'),(60,'Papua-Neuguinea','Port Moresby','pg.png','Australien'),(61,'Samoa','Apia','ws.png','Australien'),(62,'Tonga','Nuku?alofa','to.png','Australien'),(63,'Vanuatu','Port Vila','vu.png','Australien'),(64,'Kiribati','South Tarawa','ki.png','Australien'),(65,'Mikronesien','Palikir','fm.png','Australien'),(66,'Marshallinseln','Majuro','mh.png','Australien');
/*!40000 ALTER TABLE `landinfo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `punkte`
--

DROP TABLE IF EXISTS `punkte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `punkte` (
  `punkteID` int(11) NOT NULL AUTO_INCREMENT,
  `spielerID` int(11) DEFAULT NULL,
  `quizId` int(11) DEFAULT NULL,
  `gesamtPunkte` int(11) DEFAULT NULL,
  PRIMARY KEY (`punkteID`),
  KEY `spielerID` (`spielerID`),
  KEY `quizId` (`quizId`),
  CONSTRAINT `punkte_ibfk_1` FOREIGN KEY (`spielerID`) REFERENCES `spieler` (`spielerid`),
  CONSTRAINT `punkte_ibfk_2` FOREIGN KEY (`quizId`) REFERENCES `quiz` (`quizID`)
) ENGINE=InnoDB AUTO_INCREMENT=82 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `punkte`
--

LOCK TABLES `punkte` WRITE;
/*!40000 ALTER TABLE `punkte` DISABLE KEYS */;
INSERT INTO `punkte` VALUES (1,1,2,20),(2,2,3,36),(3,3,4,20),(4,1,5,12),(5,1,6,4),(6,1,7,20),(7,1,8,32),(8,1,9,16),(9,1,10,12),(10,1,11,12),(11,1,12,16),(12,1,13,8),(13,1,14,0),(14,1,15,8),(15,1,16,20),(16,1,17,0),(17,1,18,0),(18,1,19,0),(19,1,20,4),(20,1,21,4),(21,1,22,4),(22,1,23,24),(23,1,24,12),(24,1,25,12),(25,1,26,0),(26,1,27,0),(27,1,28,16),(28,1,29,0),(29,3,30,20),(30,3,31,8),(31,3,32,8),(32,3,33,0),(33,3,34,0),(34,3,35,4),(35,3,36,0),(36,4,37,4),(37,4,38,16),(38,1,39,4),(39,3,40,0),(40,3,41,16),(41,3,42,8),(42,3,43,8),(43,3,44,8),(44,3,45,20),(45,1,46,0),(46,3,47,12),(47,3,48,8),(48,3,49,8),(49,3,50,8),(50,3,51,8),(51,3,52,8),(52,1,53,4),(53,1,54,12),(54,1,55,20),(55,3,56,12),(56,3,57,8),(57,3,58,8),(58,3,59,16),(59,3,60,16),(60,1,61,12),(61,3,62,8),(62,3,63,20),(63,3,64,4),(64,3,65,8),(65,3,66,12),(66,3,67,16),(67,3,68,16),(68,3,69,12),(69,5,70,24),(70,3,71,12),(71,5,72,36),(72,5,73,36),(73,4,74,12),(74,1,75,12),(75,1,76,16),(76,5,77,8),(77,1,78,16),(78,1,79,12),(79,5,80,16),(80,5,81,8),(81,5,82,12);
/*!40000 ALTER TABLE `punkte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `quiz`
--

DROP TABLE IF EXISTS `quiz`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `quiz` (
  `quizID` int(11) NOT NULL AUTO_INCREMENT,
  `spielerID` int(11) DEFAULT NULL,
  `quizTyp` varchar(50) DEFAULT NULL,
  `gesamtPunkte` int(11) DEFAULT NULL,
  PRIMARY KEY (`quizID`),
  KEY `spielerID` (`spielerID`),
  CONSTRAINT `quiz_ibfk_1` FOREIGN KEY (`spielerID`) REFERENCES `spieler` (`spielerid`)
) ENGINE=InnoDB AUTO_INCREMENT=83 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `quiz`
--

LOCK TABLES `quiz` WRITE;
/*!40000 ALTER TABLE `quiz` DISABLE KEYS */;
INSERT INTO `quiz` VALUES (2,1,'Land-Flagge',20),(3,2,'Land-Flagge',36),(4,3,'Land-Flagge',20),(5,1,'Land-Flagge',12),(6,1,'Flagge-Land',4),(7,1,'Land-Hauptstadt',20),(8,1,'Land-Hauptstadt',32),(9,1,'Hauptstadt-Land',16),(10,1,'Hauptstadt-Land',12),(11,1,'Land-Flagge',12),(12,1,'Flagge-Land',16),(13,1,'Land-Flagge',8),(14,1,'Land-Flagge',0),(15,1,'Land-Flagge',8),(16,1,'Flagge-Land',20),(17,1,'Flagge-Land',0),(18,1,'Flagge-Land',0),(19,1,'Flagge-Land',0),(20,1,'Flagge-Land',4),(21,1,'Flagge-Land',4),(22,1,'Land-Flagge',4),(23,1,'Land-Hauptstadt',24),(24,1,'Hauptstadt-Land',12),(25,1,'Land-Hauptstadt',12),(26,1,'Flagge-Land',0),(27,1,'Flagge-Land',0),(28,1,'Land-Flagge',16),(29,1,'Land-Flagge',0),(30,3,'Flagge-Land',20),(31,3,'Flagge-Land',8),(32,3,'Land-Flagge',8),(33,3,'Flagge-Land',0),(34,3,'Flagge-Land',0),(35,3,'Flagge-Land',4),(36,3,'Flagge-Land',0),(37,4,'Flagge-Land',4),(38,4,'Hauptstadt-Land',16),(39,1,'Hauptstadt-Land',4),(40,3,'Land-Hauptstadt',0),(41,3,'Hauptstadt-Land',16),(42,3,'Hauptstadt-Land',8),(43,3,'Land-Flagge',8),(44,3,'Flagge-Land',8),(45,3,'Land-Flagge',20),(46,1,'Hauptstadt-Flagge',0),(47,3,'Land-Hauptstadt',12),(48,3,'Hauptstadt-Land',8),(49,3,'Flagge-Land',8),(50,3,'Land-Flagge',8),(51,3,'Hauptstadt-Land',8),(52,3,'Land-Flagge',8),(53,1,'Flagge-Land',4),(54,1,'Hauptstadt-Land',12),(55,1,'Flagge-Land',20),(56,3,'Land-Flagge',12),(57,3,'Flagge-Land',8),(58,3,'Land-Flagge',8),(59,3,'Land-Flagge',16),(60,3,'Hauptstadt-Land',16),(61,1,'Hauptstadt-Land',12),(62,3,'Hauptstadt-Land',8),(63,3,'Flagge-Land',20),(64,3,'Flagge-Land',4),(65,3,'Land-Flagge',8),(66,3,'Hauptstadt-Land',12),(67,3,'Land-Hauptstadt',16),(68,3,'Flagge-Land',16),(69,3,'Land-Hauptstadt',12),(70,5,'Land-Flagge',24),(71,3,'Land-Flagge',12),(72,5,'Land-Flagge',36),(73,5,'Land-Flagge',36),(74,4,'Land-Flagge',12),(75,1,'Land-Flagge',12),(76,1,'Hauptstadt-Land',16),(77,5,'Land-Flagge',8),(78,1,'Flagge-Land',16),(79,1,'Flagge-Land',12),(80,5,'Land-Hauptstadt',16),(81,5,'Hauptstadt-Land',8),(82,5,'Hauptstadt-Land',12);
/*!40000 ALTER TABLE `quiz` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `spieler`
--

DROP TABLE IF EXISTS `spieler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `spieler` (
  `spielerid` int(11) NOT NULL AUTO_INCREMENT,
  `spielername` varchar(100) DEFAULT NULL,
  `passwort` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`spielerid`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `spieler`
--

LOCK TABLES `spieler` WRITE;
/*!40000 ALTER TABLE `spieler` DISABLE KEYS */;
INSERT INTO `spieler` VALUES (1,'Ali','12345'),(2,'Tom','12345'),(3,'Ronald','12345'),(4,'Lasse','12345'),(5,'Hamidi','12345');
/*!40000 ALTER TABLE `spieler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `v_hoechste_punktzahl`
--

DROP TABLE IF EXISTS `v_hoechste_punktzahl`;
/*!50001 DROP VIEW IF EXISTS `v_hoechste_punktzahl`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_hoechste_punktzahl` AS SELECT
 1 AS `spielerid`,
  1 AS `spielername`,
  1 AS `hoechste_punktzahl` */;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `v_hoechste_punktzahl`
--

/*!50001 DROP VIEW IF EXISTS `v_hoechste_punktzahl`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = cp850 */;
/*!50001 SET character_set_results     = cp850 */;
/*!50001 SET collation_connection      = cp850_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_hoechste_punktzahl` AS select `s`.`spielerid` AS `spielerid`,`s`.`spielername` AS `spielername`,max(`p`.`gesamtPunkte`) AS `hoechste_punktzahl` from (`spieler` `s` join `punkte` `p` on(`s`.`spielerid` = `p`.`spielerID`)) group by `s`.`spielerid`,`s`.`spielername` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-06-27 10:56:37
