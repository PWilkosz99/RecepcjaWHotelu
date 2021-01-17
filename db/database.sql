-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 17 Sty 2021, 22:42
-- Wersja serwera: 10.1.29-MariaDB
-- Wersja PHP: 7.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `recepcja`
--
CREATE DATABASE IF NOT EXISTS `recepcja` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `recepcja`;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `rachunek`
--

DROP TABLE IF EXISTS `rachunek`;
CREATE TABLE `rachunek` (
  `id` int(11) NOT NULL,
  `wielkosc` int(11) NOT NULL,
  `czyuregulowano` tinyint(1) NOT NULL,
  `metoda` char(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `rezerwacja`
--

DROP TABLE IF EXISTS `rezerwacja`;
CREATE TABLE `rezerwacja` (
  `id` bigint(20) NOT NULL,
  `dataod` text NOT NULL,
  `datado` text NOT NULL,
  `iloscosob` int(11) NOT NULL,
  `czyparking` tinyint(1) NOT NULL,
  `czyjedzenie` tinyint(1) NOT NULL,
  `czyspa` tinyint(1) NOT NULL,
  `czysilownia` tinyint(1) NOT NULL,
  `imie` text NOT NULL,
  `nazwisko` text NOT NULL,
  `nrtelefonu` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `stats`
--

DROP TABLE IF EXISTS `stats`;
CREATE TABLE `stats` (
  `date` text NOT NULL,
  `counter` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `login` text,
  `password` text NOT NULL,
  `imie` text NOT NULL,
  `nazwisko` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Zrzut danych tabeli `users`
--

INSERT INTO `users` (`id`, `login`, `password`, `imie`, `nazwisko`) VALUES
(1, 'admin', 'ISMvKXpXpadDiUoOSoAfww==', 'Admin', 'Admin');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `wykluczone`
--

DROP TABLE IF EXISTS `wykluczone`;
CREATE TABLE `wykluczone` (
  `id` int(11) NOT NULL,
  `powod` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `zakwaterowanie`
--

DROP TABLE IF EXISTS `zakwaterowanie`;
CREATE TABLE `zakwaterowanie` (
  `nrezerwacji` int(11) NOT NULL,
  `npokoju` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indeksy dla zrzutów tabel
--

--
-- Indexes for table `rezerwacja`
--
ALTER TABLE `rezerwacja`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `zakwaterowanie`
--
ALTER TABLE `zakwaterowanie`
  ADD PRIMARY KEY (`nrezerwacji`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
