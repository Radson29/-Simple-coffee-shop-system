-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3308
-- Czas generowania: 06 Lut 2022, 19:32
-- Wersja serwera: 10.4.11-MariaDB
-- Wersja PHP: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `kawiarnia`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `produkty`
--

CREATE TABLE `produkty` (
  `Id_produktu` int(11) NOT NULL,
  `Nazwa` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `Kategoria` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `Cena` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Zrzut danych tabeli `produkty`
--

INSERT INTO `produkty` (`Id_produktu`, `Nazwa`, `Kategoria`, `Cena`) VALUES
(1, 'Late', 'Kawy', 8),
(2, 'Espresso', 'Kawy', 6),
(3, 'Tiramisu', 'Ciasta', 16),
(4, 'Cola', 'Soki i napoje', 7),
(6, 'Włoskie', 'Lody', 6),
(18, 'Americano', 'Kawy', 6),
(19, 'Cappuccino', 'Kawy', 6),
(20, 'Parzona', 'Kawy', 5),
(21, 'Rozpuszczalna', 'Kawy', 4),
(22, 'Szarlotka', 'Ciasta', 11),
(23, 'Wuzetka', 'Ciasta', 11),
(24, 'Sernik', 'Ciasta', 13),
(25, 'Gałkowe', 'Lody', 4),
(26, 'Świderki', 'Lody', 4),
(27, 'Popcorn', 'Przekąski', 8),
(28, 'Nachosy', 'Przekąski', 10),
(29, 'Woda', 'Soki i napoje', 5),
(30, 'Fanta', 'Soki i napoje', 7),
(31, 'Lipton', 'Soki i napoje', 5),
(32, 'Soki', 'Soki i napoje', 3);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `zamowienia`
--

CREATE TABLE `zamowienia` (
  `Id_zamowienia` int(11) NOT NULL,
  `Suma` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Zrzut danych tabeli `zamowienia`
--

INSERT INTO `zamowienia` (`Id_zamowienia`, `Suma`) VALUES
(1, 22),
(2, 14),
(4, 136),
(5, 42),
(6, 120),
(8, 72),
(9, 24),
(10, 32),
(11, 40),
(12, 28);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `zamowienia_produkty`
--

CREATE TABLE `zamowienia_produkty` (
  `Id_zam_prod` int(11) NOT NULL,
  `Id_zamowienia` int(11) NOT NULL,
  `Id_produktu` int(11) NOT NULL,
  `Ilosc` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Zrzut danych tabeli `zamowienia_produkty`
--

INSERT INTO `zamowienia_produkty` (`Id_zam_prod`, `Id_zamowienia`, `Id_produktu`, `Ilosc`) VALUES
(1, 2, 1, 1),
(2, 2, 4, 2),
(6, 5, 2, 1),
(7, 8, 1, 5),
(8, 8, 3, 2),
(9, 9, 6, 3),
(10, 9, 4, 2),
(12, 11, 1, 2),
(13, 11, 2, 4),
(14, 12, 2, 2),
(15, 12, 1, 2);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `produkty`
--
ALTER TABLE `produkty`
  ADD PRIMARY KEY (`Id_produktu`);

--
-- Indeksy dla tabeli `zamowienia`
--
ALTER TABLE `zamowienia`
  ADD PRIMARY KEY (`Id_zamowienia`);

--
-- Indeksy dla tabeli `zamowienia_produkty`
--
ALTER TABLE `zamowienia_produkty`
  ADD PRIMARY KEY (`Id_zam_prod`),
  ADD KEY `Id_produktu` (`Id_produktu`),
  ADD KEY `Id_zamowienia` (`Id_zamowienia`);

--
-- AUTO_INCREMENT dla tabel zrzutów
--

--
-- AUTO_INCREMENT dla tabeli `produkty`
--
ALTER TABLE `produkty`
  MODIFY `Id_produktu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT dla tabeli `zamowienia`
--
ALTER TABLE `zamowienia`
  MODIFY `Id_zamowienia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT dla tabeli `zamowienia_produkty`
--
ALTER TABLE `zamowienia_produkty`
  MODIFY `Id_zam_prod` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `zamowienia_produkty`
--
ALTER TABLE `zamowienia_produkty`
  ADD CONSTRAINT `zamowienia_produkty_ibfk_1` FOREIGN KEY (`Id_produktu`) REFERENCES `produkty` (`Id_produktu`),
  ADD CONSTRAINT `zamowienia_produkty_ibfk_2` FOREIGN KEY (`Id_zamowienia`) REFERENCES `zamowienia` (`Id_zamowienia`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
