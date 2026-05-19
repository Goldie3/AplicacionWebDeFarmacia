CREATE DATABASE  IF NOT EXISTS `productos_farmacia` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `productos_farmacia`;
-- MySQL dump 10.13  Distrib 8.0.45, for Win64 (x86_64)
--
-- Host: localhost    Database: productos_farmacia
-- ------------------------------------------------------
-- Server version	8.0.45

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
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto` (
  `idproducto` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) DEFAULT NULL,
  `fechaIngreso` date DEFAULT NULL,
  `cantidadProducto` int DEFAULT NULL,
  `precio` int DEFAULT NULL,
  `descripcion` text,
  `fechaVencimiento` date DEFAULT NULL,
  PRIMARY KEY (`idproducto`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (1,'Jarabe','2024-06-12',20,1000,'jarabe bueno','2026-05-01'),(2,'Paracetamol','2025-09-12',50,1500,'paracetamol medio caro creo','2026-02-19'),(3,'remedio generico','2025-04-24',100,500,'remedio terrible generico','2026-03-19'),(4,'amoxisilina','2024-11-22',100,500,'medicamento muy bueno','2027-03-19'),(5,'Loratadina 10mg','2025-05-01',110,1900,'Antialérgico para aliviar síntomas de alergia','2027-02-14'),(6,'Alcohol Gel 500ml','2025-05-02',75,3000,'Gel desinfectante para manos','2028-01-10'),(7,'Aspirina 100mg','2025-05-03',130,1600,'Medicamento analgésico y anticoagulante','2027-06-25'),(8,'Crema para quemaduras','2025-05-04',40,5200,'Crema tópica para tratar irritaciones y quemaduras leves','2026-10-12'),(9,'Sales de rehidratación','2025-05-05',95,1400,'Producto para prevenir deshidratación','2027-03-08'),(10,'Diclofenaco Gel','2025-05-06',50,4100,'Gel antiinflamatorio para dolores musculares','2026-07-19');
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'productos_farmacia'
--

--
-- Dumping routines for database 'productos_farmacia'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-05-19 13:58:20
