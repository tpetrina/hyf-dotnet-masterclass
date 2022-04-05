CREATE DATABASE  IF NOT EXISTS `heroku_303e8a211d6392d` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `heroku_303e8a211d6392d`;
-- MySQL dump 10.13  Distrib 8.0.25, for Win64 (x86_64)
--
-- Host: eu-cdbr-west-01.cleardb.com    Database: heroku_303e8a211d6392d
-- ------------------------------------------------------
-- Server version	5.6.50-log

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
-- Table structure for table `meals`
--

DROP TABLE IF EXISTS `meals`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `meals` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` text,
  `description` text,
  `location` text,
  `when` text,
  `max_reservations` int(11) DEFAULT NULL,
  `price` double DEFAULT NULL,
  `created_date` text,
  `available_reservation` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=155 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `meals`
--

LOCK TABLES `meals` WRITE;
/*!40000 ALTER TABLE `meals` DISABLE KEYS */;
INSERT INTO `meals` VALUES (5,'Ghorme Sabzi','A great Persian dishes','Lyngby','2021-07-20',15,200,'2021-04-19',NULL),(45,'Pasta','New taste','Orestad','2021-06-28',10,120,'2021-04-19',NULL),(55,'Fish','Fresh salmon','Amager','2021-06-27',20,190,'2021-04-19',NULL),(65,'Ice cream','Different tastes','Lyngby','2021-07-01',18,45,'2021-04-19',NULL),(75,'Gheime','Persian food','Lyngby','2021-07-03',16,115,'2021-04-19',NULL),(85,'Kabab','Persian Kabab with rice','Lyngby','2021-07-03',14,100,'2021-04-19',NULL),(95,'Dolmeh','Persian food','Lyngby','2021-07-03',10,80,'2021-04-19',NULL),(105,'Breakfast','sausages, bacon, baked-beans, fried eggs, mushrooms, tomatoes and toast with coffee','Orestad','2021-05-20',17,135,'2021-04-19',NULL),(115,'Fesenjan','Persian Fesenjan dish with rice','Amager','2021-06-26T11:54',18,190,NULL,NULL),(125,'ZereshkPolo','Zereshk polo with chicken','Lyngby','2021-06-30T11:57',17,170,NULL,NULL),(135,'Abgoosht','Great food','CPH','2021-06-25T18:58',10,66,NULL,NULL),(145,'Connection','string','string',NULL,0,0,NULL,NULL);
/*!40000 ALTER TABLE `meals` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reservations`
--

DROP TABLE IF EXISTS `reservations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reservations` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `number_of_guests` int(11) DEFAULT NULL,
  `meal_id` int(11) DEFAULT NULL,
  `created_date` text,
  `contact_phonenumber` text,
  `contact_name` text,
  `contact_email` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=105 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservations`
--

LOCK TABLES `reservations` WRITE;
/*!40000 ALTER TABLE `reservations` DISABLE KEYS */;
INSERT INTO `reservations` VALUES (35,3,5,'2021-04-19','46 46 46 46','Suzy Az','suzy.az@gmail.com'),(45,4,45,'2021-04-19','45 45 45 45','Hani Far','hani.far@gmail.com'),(55,2,65,'2021-04-19','45 55 55 45','Sara Sol','sara.sol@gmail.com'),(65,2,55,NULL,'98765','Hani','hfarjamy@outlook.com'),(75,2,85,NULL,'9876543','Reza','hfarjamy@gmail.com'),(85,4,105,NULL,'31360363','islam','islam.fawzy25@hotmail.com'),(95,3,105,NULL,'31360363','islam','islam.fawzy25@hotmail.com');
/*!40000 ALTER TABLE `reservations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reviews`
--

DROP TABLE IF EXISTS `reviews`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reviews` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` text,
  `description` text,
  `meal_id` int(11) DEFAULT NULL,
  `stars` int(11) DEFAULT NULL,
  `created_date` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reviews`
--

LOCK TABLES `reviews` WRITE;
/*!40000 ALTER TABLE `reviews` DISABLE KEYS */;
INSERT INTO `reviews` VALUES (5,'Perfect','We had a great time and the food was delicious',5,5,'2021-05-30'),(15,'Great','food and drinks were delicious.',45,4,'2021-06-20'),(25,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `reviews` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-04-03 15:27:49
