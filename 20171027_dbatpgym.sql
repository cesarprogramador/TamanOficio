/*
SQLyog Community v12.18 (64 bit)
MySQL - 5.6.21-log : Database - dbatpgym
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`dbatpgym` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `dbatpgym`;

/*Table structure for table `asistencias` */

DROP TABLE IF EXISTS `asistencias`;

CREATE TABLE `asistencias` (
  `idasistencia` int(11) NOT NULL AUTO_INCREMENT,
  `idpersona` int(11) DEFAULT NULL,
  `ingreso` datetime DEFAULT NULL,
  `salida` datetime DEFAULT NULL,
  `accion` varchar(1) DEFAULT NULL,
  `fechaaccion` datetime DEFAULT NULL,
  `idempleadoaccion` int(11) DEFAULT NULL,
  `idpunto` int(11) DEFAULT NULL,
  PRIMARY KEY (`idasistencia`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

/*Data for the table `asistencias` */

/*Table structure for table `cajadeldia` */

DROP TABLE IF EXISTS `cajadeldia`;

CREATE TABLE `cajadeldia` (
  `idcajadeldia` int(11) NOT NULL AUTO_INCREMENT,
  `fechacarga` datetime DEFAULT NULL,
  `montoegreso` decimal(10,0) DEFAULT NULL,
  `montoingreso` decimal(10,0) DEFAULT NULL,
  `detallemovimiento` varchar(500) DEFAULT NULL,
  `idcuota` int(11) DEFAULT NULL,
  `accion` varchar(1) DEFAULT NULL,
  `fechaaccion` datetime DEFAULT NULL,
  `idempleadoaccion` int(11) DEFAULT NULL,
  `idpuntoaccion` int(11) DEFAULT NULL,
  `idgasto` int(11) DEFAULT NULL,
  PRIMARY KEY (`idcajadeldia`)
) ENGINE=MyISAM AUTO_INCREMENT=36 DEFAULT CHARSET=utf8;

/*Data for the table `cajadeldia` */

insert  into `cajadeldia`(`idcajadeldia`,`fechacarga`,`montoegreso`,`montoingreso`,`detallemovimiento`,`idcuota`,`accion`,`fechaaccion`,`idempleadoaccion`,`idpuntoaccion`,`idgasto`) values 
(17,'2017-09-26 00:00:00','0','500','Pago de cuota',59,'N','2017-09-26 11:47:51',1,1,0),
(18,'2017-09-26 00:00:00','0','250','Pago de cuota',60,'N','2017-09-26 11:49:05',1,1,0),
(19,'2017-10-25 00:00:00','0','70','Pago de cuota',62,'N','2017-10-25 03:48:16',1,1,0),
(20,'2017-10-25 00:00:00','0','500','Pago de cuota',63,'N','2017-10-25 03:48:45',1,1,0),
(21,'2017-10-25 00:00:00','0','50','Pago de cuota',61,'N','2017-10-25 03:49:48',1,1,0),
(23,'2017-10-25 00:00:00','7845','0','Gasto',0,'N','2017-10-25 11:27:48',1,1,12),
(24,'2017-10-26 00:00:00','2375','0','Gasto: Gasto: Gasto',0,'M','2017-10-26 02:12:47',1,1,13),
(25,'2017-10-26 00:00:00','500','0','Gasto',0,'N','2017-10-26 01:55:33',1,1,14),
(26,'2017-10-26 00:00:00','600','0','Gasto: Nuevo  khjkjhkjh',0,'M','2017-10-26 02:52:02',1,1,15),
(27,'2017-10-26 00:00:00','2500','0','.',0,'B','2017-10-26 03:27:40',1,1,16),
(30,'2017-10-26 00:00:00','0','50','Pago de cuota',67,'N','2017-10-26 03:40:31',1,1,0),
(29,'2017-10-26 00:00:00','6000','0','Gasto: Nuevo gasto de LUZ con multa Modifico el monto de 5890 a 6000 y el punto por TV y factura C y proveedor 2',0,'M','2017-10-26 03:27:17',1,1,23),
(31,'2017-10-26 00:00:00','450','0','Gasto: Se paga Luz',0,'N','2017-10-26 03:45:05',1,1,24),
(32,'2017-10-27 00:00:00','0','800','Pago de cuota',69,'N','2017-10-27 03:26:12',1,1,0),
(33,'2017-10-27 00:00:00','0','800','Pago de cuota',72,'N','2017-10-27 03:35:53',1,1,0),
(34,'2017-10-20 00:00:00','500','0','Gasto: SE PAGA LA LUZ',0,'N','2017-10-27 03:37:46',1,1,25),
(35,'2017-10-27 00:00:00','500','0','Gasto: SE PAGA LA LUZ DEL LOCAL',0,'N','2017-10-27 03:38:37',1,1,26);

/*Table structure for table `clases` */

DROP TABLE IF EXISTS `clases`;

CREATE TABLE `clases` (
  `idclase` int(11) NOT NULL AUTO_INCREMENT,
  `idtipoclase` int(11) DEFAULT NULL,
  `nombreclase` varchar(30) DEFAULT NULL,
  `accion` varchar(1) DEFAULT NULL,
  `fechaaccion` datetime DEFAULT NULL,
  `idempleadoaccion` int(11) DEFAULT NULL,
  PRIMARY KEY (`idclase`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `clases` */

insert  into `clases`(`idclase`,`idtipoclase`,`nombreclase`,`accion`,`fechaaccion`,`idempleadoaccion`) values 
(1,1,'Atletismo','N','2017-08-23 08:38:19',1),
(2,2,'Natación','N','2017-08-23 08:38:35',1),
(3,2,'Aero','N','2017-08-23 15:31:09',1);

/*Table structure for table `cuotas` */

DROP TABLE IF EXISTS `cuotas`;

CREATE TABLE `cuotas` (
  `idcuota` int(11) NOT NULL AUTO_INCREMENT,
  `idcurso` int(11) DEFAULT NULL,
  `fechapago` date DEFAULT NULL,
  `fecharealpago` date DEFAULT NULL,
  `montocuota` decimal(10,0) DEFAULT NULL,
  `montopagado` decimal(10,0) DEFAULT NULL,
  `montosaldo` decimal(10,0) DEFAULT NULL,
  `accion` varchar(1) DEFAULT NULL,
  `fechaaccion` datetime DEFAULT NULL,
  `idempleadoaccion` int(11) DEFAULT NULL,
  `cuotanum` int(11) DEFAULT NULL,
  `idpuntoaccion` int(11) DEFAULT NULL,
  PRIMARY KEY (`idcuota`)
) ENGINE=MyISAM AUTO_INCREMENT=74 DEFAULT CHARSET=utf8;

/*Data for the table `cuotas` */

insert  into `cuotas`(`idcuota`,`idcurso`,`fechapago`,`fecharealpago`,`montocuota`,`montopagado`,`montosaldo`,`accion`,`fechaaccion`,`idempleadoaccion`,`cuotanum`,`idpuntoaccion`) values 
(59,23,'2017-09-26','2017-09-26','500','500','0','M','2017-09-26 11:47:51',1,1,1),
(60,23,'2017-10-26','2017-09-26','500','250','0','M','2017-09-26 11:49:05',1,2,1),
(61,23,'2017-11-26','2017-10-25','500','50','250','M','2017-10-25 03:49:48',1,3,1),
(62,24,'2017-10-25','2017-10-25','870','70','0','M','2017-10-25 03:48:16',1,1,1),
(63,25,'2017-10-25','2017-10-25','1000','500','0','M','2017-10-25 03:48:45',1,1,1),
(64,24,'2017-11-25',NULL,'870',NULL,'800','N','2017-10-25 03:48:16',1,2,1),
(65,25,'2017-11-25',NULL,'1000',NULL,'500','N','2017-10-25 03:48:45',1,2,1),
(66,23,'2017-12-26',NULL,'500',NULL,'700','N','2017-10-25 03:49:48',1,4,1),
(67,26,'2017-10-26','2017-10-26','450','50','0','M','2017-10-26 03:40:31',1,1,1),
(68,26,'2017-11-26',NULL,'450',NULL,'400','N','2017-10-26 03:40:31',1,2,1),
(69,27,'2017-10-27','2017-10-27','800','800','0','M','2017-10-27 03:26:12',1,1,1),
(70,28,'2017-10-27',NULL,'80','0','0','B','2017-10-27 03:26:00',1,1,1),
(71,27,'2017-11-27',NULL,'800',NULL,'0','N','2017-10-27 03:26:12',1,2,1),
(72,29,'2017-10-27','2017-10-27','800','800','0','M','2017-10-27 03:35:53',1,1,1),
(73,29,'2017-11-27',NULL,'800',NULL,'0','N','2017-10-27 03:35:53',1,2,1);

/*Table structure for table `cursos` */

DROP TABLE IF EXISTS `cursos`;

CREATE TABLE `cursos` (
  `idcurso` int(11) NOT NULL AUTO_INCREMENT,
  `idclase` int(11) DEFAULT NULL,
  `idpunto` int(11) DEFAULT NULL,
  `idpersona` int(11) DEFAULT NULL,
  `accion` varchar(1) DEFAULT NULL,
  `fechaaccion` datetime DEFAULT NULL,
  `idempleadoaccion` int(11) DEFAULT NULL,
  `idpuntoaccion` int(11) DEFAULT NULL,
  PRIMARY KEY (`idcurso`)
) ENGINE=MyISAM AUTO_INCREMENT=30 DEFAULT CHARSET=utf8;

/*Data for the table `cursos` */

insert  into `cursos`(`idcurso`,`idclase`,`idpunto`,`idpersona`,`accion`,`fechaaccion`,`idempleadoaccion`,`idpuntoaccion`) values 
(6,3,2,41,'N','2017-08-23 07:09:22',1,1),
(7,2,2,41,'B','2017-08-23 07:51:09',1,1),
(8,1,2,41,'N','2017-08-23 07:11:17',1,1),
(9,2,2,41,'N','2017-08-23 07:52:58',1,1),
(10,2,1,43,'B','2017-08-28 03:32:06',1,1),
(12,1,2,44,'N','2017-08-28 02:54:42',1,1),
(13,1,2,44,'N','2017-08-28 02:54:42',1,1),
(14,1,2,44,'N','2017-08-28 03:00:51',1,1),
(15,1,2,44,'N','2017-08-28 03:01:28',1,1),
(16,1,2,44,'B','2017-08-28 03:16:57',1,1),
(17,1,2,44,'N','2017-08-28 03:17:24',1,1),
(18,2,2,48,'N','2017-09-08 07:57:53',1,1),
(19,1,2,49,'N','2017-09-26 11:16:44',1,1),
(20,3,2,49,'N','2017-09-26 11:21:56',1,1),
(21,1,2,49,'N','2017-09-26 11:25:27',1,1),
(22,1,2,49,'N','2017-09-26 11:33:09',1,1),
(23,1,2,49,'N','2017-09-26 11:46:58',1,1),
(24,1,2,63,'N','2017-10-25 03:29:43',1,1),
(25,3,2,63,'N','2017-10-25 03:47:51',1,1),
(26,1,2,48,'N','2017-10-26 03:39:27',1,1),
(27,1,2,68,'N','2017-10-27 03:25:19',1,1),
(28,2,2,68,'B','2017-10-27 03:26:00',1,1),
(29,1,2,69,'N','2017-10-27 03:35:44',1,1);

/*Table structure for table `diaslaborales` */

DROP TABLE IF EXISTS `diaslaborales`;

CREATE TABLE `diaslaborales` (
  `iddialaboral` int(11) NOT NULL AUTO_INCREMENT,
  `idjornadalaboral` int(11) DEFAULT NULL,
  `ingreso` datetime DEFAULT NULL,
  `salida` datetime DEFAULT NULL,
  `accion` varchar(1) DEFAULT NULL,
  `fechaaccion` datetime DEFAULT NULL,
  `idempleadoaccion` int(11) DEFAULT NULL,
  PRIMARY KEY (`iddialaboral`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

/*Data for the table `diaslaborales` */

/*Table structure for table `especialidades` */

DROP TABLE IF EXISTS `especialidades`;

CREATE TABLE `especialidades` (
  `idespecialidad` int(11) NOT NULL AUTO_INCREMENT,
  `especialidad` varchar(30) DEFAULT NULL,
  `accion` varchar(1) DEFAULT NULL,
  `fechaaccion` datetime DEFAULT NULL,
  `idempleadoaccion` int(11) DEFAULT NULL,
  `idpuntoaccion` int(11) DEFAULT NULL,
  PRIMARY KEY (`idespecialidad`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `especialidades` */

insert  into `especialidades`(`idespecialidad`,`especialidad`,`accion`,`fechaaccion`,`idempleadoaccion`,`idpuntoaccion`) values 
(1,'Ninguna','N','2017-10-27 15:04:17',1,1),
(2,'Otras','N','2017-10-27 15:04:23',1,1);

/*Table structure for table `gastos` */

DROP TABLE IF EXISTS `gastos`;

CREATE TABLE `gastos` (
  `idgasto` int(11) NOT NULL AUTO_INCREMENT,
  `numerofactura` varchar(50) DEFAULT NULL,
  `tipofactura` varchar(10) DEFAULT NULL,
  `idpersona` int(11) DEFAULT NULL,
  `montopagado` decimal(10,0) DEFAULT NULL,
  `fecharealcarga` datetime DEFAULT NULL,
  `fechagasto` date DEFAULT NULL,
  `observacion` varchar(500) DEFAULT NULL,
  `accion` varchar(1) DEFAULT NULL,
  `fechaaccion` datetime DEFAULT NULL,
  `idempleadoaccion` int(11) DEFAULT NULL,
  `idpunto` int(11) DEFAULT NULL,
  `idpuntoaccion` int(11) DEFAULT NULL,
  PRIMARY KEY (`idgasto`)
) ENGINE=MyISAM AUTO_INCREMENT=27 DEFAULT CHARSET=utf8;

/*Data for the table `gastos` */

insert  into `gastos`(`idgasto`,`numerofactura`,`tipofactura`,`idpersona`,`montopagado`,`fecharealcarga`,`fechagasto`,`observacion`,`accion`,`fechaaccion`,`idempleadoaccion`,`idpunto`,`idpuntoaccion`) values 
(1,'A1','A',50,'150','2017-10-25 00:00:00','2017-10-25','Prueba de gastos','N','2017-10-25 00:00:00',1,2,1),
(12,'1234X','X',51,'7845','2017-10-25 11:11:53','2017-10-20','Hola a todos','N','2017-10-25 11:27:48',1,1,1),
(13,'B1234','B',61,'2375','2017-10-26 01:47:07','2017-10-25','Se pago Luz y Gas - Modificado','M','2017-10-26 02:12:47',1,2,1),
(14,'BB147258','B',52,'500','2017-10-26 01:55:10','2017-10-25','Se pago Luz y Gas','N','2017-10-26 01:55:33',1,2,1),
(15,'C1','C',52,'600','2017-10-26 01:57:01','2017-10-26','Nuevo  khjkjhkjh','M','2017-10-26 02:52:02',1,1,1),
(16,'BG1234','B',61,'2500','2017-10-26 02:05:31','2017-10-26','Se pago Telefono - Moficaado','B','2017-10-26 03:27:40',1,2,1),
(23,'147258369','C',51,'6000','2017-10-26 03:06:08','2017-10-26','Nuevo gasto de LUZ con multa Modifico el monto de 5890 a 6000 y el punto por TV y factura C y proveedor 2','M','2017-10-26 03:27:17',1,2,1),
(24,'A133','A',64,'450','2017-10-26 03:44:28','2017-10-26','Se paga Luz','N','2017-10-26 03:45:05',1,1,1),
(25,'01111','X',64,'500','2017-10-27 03:37:16','2017-10-20','SE PAGA LA LUZ','N','2017-10-27 03:37:46',1,2,1),
(26,'01147','X',64,'500','2017-10-27 03:38:03','2017-10-27','SE PAGA LA LUZ DEL LOCAL','N','2017-10-27 03:38:37',1,1,1);

/*Table structure for table `jornadalaborales` */

DROP TABLE IF EXISTS `jornadalaborales`;

CREATE TABLE `jornadalaborales` (
  `idjornadalaboral` int(11) NOT NULL AUTO_INCREMENT,
  `idpersona` int(11) DEFAULT NULL,
  `idclase` int(11) DEFAULT NULL,
  `accion` varchar(1) DEFAULT NULL,
  `fechaaccion` datetime DEFAULT NULL,
  `idempleadoaccion` int(11) DEFAULT NULL,
  `idpunto` int(11) DEFAULT NULL,
  PRIMARY KEY (`idjornadalaboral`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

/*Data for the table `jornadalaborales` */

/*Table structure for table `personas` */

DROP TABLE IF EXISTS `personas`;

CREATE TABLE `personas` (
  `idpersona` int(11) NOT NULL AUTO_INCREMENT,
  `apellido` varchar(30) DEFAULT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `fechanacimiento` date DEFAULT NULL,
  `dni` varchar(50) DEFAULT NULL,
  `cuil` varchar(50) DEFAULT NULL,
  `cel` varchar(50) DEFAULT NULL,
  `tel` varchar(50) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `calle` varchar(100) DEFAULT NULL,
  `numero` int(11) DEFAULT NULL,
  `piso` varchar(10) DEFAULT NULL,
  `dpto` varchar(10) DEFAULT NULL,
  `idpunto` int(11) DEFAULT NULL,
  `idtipopersona` int(11) DEFAULT NULL,
  `apellidocontacto` varchar(30) DEFAULT NULL,
  `nombrecontacto` varchar(30) DEFAULT NULL,
  `emailcontacto` varchar(100) DEFAULT NULL,
  `celcontacto` varchar(50) DEFAULT NULL,
  `telcontacto` varchar(50) DEFAULT NULL,
  `urlfoto` varchar(500) DEFAULT NULL,
  `accion` varchar(1) DEFAULT NULL,
  `fechaaccion` datetime DEFAULT NULL,
  `idempleadoaccion` int(11) DEFAULT NULL,
  `idpuntoaccion` int(11) DEFAULT NULL,
  `usuario` varchar(30) DEFAULT NULL,
  `passwordusuario` varchar(30) DEFAULT NULL,
  `cuit` varchar(50) DEFAULT NULL,
  `idespecialidad` int(11) DEFAULT NULL,
  PRIMARY KEY (`idpersona`)
) ENGINE=MyISAM AUTO_INCREMENT=70 DEFAULT CHARSET=utf8;

/*Data for the table `personas` */

insert  into `personas`(`idpersona`,`apellido`,`nombre`,`fechanacimiento`,`dni`,`cuil`,`cel`,`tel`,`email`,`calle`,`numero`,`piso`,`dpto`,`idpunto`,`idtipopersona`,`apellidocontacto`,`nombrecontacto`,`emailcontacto`,`celcontacto`,`telcontacto`,`urlfoto`,`accion`,`fechaaccion`,`idempleadoaccion`,`idpuntoaccion`,`usuario`,`passwordusuario`,`cuit`,`idespecialidad`) values 
(1,'Miguel','Miguel','2017-08-14','123456','20123456','1234','12345','miguel@atp.com','roca',150,'4','AD',1,1,'.','.','.','0','0','...','B','2017-09-08 03:36:35',1,1,NULL,NULL,NULL,1),
(3,'CAMBIO','FINAL','2017-08-22','1','78','78','78','87','87',87,'87','87',1,2,NULL,NULL,NULL,NULL,NULL,'...','M','2017-08-22 02:08:50',1,1,NULL,NULL,NULL,1),
(4,'NUEVO','NUEVO','2017-08-22','2','11','12','123','NUEVO@','Salta',141,'6','D3',1,2,NULL,NULL,NULL,NULL,NULL,'...','B','2017-08-22 02:09:17',1,1,NULL,NULL,NULL,1),
(5,'NUEVO','NUEVO','2017-08-22','3','11','12','123','NUEVO@','Salta',141,'6','D3',1,2,NULL,NULL,NULL,NULL,NULL,'...','B','2017-08-22 02:09:36',1,1,NULL,NULL,NULL,1),
(6,'NUEVO','NUEVO','2017-08-22','4','11','12','123','NUEVO@','Salta',141,'6','D3',1,5,'Ape contact','Nombre contact','emailcontacto','4564987','654654','...','A','2017-08-22 02:09:47',1,1,NULL,NULL,NULL,1),
(7,'NUEVO','NUEVO','2017-08-22','5','11','12','123','NUEVO@','Salta',141,'6','D3',1,2,NULL,NULL,NULL,NULL,NULL,'...','B','2017-08-22 02:09:56',1,1,NULL,NULL,NULL,1),
(8,'NUEVO','NUEVO','2017-08-22','6','11','12','123','NUEVO@','Salta',141,'6','D3',1,2,NULL,NULL,NULL,NULL,NULL,'...','B','2017-08-22 02:25:35',1,1,NULL,NULL,NULL,1),
(9,'NUEVO','NUEVO','2017-08-22','7','11','12','123','NUEVO@','Salta',141,'6','D3',1,2,NULL,NULL,NULL,NULL,NULL,'...','B','2017-08-22 02:28:00',1,1,NULL,NULL,NULL,1),
(10,'NUEVO','NUEVO','2017-08-22','8','11','12','123','NUEVO@','Salta',141,'6','D3',1,2,NULL,NULL,NULL,NULL,NULL,'...','B','2017-08-22 02:29:33',1,1,NULL,NULL,NULL,1),
(11,'NUEVO','NUEVO','2017-08-22','9','11','12','123','NUEVO@','Salta',141,'6','D3',1,2,NULL,NULL,NULL,NULL,NULL,'...','B','2017-08-22 02:29:39',1,1,NULL,NULL,NULL,1),
(12,'NUEVO','NUEVO','2017-08-22','11','11','12','123','NUEVO@','Salta',141,'6','D3',1,2,NULL,NULL,NULL,NULL,NULL,'...','B','2017-08-22 02:29:44',1,1,NULL,NULL,NULL,1),
(13,'NUEVO','NUEVO','2017-08-22','23','11','12','123','NUEVO@','Salta',141,'6','D3',1,2,NULL,NULL,NULL,NULL,NULL,'...','B','2017-08-22 02:29:59',1,1,NULL,NULL,NULL,1),
(14,'NUEVO','NUEVO','2017-08-22','44','11','12','123','NUEVO@','Salta',141,'6','D3',1,2,NULL,NULL,NULL,NULL,NULL,'...','B','2017-08-22 02:30:05',1,1,NULL,NULL,NULL,1),
(15,'NUEVO','NUEVO','2017-08-22','55','11','12','123','NUEVO@','Salta',141,'6','D3',1,2,NULL,NULL,NULL,NULL,NULL,'...','B','2017-08-22 02:30:10',1,1,NULL,NULL,NULL,1),
(16,'segundo','cambio','2017-08-22','66','11','12','123','NUEVO@','Salta',141,'6','D3',1,2,NULL,NULL,NULL,NULL,NULL,'...','M','2017-08-22 02:30:23',1,1,NULL,NULL,NULL,1),
(17,'NUEVO','NUEVO','2017-08-22','77','11','12','123','NUEVO@','Salta',141,'6','D3',1,2,NULL,NULL,NULL,NULL,NULL,'...','M','2017-08-22 02:44:19',1,1,NULL,NULL,NULL,1),
(18,'NUEVO','NUEVO','2017-08-22','88','11','12','123','NUEVO@','Salta',141,'6','D3',1,2,NULL,NULL,NULL,NULL,NULL,'...','N','2017-08-22 12:49:00',1,1,NULL,NULL,NULL,1),
(19,'NUEVO','NUEVO','2017-08-22','99','11','12','123','NUEVO@','Salta',141,'6','D3',1,2,NULL,NULL,NULL,NULL,NULL,'...','B','2017-08-22 02:31:04',1,1,NULL,NULL,NULL,1),
(20,'NUEVO','NUEVO','2017-08-22','123','11','12','123','NUEVO@','Salta',141,'6','D3',1,2,NULL,NULL,NULL,NULL,NULL,'...','B','2017-08-22 02:47:23',1,1,NULL,NULL,NULL,1),
(21,'NUEVO','NUEVO','2017-08-22','124','11','12','123','NUEVO@','Salta',141,'6','D3',1,2,NULL,NULL,NULL,NULL,NULL,'...','B','2017-09-08 03:39:21',1,1,NULL,NULL,NULL,1),
(22,'tercer','cambio','2017-08-22','178','11','12','123','NUEVO@','Salta',141,'6','D3',1,2,NULL,NULL,NULL,NULL,NULL,'...','M','2017-08-22 02:30:49',1,1,NULL,NULL,NULL,1),
(23,'se corrigio','por otro','2017-08-22','67','11','12','123','NUEVO@','Salta',141,'6','D3',1,2,NULL,NULL,NULL,NULL,NULL,'...','M','2017-08-22 02:47:40',1,1,NULL,NULL,NULL,1),
(24,'NUEVO 4747','NUEVO','2017-08-22','787','11','12','123','NUEVO@','Salta',141,'6','D3',2,2,NULL,NULL,NULL,NULL,NULL,'...','B','2017-09-08 03:36:21',1,1,NULL,NULL,NULL,1),
(25,'NUEVO','NUEVO','2017-08-22','321','11','12','123','NUEVO@','Salta',141,'6','D3',1,2,NULL,NULL,NULL,NULL,NULL,'...','N','2017-08-22 12:49:00',1,1,NULL,NULL,NULL,1),
(26,'SE actualizo','categoría','2017-08-22','64','11','12','123','NUEVO@','Salta',141,'6','D3',2,1,NULL,NULL,NULL,NULL,NULL,'...','M','2017-08-22 02:48:42',1,1,NULL,NULL,NULL,1),
(27,'NUEVO','NUEVO','2017-08-22','484','11','12','123','NUEVO@','Salta',141,'6','D3',1,2,NULL,NULL,NULL,NULL,NULL,'...','B','2017-08-22 02:29:53',1,1,NULL,NULL,NULL,1),
(28,'desd','wind','1981-08-01','4444','52','78','45','fof@ww','dosde',45,'7','8d',2,2,NULL,NULL,NULL,NULL,NULL,'...','N','2017-08-22 01:55:48',1,1,'usu','123',NULL,1),
(29,'se orrige','al profesor','1981-05-01','41','41','41','41','41aaa@','45',89999,'0','0',2,3,NULL,NULL,NULL,NULL,NULL,'...','M','2017-08-22 11:39:07',1,1,NULL,NULL,NULL,1),
(30,'kjhkhj','kjhkjh','1822-04-01','84369','654','654','654','64','654',654,'654','564',1,3,NULL,NULL,NULL,NULL,NULL,'...','N','2017-08-22 11:49:41',1,1,NULL,NULL,NULL,1),
(31,'corregido','kjhkjh','1822-04-01','4855','654','654','654','64','654',654,'654','564',1,3,NULL,NULL,NULL,NULL,NULL,'...','M','2017-09-08 03:41:03',1,1,NULL,NULL,NULL,1),
(32,'kjhkhj','kjhkjh','1822-04-01','8885','654','654','654','64','654',654,'654','564',1,3,NULL,NULL,NULL,NULL,NULL,'...','N','2017-08-23 01:48:39',1,1,NULL,NULL,NULL,1),
(33,'actualizado','kjhkjh','1822-04-01','258','654','654','654','64','654',654,'654','564',1,3,NULL,NULL,NULL,NULL,NULL,'...','M','2017-08-23 02:16:10',1,1,NULL,NULL,NULL,1),
(34,'kjhkhj','kjhkjh','1822-04-01','159','654','654','654','64','654',654,'654','564',1,3,NULL,NULL,NULL,NULL,NULL,'...','B','2017-09-08 04:02:48',1,1,NULL,NULL,NULL,1),
(35,'kjhkhj','kjhkjh','1822-04-01','753','654','654','654','64','654',654,'654','564',1,3,NULL,NULL,NULL,NULL,NULL,'...','B','2017-08-23 02:14:41',1,1,NULL,NULL,NULL,1),
(36,'profe','modificado','1822-04-01','4567','654','654','654','64','654',654,'654','564',1,3,NULL,NULL,NULL,NULL,NULL,'...','M','2017-08-23 02:15:48',1,1,NULL,NULL,NULL,1),
(37,'kjhkhj','kjhkjh','1822-04-01','6464','654','654','654','64','654',654,'654','564',1,3,NULL,NULL,NULL,NULL,NULL,'...','N','2017-08-23 01:48:39',1,1,NULL,NULL,NULL,1),
(38,'kjhkhj','kjhkjh','1822-04-01','8542','654','654','654','64','654',654,'654','564',1,3,NULL,NULL,NULL,NULL,NULL,'...','B','2017-09-08 03:42:45',1,1,NULL,NULL,NULL,1),
(39,'kjhkhj','kjhkjh','1822-04-01','5624','654','654','654','64','654',654,'654','564',1,3,NULL,NULL,NULL,NULL,NULL,'...','B','2017-08-23 02:15:02',1,1,NULL,NULL,NULL,1),
(40,'kjhkhj','kjhkjh','1822-04-01','2036','654','654','654','64','654',654,'654','564',1,3,NULL,NULL,NULL,NULL,NULL,'...','N','2017-08-23 01:48:39',1,1,NULL,NULL,NULL,1),
(41,'nuevo','socio','1849-11-04','759','111112222','11112220000','01132154','se modifico','cococo',4564,'4','4sss',1,4,NULL,NULL,NULL,NULL,NULL,'...','B','2017-10-27 03:29:17',1,1,NULL,NULL,NULL,1),
(42,'ppp nuevo','socio nuevo','1849-11-04','1532','111112222','11112220000','01132154','se modifico','cococo',4564,'4','4sss',2,4,NULL,NULL,NULL,NULL,NULL,'...','B','2017-08-23 08:14:35',1,1,NULL,NULL,NULL,1),
(43,'Flores','Cesar','1592-08-04','1234500','0','0','0','jomolca@live.com.ar','0',0,'0','0',1,4,NULL,NULL,NULL,NULL,NULL,'...','B','2017-10-27 03:31:21',1,1,NULL,NULL,NULL,1),
(44,'Tecno','Marth','1892-04-01','1122345','2012345','.','.','marth@gmail.com','.',0,'0','0',2,4,NULL,NULL,NULL,NULL,NULL,'...','B','2017-10-27 03:28:36',1,1,NULL,NULL,NULL,1),
(45,'.','Proveedor 1',NULL,NULL,NULL,'12341234','1234','proveedor1@pro1','.',0,'0','0',NULL,5,'c1','n1','aaa@www.com','1232','321',NULL,'N','2017-08-30 16:57:29',1,1,NULL,NULL,NULL,1),
(46,'NUEVO 45454','NUEVO','2017-08-22','321','11','12','123','NUEVO@','Salta',141,'6','D3',1,2,NULL,NULL,NULL,NULL,NULL,'...','B','2017-09-08 03:05:43',1,1,NULL,NULL,NULL,1),
(48,'nuevo 2017','nuevo 2017','1235-04-01','2017','2017','0','0','0','0',0,'0','0',2,4,NULL,NULL,NULL,NULL,NULL,'...','N','2017-09-08 07:57:32',1,1,'admin','1234',NULL,1),
(49,'Prueba','Itan','2010-08-01','1203120312','20120312035','0','0','itn@ddd,com','Colon',78,'0','0',2,4,NULL,NULL,NULL,NULL,NULL,'...','M','2017-09-26 11:10:21',1,1,NULL,NULL,NULL,1),
(50,'','proveedores 1','0000-00-00','','','1','1','prov@ddd,com','khjkjh',45,'45','54',1,5,'ape con','nombre con','contacto@co.com','4477','7777','','N','2017-10-05 01:23:43',1,1,NULL,NULL,'1234prov1',1),
(51,'','proveedores 2','0000-00-00','','','1','1','prov@ddd,com','khjkjh',45,'45','54',1,5,'ape con','nombre con','contacto@co.com','4477','7777','','N','2017-10-05 01:23:43',1,1,NULL,NULL,'1234prov1',1),
(52,'','proveedores 3','0000-00-00','','','1','1','prov@ddd,com','khjkjh',45,'45','54',1,5,'ape con','nombre con','contacto@co.com','4477','7777','','N','2017-10-05 01:23:43',1,1,NULL,NULL,'1234prov1',1),
(53,'','proveedores 1','0000-00-00','','','1','1','prov@ddd,com','khjkjh',45,'45','54',NULL,NULL,'ape con','nombre con','contacto@co.com','4477','7777','','N','2017-10-05 01:23:43',1,1,NULL,NULL,'1234prov1',1),
(54,'','proveedores 1','0000-00-00','','','1','1','prov@ddd,com','khjkjh',45,'45','54',NULL,NULL,'ape con','nombre con','contacto@co.com','4477','7777','','N','2017-10-05 01:23:43',1,1,NULL,NULL,'1234prov1',1),
(55,'','proveedores 1','0000-00-00','','','1','1','prov@ddd,com','khjkjh',45,'45','54',NULL,NULL,'ape con','nombre con','contacto@co.com','4477','7777','','N','2017-10-05 01:23:43',1,1,NULL,NULL,'1234prov1',1),
(56,'','kjhkjh','0000-00-00','','','654','654','65','654',654,'654','654',NULL,NULL,'lkj','lkj','lkj','654','654','','N','2017-10-11 11:05:42',1,1,NULL,NULL,'654',1),
(57,'','kjhkjh','0000-00-00','','','654','654','65','654',654,'654','654',NULL,NULL,'lkj','lkj','lkj','654','654','','N','2017-10-11 11:05:42',1,1,NULL,NULL,'654',1),
(58,'','kjhkjh','0000-00-00','','','654','654','65','654',654,'654','654',NULL,NULL,'lkj','lkj','lkj','654','654','','N','2017-10-11 11:05:42',1,1,NULL,NULL,'654',1),
(59,'','kjhkjh','0000-00-00','','','654','654','65','654',654,'654','654',NULL,NULL,'lkj','lkj','lkj','654','654','','N','2017-10-11 11:05:42',1,1,NULL,NULL,'654',1),
(60,'','modifica','0000-00-00','','','654','654','65','654',654,'654','654',NULL,5,'se corrije','lkj','lkj','654','654','','B','2017-10-12 06:13:23',1,1,NULL,NULL,'654',1),
(61,'','nuevo proveedor','0000-00-00','','','1234','1234','prove@ddd.com','calle',1,'2','3',NULL,5,'valeria','hola jose','pro@modi.com','123456','123456','','M','2017-10-12 06:01:56',1,1,NULL,NULL,'1234',1),
(62,'yoni','Marth','1892-04-01','1122345','2012345','.','.','marth@gmail.com','.',0,'0','0',2,4,'','','','','','...','B','2017-10-27 03:28:57',1,1,NULL,NULL,'',1),
(63,'lillo','socio','1981-04-01','1234666','12345554','1','1','.','.',0,'0','0',2,4,'','','','','','...','N','2017-10-25 03:29:25',1,1,NULL,NULL,'',1),
(64,'','EDET','2017-10-26','','','0','0','.','.',0,'0','0',NULL,5,'.','.','0','0','0','','N','2017-10-26 03:05:21',1,1,NULL,NULL,'0',1),
(65,'ESPECIAL','ESPECIAL','1981-05-01','415263','415263','41','41','41aaa@','45',89999,'0','0',1,3,'','','','','','...','B','2017-10-27 03:13:34',1,1,NULL,NULL,'',1),
(66,'se modifico','f','2017-04-01','124','654','0','0','.','.',0,'0','.',1,3,'','','','','','...','B','2017-10-27 03:22:44',1,1,'124','','',1),
(67,'','NUEVO 01 MODI','2017-10-27','','','1234','1234','prove@ddd.com','calle',1,'2','3',NULL,5,'PROVEEDOR','HOLA','MODIFICADO','123456','123456','','B','2017-10-27 03:24:10',1,1,'','','001234',1),
(68,'NUEVA SO MOD','MODIFICADO','1981-04-01','9988','9988','0','0','.','0',0,'0','0',2,4,'','','','','','...','B','2017-10-27 03:27:27',1,1,'9988','','',1),
(69,'NUEVO','SOCIO','1981-04-01','784512','784512','0','0','0','0',0,'0','0',2,4,'','','','','','...','N','2017-10-27 03:35:33',1,1,'784512','','',1);

/*Table structure for table `puntos` */

DROP TABLE IF EXISTS `puntos`;

CREATE TABLE `puntos` (
  `idpunto` int(11) NOT NULL AUTO_INCREMENT,
  `nombrepunto` varchar(30) DEFAULT NULL,
  `accion` varchar(1) DEFAULT NULL,
  `fechaaccion` datetime DEFAULT NULL,
  `idempleadoaccion` int(11) DEFAULT NULL,
  `idpuntoacion` int(11) DEFAULT NULL,
  `calle` varchar(100) DEFAULT NULL,
  `numero` int(11) DEFAULT NULL,
  `piso` varchar(10) DEFAULT NULL,
  `dpto` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`idpunto`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `puntos` */

insert  into `puntos`(`idpunto`,`nombrepunto`,`accion`,`fechaaccion`,`idempleadoaccion`,`idpuntoacion`,`calle`,`numero`,`piso`,`dpto`) values 
(1,'Yerba Buena','N','2017-08-19 16:30:20',1,NULL,NULL,NULL,NULL,NULL),
(2,'Tafi viejo','N','2017-08-21 21:13:16',1,NULL,NULL,NULL,NULL,NULL);

/*Table structure for table `tipopersonas` */

DROP TABLE IF EXISTS `tipopersonas`;

CREATE TABLE `tipopersonas` (
  `idtipopersona` int(11) NOT NULL AUTO_INCREMENT,
  `tipopersona` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`idtipopersona`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

/*Data for the table `tipopersonas` */

insert  into `tipopersonas`(`idtipopersona`,`tipopersona`) values 
(1,'Administrador'),
(2,'Empleado'),
(3,'Profesor'),
(4,'Socio'),
(5,'Proveedor');

/*Table structure for table `tiposdeclases` */

DROP TABLE IF EXISTS `tiposdeclases`;

CREATE TABLE `tiposdeclases` (
  `idtipodeclase` int(11) NOT NULL AUTO_INCREMENT,
  `tipodeclase` varchar(30) DEFAULT NULL,
  `accion` varchar(1) DEFAULT NULL,
  `fechaaccion` datetime DEFAULT NULL,
  `idempleadoaccion` int(11) DEFAULT NULL,
  PRIMARY KEY (`idtipodeclase`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `tiposdeclases` */

insert  into `tiposdeclases`(`idtipodeclase`,`tipodeclase`,`accion`,`fechaaccion`,`idempleadoaccion`) values 
(1,'Grupal','N','2017-08-23 08:32:23',1),
(2,'Personalizado','N','2017-08-23 08:32:36',1);

/*Table structure for table `ventas` */

DROP TABLE IF EXISTS `ventas`;

CREATE TABLE `ventas` (
  `idventa` int(11) NOT NULL AUTO_INCREMENT,
  `numerofactura` varchar(10) DEFAULT NULL,
  `tipofactura` varchar(10) DEFAULT NULL,
  `idpersona` int(11) DEFAULT NULL,
  `montoingreso` decimal(10,0) DEFAULT NULL,
  `fechaventa` datetime DEFAULT NULL,
  `fechafactura` date DEFAULT NULL,
  `observacion` varchar(500) DEFAULT NULL,
  `accion` varchar(1) DEFAULT NULL,
  `fechaaccion` datetime DEFAULT NULL,
  `idempleadoaccion` int(11) DEFAULT NULL,
  `idpunto` int(11) DEFAULT NULL,
  PRIMARY KEY (`idventa`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

/*Data for the table `ventas` */

/* Procedure structure for procedure `listarpuntos` */

/*!50003 DROP PROCEDURE IF EXISTS  `listarpuntos` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `listarpuntos`(
IN _punto VARCHAR(50),
IN _pag INT,
IN _cantfil INT
)
BEGIN
	IF (_punto IS NULL) THEN
		SELECT * FROM puntos;
	ELSE
		PREPARE STMT FROM " SELECT * 
				    FROM puntos 
			            WHERE (accion!='B') AND (nombrepunto LIKE CONCAT(? ,'%'))
				    LIMIT ?,?";
		SET @punto = _punto; 
		SET @pag = _pag; 
		SET @cantfil = _cantfil; 
		EXECUTE STMT USING @punto,@pag,@cantfil;
		DEALLOCATE PREPARE STMT;
	END IF;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_abmcuotasocio` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_abmcuotasocio` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_abmcuotasocio`(
    IN _idcuota INT,
    IN _idcurso int,
    IN _fechapago DATE,
    IN _fechaproximopago date,
    IN _montocuota VARCHAR(50),
    IN _montopagado VARCHAR(50),
    IN _montosaldo VARCHAR(50),
    IN _cuotanum int,
    IN _accion varCHAR(1),
    IN _fechaaccion datetime,
    IN _idempleadoacc int,
    in _idpuntoacc int
    )
BEGIN
case _accion 
when 'N' then
	UPDATE cuotas SET montocuota=_montocuota,fecharealpago=_fechapago,montopagado=_montopagado,accion='M',fechaaccion=_fechaaccion,idempleadoaccion=_idempleadoacc,idpuntoaccion=_idpuntoacc 
	WHERE idcuota=_idcuota;
	
	INSERT INTO cuotas (idcurso,fechapago,montocuota,montosaldo,accion,fechaaccion,idempleadoaccion,idpuntoaccion,cuotanum) 
	VALUE (_idcurso,_fechaproximopago,_montocuota,_montosaldo,_accion,_fechaaccion,_idempleadoacc,_idpuntoacc,_cuotanum);
	
	INSERT INTO cajadeldia (fechacarga,montoegreso,montoingreso,detallemovimiento,idcuota,accion,fechaaccion,idempleadoaccion,idpuntoaccion,idgasto) 
	VALUE (_fechapago,0,_montopagado,'Pago de cuota',_idcuota,_accion,_fechaaccion,_idempleadoacc,_idpuntoacc,0);
when 'M' then		
	update cuotas set montocuota=_montocuota,accion=_accion,fechaaccion=_fechaaccion,idempleadoaccion=_idempleadoacc,idpuntoaccion=_idpuntoacc 
	where idcuota=_idcuota and idcurso=_idcurso;
end case;
CALL sp_buscadorcuotas(_idcurso,'C');
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_abmgasto` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_abmgasto` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_abmgasto`(
    IN _idgasto INT,
    IN _fechacarga DATETIME,
    IN _fechafactura DATE,
    IN _tipofactura VARCHAR(10),
    IN _numerofactura VARCHAR(50),
    IN _idproveedor int,
    IN _idpunto int,
    IN _montogasto VARCHAR(50),
    IN _observacion VARCHAR(500),
    IN _accion varCHAR(1),
    IN _fechaaccion datetime,
    IN _idempleadoacc int,
    in _idpuntoacc int
    )
BEGIN
case _accion 
when 'N' then
	
	INSERT INTO gastos (fecharealcarga,fechagasto,tipofactura,numerofactura,idpersona,idpunto,montopagado,observacion,accion,fechaaccion,idempleadoaccion,idpuntoaccion) 
	VALUE (_fechacarga,_fechafactura,_tipofactura,_numerofactura,_idproveedor,_idpunto,_montogasto,_observacion,_accion,_fechaaccion,_idempleadoacc,_idpuntoacc);
	SELECT idgasto INTO _idgasto FROM gastos WHERE idpersona=_idproveedor AND idpunto=_idpunto AND fechaaccion=_fechaaccion AND numerofactura=_numerofactura AND accion!='B';
	
	INSERT INTO cajadeldia (fechacarga,montoegreso,montoingreso,detallemovimiento,idgasto,accion,fechaaccion,idempleadoaccion,idpuntoaccion,idcuota) 
	VALUE (_fechafactura,_montogasto,0,CONCaT('Gasto: ',_observacion),_idgasto,_accion,_fechaaccion,_idempleadoacc,_idpuntoacc,0);
when 'M' then		
	update gastos set fechagasto=_fechafactura,tipofactura=_tipofactura,numerofactura=_numerofactura,montopagado=_montogasto,observacion=_observacion,idpunto=_idpunto,idpersona=_idproveedor,accion=_accion,fechaaccion=_fechaaccion,idempleadoaccion=_idempleadoacc,idpuntoaccion=_idpuntoacc 
	where idgasto=_idgasto;
	UPDATE cajadeldia SET fechacarga=_fechafactura,montoegreso=_montogasto,detallemovimiento=CONCAT('Gasto: ',_observacion),accion=_accion,fechaaccion=_fechaaccion,idempleadoaccion=_idempleadoacc,idpuntoaccion=_idpuntoacc 
	WHERE idgasto=_idgasto;
WHEN 'B' THEN		
	UPDATE gastos SET accion=_accion,fechaaccion=_fechaaccion,idempleadoaccion=_idempleadoacc,idpuntoaccion=_idpuntoacc 
	WHERE idgasto=_idgasto;
	UPDATE cajadeldia SET accion=_accion,fechaaccion=_fechaaccion,idempleadoaccion=_idempleadoacc,idpuntoaccion=_idpuntoacc 
	WHERE idgasto=_idgasto;
end case;
CALL sp_buscadorgastos(0,_fechafactura,_fechafactura,'','',0,100);
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_abminscripcionsocio` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_abminscripcionsocio` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_abminscripcionsocio`(
    IN _idcuota INT,
    IN _idcurso INT,
    IN _idclase int,
    IN _dni VARCHAR(30),
    IN _idpunto int,
    IN _montocuota VARCHAR(50),
    IN _montopagado VARCHAR(50),
    IN _montosaldo VARCHAR(50),
    IN _fechapago DATE,
    IN _accion varCHAR(1),
    IN _fechaaccion datetime,
    IN _idempleadoacc int,
    in _idpuntoacc int
    )
BEGIN
DECLARE _idpersona INT;
SELECT idpersona INTO _idpersona FROM personas WHERE dni=_dni;
case _accion 
when 'N' then
	INSERT INTO cursos (idclase,idpunto,idpersona,accion,fechaaccion,idempleadoaccion,idpuntoaccion) 
	VALUE (_idclase,_idpunto,_idpersona,_accion,_fechaaccion,_idempleadoacc,_idpuntoacc);
	SELECT idcurso INTO _idcurso FROM cursos WHERE idclase=_idclase and idpersona=_idpersona and idpunto=_idpunto and fechaaccion=_fechaaccion;
	INSERT INTO cuotas (idcurso,fechapago,montocuota,montopagado,montosaldo,cuotanum,accion,fechaaccion,idempleadoaccion,idpuntoaccion) 
	VALUE (_idcurso,_fechapago,_montocuota,_montopagado,_montosaldo,1,_accion,_fechaaccion,_idempleadoacc,_idpuntoacc);
	
when 'M' then		
	update cuotas set fechapago=_fechapago,montocuota=_montocuota,accion=_accion,fechaaccion=_fechaaccion,idempleadoaccion=_idempleadoacc,idpuntoaccion=_idpuntoacc 
	where idcuota=_idcuota;
	
WHEN 'B' THEN		
	UPDATE cursos SET accion=_accion,fechaaccion=_fechaaccion,idempleadoaccion=_idempleadoacc,idpuntoaccion=_idpuntoacc 
	WHERE idcurso=_idcurso;
	
	UPDATE cuotas SET accion=_accion,fechaaccion=_fechaaccion,idempleadoaccion=_idempleadoacc,idpuntoaccion=_idpuntoacc 
	WHERE idcurso=_idcurso;
end case;
CALL sp_buscadorinscripciones(0,_dni,0,100);
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_abmpersona` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_abmpersona` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_abmpersona`(
    IN _idempleado int,
    IN _apellido VARCHAR(30),
    IN _nombre VARCHAR(30),
    IN _fechanac date,
    IN _dni VARCHAR(50),
    IN _cuil VARCHAR(50),
    IN _cel VARCHAR(50),
    IN _tel VARCHAR(50),
    IN _email VARCHAR(100),
    IN _calle VARCHAR(100),
    IN _numero int,
    IN _piso VARCHAR(10),
    IN _dpto VARCHAR(10),
    IN _punto VARCHAR(30),
    IN _tipopersona VARCHAR(30),
    in _urlfoto varchar(500),
    IN _apecontacto VARCHAR(30),
    IN _nomcontacto VARCHAR(30),
    IN _celcontacto VARCHAR(50),
    IN _telcontacto VARCHAR(50),
    IN _emailcontacto VARCHAR(100),
    IN _cuit VARCHAR(50),
    IN _idespecialidad INT,
    
    IN _accion varCHAR(1),
    IN _fechaaccion datetime,
    IN _idempleadoacc int,
    in _idpuntoacc int
    )
BEGIN
declare _idpunto int;
declare _idtipo int;
select idpunto into _idpunto from puntos where nombrepunto=_punto;
SELECT idtipopersona INTO _idtipo FROM tipopersonas WHERE tipopersona=_tipopersona;
case _accion 
when 'N' then
	INSERT INTO personas (apellido,nombre,fechanacimiento,dni,cuil,cel,tel,email,calle,numero,piso,dpto,idpunto,idtipopersona,urlfoto,apellidocontacto,nombrecontacto,celcontacto,telcontacto,emailcontacto,cuit,accion,fechaaccion,idempleadoaccion,idpuntoaccion,idespecialidad,usuario,passwordusuario) 
	VALUE (_apellido,_nombre,_fechanac,_dni,_cuil,_cel,_tel,_email,_calle,_numero,_piso,_dpto,_idpunto,_idtipo,_urlfoto,_apecontacto,_nomcontacto,_celcontacto,_telcontacto,_emailcontacto,_cuit,_accion,_fechaaccion,_idempleadoacc,_idpuntoacc,_idespecialidad,_dni,'');
when 'M' then		
	update personas set apellido=_apellido,nombre=_nombre,fechanacimiento=_fechanac,dni=_dni,cuil=_cuil,cel=_cel,tel=_tel,email=_email,calle=_calle,numero=_numero,piso=_piso,dpto=_dpto,idpunto=_idpunto,idtipopersona=_idtipo,urlfoto=_urlfoto,apellidocontacto=_apecontacto,nombrecontacto=_nomcontacto,celcontacto=_celcontacto,telcontacto=_telcontacto,emailcontacto=_emailcontacto,cuit=_cuit,accion=_accion,fechaaccion=_fechaaccion,idempleadoaccion=_idempleadoacc,idpuntoaccion=_idpuntoacc,idespecialidad=_idespecialidad 
	where idpersona=_idempleado;
WHEN 'B' THEN		
	UPDATE personas SET accion=_accion,fechaaccion=_fechaaccion,idempleadoaccion=_idempleadoacc,idpuntoaccion=_idpuntoacc 
	WHERE idpersona=_idempleado;
end case;
CASE _idtipo 
WHEN 1 THEN
	CALL sp_buscadorempleados(0,'','',_dni,'','',0,100);
WHEN 2 THEN		
	CALL sp_buscadorempleados(0,'','',_dni,'','',0,100);
WHEN 3 THEN		
	CALL sp_buscadorprofesores(0,'','',_dni,'','',0,100);
WHEN 4 THEN		
	CALL sp_buscadorsocios(0,'','',_dni,'','',0,100);
WHEN 5 THEN		
	CALL sp_buscadorproveedores(0,'',_cuit,'','',0,100);
END CASE;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_abmpunto` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_abmpunto` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_abmpunto`(
    IN _idpunto int,
    IN _nombre VARCHAR(30),
    IN _calle VARCHAR(100),
    IN _numero int,
    IN _piso VARCHAR(10),
    IN _dpto VARCHAR(10),
    IN _punto VARCHAR(30),
    IN _accion varCHAR(1),
    IN _fechaaccion datetime,
    IN _idempleadoacc int,
    in _idpuntoacc int
    )
BEGIN
case _accion 
when 'N' then
	
	INSERT INTO puntos (nombrepunto,calle,numero,piso,dpto,accion,fechaaccion,idempleadoaccion,idpuntoaccion) 
	VALUE (_nombre,_calle,_numero,_piso,_dpto,_accion,_fechaaccion,_idempleadoacc,_idpuntoacc);
when 'M' then		
	update puntos set nombrepunto=_nombre,calle=_calle,numero=_numero,piso=_piso,dpto=_dpto,accion=_accion,fechaaccion=_fechaaccion,idempleadoaccion=_idempleadoacc,idpuntoaccion=_idpuntoacc 
	where idpunto=_idpunto;
WHEN 'B' THEN		
	UPDATE punto SET accion=_accion,fechaaccion=_fechaaccion,idempleadoaccion=_idempleadoacc,idpuntoaccion=_idpuntoacc 
	WHERE idpunto=_idpunto;
end case;
CALL sp_buscadorpuntos('','',0,100);
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_abmtiposdeclases` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_abmtiposdeclases` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_abmtiposdeclases`(
    IN _idtipodeclase int,
    IN _nombre VARCHAR(30),
    IN _accion varCHAR(1),
    IN _fechaaccion datetime,
    IN _idempleadoacc int,
    in _idpuntoacc int
    )
BEGIN
case _accion 
when 'N' then
	
	INSERT INTO tiposdeclases (tipodeclase,accion,fechaaccion,idempleadoaccion,idpuntoaccion) 
	VALUE (_nombre,_accion,_fechaaccion,_idempleadoacc,_idpuntoacc);
when 'M' then		
	update tiposdeclases set tipodeclase=_nombre,accion=_accion,fechaaccion=_fechaaccion,idempleadoaccion=_idempleadoacc,idpuntoaccion=_idpuntoacc 
	where idtipodeclase=_idtipodeclase;
WHEN 'B' THEN		
	UPDATE tiposdeclases SET accion=_accion,fechaaccion=_fechaaccion,idempleadoaccion=_idempleadoacc,idpuntoaccion=_idpuntoacc 
	WHERE idtipodeclase=_idtipodeclase;
end case;
CALL sp_buscadortiposdeclases('','',0,100);
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_buscador` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_buscador` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_buscador`(
    IN _idempleado int,
    IN _apellido VARCHAR(30),
    IN _nombre VARCHAR(30),
    IN _dni VARCHAR(50),
    IN _punto VARCHAR(30),
    IN _tipopersona VARCHAR(30),
    IN _pag INT,
    IN _cantfil INT
    )
BEGIN
if (_idempleado<=0) then
	PREPARE STMT FROM "SELECT a.idpersona,a.apellido,a.nombre,b.tipopersona,c.nombrepunto
				   FROM personas a INNER JOIN tipopersonas b ON (a.idtipopersona=b.idtipopersona)
						   INNER JOIN puntos c ON (c.idpunto=a.idpunto AND c.accion!='B')
				   WHERE (a.accion!='B') AND 
				         (a.apellido LIKE CONCAT(? ,'%')) AND 
				         (a.nombre LIKE CONCAT(? ,'%')) AND 
					 (a.dni LIKE CONCAT(? ,'%')) AND
					 (b.tipopersona LIKE CONCAT(? ,'%')) AND
					 (c.nombrepunto LIKE CONCAT(? ,'%'))
				   ORDER BY a.apellido,a.nombre
				   LIMIT ?,?";
		
		SET @apellido = _apellido; 
		SET @nombre = _nombre; 
		SET @dni = _dni; 
		SET @tipopersona = _tipopersona; 
		SET @punto = _punto; 
		SET @pag = _pag; 
		SET @cantfil = _cantfil; 
		EXECUTE STMT USING @apellido,@nombre,@dni,@tipopersona,@punto,@pag,@cantfil;
		DEALLOCATE PREPARE STMT;
else			
	PREPARE STMT FROM "SELECT a.idpersona,a.apellido,a.nombre,b.tipopersona
				   FROM personas a INNER JOIN tipopersonas b ON (a.idtipopersona=b.idtipopersona)
						   INNER JOIN puntos c ON (c.idpunto=a.idpunto AND c.accion!='B')
				   WHERE (a.idpersona LIKE CONCAT(? ,'%'))";
		
		SET @idempleado = _idempleado; 
		EXECUTE STMT USING @idempleado;
		DEALLOCATE PREPARE STMT;
end if;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_buscadorcajadeldia` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_buscadorcajadeldia` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_buscadorcajadeldia`(
    IN _tipooperacion VARCHAR(30),
    IN _fechaini DATETIME,
    IN _fechafin DATETIME,
    IN _apellido VARCHAR(30),
    IN _nombre VARCHAR(30),
    IN _detallemov VARCHAR(50),
    IN _tipopersona VARCHAR(30),
    IN _punto VARCHAR(30),
    IN _nombreclase VARCHAR(30),
    IN _tipoclase VARCHAR(30),
    IN _pag INT,
    IN _cantfil INT
    )
BEGIN
if (_tipooperacion = 'Caja del día') then
	PREPARE STMT FROM "SELECT a.idcajadeldia,a.fechacarga AS 'Fecha Carga',b.nombrepunto AS 'Punto',CONCAT(a.detallemovimiento,' Nº',c.cuotanum) AS 'Detalle Movimiento',CONCAT(f.apellido,', ',f.nombre) AS 'Persona',CONCAT(e.nombreclase,'/',g.tipodeclase) AS 'Clase/Tipo',a.montoingreso AS 'Ingresos',a.montoegreso AS 'Egresos',a.idcuota,a.idgasto
			   FROM cajadeldia a INNER JOIN puntos b ON (a.idpuntoaccion=b.idpunto AND b.accion!='B')
					     INNER JOIN cuotas c ON (c.idcuota=a.idcuota AND c.accion!='B')
					     INNER JOIN cursos d ON (d.idcurso=c.idcurso AND d.accion!='B')
					     INNER JOIN clases e ON (e.idclase=d.idclase AND e.accion!='B')
					     INNER JOIN personas f ON (d.idpersona=f.idpersona AND f.accion!='B')
					     INNER JOIN tiposdeclases g ON (g.idtipodeclase=e.idtipoclase AND g.accion!='B')
			   WHERE (a.accion!='B') AND 
				 (a.fechacarga BETWEEN ? AND ?) AND 
				 (a.detallemovimiento LIKE CONCAT('%',? ,'%')) AND 
				 (f.apellido LIKE CONCAT('%',? ,'%')) AND 
				 (f.nombre LIKE CONCAT('%',? ,'%')) AND 
				 (e.nombreclase LIKE CONCAT('%',? ,'%')) AND 
				 (g.tipodeclase LIKE CONCAT('%',? ,'%')) AND 
				 (b.nombrepunto LIKE CONCAT('%',? ,'%'))
			   UNION
			   SELECT a.idcajadeldia,a.fechacarga AS 'Fecha Carga',d.nombrepunto AS 'Punto',a.detallemovimiento AS 'Detalle Movimiento',c.nombre AS 'Persona','' AS 'Clase/Tipo',a.montoingreso AS 'Ingresos',a.montoegreso AS 'Egresos',a.idcuota,a.idgasto
			   FROM cajadeldia a INNER JOIN gastos b ON (a.idgasto=b.idgasto AND b.accion!='B')
				             INNER JOIN personas c ON (c.idpersona=b.idpersona AND c.accion!='B')
				             INNER JOIN puntos d ON (d.idpunto=b.idpunto AND d.accion!='B')
			   WHERE (a.accion!='B') AND 
				 (a.fechacarga BETWEEN ? AND ?) AND 
				 (a.detallemovimiento LIKE CONCAT('%',? ,'%')) AND 
				 (d.nombrepunto LIKE CONCAT('%',? ,'%')) AND 
				 (c.nombre LIKE CONCAT('%',? ,'%'))
		           ORDER BY 2
			   LIMIT ?,?";
		
		SET @fechaini = _fechaini; 
		SET @fechafin = _fechafin; 
		SET @detallemov = _detallemov; 
		SET @apellido = _apellido; 
		SET @nombre = _nombre; 
		SET @nombreclase = _nombreclase; 
		SET @tipoclase = _tipoclase; 
		SET @punto = _punto; 
		SET @pag = _pag; 
		SET @cantfil = _cantfil; 
		EXECUTE STMT USING @fechaini,@fechafin,@detallemov,@apellido,@nombre,@nombreclase,@tipoclase,@punto,@fechaini,@fechafin,@detallemov,@punto,@nombre,@pag,@cantfil;
		DEALLOCATE PREPARE STMT;
ELSE
	IF (_tipooperacion = 'Ingresos') THEN
		PREPARE STMT FROM "SELECT a.idcajadeldia,a.fechacarga AS 'Fecha Carga',b.nombrepunto AS 'Punto',CONCAT(a.detallemovimiento,' Nº',c.cuotanum) AS 'Detalle Movimiento',CONCAT(f.apellido,', ',f.nombre) AS 'Socio',CONCAT(e.nombreclase,'/',g.tipodeclase) AS 'Clase/Tipo',a.montoingreso AS 'Ingresos',a.montoegreso AS 'Egresos',a.idcuota,a.idgasto
				   FROM cajadeldia a INNER JOIN puntos b ON (a.idpuntoaccion=b.idpunto AND b.accion!='B')
						     INNER JOIN cuotas c ON (c.idcuota=a.idcuota AND c.accion!='B')
						     INNER JOIN cursos d ON (d.idcurso=c.idcurso AND d.accion!='B')
						     INNER JOIN clases e ON (e.idclase=d.idclase AND e.accion!='B')
						     INNER JOIN personas f ON (d.idpersona=f.idpersona AND f.accion!='B')
						     INNER JOIN tiposdeclases g ON (g.idtipodeclase=e.idtipoclase AND g.accion!='B')
				   WHERE (a.accion!='B') AND 
					 (a.fechacarga BETWEEN ? AND ?) AND 
					 (a.detallemovimiento LIKE CONCAT('%',? ,'%')) AND 
					 (f.apellido LIKE CONCAT('%',? ,'%')) AND 
					 (f.nombre LIKE CONCAT('%',? ,'%')) AND 
					 (e.nombreclase LIKE CONCAT('%',? ,'%')) AND 
					 (g.tipodeclase LIKE CONCAT('%',? ,'%')) AND 
					 (b.nombrepunto LIKE CONCAT('%',? ,'%'))
				   ORDER BY 2
				   LIMIT ?,?";
			
			SET @fechaini = _fechaini; 
			SET @fechafin = _fechafin; 
			SET @detallemov = _detallemov; 
			SET @apellido = _apellido; 
			SET @nombre = _nombre; 
			SET @nombreclase = _nombreclase; 
			SET @tipoclase = _tipoclase; 
			SET @punto = _punto; 
			SET @pag = _pag; 
			SET @cantfil = _cantfil; 
			EXECUTE STMT USING @fechaini,@fechafin,@detallemov,@apellido,@nombre,@nombreclase,@tipoclase,@punto,@pag,@cantfil;
			DEALLOCATE PREPARE STMT;
	ELSE
		IF (_tipooperacion = 'Egresos') THEN
		PREPARE STMT FROM "SELECT a.idcajadeldia,a.fechacarga AS 'Fecha Carga',d.nombrepunto AS 'Punto',a.detallemovimiento AS 'Detalle Movimiento',c.nombre AS 'Proveedor','' AS 'Clase/Tipo',a.montoingreso AS 'Ingresos',a.montoegreso AS 'Egresos',a.idcuota,a.idgasto
				   FROM cajadeldia a INNER JOIN gastos b ON (a.idgasto=b.idgasto AND b.accion!='B')
						     INNER JOIN personas c ON (c.idpersona=b.idpersona AND c.accion!='B')
						     INNER JOIN puntos d ON (d.idpunto=b.idpunto AND d.accion!='B')
				   WHERE (a.accion!='B') AND 
					 (a.fechacarga BETWEEN ? AND ?) AND 
					 (a.detallemovimiento LIKE CONCAT('%',? ,'%')) AND 
					 (d.nombrepunto LIKE CONCAT('%',? ,'%')) AND 
					 (c.nombre LIKE CONCAT('%',? ,'%'))
				   ORDER BY 2
				   LIMIT ?,?";
			
			SET @fechaini = _fechaini; 
			SET @fechafin = _fechafin; 
			SET @detallemov = _detallemov; 
			SET @punto = _punto; 
			SET @nombre = _nombre; 
			SET @pag = _pag; 
			SET @cantfil = _cantfil; 
			EXECUTE STMT USING @fechaini,@fechafin,@detallemov,@punto,@nombre,@pag,@cantfil;
			DEALLOCATE PREPARE STMT;
	ELSE
		PREPARE STMT FROM "SELECT '' as col0,a.fechapago AS 'Fecha Pago',d.nombrepunto AS 'Punto', CONCAT('Debe Cuota Nº',a.cuotanum) AS 'Detalle Movimiento',CONCAT(e.apellido,', ',e.nombre) AS 'Socio',CONCAT(c.nombreclase,'/',f.tipodeclase) AS 'Clase/Tipo',a.montocuota AS 'Cuota',a.montosaldo AS 'Saldo',a.montocuota+a.montosaldo AS 'Deuda',a.idcuota
					FROM cuotas a INNER JOIN cursos b ON (a.idcurso=b.idcurso AND b.accion!='B')
						      INNER JOIN clases c ON (b.idclase=c.idclase AND c.accion!='B')
						      INNER JOIN puntos d ON (d.idpunto=b.idpunto AND d.accion!='B')
						      INNER JOIN personas e ON (e.idpersona=b.idpersona AND e.accion!='B')
						      INNER JOIN tiposdeclases f ON (f.idtipodeclase=c.idtipoclase AND f.accion!='B')
				   WHERE (a.accion!='B') AND 
					 (a.montopagado IS NULL) AND
					 (a.fechapago BETWEEN ? AND ?) AND 
					 (e.apellido LIKE CONCAT('%',? ,'%')) AND 
					 (e.nombre LIKE CONCAT('%',? ,'%')) AND 
					 (c.nombreclase LIKE CONCAT('%',? ,'%')) AND 
					 (f.tipodeclase LIKE CONCAT('%',? ,'%')) AND 
					 (d.nombrepunto LIKE CONCAT('%',? ,'%'))
				   ORDER BY 1
				   LIMIT ?,?";
			
			SET @fechaini = _fechaini; 
			SET @fechafin = _fechafin; 
			SET @apellido = _apellido; 
			SET @nombre = _nombre; 
			SET @nombreclase = _nombreclase; 
			SET @tipoclase = _tipoclase; 
			SET @punto = _punto; 
			SET @pag = _pag; 
			SET @cantfil = _cantfil; 
			EXECUTE STMT USING @fechaini,@fechafin,@apellido,@nombre,@nombreclase,@tipoclase,@punto,@pag,@cantfil;
			DEALLOCATE PREPARE STMT;	
		END IF;	
	END IF;
end if;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_buscadorclases` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_buscadorclases` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_buscadorclases`(
    IN _idclase int,
    IN _idtipodeclase int,
    in _nombreclase varchar(30),
    IN _pag INT,
    IN _cantfil INT
    )
BEGIN
if (_idclase<=0) then
	PREPARE STMT FROM "SELECT a.idclase,a.nombreclase
				FROM clases a INNER JOIN tiposdeclases b ON (a.idtipoclase=b.idtipodeclase AND b.accion!='B' AND a.accion!='B')
				   WHERE (b.idtipodeclase LIKE CONCAT(? ,'%')) AND (a.nombreclase LIKE CONCAT(? ,'%'))
				   ORDER BY a.nombreclase
				   LIMIT ?,?";
		
		SET @idtipodeclase = _idtipodeclase; 
		SET @nombreclase = _nombreclase; 
		SET @pag = _pag; 
		SET @cantfil = _cantfil; 
		EXECUTE STMT USING @idtipodeclase,@nombreclase,@pag,@cantfil;
		DEALLOCATE PREPARE STMT;
else			
	PREPARE STMT FROM "SELECT a.nombreclase
			   FROM clases a INNER JOIN tiposdeclases b ON (a.idtipoclase=b.idtipodeclase AND b.accion!='B' AND a.accion!='B')
			   WHERE (a.idclase LIKE CONCAT(? ,'%'))";
		
		SET @idclase = _idclase; 
		EXECUTE STMT USING @idclase;
		DEALLOCATE PREPARE STMT;
end if;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_buscadorcuotas` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_buscadorcuotas` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_buscadorcuotas`(
    IN _idcurso int,
    in _accion varchar(1)
    )
BEGIN
CASE _accion 
WHEN 'S' THEN
	PREPARE STMT FROM "SELECT a.apellido,a.nombre,a.dni,a.email,c.nombrepunto,e.tipodeclase,d.nombreclase,CONCAT('$ ',f.montocuota) AS cuota
			FROM personas a INNER JOIN cursos b ON (a.idpersona=b.idpersona AND a.accion!='B') 
			INNER JOIN puntos c ON (b.idpunto=c.idpunto AND c.accion!='B')
			INNER JOIN clases d ON (d.idclase=b.idclase AND d.accion!='B')
			INNER JOIN tiposdeclases e ON (e.idtipodeclase=d.idtipoclase AND e.accion!='B')
			INNER JOIN cuotas f ON (f.idcurso=b.idcurso AND f.accion!='B')
			WHERE (b.idcurso LIKE CONCAT(? ,'%')) AND (b.accion!='B')";
		
		SET @idcurso = _idcurso; 
		EXECUTE STMT USING @idcurso;
		DEALLOCATE PREPARE STMT;
WHEN 'C' THEN		
	PREPARE STMT FROM "SELECT b.idcuota,b.cuotanum AS 'Nº Cuota',b.fechapago,b.fecharealpago as 'Fecha Pago',b.montocuota AS 'Monto Cuota',b.montopagado AS 'Monto Pagado',b.montosaldo AS 'Monto Saldo'
			FROM cursos a INNER JOIN cuotas b ON (a.idcurso=b.idcurso AND a.accion!='B')
			WHERE (b.idcurso LIKE CONCAT(? ,'%')) AND (b.accion!='B')
			ORDER BY b.cuotanum DESC";
		
		SET @idcurso = _idcurso; 
		EXECUTE STMT USING @idcurso;
		DEALLOCATE PREPARE STMT;
END CASE;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_buscadorempleados` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_buscadorempleados` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_buscadorempleados`(
    IN _idempleado int,
    IN _apellido VARCHAR(30),
    IN _nombre VARCHAR(30),
    IN _dni VARCHAR(50),
    IN _punto VARCHAR(30),
    IN _tipopersona VARCHAR(30),
    IN _pag INT,
    IN _cantfil INT
    )
BEGIN
if (_idempleado<=0) then
	PREPARE STMT FROM "SELECT a.idpersona,CONCAT(a.apellido,', ', a.nombre) AS Nombre,b.tipopersona AS Privilegio,c.nombrepunto AS Punto
				   FROM personas a INNER JOIN tipopersonas b ON (a.idtipopersona=b.idtipopersona AND b.idtipopersona between 1 and 2)
						   INNER JOIN puntos c ON (c.idpunto=a.idpunto AND c.accion!='B')
				   WHERE (a.accion!='B') AND 
				         (a.apellido LIKE CONCAT(? ,'%')) AND 
				         (a.nombre LIKE CONCAT(? ,'%')) AND 
					 (a.dni LIKE CONCAT(? ,'%')) AND
					 (b.tipopersona LIKE CONCAT(? ,'%')) AND
					 (c.nombrepunto LIKE CONCAT(? ,'%'))
				   ORDER BY a.apellido,a.nombre
				   LIMIT ?,?";
		
		SET @apellido = _apellido; 
		SET @nombre = _nombre; 
		SET @dni = _dni; 
		SET @tipopersona = _tipopersona; 
		SET @punto = _punto; 
		SET @pag = _pag; 
		SET @cantfil = _cantfil; 
		EXECUTE STMT USING @apellido,@nombre,@dni,@tipopersona,@punto,@pag,@cantfil;
		DEALLOCATE PREPARE STMT;
else			
	PREPARE STMT FROM "SELECT a.apellido,a.nombre,a.fechanacimiento,a.dni,a.cuil,a.cel,a.tel,a.email,a.calle,a.numero,a.piso,a.dpto,b.tipopersona,c.nombrepunto,a.urlfoto
				   FROM personas a INNER JOIN tipopersonas b ON (a.idtipopersona=b.idtipopersona)
						   INNER JOIN puntos c ON (c.idpunto=a.idpunto AND c.accion!='B')
				   WHERE (a.idpersona LIKE CONCAT(? ,'%'))";
		
		SET @idempleado = _idempleado; 
		EXECUTE STMT USING @idempleado;
		DEALLOCATE PREPARE STMT;
end if;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_buscadorespecialidades` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_buscadorespecialidades` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_buscadorespecialidades`(
    IN _idespecialidad int,
    in _especialidad varchar(30),
    IN _pag INT,
    IN _cantfil INT
    )
BEGIN
if (_idespecialidad<=0) then
	PREPARE STMT FROM "SELECT a.idespecialidad,a.especialidad
				FROM especialidades a 
				   WHERE (a.accion!='B') AND (a.especialidad LIKE CONCAT(? ,'%'))
				   ORDER BY a.especialidad
				   LIMIT ?,?";
		
		SET @especialidad = _especialidad; 
		SET @pag = _pag; 
		SET @cantfil = _cantfil; 
		EXECUTE STMT USING @especialidad,@pag,@cantfil;
		DEALLOCATE PREPARE STMT;
else			
	PREPARE STMT FROM "SELECT a.idespecialidad,a.especialidad
				FROM especialidades a 
			   WHERE (a.idespecialidad LIKE CONCAT(? ,'%'))";
		
		SET @idespecialidad = _idespecialidad; 
		EXECUTE STMT USING @idespecialidad;
		DEALLOCATE PREPARE STMT;
end if;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_buscadorgastos` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_buscadorgastos` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_buscadorgastos`(
    IN _idgasto int,
    IN _fechaini DATETIME,
    IN _fechafin DATETIME,
    IN _proveedor VARCHAR(30),
    IN _punto VARCHAR(30),
    IN _pag INT,
    IN _cantfil INT
    )
BEGIN
if (_idgasto <=0) then
	PREPARE STMT FROM "SELECT a.idgasto,a.fechagasto AS 'Fecha Gasto',b.nombrepunto AS 'Punto',c.nombre AS 'Proveedor',a.montopagado AS 'Egresos'
			FROM gastos a INNER JOIN puntos b ON (a.idpunto=b.idpunto AND b.accion!='B')
				     INNER JOIN personas c ON (c.idpersona=a.idpersona AND c.accion!='B')
				     INNER JOIN tipopersonas d ON (d.idtipopersona=c.idtipopersona)
			WHERE (a.accion!='B') AND 
			 (a.fechagasto BETWEEN ? AND ?) AND 
			 (c.nombre LIKE CONCAT('%',? ,'%')) AND 
			 (b.nombrepunto LIKE CONCAT('%',? ,'%'))
			   ORDER BY a.fechagasto
			   LIMIT ?,?";
		
		SET @fechaini = _fechaini; 
		SET @fechafin = _fechafin; 
		SET @proveedor = _proveedor; 
		SET @punto = _punto; 
		SET @pag = _pag; 
		SET @cantfil = _cantfil; 
		EXECUTE STMT USING @fechaini,@fechafin,@proveedor,@punto,@pag,@cantfil;
		DEALLOCATE PREPARE STMT;
ELSE			
	PREPARE STMT FROM "SELECT a.idgasto,a.fecharealcarga,a.fechagasto,a.tipofactura,a.numerofactura,c.nombre,b.nombrepunto,a.montopagado,a.observacion
			FROM gastos a INNER JOIN puntos b ON (a.idpunto=b.idpunto AND b.accion!='B')
				     INNER JOIN personas c ON (c.idpersona=a.idpersona AND c.accion!='B')
				     INNER JOIN tipopersonas d ON (d.idtipopersona=c.idtipopersona)
			WHERE (a.accion!='B') AND 
			 (a.idgasto LIKE CONCAT(? ,'%'))";
		
		SET @idgasto = _idgasto; 
		EXECUTE STMT USING @idgasto;
		DEALLOCATE PREPARE STMT;
END IF;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_buscadorinscripciones` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_buscadorinscripciones` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_buscadorinscripciones`(
    IN _idcurso int,
    in _dni varchar(30),
    IN _pag INT,
    IN _cantfil INT
    )
BEGIN
if (_idcurso<=0) then
	PREPARE STMT FROM "SELECT b.idcurso,c.nombrepunto as Punto,e.tipodeclase as Tipos,d.nombreclase as Clase,f.montocuota as Cuota,f.idcuota,f.fechapago
			FROM personas a INNER JOIN cursos b ON (a.idpersona=b.idpersona AND b.accion!='B') 
			INNER JOIN puntos c ON (b.idpunto=c.idpunto AND c.accion!='B')
			INNER JOIN clases d ON (d.idclase=b.idclase AND d.accion!='B')
			INNER JOIN tiposdeclases e ON (e.idtipodeclase=d.idtipoclase AND e.accion!='B')
			INNER JOIN cuotas f ON (f.idcurso=b.idcurso AND f.accion!='B')
			WHERE (a.dni LIKE CONCAT(? ,'%')) AND (a.accion!='B') AND (f.fecharealpago IS NULL)
			ORDER BY b.idcurso
			LIMIT ?,?";
		
		SET @dni = _dni; 
		SET @pag = _pag; 
		SET @cantfil = _cantfil; 
		EXECUTE STMT USING @dni,@pag,@cantfil;
		DEALLOCATE PREPARE STMT;
else			
	PREPARE STMT FROM "SELECT b.idcurso,a.dni,c.nombrepunto,e.tipodeclase,d.nombreclase,f.montocuota,f.idcuota,f.fechapago
			FROM personas a INNER JOIN cursos b ON (a.idpersona=b.idpersona) 
			INNER JOIN puntos c ON (b.idpunto=c.idpunto)
			INNER JOIN clases d ON (d.idclase=b.idclase)
			INNER JOIN tiposdeclases e ON (e.idtipodeclase=d.idtipoclase)
			INNER JOIN cuotas f ON (f.idcurso=b.idcurso)
			WHERE (b.idcurso LIKE CONCAT(? ,'%')) AND (f.fecharealpago IS NULL)";
		
		SET @idcurso = _idcurso; 
		EXECUTE STMT USING @idcurso;
		DEALLOCATE PREPARE STMT;
end if;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_buscadorprofesores` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_buscadorprofesores` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_buscadorprofesores`(
    IN _idempleado int,
    IN _apellido VARCHAR(30),
    IN _nombre VARCHAR(30),
    IN _dni VARCHAR(50),
    IN _punto VARCHAR(30),
    IN _tipopersona VARCHAR(30),
    IN _pag INT,
    IN _cantfil INT
    )
BEGIN
if (_idempleado<=0) then
	PREPARE STMT FROM "SELECT a.idpersona,CONCAT(a.apellido,', ', a.nombre) AS Nombre,b.tipopersona AS Privilegio,c.nombrepunto AS Punto
				   FROM personas a INNER JOIN tipopersonas b ON (a.idtipopersona=b.idtipopersona AND b.idtipopersona=3)
						   INNER JOIN puntos c ON (c.idpunto=a.idpunto AND c.accion!='B')
				   WHERE (a.accion!='B') AND 
				         (a.apellido LIKE CONCAT(? ,'%')) AND 
				         (a.nombre LIKE CONCAT(? ,'%')) AND 
					 (a.dni LIKE CONCAT(? ,'%')) AND
					 (b.tipopersona LIKE CONCAT(? ,'%')) AND
					 (c.nombrepunto LIKE CONCAT(? ,'%'))
				   ORDER BY a.apellido,a.nombre
				   LIMIT ?,?";
		
		SET @apellido = _apellido; 
		SET @nombre = _nombre; 
		SET @dni = _dni; 
		SET @tipopersona = _tipopersona; 
		SET @punto = _punto; 
		SET @pag = _pag; 
		SET @cantfil = _cantfil; 
		EXECUTE STMT USING @apellido,@nombre,@dni,@tipopersona,@punto,@pag,@cantfil;
		DEALLOCATE PREPARE STMT;
else			
	PREPARE STMT FROM "SELECT a.apellido,a.nombre,a.fechanacimiento,a.dni,a.cuil,a.cel,a.tel,a.email,a.calle,a.numero,a.piso,a.dpto,d.especialidad,c.nombrepunto,a.urlfoto
				   FROM personas a INNER JOIN tipopersonas b ON (a.idtipopersona=b.idtipopersona)
						   INNER JOIN puntos c ON (c.idpunto=a.idpunto AND c.accion!='B')
						   INNER JOIN especialidades d ON (d.idespecialidad=a.idespecialidad) 
				   WHERE (a.idpersona LIKE CONCAT(? ,'%'))";
		
		SET @idempleado = _idempleado; 
		EXECUTE STMT USING @idempleado;
		DEALLOCATE PREPARE STMT;
end if;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_buscadorproveedores` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_buscadorproveedores` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_buscadorproveedores`(
    IN _idproveedor int,
    IN _nombre VARCHAR(30),
    IN _cuit VARCHAR(30),
    IN _apecontacto VARCHAR(30),
    IN _nomcontacto VARCHAR(30),
    IN _pag INT,
    IN _cantfil INT
    )
BEGIN
if (_idproveedor<=0) then
	PREPARE STMT FROM "SELECT a.idpersona,a.nombre AS Nombre
				   FROM personas a INNER JOIN tipopersonas b ON (a.idtipopersona=b.idtipopersona AND b.idtipopersona=5)
				   WHERE (a.accion!='B') AND 
				         (a.nombre LIKE CONCAT(? ,'%')) AND
				         (a.cuit LIKE CONCAT(? ,'%')) AND
				         (a.apellidocontacto LIKE CONCAT(? ,'%')) AND
				         (a.nombrecontacto LIKE CONCAT(? ,'%'))
				   ORDER BY a.nombre
				   LIMIT ?,?";
		
		SET @nombre = _nombre; 
		SET @cuit = _cuit; 
		SET @apecontacto = _apecontacto; 
		SET @nomcontacto = _nomcontacto; 
		SET @pag = _pag; 
		SET @cantfil = _cantfil; 
		EXECUTE STMT USING @nombre,@cuit,@apecontacto,@nomcontacto,@pag,@cantfil;
		DEALLOCATE PREPARE STMT;
else			
	PREPARE STMT FROM "SELECT a.nombre,a.cuit,a.cel,a.tel,a.email,a.calle,a.numero,a.piso,a.dpto,a.apellidocontacto,a.nombrecontacto,a.celcontacto,a.telcontacto,a.emailcontacto
			   FROM personas a INNER JOIN tipopersonas b ON (a.idtipopersona=b.idtipopersona)
			   WHERE (a.idpersona LIKE CONCAT(? ,'%'))";
		
		SET @idempleado = _idproveedor; 
		EXECUTE STMT USING @idempleado;
		DEALLOCATE PREPARE STMT;
end if;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_buscadorpuntos` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_buscadorpuntos` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_buscadorpuntos`(
    IN _idpunto int,
    in _nombrepunto varchar(30),
    IN _pag INT,
    IN _cantfil INT
    )
BEGIN
if (_idpunto<=0) then
	PREPARE STMT FROM "SELECT a.idpunto,a.nombrepunto
				FROM puntos a 
				   WHERE (a.accion!='B') AND (a.nombrepunto LIKE CONCAT(? ,'%'))
				   ORDER BY a.nombrepunto
				   LIMIT ?,?";
		
		SET @nombrepunto = _nombrepunto; 
		SET @pag = _pag; 
		SET @cantfil = _cantfil; 
		EXECUTE STMT USING @nombrepunto,@pag,@cantfil;
		DEALLOCATE PREPARE STMT;
else			
	PREPARE STMT FROM "SELECT a.nombrepunto,a.idpunto
			   FROM puntos a
			   WHERE (a.idpunto LIKE CONCAT(? ,'%'))";
		
		SET @idpunto = _idpunto; 
		EXECUTE STMT USING @idpunto;
		DEALLOCATE PREPARE STMT;
end if;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_buscadorsocios` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_buscadorsocios` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_buscadorsocios`(
    IN _idempleado int,
    IN _apellido VARCHAR(30),
    IN _nombre VARCHAR(30),
    IN _dni VARCHAR(50),
    IN _punto VARCHAR(30),
    IN _tipopersona VARCHAR(30),
    IN _pag INT,
    IN _cantfil INT
    )
BEGIN
if (_idempleado<=0) then
	PREPARE STMT FROM "SELECT a.idpersona,CONCAT(a.apellido,', ', a.nombre) AS Nombre,b.tipopersona AS Privilegio,c.nombrepunto AS Punto
				   FROM personas a INNER JOIN tipopersonas b ON (a.idtipopersona=b.idtipopersona AND b.idtipopersona=4)
						   INNER JOIN puntos c ON (c.idpunto=a.idpunto AND c.accion!='B')
				   WHERE (a.accion!='B') AND 
				         (a.apellido LIKE CONCAT(? ,'%')) AND 
				         (a.nombre LIKE CONCAT(? ,'%')) AND 
					 (a.dni LIKE CONCAT(? ,'%')) AND
					 (b.tipopersona LIKE CONCAT(? ,'%')) AND
					 (c.nombrepunto LIKE CONCAT(? ,'%'))
				   ORDER BY a.apellido,a.nombre
				   LIMIT ?,?";
		
		SET @apellido = _apellido; 
		SET @nombre = _nombre; 
		SET @dni = _dni; 
		SET @tipopersona = _tipopersona; 
		SET @punto = _punto; 
		SET @pag = _pag; 
		SET @cantfil = _cantfil; 
		EXECUTE STMT USING @apellido,@nombre,@dni,@tipopersona,@punto,@pag,@cantfil;
		DEALLOCATE PREPARE STMT;
else			
	PREPARE STMT FROM "SELECT a.apellido,a.nombre,a.fechanacimiento,a.dni,a.cuil,a.cel,a.tel,a.email,a.calle,a.numero,a.piso,a.dpto,b.tipopersona,c.nombrepunto,a.urlfoto
				   FROM personas a INNER JOIN tipopersonas b ON (a.idtipopersona=b.idtipopersona)
						   INNER JOIN puntos c ON (c.idpunto=a.idpunto AND c.accion!='B')
				   WHERE (a.idpersona LIKE CONCAT(? ,'%'))";
		
		SET @idempleado = _idempleado; 
		EXECUTE STMT USING @idempleado;
		DEALLOCATE PREPARE STMT;
end if;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_buscadortiposdeclases` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_buscadortiposdeclases` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_buscadortiposdeclases`(
    IN _idtipodeclase int,
    IN _tipodeclase VARCHAR(30),
    IN _pag INT,
    IN _cantfil INT
    )
BEGIN
if (_idtipodeclase<=0) then
	PREPARE STMT FROM "SELECT a.idtipodeclase,a.tipodeclase
			  FROM tiposdeclases a
			  WHERE (a.accion!='B') AND (a.tipodeclase LIKE CONCAT(? ,'%'))
			   ORDER BY a.tipodeclase
			   LIMIT ?,?";
		
		SET @tipodeclase = _tipodeclase; 
		SET @pag = _pag; 
		SET @cantfil = _cantfil; 
		EXECUTE STMT USING @tipodeclase,@pag,@cantfil;
		DEALLOCATE PREPARE STMT;
else			
	PREPARE STMT FROM "SELECT a.idtipodeclase,a.tipodeclase
				FROM tiposdeclases a 
				   WHERE (a.idtipodeclase LIKE CONCAT(? ,'%'))";
		
		SET @idtipodeclase = _idtipodeclase; 
		EXECUTE STMT USING @idtipodeclase;
		DEALLOCATE PREPARE STMT;
end if;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_buscadortiposdeclasesporpunto` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_buscadortiposdeclasesporpunto` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_buscadortiposdeclasesporpunto`(
    in _idpunto int,
    IN _pag INT,
    IN _cantfil INT
    )
BEGIN
if (_idpunto<=0) then
	PREPARE STMT FROM "SELECT a.idtipodeclase,a.tipodeclase
			  FROM tiposdeclases a INNER JOIN clases b ON (a.idtipodeclase=b.idtipoclase AND b.accion!='B') 
				INNER JOIN cursos c ON (c.idclase=b.idclase AND c.accion!='B')
				GROUP BY a.idtipodeclase,a.tipodeclase
			 ORDER BY a.tipodeclase
			   LIMIT ?,?";
		
		SET @pag = _pag; 
		SET @cantfil = _cantfil; 
		EXECUTE STMT USING @pag,@cantfil;
		DEALLOCATE PREPARE STMT;
else			
	PREPARE STMT FROM "SELECT a.idtipodeclase,a.tipodeclase
				FROM tiposdeclases a INNER JOIN clases b ON (a.idtipodeclase=b.idtipoclase AND b.accion!='B') 
				INNER JOIN cursos c ON (c.idclase=b.idclase AND c.accion!='B')
				   WHERE (c.idpunto=?)
				   GROUP BY a.idtipodeclase,a.tipodeclase
				   ORDER BY a.tipodeclase
			   LIMIT ?,?";
		
		SET @idpunto = _idpunto; 
		SET @pag = _pag; 
		SET @cantfil = _cantfil; 
		EXECUTE STMT USING @idpunto,@pag,@cantfil;
		DEALLOCATE PREPARE STMT;
end if;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_login` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_login` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_login`(
    IN _usuario VARCHAR(50),
    IN _password VARCHAR(50)
    )
BEGIN
	PREPARE STMT FROM "SELECT a.idpersona,a.apellido,a.nombre,b.tipopersona,c.nombrepunto
			   FROM personas a INNER JOIN tipopersonas b ON (a.idtipopersona=b.idtipopersona)
					   INNER JOIN puntos c ON (c.idpunto=a.idpunto AND c.accion!='B')
			   WHERE (a.accion!='B') AND 
			         (a.usuario=?) AND 
			         (a.passwordusuario=?)";
		
		SET @usuario = _usuario; 
		SET @password = _password; 
		EXECUTE STMT USING @usuario,@password;
		DEALLOCATE PREPARE STMT;
END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
