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
-- Table structure for table `tb_m_asset`
--

DROP TABLE IF EXISTS `tb_m_asset`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_m_asset` (
  `id` varchar(10) NOT NULL,
  `number` varchar(12) NOT NULL,
  `create_date` datetime NOT NULL,
  `type` varchar(2) NOT NULL,
  `employee` varchar(6) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `tb_m_asset_ibfk_1` (`type`),
  KEY `tb_m_asset_ibfk_2` (`employee`),
  CONSTRAINT `tb_m_asset_ibfk_1` FOREIGN KEY (`type`) REFERENCES `tb_m_type` (`id`) ON UPDATE CASCADE,
  CONSTRAINT `tb_m_asset_ibfk_2` FOREIGN KEY (`employee`) REFERENCES `tb_m_participant` (`id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_m_asset`
--

LOCK TABLES `tb_m_asset` WRITE;
/*!40000 ALTER TABLE `tb_m_asset` DISABLE KEYS */;
INSERT INTO `tb_m_asset` VALUES ('BC01','2147483647','0001-01-01 00:00:00','AC','116302'),('BC02','2147483647','0000-00-00 00:00:00','AC','116416'),('BC03','112434743','0000-00-00 00:00:00','AC','116422'),('BC04','111981447','0000-00-00 00:00:00','AC','C0025'),('BC05','112094487','0000-00-00 00:00:00','AC','116419'),('BC06','112349751','0000-00-00 00:00:00','AC','116418'),('BC07','111882103','0000-00-00 00:00:00','AC','116417'),('BC08','112175687','0000-00-00 00:00:00','AC','116421'),('BC09','112120631','0000-00-00 00:00:00','AC','116414'),('BC10','112500135','0000-00-00 00:00:00','AC','116415'),('BC11','2147483647','0000-00-00 00:00:00','AC','116303'),('BC12','112073095','0000-00-00 00:00:00','AC','116420'),('BC13','2147483647','0000-00-00 00:00:00','AC',NULL),('BC14','2147483647','0000-00-00 00:00:00','AC','16150'),('BC15','112219383','0000-00-00 00:00:00','AC',NULL),('BC16','112616999','0000-00-00 00:00:00','AC',NULL),('BC17','115518199','0000-00-00 00:00:00','AC',NULL),('BC18','113042743','0000-00-00 00:00:00','AC',NULL),('BC19','2147483647','0000-00-00 00:00:00','AC',NULL),('BC20','112081527','0000-00-00 00:00:00','AC','K0002'),('BC21','2147483647','0000-00-00 00:00:00','AC','C0020'),('BC22','2147483647','0000-00-00 00:00:00','AC','C0028'),('BC23','112379015','0000-00-00 00:00:00','AC','116301'),('BC24','112011335','0000-00-00 00:00:00','AC','K0004'),('BC25','2147483647','0000-00-00 00:00:00','AC',NULL),('BC26','112345543','0000-00-00 00:00:00','AC',NULL),('BC27','2147483647','0000-00-00 00:00:00','AC',NULL),('BC28','2147483647','0000-00-00 00:00:00','AC','116300'),('BC29','2147483647','0000-00-00 00:00:00','AC','116306'),('BC30','111958583','0000-00-00 00:00:00','AC',NULL),('BC31','2147483647','0000-00-00 00:00:00','AC',NULL),('BC32','2147483647','0000-00-00 00:00:00','AC',NULL),('BC33','521043990','0000-00-00 00:00:00','AC',NULL),('BC34','2147483647','0000-00-00 00:00:00','AC',NULL),('BC35','2147483647','0000-00-00 00:00:00','AC',NULL),('BC36','2147483647','0000-00-00 00:00:00','AC','116310'),('BC37','2147483647','0000-00-00 00:00:00','AC',NULL),('BC38','2147483647','0000-00-00 00:00:00','AC','116305'),('BC39','1693903404','0000-00-00 00:00:00','AC',NULL),('BC40','2147483647','0000-00-00 00:00:00','AC',NULL),('IDXX','0','0000-00-00 00:00:00','ID',NULL),('LC10','10','2019-12-13 07:26:24','LC',NULL),('LC11','11','2019-12-13 07:19:41','LC',NULL),('LC12','12','2019-12-13 07:14:36','LC',NULL),('LC13','13','0000-00-00 00:00:00','LC',NULL),('LC14','14','0000-00-00 00:00:00','LC',NULL),('LC15','15','0000-00-00 00:00:00','LC',NULL),('LC16','16','0000-00-00 00:00:00','LC',NULL),('LC17','17','0000-00-00 00:00:00','LC',NULL),('LC18','18','0000-00-00 00:00:00','LC',NULL),('LC31','31','0000-00-00 00:00:00','LC',NULL),('LC32','32','0000-00-00 00:00:00','LC',NULL),('LC33','33','0000-00-00 00:00:00','LC',NULL),('LC34','34','0000-00-00 00:00:00','LC',NULL),('LC35','35','0000-00-00 00:00:00','LC',NULL),('LC36','36','0000-00-00 00:00:00','LC',NULL),('LC49','49','0000-00-00 00:00:00','LC',NULL),('LC50','50','0000-00-00 00:00:00','LC',NULL),('LC51','51','0000-00-00 00:00:00','LC',NULL),('LC52','52','0000-00-00 00:00:00','LC',NULL),('LC53','53','0000-00-00 00:00:00','LC',NULL),('LC54','54','0000-00-00 00:00:00','LC',NULL),('LC67','67','0000-00-00 00:00:00','LC',NULL),('LC68','68','0000-00-00 00:00:00','LC',NULL),('LC69','69','0000-00-00 00:00:00','LC',NULL),('LC70','70','0000-00-00 00:00:00','LC',NULL),('LC71','71','0000-00-00 00:00:00','LC',NULL),('LC72','72','0000-00-00 00:00:00','LC',NULL),('UW01','1','2020-01-15 08:34:11','UW',NULL),('UW02','2','2020-01-15 08:34:29','UW','16149'),('UW03','3','2020-01-15 08:34:42','UW',NULL),('UW04','4','2020-01-15 08:34:52','UW',NULL),('UW05','5','2020-01-15 08:34:58','UW',NULL),('UW6','6','2020-03-24 15:04:27','UW',NULL);
/*!40000 ALTER TABLE `tb_m_asset` ENABLE KEYS */;
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
