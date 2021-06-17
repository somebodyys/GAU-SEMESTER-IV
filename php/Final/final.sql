-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 16, 2021 at 04:22 PM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 8.0.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cv`
--

-- --------------------------------------------------------

--
-- Table structure for table `aplicants`
--

CREATE TABLE `aplicants` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `private_id` varchar(11) NOT NULL,
  `password` varchar(50) NOT NULL,
  `registered` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `aplicants`
--

INSERT INTO `aplicants` (`id`, `name`, `private_id`, `password`, `registered`) VALUES
(1, 'test2', '11111111111', 'asdasd', '2021-06-09'),
(4, 'asdasd', '11111111111', 'adads', '2021-06-16'),
(5, 'asdasd', '11111111112', 'asdasdasd', '2021-06-16'),
(6, 'asdasd', '13222222222', 'asdasdasd', '2021-06-16');

-- --------------------------------------------------------

--
-- Table structure for table `cvs`
--

CREATE TABLE `cvs` (
  `id` int(11) NOT NULL,
  `contact` text NOT NULL,
  `education` text NOT NULL,
  `workExp` text NOT NULL,
  `aplicant_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cvs`
--

INSERT INTO `cvs` (`id`, `contact`, `education`, `workExp`, `aplicant_id`) VALUES
(1, 'testa', 'asdasd', 'asdasd', 1),
(2, 'asdasd', 'asdasd', 'asdasd', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `aplicants`
--
ALTER TABLE `aplicants`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `cvs`
--
ALTER TABLE `cvs`
  ADD PRIMARY KEY (`id`),
  ADD KEY `connection` (`aplicant_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `aplicants`
--
ALTER TABLE `aplicants`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `cvs`
--
ALTER TABLE `cvs`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `cvs`
--
ALTER TABLE `cvs`
  ADD CONSTRAINT `connection` FOREIGN KEY (`aplicant_id`) REFERENCES `aplicants` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
