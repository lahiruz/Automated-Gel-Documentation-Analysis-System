-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Dec 21, 2015 at 04:25 AM
-- Server version: 5.6.12-log
-- PHP Version: 5.4.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `gel_documentation_system`
--
CREATE DATABASE IF NOT EXISTS `gel_documentation_system` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `gel_documentation_system`;

-- --------------------------------------------------------

--
-- Table structure for table `db_final_value`
--

CREATE TABLE IF NOT EXISTS `db_final_value` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Image_ID` varchar(250) DEFAULT NULL,
  `Patient_ID` varchar(250) DEFAULT NULL,
  `Desease_Name` varchar(250) DEFAULT NULL,
  `BP_Value` varchar(1000) DEFAULT NULL,
  `Negative_Controller` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=110 ;

--
-- Dumping data for table `db_final_value`
--

INSERT INTO `db_final_value` (`ID`, `Image_ID`, `Patient_ID`, `Desease_Name`, `BP_Value`, `Negative_Controller`) VALUES
(11, 'hd_001', '1122', 'HD', '210,190', NULL),
(12, 'stroke_005', '1221', 'Stroke', '123,435,566,124,234,233,455,500,222', NULL),
(13, 'stroke_010', '1222', 'Stroke', '120,145,100,178,198,190,200,210,220,215,390,376,415,435,423,495,487', NULL),
(14, 'stroke_015', '1223', 'Stroke', '486,493,512,510,190,199,210,506,345,124,398,490,491,478,492,505,507', NULL),
(15, 'stroke_020', '1224', 'Stroke', '456,321,498,199,200,205,203,210,215,195,190,194,480,482,512,505,543', NULL),
(16, 'stroke_030', '1225', 'Stroke', '195,190,162,195,194,205,100,210,211,278,220,217,190,498,496,492,502,191', NULL),
(42, 'image001', '001', 'DMD A', '404.000000,428.000000,440.000000,446.000000,455.000000,470.000000,482.000000,488.000000', '403.000000,417.000000,437.000000'),
(43, 'image001', '002', 'DMD A', '398.000000,408.000000,427.000000,439.000000', '403.000000,417.000000,437.000000'),
(44, 'image001', '003', 'DMD A', '399.000000,423.000000,436.000000,451.000000,459.000000,466.000000,473.000000,478.000000,487.000000,498.000000', '403.000000,417.000000,437.000000'),
(45, 'image001', '004', 'DMD A', '391.000000,403.000000,423.000000', '403.000000,417.000000,437.000000'),
(46, 'image001', '005', 'DMD A', '396.000000,407.000000,428.000000', '403.000000,417.000000,437.000000'),
(47, 'image001', '006', 'DMD A', '394.000000,408.000000,427.000000,467.000000,483.000000', '403.000000,417.000000,437.000000'),
(48, 'image001', '007', 'DMD A', '304.000000,398.000000,412.000000,433.000000,467.000000,476.000000,482.000000', '403.000000,417.000000,437.000000'),
(49, 'image001', '008', 'DMD A', '407.000000,416.000000,428.000000,440.000000', '403.000000,417.000000,437.000000'),
(62, 'test001', '77', 'DMD C', '515.000000,527.000000,551.000000,564.000000,576.000000,612.000000,624.000000', '514.000000,548.000000,564.000000,611.000000,623.000000'),
(63, 'test001', '77', 'DMD D', '544.000000,594.000000,632.000000,645.000000', '547.000000,552.000000,590.000000,627.000000'),
(64, 'test001', '77', 'DMD A', '527.000000,536.000000,552.000000,581.000000', '530.000000,539.000000,555.000000,586.000000'),
(65, 'test001', '77', 'DMD B', '498.000000,510.000000,523.000000,556.000000,608.000000', '505.000000,517.000000,542.000000,558.000000,609.000000'),
(66, 'test001', '77', 'DMD E', '524.000000', '523.000000'),
(67, 'test001', '77', 'DMD F', '', '604.000000'),
(74, 'test002', '88', 'DMD C', '515.000000,527.000000,551.000000,564.000000,576.000000,612.000000,624.000000', '514.000000,548.000000,564.000000,611.000000,623.000000'),
(75, 'test002', '88', 'DMD D', '544.000000,594.000000,632.000000,645.000000', '547.000000,552.000000,590.000000,627.000000'),
(76, 'test002', '88', 'DMD A', '527.000000,536.000000,552.000000,581.000000', '530.000000,539.000000,555.000000,586.000000'),
(77, 'test002', '88', 'DMD B', '498.000000,510.000000,523.000000,556.000000,608.000000', '505.000000,517.000000,542.000000,558.000000,609.000000'),
(78, 'test002', '88', 'DMD E', '524.000000', '523.000000'),
(79, 'test002', '88', 'DMD F', '', '604.000000'),
(86, 'im234', '567', 'DMD C', '515.000000,527.000000,551.000000,564.000000,576.000000,612.000000,624.000000', '514.000000,548.000000,564.000000,611.000000,623.000000'),
(87, 'im234', '567', 'DMD D', '544.000000,594.000000,632.000000,645.000000', '547.000000,552.000000,590.000000,627.000000'),
(88, 'im234', '567', 'DMD A', '527.000000,536.000000,552.000000,581.000000', '530.000000,539.000000,555.000000,586.000000'),
(89, 'im234', '567', 'DMD B', '498.000000,510.000000,523.000000,556.000000,608.000000', '505.000000,517.000000,542.000000,558.000000,609.000000'),
(90, 'im234', '567', 'DMD E', '524.000000', '523.000000'),
(91, 'im234', '567', 'DMD F', '', '604.000000'),
(98, 'Image_001', '444', 'DMD C', '515.000000,527.000000,551.000000,564.000000,576.000000,612.000000,624.000000', '514.000000,548.000000,564.000000,611.000000,623.000000'),
(99, 'Image_001', '444', 'DMD D', '544.000000,594.000000,632.000000,645.000000', '547.000000,552.000000,590.000000,627.000000'),
(100, 'Image_001', '444', 'DMD A', '527.000000,536.000000,552.000000,581.000000', '530.000000,539.000000,555.000000,586.000000'),
(101, 'Image_001', '444', 'DMD B', '498.000000,510.000000,523.000000,556.000000,608.000000', '505.000000,517.000000,542.000000,558.000000,609.000000'),
(102, 'Image_001', '444', 'DMD E', '524.000000', '523.000000'),
(103, 'Image_001', '444', 'DMD F', '', '604.000000'),
(104, 'Image_005', 'P_010', 'DMD C', '515.000000,527.000000,551.000000,564.000000,576.000000,612.000000,624.000000', '514.000000,548.000000,564.000000,611.000000,623.000000'),
(105, 'Image_005', 'P_010', 'DMD D', '544.000000,594.000000,632.000000,645.000000', '547.000000,552.000000,590.000000,627.000000'),
(106, 'Image_005', 'P_010', 'DMD A', '527.000000,536.000000,552.000000,581.000000', '530.000000,539.000000,555.000000,586.000000'),
(107, 'Image_005', 'P_010', 'DMD B', '498.000000,510.000000,523.000000,556.000000,608.000000', '505.000000,517.000000,542.000000,558.000000,609.000000'),
(108, 'Image_005', 'P_010', 'DMD E', '524.000000', '523.000000'),
(109, 'Image_005', 'P_010', 'DMD F', '', '604.000000');

-- --------------------------------------------------------

--
-- Table structure for table `deseace_type`
--

CREATE TABLE IF NOT EXISTS `deseace_type` (
  `ID` int(11) NOT NULL,
  `Name` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `deseace_type`
--

INSERT INTO `deseace_type` (`ID`, `Name`) VALUES
(1, 'DMD A'),
(2, 'DMD B'),
(3, 'DMD C'),
(4, 'DMD D'),
(5, 'DMD E'),
(6, 'DMD F'),
(7, 'HD'),
(8, 'SCA 1'),
(9, 'SCA 2'),
(10, 'SCA 3'),
(11, 'STROKE'),
(12, '(+) CONTROLLER'),
(13, '(-) CONTROLLER_A'),
(14, '(-) CONTROLLER_B'),
(15, '(-) CONTROLLER_C'),
(16, '(-) CONTROLLER_D'),
(17, '(-) CONTROLLER_E'),
(18, '(-) CONTROLLER_F'),
(19, '50 BP LADDER'),
(20, '100 BP LADDER'),
(21, 'NO DNA'),
(22, 'NO BAND');

-- --------------------------------------------------------

--
-- Table structure for table `dmd_type_a`
--

CREATE TABLE IF NOT EXISTS `dmd_type_a` (
  `ID` int(11) NOT NULL,
  `Exone_Value` varchar(250) DEFAULT NULL,
  `Value` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `dmd_type_b`
--

CREATE TABLE IF NOT EXISTS `dmd_type_b` (
  `ID` int(11) NOT NULL,
  `Exone_Value` varchar(250) DEFAULT NULL,
  `Value` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `dmd_type_c`
--

CREATE TABLE IF NOT EXISTS `dmd_type_c` (
  `ID` int(11) NOT NULL,
  `Exone_Value` varchar(250) DEFAULT NULL,
  `Value` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `dmd_type_d`
--

CREATE TABLE IF NOT EXISTS `dmd_type_d` (
  `ID` int(11) NOT NULL,
  `Exone_Value` varchar(250) DEFAULT NULL,
  `Value` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `dmd_type_e`
--

CREATE TABLE IF NOT EXISTS `dmd_type_e` (
  `ID` int(11) NOT NULL,
  `Exone_Value` varchar(250) DEFAULT NULL,
  `Value` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `dmd_type_f`
--

CREATE TABLE IF NOT EXISTS `dmd_type_f` (
  `ID` int(11) NOT NULL,
  `Exone_Value` varchar(250) DEFAULT NULL,
  `Value` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `hd_severity`
--

CREATE TABLE IF NOT EXISTS `hd_severity` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Patient_ID` varchar(250) DEFAULT NULL,
  `Age_On_Set` varchar(250) DEFAULT NULL,
  `UHDRS_Total_Score` varchar(250) DEFAULT NULL,
  `UHDRS_Functional_Score` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=69 ;

