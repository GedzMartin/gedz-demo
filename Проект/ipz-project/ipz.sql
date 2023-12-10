-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Dec 05, 2021 at 05:28 PM
-- Server version: 5.7.24
-- PHP Version: 7.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ipz`
--

-- --------------------------------------------------------

--
-- Table structure for table `admins`
--

CREATE TABLE `admins` (
  `id` int(11) NOT NULL,
  `name` varchar(10) NOT NULL,
  `surname` varchar(10) NOT NULL,
  `login` varchar(15) NOT NULL,
  `password` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `admins`
--

INSERT INTO `admins` (`id`, `name`, `surname`, `login`, `password`) VALUES
(1, 'Dmytro', 'Denys', 'denysd', '1234');

-- --------------------------------------------------------

--
-- Table structure for table `atmcapacity`
--

CREATE TABLE `atmcapacity` (
  `atm` varchar(10) NOT NULL,
  `currentuah` int(11) DEFAULT NULL,
  `currenteur` int(11) DEFAULT NULL,
  `currentusd` int(11) DEFAULT NULL,
  `maxuah` int(11) NOT NULL,
  `maxeur` int(11) NOT NULL,
  `maxusd` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `atmcapacity`
--

INSERT INTO `atmcapacity` (`atm`, `currentuah`, `currenteur`, `currentusd`, `maxuah`, `maxeur`, `maxusd`) VALUES
('main', 6000, 1700, 4400, 50000, 5000, 5000);

-- --------------------------------------------------------

--
-- Table structure for table `clients`
--

CREATE TABLE `clients` (
  `id` int(11) UNSIGNED NOT NULL,
  `clientname` varchar(15) CHARACTER SET utf8 NOT NULL,
  `clientsurname` varchar(15) CHARACTER SET utf8 NOT NULL,
  `phonenumber` varchar(10) CHARACTER SET utf8 NOT NULL,
  `pincode` varchar(4) CHARACTER SET utf8 NOT NULL,
  `balanceuah` int(10) UNSIGNED DEFAULT NULL,
  `balanceeur` int(10) UNSIGNED DEFAULT NULL,
  `balanceusd` int(10) UNSIGNED DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf32;

--
-- Dumping data for table `clients`
--

INSERT INTO `clients` (`id`, `clientname`, `clientsurname`, `phonenumber`, `pincode`, `balanceuah`, `balanceeur`, `balanceusd`) VALUES
(1, 'SERHI', 'VASYLENKOI', '0672791090', '1111', 4678, 0, 1548),
(2, 'RUSLAN', 'ROMANCHENKO', '0991843195', '9999', 670, 150, 1214),
(3, 'VLADYSLAV', 'KRAMARCHUK', '0506088432', '9999', 5400, 900, 200),
(4, 'OKSANA', 'KRAVCHENKO', '0808186937', '1111', 1400, 2500, 1450);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admins`
--
ALTER TABLE `admins`
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `atmcapacity`
--
ALTER TABLE `atmcapacity`
  ADD PRIMARY KEY (`atm`);

--
-- Indexes for table `clients`
--
ALTER TABLE `clients`
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admins`
--
ALTER TABLE `admins`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `clients`
--
ALTER TABLE `clients`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
