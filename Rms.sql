-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: rms
-- ------------------------------------------------------
-- Server version	5.7.20-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `bill`
--

DROP TABLE IF EXISTS `bill`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bill` (
  `bid` int(11) NOT NULL AUTO_INCREMENT,
  `oid` int(11) NOT NULL,
  `billtotal` varchar(45) NOT NULL,
  PRIMARY KEY (`bid`),
  KEY `oid_idx` (`oid`),
  CONSTRAINT `oid` FOREIGN KEY (`oid`) REFERENCES `orderfood` (`oid`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bill`
--

LOCK TABLES `bill` WRITE;
/*!40000 ALTER TABLE `bill` DISABLE KEYS */;
INSERT INTO `bill` VALUES (1,3,'15'),(2,4,'34'),(3,5,'15'),(4,6,'25'),(5,7,'28'),(6,8,'37'),(7,9,'35'),(8,10,'22'),(9,11,'10'),(10,12,'10'),(11,13,'25'),(12,14,'26'),(13,15,'11'),(14,16,'25'),(15,17,'53'),(16,18,'11'),(17,19,'18'),(18,20,'19'),(19,21,'3'),(20,22,'3'),(21,23,'750'),(22,24,'1650'),(23,25,'1250'),(24,26,'1160'),(25,27,'300'),(26,28,'530'),(27,29,'320'),(28,30,'450'),(29,31,'1240'),(30,32,'900'),(31,33,'320'),(32,34,'320'),(33,35,'1160'),(34,36,'700'),(35,37,'940'),(36,38,'750'),(37,39,'200'),(38,40,'490'),(39,41,'600'),(40,42,'1000'),(41,43,'1040');
/*!40000 ALTER TABLE `bill` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `login`
--

DROP TABLE IF EXISTS `login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `login` (
  `uid` int(11) NOT NULL AUTO_INCREMENT,
  `uname` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `type` varchar(45) NOT NULL,
  PRIMARY KEY (`uid`),
  UNIQUE KEY `uname_UNIQUE` (`uname`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login`
--

LOCK TABLES `login` WRITE;
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` VALUES (1,'bilal','admin','admin'),(2,'shayaan','admin','admin'),(3,'abeer','user','user'),(4,'Hammad','user','user');
/*!40000 ALTER TABLE `login` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menu`
--

DROP TABLE IF EXISTS `menu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `menu` (
  `Menu_Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Price` varchar(45) NOT NULL,
  `SellPrice` varchar(45) NOT NULL,
  `Type` varchar(45) NOT NULL,
  `Category` varchar(45) NOT NULL,
  PRIMARY KEY (`Menu_Id`,`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menu`
--

LOCK TABLES `menu` WRITE;
/*!40000 ALTER TABLE `menu` DISABLE KEYS */;
INSERT INTO `menu` VALUES (1,'Regular Fries','20','100','Veg','Fast Food'),(2,'Masala Fries','22','120','Veg','Fast Food'),(3,'Chicken Burger','100','200','Non-Veg','Fast Food'),(4,'Beef Burger','120','250','Non-Veg','Fast Food'),(5,'Chicken Corn Soup','50','150','Non-Veg','Chinese'),(6,'Chicken Shashlik','320','500','Non-Veg','Chinese'),(7,'Fish Shashlik','350','520','Non-Veg','Chinese'),(8,'Garlic Rice','100','230','Non-Veg','Chinese'),(9,'Pizza Roll','150','240','Non-Veg','Rolls'),(10,'Chicken Roll','20','100','Non-Veg','Rolls'),(11,'Beef Roll','40','100','Non-Veg','Rolls'),(12,'Arabian Roll','50','240','Non-Veg','Rolls'),(13,'Boneless Handi','300','600','Non-Veg','Pakistani'),(14,'Chicken Biryani','60','150','Non-Veg','Pakistani'),(15,'Beef Biryani','60','130','Non-Veg','Pakistani'),(16,'Mutton Karahi','500','850','Non-Veg','Pakistani'),(17,'Paratha','20','50','Veg','Extras'),(18,'Naan','3','15','Veg','Extras'),(19,'Drink','20','80','Veg','Extras'),(20,'Salad','40','100','Veg','Extras'),(21,'Fruit Chaat','70','150','Veg','Dessert'),(22,'Ice Cream','70','200','Veg','Dessert'),(23,'Cake','100','350','Veg','Dessert'),(24,'Chocolate','80','250','Veg','Dessert'),(25,'Brownie','50','150','Non-Veg','Dessert');
/*!40000 ALTER TABLE `menu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderdetail`
--

DROP TABLE IF EXISTS `orderdetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orderdetail` (
  `odid` int(11) NOT NULL AUTO_INCREMENT,
  `order_id` int(11) NOT NULL,
  `bid` int(11) NOT NULL,
  `Menu_Id` int(11) NOT NULL,
  `Name` varchar(45) NOT NULL,
  `qty` varchar(45) NOT NULL,
  `price` varchar(45) NOT NULL,
  PRIMARY KEY (`odid`),
  KEY `bid_idx` (`order_id`,`bid`),
  KEY `Menu_Id_idx` (`Menu_Id`),
  CONSTRAINT `bid` FOREIGN KEY (`order_id`, `bid`) REFERENCES `bill` (`oid`, `bid`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `order_id` FOREIGN KEY (`order_id`) REFERENCES `orderfood` (`oid`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderdetail`
--

LOCK TABLES `orderdetail` WRITE;
/*!40000 ALTER TABLE `orderdetail` DISABLE KEYS */;
INSERT INTO `orderdetail` VALUES (1,36,34,1,'Regular Fries','3','100'),(2,36,34,3,'Chicken Burger','2','200'),(3,37,35,2,'Masala Fries','2','120'),(4,37,35,4,'Beef Burger','2','250'),(5,37,35,3,'Chicken Burger','1','200'),(6,38,36,3,'Chicken Burger','3','200'),(7,38,36,14,'Chicken Biryani','1','150'),(8,39,37,10,'Chicken Roll','2','100'),(9,40,38,2,'Masala Fries','2','120'),(10,40,38,4,'Beef Burger','1','250'),(11,41,39,1,'Regular Fries','1','100'),(12,41,39,4,'Beef Burger','2','250'),(13,42,40,6,'Chicken Shashlik','2','500'),(14,43,41,7,'Fish Shashlik','2','520');
/*!40000 ALTER TABLE `orderdetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderfood`
--

DROP TABLE IF EXISTS `orderfood`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orderfood` (
  `oid` int(11) NOT NULL AUTO_INCREMENT,
  `orderdate` datetime NOT NULL,
  PRIMARY KEY (`oid`)
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderfood`
--

LOCK TABLES `orderfood` WRITE;
/*!40000 ALTER TABLE `orderfood` DISABLE KEYS */;
INSERT INTO `orderfood` VALUES (1,'2018-01-03 16:49:47'),(2,'2018-01-03 17:06:25'),(3,'2018-01-03 17:07:38'),(4,'2018-01-03 17:09:06'),(5,'2018-01-03 17:18:29'),(6,'2018-01-03 17:21:21'),(7,'2018-01-03 17:42:17'),(8,'2018-01-03 17:42:41'),(9,'2018-01-03 18:27:32'),(10,'2018-01-03 18:28:58'),(11,'2018-01-03 18:45:54'),(12,'2018-01-03 18:47:34'),(13,'2018-01-03 18:50:20'),(14,'2018-01-03 18:53:23'),(15,'2018-01-03 18:54:44'),(16,'2018-01-03 19:14:07'),(17,'2018-01-03 19:17:48'),(18,'2018-01-03 19:18:09'),(19,'2018-01-03 19:32:58'),(20,'2018-01-03 23:22:56'),(21,'2018-01-03 23:24:48'),(22,'2018-01-03 23:44:01'),(23,'2018-01-04 00:43:51'),(24,'2018-01-04 00:45:22'),(25,'2018-01-04 00:58:53'),(26,'2018-01-04 01:00:24'),(27,'2018-01-04 01:03:58'),(28,'2018-01-04 01:08:38'),(29,'2018-01-04 01:11:52'),(30,'2018-01-04 01:56:22'),(31,'2018-01-04 01:58:15'),(32,'2018-01-04 02:00:54'),(33,'2018-01-04 02:01:55'),(34,'2018-01-04 02:03:36'),(35,'2018-01-04 02:24:55'),(36,'2018-01-04 02:39:41'),(37,'2018-01-04 02:41:17'),(38,'2018-01-04 02:43:43'),(39,'2018-01-04 02:43:59'),(40,'2018-01-04 02:47:07'),(41,'2018-01-04 02:47:27'),(42,'2018-01-04 02:48:17'),(43,'2018-01-04 02:48:34');
/*!40000 ALTER TABLE `orderfood` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-01-04  3:02:31
