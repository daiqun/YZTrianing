-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.1.53-community


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema oes
--

CREATE DATABASE IF NOT EXISTS oes;
USE oes;

--
-- Definition of table `exam`
--

DROP TABLE IF EXISTS `exam`;
CREATE TABLE `exam` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `exam_name` varchar(45) NOT NULL,
  `single_question_score` int(11) NOT NULL COMMENT '单个问题分数',
  `question_quantity` int(11) NOT NULL COMMENT '问题数量',
  `exam_duration` varchar(500) NOT NULL COMMENT '考试持续时间',
  `total_score` int(11) DEFAULT NULL COMMENT '总分',
  `pass_criteria` int(11) NOT NULL COMMENT '通过标准',
  `exam_description` varchar(200) DEFAULT NULL,
  `exam_notice` varchar(450) DEFAULT NULL,
  `examination_rules` varchar(450) DEFAULT NULL,
  `system_information` varchar(450) DEFAULT NULL,
  `contact_us` varchar(450) DEFAULT NULL,
  `exam_status` int(11) DEFAULT NULL COMMENT '考试状态',
  `create_time` datetime DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `create_by` varchar(45) DEFAULT NULL,
  `update_by` varchar(45) DEFAULT NULL,
  `effective_time` date DEFAULT NULL,
  `is_delete` int(11) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `exam`
--

/*!40000 ALTER TABLE `exam` DISABLE KEYS */;
/*!40000 ALTER TABLE `exam` ENABLE KEYS */;


--
-- Definition of table `exam_record`
--

DROP TABLE IF EXISTS `exam_record`;
CREATE TABLE `exam_record` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `exam_time` datetime NOT NULL,
  `exam_score` int(11) DEFAULT NULL,
  `exam_anwser` varchar(100) DEFAULT NULL,
  `exam_status` int(11) DEFAULT NULL,
  `user_id` int(11) DEFAULT NULL,
  `exam_id` int(11) DEFAULT NULL,
  `question_id` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `creat_by` varchar(45) DEFAULT NULL,
  `update_by` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `user_exam_record_user_id` (`user_id`),
  KEY `exam_exam_record_exam_id` (`exam_id`),
  KEY `exam_record_question_question_id` (`question_id`),
  CONSTRAINT `exam_exam_record_exam_id` FOREIGN KEY (`exam_id`) REFERENCES `exam` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `exam_record_question_question_id` FOREIGN KEY (`question_id`) REFERENCES `question` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `user_exam_record_user_id` FOREIGN KEY (`user_id`) REFERENCES `user` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `exam_record`
--

/*!40000 ALTER TABLE `exam_record` DISABLE KEYS */;
/*!40000 ALTER TABLE `exam_record` ENABLE KEYS */;


--
-- Definition of table `permission`
--

DROP TABLE IF EXISTS `permission`;
CREATE TABLE `permission` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `display_name` varchar(45) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `create_by` varchar(45) DEFAULT NULL,
  `update_by` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `permission`
--

/*!40000 ALTER TABLE `permission` DISABLE KEYS */;
INSERT INTO `permission` (`id`,`name`,`display_name`,`create_time`,`update_time`,`create_by`,`update_by`) VALUES 
 (1,'create_user','新增用户',NULL,NULL,NULL,NULL),
 (2,'delete_user','删除用户',NULL,NULL,NULL,NULL),
 (3,'update_user','修改用户信息',NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `permission` ENABLE KEYS */;


--
-- Definition of table `question`
--

DROP TABLE IF EXISTS `question`;
CREATE TABLE `question` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) DEFAULT NULL,
  `question_content` varchar(450) DEFAULT NULL,
  `choice_A` varchar(100) DEFAULT NULL,
  `choice_B` varchar(100) DEFAULT NULL,
  `choice_C` varchar(100) DEFAULT NULL,
  `choice_D` varchar(100) DEFAULT NULL,
  `correct_anwser` varchar(100) DEFAULT NULL,
  `is_delete` int(11) DEFAULT '0',
  `create_time` datetime DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `create_by` varchar(45) DEFAULT NULL,
  `update_by` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `question_user_user_id` (`user_id`),
  CONSTRAINT `question_user_user_id` FOREIGN KEY (`user_id`) REFERENCES `user` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `question`
--

