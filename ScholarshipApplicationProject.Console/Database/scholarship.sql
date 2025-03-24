-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2025. Már 24. 18:59
-- Kiszolgáló verziója: 10.4.28-MariaDB
-- PHP verzió: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `scholarship`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `scholarship`
--

CREATE TABLE `scholarship` (
  `email` varchar(19) NOT NULL,
  `name` varchar(13) DEFAULT NULL,
  `amount` int(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- A tábla adatainak kiíratása `scholarship`
--

INSERT INTO `scholarship` (`email`, `name`, `amount`) VALUES
('alice@example.com', 'Alice Johnson', 1500),
('bob@example.com', 'Bob Smith', 2000),
('charlie@example.com', 'Charlie Brown', 1800),
('diana@example.com', 'Diana White', 2200);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `scholarship`
--
ALTER TABLE `scholarship`
  ADD PRIMARY KEY (`email`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