--
-- Dumping data for table `hd_severity`
--

INSERT INTO `hd_severity` (`ID`, `Patient_ID`, `Age_On_Set`, `UHDRS_Total_Score`, `UHDRS_Functional_Score`) VALUES
(1, '34', '45', '6', '67'),
(2, '567', '90', '89', '78'),
(3, '001', '12', '2123', '42'),
(4, '234', '44', '66', '42'),
(5, '234', '23', '55', '55'),
(6, '111', '22', '33', '44'),
(7, '234', '334', '343', '343'),
(8, '234', '32', '2323', '233'),
(9, '234', '23', '23232', '232323'),
(10, '001', '24', '46', '57'),
(11, '001', '24', '56', '34'),
(12, '001', '45', '54', '86'),
(13, '234', '12', '33', '44'),
(14, '234', '11', '22', '33'),
(15, '1122', '223', '33', '44'),
(16, '1122', '11', '22', '44'),
(17, '1122', '21', '312', '123'),
(18, '1122', '11', '22', '33'),
(19, '234', '55', '55', '66'),
(20, '234', '112', '33', '55'),
(21, '234', '11', '22', '44'),
(22, '1122', '11', '22', '33'),
(23, '1122', '12', '33', '44'),
(24, '1122', '122', '444', '55'),
(25, '1122', '112', '11', '323'),
(26, '1122', '22', '11', '466'),
(27, '234', '11', '22', '33'),
(28, '001', '11', '33', '44'),
(29, '234', '122', '32', '33'),
(30, '1122', '34', '433', '34'),
(31, '1122', '12', '33', '44'),
(32, '1122', '12', '313', '331'),
(33, '1122', '42', '34', '342'),
(34, '1122', '23', '44', '12'),
(35, '1122', '12', '31', '113'),
(36, '1122', '12', '123', '31'),
(37, '1122', '23', '34', '42'),
(38, '1122', '34', '23', '54'),
(39, '1122', '24', '54', '35'),
(40, '1122', '23', '432', '34'),
(41, '1122', '12', '23', '32'),
(42, '1122', '23', '25', '5432'),
(43, '1122', '25', '346', '452'),
(44, '1122', '23', '41', '25'),
(45, '1122', '12', '321', '213'),
(46, '1122', '4', '532', '234'),
(47, '1122', '21', '323', '2424'),
(48, '1122', '34', '35', '535'),
(49, '1122', '12', '12', '12'),
(50, '1221', '23', '233', '23'),
(51, '1221', '12', '12', '12'),
(52, '1122', '12', '123', '43'),
(53, '1122', '23', '12', '123'),
(54, '1221', '12', '12', '12'),
(55, '1122', '33', '44', '34'),
(56, '1122', '12', '24', '12'),
(57, '001', '11', '24', '20'),
(58, '1122', '12', '24', '20'),
(59, '1122', '11', '22', '24'),
(60, '1122', '23', '67', '23'),
(61, '1122', '12', '31', '32'),
(62, '1122', '12', '32', '32'),
(63, '1122', '2121', '211', '3232'),
(64, '1122', '23', '45', '23'),
(65, '1122', '35', '20', '24'),
(66, '1122', '34', '20', '24'),
(67, '1122', '34', '20', '24'),
(68, '1122', '35', '20', '24');