/*!40000 ALTER TABLE `question` DISABLE KEYS */;
INSERT INTO `question` (`id`,`user_id`,`question_content`,`choice_A`,`choice_B`,`choice_C`,`choice_D`,`correct_anwser`,`is_delete`,`create_time`,`update_time`,`create_by`,`update_by`) VALUES 
 (1,1,'1、软件测试就是为了验证软件功能实现的是否正确，是否完成既定目标的活动，所以软件测试在软件工程的后期才开始具体的工作。 （初级）           （ × ） ','1','2','3','4','B',0,'2017-04-03 17:29:46','2017-04-03 19:51:25','william.dai','william.dai'),
 (2,1,'2.发现错误多的模块，残留在模块中的错误也多。( √ ) （初级） ','1','2','3','4','B',0,'2017-04-03 17:30:15','2017-04-03 19:51:53','william.dai','william.dai'),
 (3,1,'3、测试人员在测试过程中发现一处问题，如果问题影响不大，而自己又可以修改，应立即将此问题正确修改，以加快、提高开发的进程。（ × ）（初级）','1','2','3','4','B',0,'2017-04-03 17:31:57','2017-04-03 19:51:46','william.dai','william.dai'),
 (4,1,'4、单元测试通常应该先进行“人工走查”，再以白盒法为主，辅以黑盒法进行动态测试。   （ √ ）（中级）','1','2','3','4','A',0,'2017-04-03 17:32:25','2017-04-03 19:54:29','william.dai','william.dai'),
 (5,1,'5、功能测试是系统测试的主要内容，检查系统的功能、性能是否与需求规格说明相同。（ √ ）（中级）','1','2','3','4','B',0,'2017-04-03 19:53:52','2017-04-03 20:29:31','william.dai','william.dai'),
 (6,1,'6、软件质量管理即QM由QA和QC构成，软件测试属于QC的核心工作内容。（√）（高级）','1','2','3','4','A',0,'2017-04-03 19:55:28','2017-04-03 19:55:28','william.dai','william.dai'),
 (7,1,'7、软件测试只能发现错误，但不能保证测试后的软件没有错误。(√)','1','2','3','4','A',0,'2017-04-03 19:55:49','2017-04-03 19:55:49','william.dai','william.dai'),
 (8,1,'8、软件就是程序。(X) ','1','2','3','4','B',0,'2017-04-03 19:56:02','2017-04-03 19:56:02','william.dai','william.dai'),
 (9,1,'9、测试只要做到语句覆盖和分支覆盖，就可以发现程序中的所有错误。(X)','1','2','3','4','C',0,'2017-04-03 19:56:12','2017-04-03 19:56:12','william.dai','william.dai'),
 (10,1,'10、I18N测试是指对产品做出具有国际性的规划，而L10N测试则是指对软件做出符合本地需求更改工作。（√）【高级】','1','2','3','4','B',0,'2017-04-03 19:56:25','2017-04-03 20:04:24','william.dai','william.dai'),
 (11,1,'1、 进行软件质量管理的重要性有：（ABCD）【中级】','A、维护降低成本 ','B、法律上的要求','C、市场竞争的需要','D、质量标准化的趋势','B',0,'2017-04-03 19:57:50','2017-04-03 20:29:37','william.dai','william.dai'),
 (12,1,'2、以测试的形态分测试可以分为：（ABC）【中级】','A、建构性测试','B、系统测试 ','C、专项测试','D、单元测试','B',0,'2017-04-03 20:18:34','2017-04-03 20:30:34','william.dai','william.dai'),
 (13,1,'3、选出属于黑盒测试方法的选项（ABC）【初级】','A、测试用例覆盖 ','B、输入覆盖','C、输出覆盖','D、分支覆盖','B',0,'2017-04-03 20:26:36','2017-04-03 20:30:29','william.dai','william.dai'),
 (14,1,'4、编写测试计划的目的是：（ABC）【中级】','A、使测试工作顺利进行','B、使项目参与人员沟通更舒畅','C、使测试工作更加系统化','D、软件工程以及软件过程的需要','B',0,'2017-04-03 20:28:57','2017-04-03 20:40:53','william.dai','william.dai'),
 (15,1,'<script>alert(123)</script>','<script>alert(1213)</script>','<script>alert(1223)</script>','<script>alert(1233)</script>','<script>alert(1243)</script>','B',0,'2017-04-03 21:40:59','2017-04-03 23:14:28','william.dai','william.dai'),
 (16,1,'<script>(\"233\")</script><script>(\"233\")</script>','1','2','3','4','B',0,'2017-04-03 21:41:52','2017-04-04 08:48:48','william.dai','william.dai'),
 (17,1,'<script>alert(123)</script>啊大厦','阿斯大声的','阿斯顿撒旦','阿斯顿撒旦阿斯顿','阿斯顿','C',0,'2017-04-04 08:51:08','2017-04-04 08:51:08','william.dai','william.dai'),
 (18,1,'啊发烧碟','阿斯发达地方','阿斯顿发','的发烧碟发生','打发打发','C',0,'2017-04-04 09:25:16','2017-04-04 09:25:16','william.dai','william.dai');
