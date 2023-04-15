CREATE DATABASE  IF NOT EXISTS `sicl` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `sicl`;
-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: sicl
-- ------------------------------------------------------
-- Server version	5.7.41-log

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
-- Table structure for table `clasificaciones`
--

DROP TABLE IF EXISTS `clasificaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clasificaciones` (
  `IdClasificacion` int(11) NOT NULL AUTO_INCREMENT,
  `Clasificacion` varchar(100) NOT NULL,
  PRIMARY KEY (`IdClasificacion`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clasificaciones`
--

LOCK TABLES `clasificaciones` WRITE;
/*!40000 ALTER TABLE `clasificaciones` DISABLE KEYS */;
INSERT INTO `clasificaciones` VALUES (1,'SISTEMA'),(2,'CLIENTES'),(3,'FACTURACION');
/*!40000 ALTER TABLE `clasificaciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `IdCliente` int(11) NOT NULL AUTO_INCREMENT,
  `NombreCliente` varchar(50) NOT NULL,
  `ApellidoCliente` varchar(50) NOT NULL,
  `DuiCliente` varchar(11) NOT NULL,
  `GeneroCliente` enum('M','F') DEFAULT NULL,
  `IdDireccion` int(11) NOT NULL,
  PRIMARY KEY (`IdCliente`),
  KEY `IdDireccion` (`IdDireccion`),
  CONSTRAINT `clientes_ibfk_1` FOREIGN KEY (`IdDireccion`) REFERENCES `direcciones` (`IdDireccion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departamentos`
--

DROP TABLE IF EXISTS `departamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `departamentos` (
  `IdDepartamento` int(11) NOT NULL AUTO_INCREMENT,
  `Departamento` varchar(30) NOT NULL,
  PRIMARY KEY (`IdDepartamento`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamentos`
--

LOCK TABLES `departamentos` WRITE;
/*!40000 ALTER TABLE `departamentos` DISABLE KEYS */;
INSERT INTO `departamentos` VALUES (1,'AHUACHAPAN'),(2,'SANTA ANA'),(3,'SONSONATE'),(4,'CHALATENANGO'),(5,'LA LIBERTAD'),(6,'SAN SALVADOR'),(7,'CUSCATLAN'),(8,'SAN VICENTE'),(9,'USULUTAN'),(10,'SAN MIGUEL'),(11,'LA PAZ'),(12,'MORAZAN'),(13,'LA UNION'),(14,'CABAÑAS');
/*!40000 ALTER TABLE `departamentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detallepedido`
--

DROP TABLE IF EXISTS `detallepedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detallepedido` (
  `IdDetallePedido` int(11) NOT NULL AUTO_INCREMENT,
  `CantidadProductos` int(11) NOT NULL,
  `IdPedido` int(11) NOT NULL,
  `IdMedicamento` int(11) NOT NULL,
  PRIMARY KEY (`IdDetallePedido`),
  KEY `IdPedido` (`IdPedido`),
  KEY `IdMedicamento` (`IdMedicamento`),
  CONSTRAINT `detallepedido_ibfk_1` FOREIGN KEY (`IdPedido`) REFERENCES `pedidos` (`IdPedido`),
  CONSTRAINT `detallepedido_ibfk_2` FOREIGN KEY (`IdMedicamento`) REFERENCES `medicamento` (`IdMedicamento`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallepedido`
--

LOCK TABLES `detallepedido` WRITE;
/*!40000 ALTER TABLE `detallepedido` DISABLE KEYS */;
/*!40000 ALTER TABLE `detallepedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalleventa`
--

DROP TABLE IF EXISTS `detalleventa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalleventa` (
  `IdDetalleVenta` int(11) NOT NULL AUTO_INCREMENT,
  `CantidadProducto` int(11) NOT NULL,
  `IdVenta` int(11) NOT NULL,
  `IdMedicamento` int(11) NOT NULL,
  PRIMARY KEY (`IdDetalleVenta`),
  KEY `FK1_idx` (`IdMedicamento`),
  KEY `IdVenta` (`IdVenta`),
  CONSTRAINT `detalleventa_ibfk_1` FOREIGN KEY (`IdVenta`) REFERENCES `venta` (`IdVenta`),
  CONSTRAINT `detalleventa_ibfk_2` FOREIGN KEY (`IdMedicamento`) REFERENCES `medicamento` (`IdMedicamento`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalleventa`
--

LOCK TABLES `detalleventa` WRITE;
/*!40000 ALTER TABLE `detalleventa` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalleventa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `direcciones`
--

DROP TABLE IF EXISTS `direcciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `direcciones` (
  `IdDireccion` int(11) NOT NULL AUTO_INCREMENT,
  `NumeroCasa` varchar(50) DEFAULT NULL,
  `PasajePoligono` varchar(50) DEFAULT NULL,
  `Calle` varchar(50) DEFAULT NULL,
  `Colonia` varchar(40) DEFAULT NULL,
  `Canton` varchar(50) DEFAULT NULL,
  `Caserio` varchar(50) DEFAULT NULL,
  `CodigoPostal` varchar(20) DEFAULT NULL,
  `Pais` varchar(50) NOT NULL,
  `IdMunicipio` int(11) NOT NULL,
  PRIMARY KEY (`IdDireccion`),
  KEY `IdMunicipio` (`IdMunicipio`),
  CONSTRAINT `direcciones_ibfk_1` FOREIGN KEY (`IdMunicipio`) REFERENCES `municipios` (`IdMunicipios`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `direcciones`
--

LOCK TABLES `direcciones` WRITE;
/*!40000 ALTER TABLE `direcciones` DISABLE KEYS */;
INSERT INTO `direcciones` VALUES (3,'68','C','13',NULL,NULL,NULL,NULL,'El Salvador',35);
/*!40000 ALTER TABLE `direcciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleados` (
  `IdEmpleado` int(11) NOT NULL AUTO_INCREMENT,
  `NombreEmpleado` varchar(50) NOT NULL,
  `ApellidoEmpleado` varchar(50) NOT NULL,
  `TelefonoEmpleado` varchar(9) NOT NULL,
  `Genero` enum('M','F') DEFAULT NULL,
  `IdDireccion` int(11) NOT NULL,
  PRIMARY KEY (`IdEmpleado`),
  KEY `FKD_idx` (`IdDireccion`),
  CONSTRAINT `FKD` FOREIGN KEY (`IdDireccion`) REFERENCES `direcciones` (`IdDireccion`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados`
--

LOCK TABLES `empleados` WRITE;
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
INSERT INTO `empleados` VALUES (3,'Jorge','Perez','70289460','M',3);
/*!40000 ALTER TABLE `empleados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factura`
--

DROP TABLE IF EXISTS `factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `factura` (
  `IdFactura` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date NOT NULL,
  `IdDetalleVenta` int(11) NOT NULL,
  `Cantidad` tinyint(4) NOT NULL,
  `Subtotal` int(11) NOT NULL,
  `Total` int(11) NOT NULL,
  PRIMARY KEY (`IdFactura`),
  KEY `FK1_idx` (`IdDetalleVenta`),
  CONSTRAINT `FK1` FOREIGN KEY (`IdDetalleVenta`) REFERENCES `detalleventa` (`IdDetalleVenta`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura`
--

LOCK TABLES `factura` WRITE;
/*!40000 ALTER TABLE `factura` DISABLE KEYS */;
/*!40000 ALTER TABLE `factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `farmaceutica`
--

DROP TABLE IF EXISTS `farmaceutica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `farmaceutica` (
  `IdFarmaceutica` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) NOT NULL,
  `numeroContacto` varchar(20) NOT NULL,
  `distribuidora` varchar(100) NOT NULL,
  `IdDireccion` int(11) NOT NULL,
  PRIMARY KEY (`IdFarmaceutica`),
  KEY `IdDireccion` (`IdDireccion`),
  CONSTRAINT `farmaceutica_ibfk_1` FOREIGN KEY (`IdDireccion`) REFERENCES `direcciones` (`IdDireccion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `farmaceutica`
--

LOCK TABLES `farmaceutica` WRITE;
/*!40000 ALTER TABLE `farmaceutica` DISABLE KEYS */;
/*!40000 ALTER TABLE `farmaceutica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medicamento`
--

DROP TABLE IF EXISTS `medicamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `medicamento` (
  `IdMedicamento` int(11) NOT NULL AUTO_INCREMENT,
  `IdFarmaceutica` int(11) NOT NULL,
  `PrecioUnidad` decimal(5,2) NOT NULL,
  `PrecioCaja` decimal(5,2) NOT NULL,
  `lote` varchar(100) NOT NULL,
  `fechaVencimiento` date NOT NULL,
  `ContenidoNeto` varchar(100) NOT NULL,
  `Presentacion` varchar(100) NOT NULL,
  `edadConsumidor` tinyint(4) NOT NULL,
  `restricciones` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`IdMedicamento`),
  KEY `IdFarmaceutica` (`IdFarmaceutica`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medicamento`
--

LOCK TABLES `medicamento` WRITE;
/*!40000 ALTER TABLE `medicamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `medicamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `municipios`
--

DROP TABLE IF EXISTS `municipios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `municipios` (
  `IdMunicipios` int(11) NOT NULL AUTO_INCREMENT,
  `municipio` varchar(100) NOT NULL,
  `IdDepartamento` int(11) NOT NULL,
  PRIMARY KEY (`IdMunicipios`),
  KEY `IdDepartamento` (`IdDepartamento`),
  CONSTRAINT `municipios_ibfk_1` FOREIGN KEY (`IdDepartamento`) REFERENCES `departamentos` (`IdDepartamento`)
) ENGINE=InnoDB AUTO_INCREMENT=264 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `municipios`
--

LOCK TABLES `municipios` WRITE;
/*!40000 ALTER TABLE `municipios` DISABLE KEYS */;
INSERT INTO `municipios` VALUES (1,'Apaneca',1),(2,'Atiquizaya',1),(3,'Concepcion de Ataco',1),(4,'El Refugio',1),(5,'Guaymango',1),(6,'Jujutla',1),(7,'San Francisco Menendez',1),(8,'San Lorenzo',1),(9,'San Pedro Puxtla',1),(10,'Tacuba',1),(11,'Turin',1),(12,'Candelaria de la Frontera',2),(13,'Chalchuapa',2),(14,'Coatepeque',2),(15,'El Congo',2),(16,'El Porvenir',2),(17,'Masahuat',2),(18,'Metapan',2),(19,'San Antonio Pajonal',2),(20,'San Sebastian Salitrillo',2),(21,'Santa Rosa Guachipilin',2),(22,'Santiago de la frontera',2),(23,'Texistepeque',2),(24,'Santa Ana',2),(25,'Ahuachapan',1),(26,'Sonsonate',3),(27,'Acajutla',3),(28,'Armenia',3),(29,'Caluco',3),(30,'Cuisnahuat',3),(31,'Izalco',3),(32,'Juayua',3),(33,'Nahuizalco',3),(34,'Salcoatitan',3),(35,'San Antonio del Monte',3),(36,'San Julian',3),(37,'Santa Catarina Masahuat',3),(38,'Santa Isabel Ishuatan',3),(39,'Santo Domingo de Guzman',3),(40,'Sonzacate',3),(41,'Chalatenango',4),(42,'Agua Caliente',4),(43,'Arcatao',4),(44,'Azacualpa',4),(45,'Cancasque',4),(46,'Citala',4),(47,'Comalapa',4),(48,'Concepcion Quezaltepeque',4),(49,'Dulce Nombre de Maria',4),(50,'El Carrizal',4),(51,'El Paraiso',4),(52,'La Laguna ',4),(53,'La Palma',4),(54,'La Reina',4),(55,'Las Flores',4),(56,'Las Vueltas',4),(57,'Nombre de Jesus',4),(58,'Nueva Concepcion ',4),(59,'Nueva Trinidad',4),(60,'Ojos de Agua',4),(61,'Potonico',4),(62,'San Antonio de la Cruz',4),(63,'San Antonio Los Ranchos',4),(64,'San Fernando',4),(65,'San Francisco Lempa ',4),(66,'San Francisco Morazan',4),(67,'San Ignacio',4),(68,'San Isidro Labrador',4),(69,'San Luis del Carmen',4),(70,'San Miguel de Mercedes',4),(71,'San Rafael',4),(72,'Santa Rita',4),(73,'Tejutla',4),(74,'Santa Tecla',5),(75,'Antiguo Cuscatlan',5),(76,'Chiltiupan',5),(77,'Cuidad Arce',5),(78,'Colon ',5),(79,'Comasagua',5),(80,'Jayaque',5),(81,'Jicalapa',5),(82,'La Libertad',5),(83,'Nuevo Cuscatlan',5),(84,'Quezaltepeque',5),(85,'San Juan Opico',5),(86,'Sacacoyo',5),(87,'San Jose Villanueva',5),(88,'San Matias',5),(89,'San Pablo Tacachico',5),(90,'Talnique',5),(91,'Tamanique',5),(92,'Teotepeque',5),(93,'Tepecoyo',5),(94,'Zaragoza',5),(95,'San Salvador',6),(96,'Aguilares',6),(97,'Apopa',6),(98,'Ayutuxtepeque',6),(99,'Ciudad Delgado',6),(100,'Cuscatancingo',6),(101,'El Paisnal',6),(102,'Guazapa',6),(103,'Ilopango',6),(104,'Mejicanos',6),(105,'Nejapa',6),(106,'Panchimalco',6),(107,'Rosario de Mora',6),(108,'San Marcos',6),(109,'San Martin',6),(110,'Santiago Texacuangos',6),(111,'Santo Tomas',6),(112,'Soyapango',6),(113,'Tonacatepeque',6),(114,'Cojutepeque',7),(115,'Candelaria',7),(116,'El Carmen',7),(117,'El Rosario',7),(118,'Monte San Juan',7),(119,'Oratorio de Concepcion',7),(120,'San Bartolome Perulapia',7),(121,'San Cristobal',7),(122,'San Jose Guayabal',7),(123,'San Pedro Perulapan',7),(124,'San Rafael Cedros',7),(125,'San Ramon',7),(126,'Santa Cruz Analquito',7),(127,'Santa Cruz Michapa',7),(128,'Suchitoto',7),(129,'Tenancingo',7),(130,'San Vicente',8),(131,'Apastepeque',8),(132,'Guadalupe',8),(133,'San Cayetano Istepeque',8),(134,'San Esteban Catarina',8),(135,'San Ildefonso',8),(136,'San Lorenzo',8),(137,'San Sebastian',8),(138,'Santa Clara',8),(139,'Santo Domingo',8),(140,'Tecoluca',8),(141,'Tepetitan',8),(142,'Verapaz',8),(143,'Usulutan',9),(144,'Alegria',9),(145,'Berlin',9),(146,'California',9),(147,'Concepcion Batres',9),(148,'El Triunfo',9),(149,'Ereguayquin',9),(150,'Estanzuelas',9),(151,'Jiquilisco',9),(152,'Jucuapa',9),(153,'Jucuaran',9),(154,'Mercedes Umaña',9),(155,'Nueva Granada',9),(156,'Ozatlan',9),(157,'Puerto el Triunfo',9),(158,'San Agustin',9),(159,'San Buenaventura',9),(160,'San Dionisio',9),(161,'San Francisco Javier',9),(162,'Santa Elena',9),(163,'Santa Maria',9),(164,'Santiago de Maria',9),(165,'Tecapan',9),(166,'San Miguel',10),(167,'Carolina',10),(168,'Chapeltique',10),(169,'Chinameca',10),(170,'Chirilagua',10),(171,'Cuida Barrios',10),(172,'Comacaran',10),(173,'El Transito',10),(174,'Lolotique',10),(175,'Moncagua',10),(176,'Nueva Guadalupe',10),(177,'Nuevo Eden de San Juan',10),(178,'Quelepa',10),(179,'San Antonio',10),(180,'San Gerardo',10),(181,'San Jorge',10),(182,'San Luis de la Reina',10),(183,'San Rafael Oriente',10),(184,'Sesori',10),(185,'Uluazapa',10),(186,'Zacatecoluca',11),(187,'Cuyultitan',11),(188,'El Rosario',11),(189,'Jerusalen',11),(190,'Mercedes La Ceiba',11),(191,'Olocuilta',11),(192,'Paraiso de Osorio',11),(193,'San Antonio Masahuat',11),(194,'San Emigdio',11),(195,'San Francisco Chinameca',11),(196,'San Pedro Masahuat',11),(197,'San Juan Nonualco',11),(198,'San Juan Talpa',11),(199,'San Juan Tepezontes',11),(200,'San Luis La Herradura',11),(201,'San Luis Talpa',11),(202,'San Miguel Tepezontes',11),(203,'San Pedro Nonualco',11),(204,'San Rafael Obrajuelo',11),(205,'Santa Maria Ostuma',11),(206,'Santiago Nonualco',11),(207,'Tapalhuaca',11),(208,'San Francico Gotera',12),(209,'Arambala ',12),(210,'Cacaopera',12),(211,'Chilanga',12),(212,'Corinto',12),(213,'Delicias de Concepcion',12),(214,'El Divisadero',12),(215,'El Rosario',12),(216,'Gualococti',12),(217,'Guatajiagua',12),(218,'Joateca',12),(219,'Jocoaitique',12),(220,'Jocoro',12),(221,'Lolotiquillo',12),(222,'Meanguera',12),(223,'Osicala',12),(224,'Perquin',12),(225,'San Carlos',12),(226,'San Fernando',12),(227,'San Isidro',12),(228,'San Simon',12),(229,'Semsembra',12),(230,'Sociedad',12),(231,'Torola',12),(232,'Yamabal',12),(233,'Yoloaiquin',12),(234,'La Union',13),(235,'Anamoros',13),(236,'Bolivar',13),(237,'Concepcion de Oriente',13),(238,'Conchagua',13),(239,'El Carmen',13),(240,'El Sauce',13),(241,'Intipuca',13),(242,'Lislique',13),(243,'Meanguera de Golfo',13),(244,'Nueva Esparta',13),(245,'Pasaquina',13),(246,'Poloros',13),(247,'San Alejo',13),(248,'San Jose',13),(249,'Santa Rosa de Lima',13),(250,'Yayantique',13),(251,'Yucuaiquin',13),(252,'Sensuntepeque',14),(253,'Cinquera',14),(254,'Dolores',14),(255,'Guacotecti',14),(256,'Ilobasco',14),(257,'Jutiapa',14),(258,'San Isidro',14),(259,'Tejutepeque',14),(260,'Victoria',14),(262,'Nahuilingo',3),(263,'Huizucar',5);
/*!40000 ALTER TABLE `municipios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `opciones`
--

DROP TABLE IF EXISTS `opciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `opciones` (
  `IdOpcion` int(11) NOT NULL AUTO_INCREMENT,
  `Opcion` varchar(100) NOT NULL,
  `IdClasificacion` int(11) NOT NULL,
  PRIMARY KEY (`IdOpcion`),
  KEY `FKQ_idx` (`IdClasificacion`),
  CONSTRAINT `FKQ` FOREIGN KEY (`IdClasificacion`) REFERENCES `clasificaciones` (`IdClasificacion`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `opciones`
--

LOCK TABLES `opciones` WRITE;
/*!40000 ALTER TABLE `opciones` DISABLE KEYS */;
INSERT INTO `opciones` VALUES (1,'INICIAR  SESION',1),(2,'VER USUARIOS',1),(3,'AGREGAR USUARIO',1),(4,'EDITAR USUARIO',1),(5,'ELIMINAR USUARIO',1),(6,'VER CLIENTES',2);
/*!40000 ALTER TABLE `opciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pago`
--

DROP TABLE IF EXISTS `pago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pago` (
  `IdPago` int(11) NOT NULL AUTO_INCREMENT,
  `FormaPago` varchar(50) NOT NULL,
  PRIMARY KEY (`IdPago`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pago`
--

LOCK TABLES `pago` WRITE;
/*!40000 ALTER TABLE `pago` DISABLE KEYS */;
/*!40000 ALTER TABLE `pago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedidos`
--

DROP TABLE IF EXISTS `pedidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pedidos` (
  `IdPedido` int(11) NOT NULL AUTO_INCREMENT,
  `FechaPedido` date NOT NULL,
  `MontoPedido` decimal(2,0) NOT NULL,
  `IdFarmaceutica` int(11) NOT NULL,
  PRIMARY KEY (`IdPedido`),
  KEY `FK1_idx` (`IdFarmaceutica`),
  CONSTRAINT `pedidos_ibfk_1` FOREIGN KEY (`IdFarmaceutica`) REFERENCES `farmaceutica` (`IdFarmaceutica`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedidos`
--

LOCK TABLES `pedidos` WRITE;
/*!40000 ALTER TABLE `pedidos` DISABLE KEYS */;
/*!40000 ALTER TABLE `pedidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `permisos`
--

DROP TABLE IF EXISTS `permisos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `permisos` (
  `IdPermiso` int(11) NOT NULL AUTO_INCREMENT,
  `IdRol` int(11) NOT NULL,
  `IdOpcion` int(11) NOT NULL,
  PRIMARY KEY (`IdPermiso`),
  KEY `fk1_idx` (`IdRol`),
  KEY `IdOpcion` (`IdOpcion`),
  CONSTRAINT `permisos_ibfk_1` FOREIGN KEY (`IdRol`) REFERENCES `rol` (`IdRol`),
  CONSTRAINT `permisos_ibfk_2` FOREIGN KEY (`IdOpcion`) REFERENCES `opciones` (`IdOpcion`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permisos`
--

LOCK TABLES `permisos` WRITE;
/*!40000 ALTER TABLE `permisos` DISABLE KEYS */;
INSERT INTO `permisos` VALUES (1,1,1),(2,1,2),(3,1,3),(4,1,4),(5,1,5),(6,1,6);
/*!40000 ALTER TABLE `permisos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rol`
--

DROP TABLE IF EXISTS `rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rol` (
  `IdRol` int(11) NOT NULL AUTO_INCREMENT,
  `Rol` varchar(50) NOT NULL,
  PRIMARY KEY (`IdRol`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rol`
--

LOCK TABLES `rol` WRITE;
/*!40000 ALTER TABLE `rol` DISABLE KEYS */;
INSERT INTO `rol` VALUES (1,'ADMINISTRADOR'),(2,'VENDEDOR'),(3,'DIGITADOR');
/*!40000 ALTER TABLE `rol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stock`
--

DROP TABLE IF EXISTS `stock`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `stock` (
  `IdStock` int(11) NOT NULL AUTO_INCREMENT,
  `IdMedicamemnto` int(11) NOT NULL,
  `Cantidad` int(11) NOT NULL,
  PRIMARY KEY (`IdStock`),
  KEY `IdMedicamemnto` (`IdMedicamemnto`),
  CONSTRAINT `stock_ibfk_1` FOREIGN KEY (`IdMedicamemnto`) REFERENCES `medicamento` (`IdMedicamento`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stock`
--

LOCK TABLES `stock` WRITE;
/*!40000 ALTER TABLE `stock` DISABLE KEYS */;
/*!40000 ALTER TABLE `stock` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `IdUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(50) NOT NULL,
  `clave` varchar(50) NOT NULL,
  `IdRol` int(11) NOT NULL,
  `IdEmpleado` int(11) NOT NULL,
  PRIMARY KEY (`IdUsuario`),
  KEY `usuarios_ibfk_1_idx` (`IdRol`),
  KEY `FKEm_idx` (`IdEmpleado`),
  CONSTRAINT `FKEm` FOREIGN KEY (`IdEmpleado`) REFERENCES `empleados` (`IdEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`IdRol`) REFERENCES `rol` (`IdRol`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (6,'Alex','3be0ff98032936bc7f9df51c5685ee5f2dd6ccee',1,3);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venta`
--

DROP TABLE IF EXISTS `venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `venta` (
  `IdVenta` int(11) NOT NULL AUTO_INCREMENT,
  `IdEmpleado` int(11) NOT NULL,
  `IdMaterialQuirurgico` int(11) DEFAULT NULL,
  `nombreFarmacia` varchar(50) NOT NULL,
  `IdPago` int(11) NOT NULL,
  `Total` decimal(5,2) NOT NULL,
  `IdCliente` int(11) NOT NULL,
  PRIMARY KEY (`IdVenta`),
  KEY `IdUsuario` (`IdEmpleado`),
  KEY `IdPago` (`IdPago`),
  KEY `IdCliente` (`IdCliente`),
  CONSTRAINT `FKE` FOREIGN KEY (`IdEmpleado`) REFERENCES `empleados` (`IdEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `venta_ibfk_3` FOREIGN KEY (`IdPago`) REFERENCES `pago` (`IdPago`),
  CONSTRAINT `venta_ibfk_4` FOREIGN KEY (`IdCliente`) REFERENCES `clientes` (`IdCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venta`
--

LOCK TABLES `venta` WRITE;
/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
/*!40000 ALTER TABLE `venta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'sicl'
--

--
-- Dumping routines for database 'sicl'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-04-09 18:02:56
