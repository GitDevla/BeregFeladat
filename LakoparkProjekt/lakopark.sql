-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Jan 23. 09:14
-- Kiszolgáló verziója: 10.4.22-MariaDB
-- PHP verzió: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `lakopark`
--
CREATE DATABASE IF NOT EXISTS `lakopark` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;
USE `lakopark`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `haz`
--

CREATE TABLE `haz` (
  `ID` int(10) UNSIGNED NOT NULL,
  `LakoparkID` int(10) UNSIGNED NOT NULL,
  `Utca` int(10) UNSIGNED NOT NULL,
  `HázSzám` int(10) UNSIGNED NOT NULL,
  `Méret` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `haz`
--

INSERT INTO `haz` (`ID`, `LakoparkID`, `Utca`, `HázSzám`, `Méret`) VALUES
(1, 1, 0, 1, 1),
(2, 1, 0, 2, 1),
(3, 1, 0, 5, 3),
(4, 1, 0, 6, 1),
(5, 1, 1, 1, 1),
(6, 1, 1, 2, 2),
(7, 1, 1, 5, 2),
(8, 1, 1, 7, 2),
(9, 1, 2, 1, 1),
(10, 1, 2, 2, 3),
(11, 1, 2, 3, 1),
(12, 1, 2, 4, 3),
(13, 1, 2, 5, 2),
(14, 1, 2, 6, 1),
(15, 1, 2, 7, 1),
(16, 1, 3, 2, 2),
(17, 1, 3, 4, 3),
(18, 1, 3, 5, 2),
(19, 1, 3, 7, 3),
(20, 1, 3, 8, 3),
(21, 1, 4, 0, 1),
(22, 1, 4, 3, 1),
(23, 1, 4, 6, 1),
(24, 1, 4, 7, 3),
(25, 2, 0, 0, 1),
(26, 2, 0, 2, 3),
(27, 2, 0, 4, 2),
(28, 2, 1, 0, 3),
(29, 2, 1, 2, 3),
(30, 2, 1, 3, 3),
(31, 2, 1, 4, 2),
(32, 2, 2, 0, 1),
(33, 2, 2, 1, 3),
(34, 2, 2, 4, 2),
(35, 3, 0, 1, 3),
(36, 3, 0, 2, 1),
(37, 3, 0, 6, 3),
(38, 3, 1, 0, 2),
(39, 3, 1, 1, 2),
(40, 3, 1, 2, 3),
(41, 3, 1, 6, 2),
(42, 3, 2, 1, 1),
(43, 3, 2, 4, 1),
(44, 3, 2, 5, 1),
(45, 3, 2, 6, 3),
(46, 3, 3, 0, 2),
(47, 3, 3, 1, 3),
(48, 3, 3, 2, 2),
(49, 3, 3, 4, 3),
(50, 3, 3, 5, 3);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `lakopark`
--

CREATE TABLE `lakopark` (
  `ID` int(10) UNSIGNED NOT NULL,
  `Nev` varchar(255) NOT NULL,
  `UtcakSzama` int(10) UNSIGNED NOT NULL,
  `MaxHázakSzáma` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `lakopark`
--

INSERT INTO `lakopark` (`ID`, `Nev`, `UtcakSzama`, `MaxHázakSzáma`) VALUES
(1, 'Puskás Ferenc', 5, 10),
(2, 'Van Gogh', 3, 5),
(3, 'Vivaldi', 4, 7);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `haz`
--
ALTER TABLE `haz`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `LakoparkID` (`LakoparkID`);

--
-- A tábla indexei `lakopark`
--
ALTER TABLE `lakopark`
  ADD PRIMARY KEY (`ID`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `haz`
--
ALTER TABLE `haz`
  MODIFY `ID` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT a táblához `lakopark`
--
ALTER TABLE `lakopark`
  MODIFY `ID` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `haz`
--
ALTER TABLE `haz`
  ADD CONSTRAINT `haz_ibfk_1` FOREIGN KEY (`LakoparkID`) REFERENCES `lakopark` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
