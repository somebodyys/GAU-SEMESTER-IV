-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 16, 2021 at 12:54 PM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mydata`
--

-- --------------------------------------------------------

--
-- Table structure for table `data`
--

CREATE TABLE `data` (
  `Id` int(11) NOT NULL,
  `Title` varchar(30) NOT NULL,
  `Date` date NOT NULL,
  `Type` varchar(30) NOT NULL,
  `Photo` varchar(50) NOT NULL,
  `Text` text DEFAULT NULL,
  `Author` varchar(30) DEFAULT NULL,
  `Description` varchar(200) DEFAULT NULL,
  `Meta_k` varchar(200) NOT NULL,
  `Meta_d` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `data`
--

INSERT INTO `data` (`Id`, `Title`, `Date`, `Type`, `Photo`, `Text`, `Author`, `Description`, `Meta_k`, `Meta_d`) VALUES
(1, 'Titel', '2021-04-15', 'asdasd', 'Storage/Tornike.jpg', 'asdasd', 'auth', 'desc', 'k', 'd'),
(2, 'Data2', '2021-04-14', '2', 'Storage/Tornike.jpg', 'Something', 'tornike', 'this is best data', 'my  data', 'data 2 desc'),
(3, 'Someting', '2021-04-02', 'beSt', 'Storage/Tornike.jpg', 'something text', 'father', 'my sesc', 'meta key som', 'desc'),
(4, 'my Title', '2021-04-20', 'my Best', 'Storage/Tornike.jpg', 'aeubfaubdiae', 'The author', 'My Title Desc', 'Meta Key', 'Meta d'),
(5, 'the good', '2021-04-11', 'bad', 'Storage/Tornike.jpg', 'my number', 'jora', 'mydesc', 'aab', 'ujnsd'),
(6, 'Umbra', '2021-04-16', 'Something', 'Storage/Tornike.jpg', 'it is text', 'it is author', 'adeas', 'keyyys', 'desccs'),
(7, 'It is the best', '2021-04-17', 'asdawdasd', 'Storage/Tornike.jpg', 'It is text', 'aau', 'inaiendeai', 'asdadae', 'adead'),
(8, 'WHy are you here?', '2021-04-08', 'my type', 'Storage/Tornike.jpg', 'asdaedae', 'auth', 'adeeknd', 'adnednae', 'asde'),
(9, 'It is the best ', '2021-04-10', 'asdaedae', 'Storage/Tornike.jpg', 'aaaaaa', 'adeada', 'edaedaed', 'aedaed', 'aedaed'),
(10, 'Where are you?', '2021-04-16', 'aded', 'Storage/Tornike.jpg', 'All ab', 'aed', 'ee', 'a', 'd'),
(11, 'All about covid', '2021-05-03', 'aedaed', 'Storage/Tornike.jpg', 'aedaedae', 'awd', 'daed', 'aeda', 'aed'),
(12, 'The alst', '2021-04-12', 'asdaed', 'Storage/Tornike.jpg', 'aaaa', 'eded', 'a', 'ed', 'aed'),
(13, 'Somthing', '2021-03-31', 'adedae', 'Storage/Tornike.jpg', 'aedaed', 'aed', 'aed', 'aed', 'aed'),
(14, ' სატესტო', '2021-04-19', '2', 'Storage/Tornike.jpg', 'ასდაედაე', 'ად', 'ასდაედ', 'აწდა', 'ედაედ');

-- --------------------------------------------------------

--
-- Table structure for table `menu`
--

CREATE TABLE `menu` (
  `Id` int(11) NOT NULL,
  `Title` varchar(50) NOT NULL,
  `Meta_k` varchar(200) NOT NULL,
  `Meta_d` varchar(200) NOT NULL,
  `Text` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `menu`
--

INSERT INTO `menu` (`Id`, `Title`, `Meta_k`, `Meta_d`, `Text`) VALUES
(2, 'Tab1', 'tab1 Key', 'tab1 desc', 'text about tag 1'),
(3, 'Tab 2', 'Tab 2 key', 'Tab 2 Desc', 'Text About Tab 2'),
(4, 'Tab 3 ', 'Tab 3 key', 'Tab 3 desc', 'Tab 3  text'),
(5, 'Tab 4 ', 'Tab 4 key', 'Tab 4 desc', 'Tab 4 text'),
(6, 'Tab 5', 'Tab 5 key', 'Tab 5 Desc ', 'Tab 5 Text'),
(7, 'ფილმები', 'მეტა გასაღები', 'მეტა აღწერილობა', 'ტექსტი'),
(8, 'თამაშები', 'თამაშების გასაღები', 'აღწერილობა', 'ინფორმცია'),
(9, 'მუსიკები', 'მუსიკების გასაღები ', 'აღწერილობა', 'ინფორმაცია');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `Id` int(11) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `Lastname` varchar(30) NOT NULL,
  `Age` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Red_Date` date NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Gender` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`Id`, `Name`, `Lastname`, `Age`, `Date`, `Red_Date`, `Password`, `Gender`) VALUES
(1, 'Tornike', 'Kikacheishvili', 23, '1997-10-27', '2021-04-29', 'Test', 'Male'),
(2, 'Dato', 'Datashvili', 22, '2021-04-04', '2021-04-29', 'asdawdasdawd', 'Male'),
(3, 'Nino', 'NIniashvili', 59, '2021-04-05', '2021-04-29', 'awdasdawdawda', 'Female'),
(4, 'Marta', 'amartashvilidze', 55, '2021-04-02', '2021-04-29', 'aadwdawdwdasd', 'Female'),
(6, 'Ninea ', 'anasovi', 23, '2021-04-12', '2021-04-29', 'Ninea', 'Female');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `data`
--
ALTER TABLE `data`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `data`
--
ALTER TABLE `data`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `menu`
--
ALTER TABLE `menu`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
