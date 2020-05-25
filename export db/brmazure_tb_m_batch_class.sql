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
-- Table structure for table `tb_m_batch_class`
--

DROP TABLE IF EXISTS `tb_m_batch_class`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_m_batch_class` (
  `id` varchar(10) NOT NULL,
  `quantity` int(2) NOT NULL,
  `plan` int(2) NOT NULL,
  `create_date` datetime NOT NULL,
  `trainer` varchar(5) DEFAULT NULL,
  `batch` varchar(2) DEFAULT NULL,
  `class` int(1) DEFAULT NULL,
  `room` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `batch` (`batch`),
  KEY `class` (`class`),
  KEY `room` (`room`),
  KEY `trainer` (`trainer`),
  CONSTRAINT `tb_m_batch_class_ibfk_1` FOREIGN KEY (`batch`) REFERENCES `tb_m_batch` (`id`) ON UPDATE CASCADE,
  CONSTRAINT `tb_m_batch_class_ibfk_2` FOREIGN KEY (`class`) REFERENCES `tb_m_class` (`id`) ON UPDATE CASCADE,
  CONSTRAINT `tb_m_batch_class_ibfk_3` FOREIGN KEY (`room`) REFERENCES `tb_m_room` (`id`) ON UPDATE CASCADE,
  CONSTRAINT `tb_m_batch_class_ibfk_4` FOREIGN KEY (`trainer`) REFERENCES `tb_m_employee` (`id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_m_batch_class`
--

LOCK TABLES `tb_m_batch_class` WRITE;
/*!40000 ALTER TABLE `tb_m_batch_class` DISABLE KEYS */;
INSERT INTO `tb_m_batch_class` VALUES ('01-Java',6,10,'0000-00-00 00:00:00','06264','01',2,'41-Ex'),('02-Java',6,10,'0001-01-01 00:00:00','14422','02',2,'18-Mi'),('03-Java',7,10,'0001-01-01 00:00:00','14422','03',2,'41-Ex'),('04-Java',8,10,'0000-00-00 00:00:00','08464','04',2,'41-Ex'),('05-Java',11,10,'0000-00-00 00:00:00','08464','05',2,'41-Ex'),('06-Net',8,10,'0000-00-00 00:00:00','08464','06',1,'41-Ex'),('07-Java',11,10,'0000-00-00 00:00:00','08464','07',2,'41-Ex'),('08-Java',11,10,'0000-00-00 00:00:00','08464','08',2,'41-Ex'),('09-Java',7,10,'0000-00-00 00:00:00','08464','09',2,'41-Ex'),('10-Java',8,10,'0000-00-00 00:00:00','08464','10',2,'41-Ex'),('11-Java',5,10,'0000-00-00 00:00:00','08464','11',2,'41-Ex'),('12-Java',10,10,'0000-00-00 00:00:00','08464','12',2,'41-Ex'),('13-Net',5,10,'0000-00-00 00:00:00','08464','13',1,'41-Ex'),('14-Java',9,10,'0000-00-00 00:00:00','13364','14',2,'18-Jo'),('14-Net',11,10,'0000-00-00 00:00:00','13144','14',1,'41-Ex'),('15-Java',14,10,'0000-00-00 00:00:00','13364','15',2,'18-Jo'),('16-Net',8,10,'0000-00-00 00:00:00','13144','16',1,'41-Ex'),('17-Java',11,10,'0000-00-00 00:00:00','13364','17',2,'18-Am'),('18-Net',10,10,'0000-00-00 00:00:00','13144','18',1,'18-Os'),('19-Java',7,10,'0000-00-00 00:00:00','13364','19',2,'18-Os'),('20-Net',11,10,'0000-00-00 00:00:00','13144','20',1,'18-Os'),('21-Java',12,10,'0000-00-00 00:00:00','13364','21',2,'18-Am'),('22-Java',10,10,'0000-00-00 00:00:00','13364','22',2,'18-Os'),('22-Net',11,10,'0000-00-00 00:00:00','13144','22',1,'18-Am'),('23-Java',9,10,'0000-00-00 00:00:00','14422','23',2,'18-Mi'),('24-Net',10,10,'0000-00-00 00:00:00','13144','24',1,'18-Os'),('25-Java',10,10,'0000-00-00 00:00:00','13364','25',2,'18-Am'),('26-Java',7,10,'0000-00-00 00:00:00','14422','26',2,'18-Mi'),('26-Net',10,10,'0000-00-00 00:00:00','13144','26',1,'18-Os'),('27-Java',10,10,'0000-00-00 00:00:00','13364','27',2,'18-Am'),('28-Net',8,10,'0000-00-00 00:00:00','13144','28',1,'18-Os'),('29-Java',6,10,'0001-01-01 00:00:00','14422','29',2,'18-Am'),('30-Net',9,10,'0000-00-00 00:00:00','13144','30',1,'18-Mi'),('31-Java',9,10,'0000-00-00 00:00:00','14422','31',2,'18-Am'),('32-Java',6,10,'0001-01-01 00:00:00','13364','32',2,'18-Mi'),('32-Net',12,10,'0001-01-01 00:00:00','13144','32',1,'18-Os'),('33-.Net De',12,10,'2019-12-19 05:55:10','13144','33',1,'18-Am'),('33-Java De',9,10,'2020-01-02 07:04:28','14422','33',2,'18-Os'),('34-Java De',7,10,'2020-02-07 03:04:19','13364','34',2,'18-Mi'),('35-.Net De',9,10,'2020-02-29 00:10:59','13144','35',1,'18-Am'),('35-Java',0,10,'2020-03-24 07:59:47','14422','35',2,'18-Jo'),('C1-Java',29,30,'0000-00-00 00:00:00',NULL,'C1',2,'18-Am'),('D1-Java',4,0,'0000-00-00 00:00:00',NULL,'D1',2,'18-Am'),('D2-Buss',3,0,'0000-00-00 00:00:00',NULL,'D2',3,'18-Am'),('D2-Qual',1,0,'0000-00-00 00:00:00',NULL,'D2',5,'18-Am'),('K1-Java',4,4,'0000-00-00 00:00:00','14422','K1',2,'18-Am'),('M1-Java',10,14,'0000-00-00 00:00:00','13364','M1',2,'18-Am');
/*!40000 ALTER TABLE `tb_m_batch_class` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-25 18:14:53
