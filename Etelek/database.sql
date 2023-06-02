-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 05, 2022 at 06:11 PM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `etelek`
--
CREATE DATABASE IF NOT EXISTS `etelek` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `etelek`;

-- --------------------------------------------------------

--
-- Table structure for table `etelek`
--

CREATE TABLE `etelek` (
  `id` int(10) UNSIGNED NOT NULL,
  `etel` varchar(255) NOT NULL,
  `kat_id` int(10) UNSIGNED NOT NULL,
  `vega` tinyint(1) NOT NULL,
  `ar` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `etelek`
--

INSERT INTO `etelek` (`id`, `etel`, `kat_id`, `vega`, `ar`) VALUES
(1, 'Erőleves tojással', 1, 1, 650),
(2, 'Húsleves', 1, 0, 700),
(3, 'Orjaleves', 1, 0, 700),
(4, 'Gulyásleves', 1, 0, 750),
(5, 'Jókai bableves', 1, 0, 850),
(6, 'Tárkonyos raguleves', 1, 0, 850),
(7, 'Hagymakrémleves', 1, 1, 650),
(8, 'Eperkrémleves', 1, 1, 650),
(9, 'Paradicsomleves', 1, 1, 650),
(10, 'Tojásleves', 1, 1, 600),
(11, 'Gyümölcsleves', 1, 1, 600),
(12, 'Brokkolikrémlves', 1, 1, 650),
(13, 'Karfiol leves', 1, 1, 650),
(14, 'Parajos gnocci sajttal', 2, 1, 980),
(15, 'Milánói makaróni', 2, 0, 1150),
(16, 'Padlizsános lasagne', 2, 1, 1200),
(17, 'Pasta all\'arabiata', 2, 0, 1200),
(18, 'Barátfüle', 2, 1, 1300),
(19, 'Házi túrós csusza', 2, 1, 1150),
(20, 'Ricottás-spenótos tortellini', 2, 1, 1200),
(21, 'Velővel töltött cannelloni', 2, 0, 1500),
(22, 'Kijevi jércemell', 5, 0, 1300),
(23, 'Hawaii csirkemell', 5, 0, 1300),
(24, 'Vasalt csirkemell salátával', 5, 0, 1350),
(25, 'Szedervölgyi pulykamell', 5, 0, 1400),
(26, 'Nosztalgia csirkemell', 5, 0, 1200),
(27, 'Csirkepaprikás', 5, 0, 1050),
(28, 'Barbár csirke', 5, 0, 1050),
(29, 'Spenótos csirke', 5, 0, 1240),
(30, 'Tejfölös csirkeragu', 5, 0, 1100),
(31, 'Süllő filé roston', 6, 0, 1400),
(32, 'Vasi harcsaszelet', 6, 0, 1500),
(33, 'Egész Süllő', 6, 0, 2500),
(34, 'Pisztráng egészben sütve', 6, 0, 2500),
(35, 'Haltorta tócsnival', 6, 0, 2000),
(36, 'Milánói borda', 4, 0, 2600),
(37, 'Betyár borda', 4, 0, 2600),
(38, 'Cigánypecsenye', 4, 0, 2400),
(39, 'Brassói aprópecsenye', 4, 0, 2500),
(40, 'Sertéscsülök pékné módra', 4, 0, 3000),
(41, 'Rántott karajszelet', 4, 0, 2800),
(42, 'Sertés Cordon Bleu', 4, 0, 2800),
(43, 'Sertés sárgadinnyével', 4, 0, 2900),
(44, 'Szecsuáni sertés', 4, 0, 2800),
(45, 'Sertés szelet sajtmártással', 4, 0, 2700),
(46, 'Sertés terrine', 4, 0, 2700),
(47, 'Madártej', 3, 1, 600),
(48, 'Gundel palacsinta', 3, 1, 800),
(49, 'Fagylaltkehely', 3, 1, 950),
(50, 'Sacher torta', 3, 1, 450),
(51, 'Somlói galuska', 3, 1, 500),
(52, 'Dobos torta', 3, 1, 500),
(53, 'Mézes zserbó', 3, 1, 300),
(54, 'Tiramisu', 3, 1, 650),
(55, 'Gesztenypüré tejszínhabbal', 3, 1, 650),
(56, 'Rákóczi túrós', 3, 1, 350),
(57, 'Nosztalgia krémes', 3, 1, 300),
(58, 'Holland krémes', 3, 1, 300);

-- --------------------------------------------------------

--
-- Table structure for table `kategoria`
--

CREATE TABLE `kategoria` (
  `id` int(10) UNSIGNED NOT NULL,
  `kategoria` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `kategoria`
--

INSERT INTO `kategoria` (`id`, `kategoria`) VALUES
(1, 'Levesek'),
(2, 'Tészták'),
(3, 'Desszertek'),
(4, 'Sertés ételek'),
(5, 'Szárnyasok'),
(6, 'Hal ételek');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `etelek`
--
ALTER TABLE `etelek`
  ADD PRIMARY KEY (`id`),
  ADD KEY `kat_id` (`kat_id`);

--
-- Indexes for table `kategoria`
--
ALTER TABLE `kategoria`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `etelek`
--
ALTER TABLE `etelek`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=59;

--
-- AUTO_INCREMENT for table `kategoria`
--
ALTER TABLE `kategoria`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `etelek`
--
ALTER TABLE `etelek`
  ADD CONSTRAINT `etelek_ibfk_1` FOREIGN KEY (`kat_id`) REFERENCES `kategoria` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
