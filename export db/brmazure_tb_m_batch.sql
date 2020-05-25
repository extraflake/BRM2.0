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
-- Table structure for table `tb_m_batch`
--

DROP TABLE IF EXISTS `tb_m_batch`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_m_batch` (
  `id` varchar(3) NOT NULL,
  `name` varchar(50) NOT NULL,
  `type` varchar(50) NOT NULL,
  `start_date` datetime NOT NULL,
  `end_date` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_m_batch`
--

LOCK TABLES `tb_m_batch` WRITE;
/*!40000 ALTER TABLE `tb_m_batch` DISABLE KEYS */;
INSERT INTO `tb_m_batch` VALUES ('01','Batch 01','Bootcamp','2013-01-01 00:00:00','2013-02-28 00:00:00'),('02','Batch 02','Bootcamp','2013-07-10 00:00:00','2013-09-09 00:00:00'),('03','Batch 03','Bootcamp','2014-04-01 00:00:00','2014-05-31 00:00:00'),('04','Batch 04','Bootcamp','2014-10-01 00:00:00','2014-11-30 00:00:00'),('05','Batch 05','Bootcamp','2015-01-05 00:00:00','2015-03-04 00:00:00'),('06','Batch 06','Bootcamp','2015-04-01 00:00:00','2015-05-31 00:00:00'),('07','Batch 07','Bootcamp','2015-11-01 00:00:00','2015-12-31 00:00:00'),('08','Batch 08','Bootcamp','2016-03-07 00:00:00','2016-05-06 00:00:00'),('09','Batch 09','Bootcamp','2016-09-19 00:00:00','2016-11-18 00:00:00'),('10','Batch 10','Bootcamp','2017-02-20 00:00:00','2017-04-19 00:00:00'),('11','Batch 11','Bootcamp','2017-04-03 00:00:00','2017-06-02 00:00:00'),('12','Batch 12','Bootcamp','2017-08-01 00:00:00','2017-09-30 00:00:00'),('13','Batch 13','Bootcamp','2017-10-02 00:00:00','2017-12-01 00:00:00'),('14','Batch 14','Bootcamp','2018-01-03 00:00:00','2018-03-02 00:00:00'),('15','Batch 15','Bootcamp','2018-03-12 00:00:00','2018-05-11 00:00:00'),('16','Batch 16','Bootcamp','2018-04-01 00:00:00','2018-05-31 00:00:00'),('17','Batch 17','Bootcamp','2018-06-01 00:00:00','2018-07-31 00:00:00'),('18','Batch 18','Bootcamp','2018-08-01 00:00:00','2018-09-30 00:00:00'),('19','Batch 19','Bootcamp','2018-09-01 00:00:00','2018-10-31 00:00:00'),('20','Batch 20','Bootcamp','2018-10-01 00:00:00','2018-11-30 00:00:00'),('21','Batch 21','Bootcamp','2018-11-01 00:00:00','2018-12-31 00:00:00'),('22','Batch 22','Bootcamp','2019-01-01 00:00:00','2019-02-28 00:00:00'),('23','Batch 23','Bootcamp','2019-02-01 00:00:00','2019-03-31 00:00:00'),('24','Batch 24','Bootcamp','2019-03-01 00:00:00','2019-04-30 00:00:00'),('25','Batch 25','Bootcamp','2019-04-01 00:00:00','2019-05-31 00:00:00'),('26','Batch 26','Bootcamp','2019-05-01 00:00:00','2019-06-30 00:00:00'),('27','Batch 27','Bootcamp','2019-06-17 00:00:00','2019-08-16 00:00:00'),('28','Batch 28','Bootcamp','2019-07-01 00:00:00','2019-08-31 00:00:00'),('29','Batch 29','Bootcamp','2019-08-01 00:00:00','2019-09-30 00:00:00'),('30','Batch 30','Bootcamp','2019-09-01 00:00:00','2019-10-31 00:00:00'),('31','Batch 31','Bootcamp','2019-10-01 00:00:00','2019-11-30 00:00:00'),('32','Batch 32','Bootcamp','2019-11-01 00:00:00','2019-12-31 00:00:00'),('33','Batch 33','Bootcamp','2020-01-01 00:00:00','2020-02-29 00:00:00'),('34','Batch 34','Bootcamp','2020-02-06 00:00:00','2020-04-09 00:00:00'),('35','Batch 35','Bootcamp','2020-03-02 00:00:00','2020-05-08 00:00:00'),('C1','Batch 01 (IBI KKG)','Bootcamp On Campus','2019-07-29 00:00:00','2019-08-02 00:00:00'),('D1','Batch 01','Bootcamp IT Del','2018-01-01 00:00:00','0000-00-00 00:00:00'),('D2','Batch 02','Bootcamp IT Del','2019-09-16 00:00:00','0000-00-00 00:00:00'),('K1','Batch 01 (UKSW)','Kerja Praktik','2019-09-02 00:00:00','2019-09-30 00:00:00'),('M1','Batch 01','Metrodata Coding Camp','2019-09-09 00:00:00','2019-11-08 00:00:00');
/*!40000 ALTER TABLE `tb_m_batch` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-25 18:14:48