/*!40000 ALTER TABLE `question` ENABLE KEYS */;


--
-- Definition of table `role`
--

DROP TABLE IF EXISTS `role`;
CREATE TABLE `role` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `display_name` varchar(45) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `create_by` varchar(45) DEFAULT NULL,
  `update_by` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `role`
--

/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` (`id`,`name`,`display_name`,`create_time`,`update_time`,`create_by`,`update_by`) VALUES 
 (1,'SysAdmin','系统管理员',NULL,NULL,NULL,NULL),
 (2,'ContentAdmin','考试管理员',NULL,NULL,NULL,NULL),
 (3,'Teacher','教师',NULL,NULL,NULL,NULL),
 (4,'Student','学生',NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `role` ENABLE KEYS */;


--
-- Definition of table `role_permission`
--

DROP TABLE IF EXISTS `role_permission`;
CREATE TABLE `role_permission` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `role_id` int(11) NOT NULL,
  `permission_id` int(11) NOT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `create_by` varchar(45) DEFAULT NULL,
  `update_by` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`,`role_id`,`permission_id`),
  KEY `role_permission_role_id` (`role_id`),
  KEY `role_permission_permission_id` (`permission_id`),
  CONSTRAINT `role_permission_permission_id` FOREIGN KEY (`permission_id`) REFERENCES `permission` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `role_permission_role_id` FOREIGN KEY (`role_id`) REFERENCES `role` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `role_permission`
--

/*!40000 ALTER TABLE `role_permission` DISABLE KEYS */;
INSERT INTO `role_permission` (`id`,`role_id`,`permission_id`,`create_time`,`update_time`,`create_by`,`update_by`) VALUES 
 (1,1,1,NULL,NULL,NULL,NULL),
 (2,1,2,NULL,NULL,NULL,NULL),
 (3,1,3,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `role_permission` ENABLE KEYS */;


--
-- Definition of table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_name` varchar(45) NOT NULL,
  `password` varchar(32) NOT NULL,
  `gender` enum('man','woman') DEFAULT NULL,
  `phone_number` varchar(11) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `chinese_name` varchar(45) DEFAULT NULL,
  `avatar` varchar(500) DEFAULT NULL,
  `last_login_time` datetime DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `create_by` varchar(45) DEFAULT NULL,
  `update_by` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `user`
--

/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` (`id`,`user_name`,`password`,`gender`,`phone_number`,`email`,`chinese_name`,`avatar`,`last_login_time`,`create_time`,`update_time`,`create_by`,`update_by`) VALUES 
 (1,'william.dai','123456',NULL,NULL,NULL,NULL,NULL,NULL,'2017-04-03 17:20:10','2017-04-03 17:20:10',NULL,NULL);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;


--
-- Definition of table `user_exam`
--

DROP TABLE IF EXISTS `user_exam`;
CREATE TABLE `user_exam` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `exam_id` int(11) NOT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `create_by` varchar(45) DEFAULT NULL,
  `update-by` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`,`user_id`,`exam_id`),
  KEY `user_exam_user_id` (`user_id`),
  KEY `user_exam_exam_id` (`exam_id`),
  CONSTRAINT `user_exam_exam_id` FOREIGN KEY (`exam_id`) REFERENCES `exam` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `user_exam_user_id` FOREIGN KEY (`user_id`) REFERENCES `user` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `user_exam`
--

/*!40000 ALTER TABLE `user_exam` DISABLE KEYS */;
/*!40000 ALTER TABLE `user_exam` ENABLE KEYS */;


--
-- Definition of table `user_role`
--

DROP TABLE IF EXISTS `user_role`;
CREATE TABLE `user_role` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `role_id` int(11) NOT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `create_by` varchar(45) DEFAULT NULL,
  `update_by` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`,`user_id`,`role_id`),
  KEY `user_role_user_id` (`user_id`),
  KEY `user_role_role_id` (`role_id`),
  CONSTRAINT `user_role_role_id` FOREIGN KEY (`role_id`) REFERENCES `role` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `user_role_user_id` FOREIGN KEY (`user_id`) REFERENCES `user` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `user_role`
--

/*!40000 ALTER TABLE `user_role` DISABLE KEYS */;
INSERT INTO `user_role` (`id`,`user_id`,`role_id`,`create_time`,`update_time`,`create_by`,`update_by`) VALUES 
 (1,1,1,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `user_role` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
