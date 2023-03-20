-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Már 20. 09:14
-- Kiszolgáló verziója: 10.4.6-MariaDB
-- PHP verzió: 7.3.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `fozde`
--
CREATE DATABASE IF NOT EXISTS `fozde` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `fozde`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `bejelentkezes`
--

CREATE TABLE `bejelentkezes` (
  `id` int(11) NOT NULL,
  `nev` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `jelszo` varchar(64) COLLATE utf8_hungarian_ci NOT NULL,
  `jogosultsag` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `bejelentkezes`
--

INSERT INTO `bejelentkezes` (`id`, `nev`, `jelszo`, `jogosultsag`) VALUES
(1, 'Dávid', 'Szellem', 0),
(2, 'Zsolt', 'Béla', 1),
(3, 'Balázs', 'Miceh', 2);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `mertekegysegek`
--

CREATE TABLE `mertekegysegek` (
  `ID` int(11) NOT NULL,
  `egysegnev` varchar(5) COLLATE utf8_hungarian_ci NOT NULL,
  `mennyiseg` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `mertekegysegek`
--

INSERT INTO `mertekegysegek` (`ID`, `egysegnev`, `mennyiseg`) VALUES
(1, 'liter', 1),
(2, 'hordó', 100),
(3, 'decis', 0.1),
(7, 'Rekes', 6),
(8, 'János', 10),
(9, 'isz', 1000);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `termekegysegek`
--

CREATE TABLE `termekegysegek` (
  `ID` int(11) NOT NULL,
  `termekID` int(11) NOT NULL,
  `mertekID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `termekegysegek`
--

INSERT INTO `termekegysegek` (`ID`, `termekID`, `mertekID`) VALUES
(1, 1, 1),
(2, 1, 3),
(3, 2, 2),
(4, 2, 1),
(5, 3, 7),
(6, 3, 3),
(9, 5, 3),
(10, 5, 3),
(11, 6, 1),
(13, 7, 2),
(14, 7, 2),
(16, 8, 3),
(17, 9, 1),
(19, 10, 2),
(20, 10, 1),
(21, 11, 1),
(22, 11, 3),
(23, 12, 1),
(25, 13, 1),
(26, 13, 7),
(27, 14, 7),
(28, 15, 2),
(29, 16, 3),
(30, 17, 2),
(31, 18, 2),
(33, 20, 1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `termekek`
--

CREATE TABLE `termekek` (
  `id` int(11) NOT NULL,
  `nev` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `evjarat` varchar(4) COLLATE utf8_hungarian_ci NOT NULL,
  `erosseg` float(3,1) NOT NULL,
  `literar` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `termekek`
--

INSERT INTO `termekek` (`id`, `nev`, `evjarat`, `erosseg`, `literar`) VALUES
(1, 'Füge', '2021', 66.0, 7000),
(2, 'FÜge', '2021', 66.0, 7000),
(3, 'FUge', '2010', 67.0, 5000),
(4, 'Füge', '2021', 66.0, 7000),
(5, 'Nem füge', '2000', 66.0, 7000),
(6, 'Füge', '2021', 66.0, 7000),
(7, 'Fuge', '2021', 66.0, 7000),
(8, 'Füge', '2021', 66.0, 7000),
(9, 'Füge', '2021', 66.0, 7000),
(10, 'Füge', '2021', 66.0, 7000),
(11, 'Füge', '2021', 66.0, 7000),
(12, 'Füge', '2021', 66.0, 7000),
(13, 'Füge', '2021', 66.0, 7000),
(14, 'Fuege', '2000', 66.0, 7000),
(15, 'János', '2005', 65.0, 650),
(16, 'Nem Zsolt', '1999', 57.0, 7333),
(17, 'Füge', '2001', 56.0, 400),
(18, 'Termék', '206', 70.0, 550),
(19, 'Biztosan nem füge', '2010', 50.0, 6000),
(20, 'Finomka', '2000', 80.0, 2500);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `bejelentkezes`
--
ALTER TABLE `bejelentkezes`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `mertekegysegek`
--
ALTER TABLE `mertekegysegek`
  ADD PRIMARY KEY (`ID`);

--
-- A tábla indexei `termekegysegek`
--
ALTER TABLE `termekegysegek`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `termekID` (`termekID`),
  ADD KEY `mertekID` (`mertekID`);

--
-- A tábla indexei `termekek`
--
ALTER TABLE `termekek`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `bejelentkezes`
--
ALTER TABLE `bejelentkezes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT a táblához `mertekegysegek`
--
ALTER TABLE `mertekegysegek`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT a táblához `termekegysegek`
--
ALTER TABLE `termekegysegek`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT a táblához `termekek`
--
ALTER TABLE `termekek`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `termekegysegek`
--
ALTER TABLE `termekegysegek`
  ADD CONSTRAINT `termekegysegek_ibfk_1` FOREIGN KEY (`termekID`) REFERENCES `termekek` (`id`),
  ADD CONSTRAINT `termekegysegek_ibfk_2` FOREIGN KEY (`mertekID`) REFERENCES `mertekegysegek` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
