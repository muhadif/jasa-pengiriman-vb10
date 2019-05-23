/*
SQLyog Enterprise v12.4.3 (32 bit)
MySQL - 5.7.23 : Database - jasa_pengiriman
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`jasa_pengiriman` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `jasa_pengiriman`;

/*Table structure for table `cities` */

DROP TABLE IF EXISTS `cities`;

CREATE TABLE `cities` (
  `id` int(10) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `cities` */

insert  into `cities`(`id`,`name`) values 
(1,'Jakarta'),
(2,'Bogor'),
(3,'Denpasar'),
(4,'Tangerang'),
(5,'Bekasi'),
(6,'Yogyakarta');

/*Table structure for table `goods` */

DROP TABLE IF EXISTS `goods`;

CREATE TABLE `goods` (
  `id` varchar(20) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `goods_category_id` int(10) DEFAULT NULL,
  `weight` double DEFAULT NULL,
  `price` bigint(20) DEFAULT NULL,
  `sender_id` int(10) DEFAULT NULL,
  `receiver_id` int(10) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `goods_category_id` (`goods_category_id`),
  KEY `sender_id` (`sender_id`),
  KEY `receiver_id` (`receiver_id`),
  CONSTRAINT `goods_ibfk_2` FOREIGN KEY (`sender_id`) REFERENCES `senders` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `goods_ibfk_3` FOREIGN KEY (`receiver_id`) REFERENCES `receivers` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `goods_ibfk_4` FOREIGN KEY (`goods_category_id`) REFERENCES `goods_category` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `goods` */

insert  into `goods`(`id`,`name`,`goods_category_id`,`weight`,`price`,`sender_id`,`receiver_id`) values 
('64NKJEJG','Xiaomi A5',3,2,45000,13,8),
('Z1UII006','asdas',1,1,14000,15,9);

/*Table structure for table `goods_category` */

DROP TABLE IF EXISTS `goods_category`;

CREATE TABLE `goods_category` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

/*Data for the table `goods_category` */

insert  into `goods_category`(`id`,`name`) values 
(1,'Bronze'),
(2,'Silver'),
(3,'Gold'),
(4,'Platinum');

/*Table structure for table `history` */

DROP TABLE IF EXISTS `history`;

CREATE TABLE `history` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `date` datetime DEFAULT CURRENT_TIMESTAMP,
  `good_id` varchar(20) DEFAULT NULL,
  `location` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `good_id` (`good_id`),
  CONSTRAINT `history_ibfk_1` FOREIGN KEY (`good_id`) REFERENCES `goods` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `history` */

insert  into `history`(`id`,`date`,`good_id`,`location`) values 
(1,'2019-05-22 22:59:26','64NKJEJG','Bantul'),
(2,'2019-05-22 23:09:00','64NKJEJG','Sleman'),
(3,'2019-05-22 23:09:43','64NKJEJG','a');

/*Table structure for table `price` */

DROP TABLE IF EXISTS `price`;

CREATE TABLE `price` (
  `city_1_id` int(10) NOT NULL,
  `city_2_id` int(10) NOT NULL,
  `price` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`city_1_id`,`city_2_id`),
  KEY `city_2_id` (`city_2_id`),
  CONSTRAINT `price_ibfk_1` FOREIGN KEY (`city_1_id`) REFERENCES `cities` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `price_ibfk_2` FOREIGN KEY (`city_2_id`) REFERENCES `cities` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `price` */

insert  into `price`(`city_1_id`,`city_2_id`,`price`) values 
(1,1,9000),
(1,2,9000),
(1,3,25000),
(1,4,9000),
(1,5,9000),
(1,6,15000),
(2,1,9000),
(2,2,9000),
(2,3,25000),
(2,4,9000),
(2,5,9000),
(2,6,15000),
(3,1,25000),
(3,2,25000),
(3,3,9000),
(3,4,15000),
(3,5,15000),
(3,6,18000),
(4,1,9000),
(4,2,9000),
(4,3,15000),
(4,4,9000),
(4,5,9000),
(4,6,15000),
(5,1,9000),
(5,2,9000),
(5,3,15000),
(5,4,9000),
(5,5,9000),
(5,6,15000),
(6,1,15000),
(6,2,15000),
(6,3,18000),
(6,4,15000),
(6,5,15000),
(6,6,9000);

/*Table structure for table `receivers` */

DROP TABLE IF EXISTS `receivers`;

CREATE TABLE `receivers` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `contact` varchar(255) DEFAULT NULL,
  `city_id` int(10) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `city_id` (`city_id`),
  CONSTRAINT `receivers_ibfk_1` FOREIGN KEY (`city_id`) REFERENCES `cities` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

/*Data for the table `receivers` */

insert  into `receivers`(`id`,`name`,`address`,`contact`,`city_id`) values 
(8,'Cannavaro Yogi Pratama','Depok','08589745423',1),
(9,'dsad','sdas','ads',1);

/*Table structure for table `roles` */

DROP TABLE IF EXISTS `roles`;

CREATE TABLE `roles` (
  `id` int(10) NOT NULL,
  `name` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `roles` */

insert  into `roles`(`id`,`name`) values 
(1,'admin'),
(2,'user');

/*Table structure for table `senders` */

DROP TABLE IF EXISTS `senders`;

CREATE TABLE `senders` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `contact` varchar(255) DEFAULT NULL,
  `city_id` int(10) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `city_id` (`city_id`),
  CONSTRAINT `senders_ibfk_1` FOREIGN KEY (`city_id`) REFERENCES `cities` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

/*Data for the table `senders` */

insert  into `senders`(`id`,`name`,`address`,`contact`,`city_id`) values 
(13,'Muhammad Ihsan Satyawan','Perum Cipta Jati Permai','0821238049',6),
(14,'asd','asda','asd',1),
(15,'dasd','sdas','ads',1);

/*Table structure for table `users` */

DROP TABLE IF EXISTS `users`;

CREATE TABLE `users` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) DEFAULT NULL,
  `fullname` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `role_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `role_id` (`role_id`),
  CONSTRAINT `users_ibfk_1` FOREIGN KEY (`role_id`) REFERENCES `roles` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `users` */

insert  into `users`(`id`,`username`,`fullname`,`password`,`role_id`) values 
(1,'ihsansatyawan','ihsan satyawan','admin',1),
(2,'admin','admin','admin',1);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