-- --------------------------------------------------------

--
-- Table structure for table `patient_detail`
--

CREATE TABLE IF NOT EXISTS `patient_detail` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Patient_ID` varchar(250) DEFAULT NULL,
  `Patient_Name` varchar(250) DEFAULT NULL,
  `Age` varchar(250) DEFAULT NULL,
  `Sex` varchar(250) DEFAULT NULL,
  `Desease_Name` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=23 ;

--
-- Dumping data for table `patient_detail`
--

INSERT INTO `patient_detail` (`ID`, `Patient_ID`, `Patient_Name`, `Age`, `Sex`, `Desease_Name`) VALUES
(1, '001', 'lahiru', '25', 'male', 'DMD'),
(2, '2', 'lahiru', '24', 'Male', 'DMD A'),
(3, '3', 'chandu', '25', 'Male', 'DMD B'),
(4, '4', 'bhagya', '25', 'Male', 'HD'),
(5, '5', 'chathu', '34', 'Select Sex', 'STROKE'),
(6, '123', 'bhagya', '25', 'Male', 'DMD C'),
(7, '234', 'chanthu', '34', 'Male', 'DMD A'),
(8, '345', 'amali', '24', 'Female', 'DMD B'),
(9, '456', 'ranil', '45', 'Male', 'DMD C'),
(10, '567', 'girl', '34', 'Select Sex', 'DMD D'),
(11, '6', 'roshan', '26', 'Male', 'HD'),
(12, '7', 'ran', '25', 'Male', 'DMD B'),
(13, '1122', 'kasun Fernando', '38', 'Male', 'HD'),
(14, '111', 'nimal', '34', 'Select Sex', 'Select Desease Name'),
(15, '2233', 'bhagya', '32', 'Male', 'DMD A'),
(16, '121212', 'kamal', '23', 'Male', 'STROKE'),
(17, 'ewe', 'wwer', '45', 'Male', 'DMD'),
(18, 'P_001', 'Nimal', '34', 'Male', 'DMD'),
(19, 'P_001', 'Sunil Perera', '34', 'Male', 'DMD'),
(20, 'P_001', 'Sumal Perera', '35', 'Male', 'DMD'),
(21, 'P_005', 'Sumal Silva', '34', 'Male', 'DMD'),
(22, 'P_010', 'Nimal Silva', '34', 'Male', 'DMD');

-- --------------------------------------------------------

--
-- Table structure for table `user_detail`
--

CREATE TABLE IF NOT EXISTS `user_detail` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `User_Name` varchar(250) NOT NULL,
  `Passward` varchar(250) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `user_detail`
--

INSERT INTO `user_detail` (`ID`, `User_Name`, `Passward`) VALUES
(1, 'chandu', '123'),
(2, 'lahiru', '456');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
