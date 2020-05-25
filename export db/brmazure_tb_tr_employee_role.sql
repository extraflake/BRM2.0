-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: localhost    Database: brmazure
-- ------------------------------------------------------
-- Server version	5.7.27-log

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
-- Table structure for table `tb_tr_employee_role`
--

DROP TABLE IF EXISTS `tb_tr_employee_role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_tr_employee_role` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `is_deleted` tinyint(1) NOT NULL,
  `role` int(1) NOT NULL,
  `employee` varchar(6) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `employee` (`employee`),
  KEY `role` (`role`),
  CONSTRAINT `tb_tr_employee_role_ibfk_1` FOREIGN KEY (`employee`) REFERENCES `tb_m_employee` (`id`) ON UPDATE CASCADE,
  CONSTRAINT `tb_tr_employee_role_ibfk_2` FOREIGN KEY (`role`) REFERENCES `tb_m_role` (`id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_tr_employee_role`
--

LOCK TABLES `tb_tr_employee_role` WRITE;
/*!40000 ALTER TABLE `tb_tr_employee_role` DISABLE KEYS */;
INSERT INTO `tb_tr_employee_role` VALUES (1,0,4,'14422'),(2,0,5,'14422'),(3,0,4,'13364'),(4,0,4,'13144'),(5,0,5,'14186'),(6,0,5,'12887'),(7,0,5,'09036'),(8,0,6,'06264'),(9,0,5,'06328'),(10,0,5,'08083'),(11,0,5,'03140');
/*!40000 ALTER TABLE `tb_tr_employee_role` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-25 18:14:52
