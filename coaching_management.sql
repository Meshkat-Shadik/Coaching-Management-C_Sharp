-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 15, 2019 at 05:25 PM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.3.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `coaching_management`
--

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `Transaction_id` int(11) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `Course` varchar(40) NOT NULL,
  `Number` varchar(50) NOT NULL,
  `Amount` int(10) NOT NULL,
  `Email` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `payment`
--

INSERT INTO `payment` (`Transaction_id`, `Name`, `Course`, `Number`, `Amount`, `Email`) VALUES
(3, 'shadik', 'Bangla=3000', '01777277015', 3000, 'shadikmeshkat328@gmail.com'),
(4, 'unknown', 'English=4000', '01777277015', 4000, 'unknown1602058@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `student_registration`
--

CREATE TABLE `student_registration` (
  `Id` int(10) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `Class` varchar(40) NOT NULL,
  `Course_session` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Name_of_institution` varchar(50) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Contact_no` varchar(50) NOT NULL,
  `Guardian_contact_no` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `student_registration`
--

INSERT INTO `student_registration` (`Id`, `Name`, `Class`, `Course_session`, `Email`, `Name_of_institution`, `Address`, `Contact_no`, `Guardian_contact_no`, `Password`) VALUES
(1, 'shadik', 'Class12', 'july-December', 'shadikmeshkat328@gmail.com', 'PSTU', 'Khulna', '+8801794896487', '+8801794896487', '12345');

-- --------------------------------------------------------

--
-- Table structure for table `teacher_registration`
--

CREATE TABLE `teacher_registration` (
  `Id` int(10) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `Subject` varchar(40) NOT NULL,
  `Qualification` varchar(50) NOT NULL,
  `Email` varchar(40) NOT NULL,
  `Address` varchar(30) NOT NULL,
  `Password` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`Transaction_id`);

--
-- Indexes for table `student_registration`
--
ALTER TABLE `student_registration`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `teacher_registration`
--
ALTER TABLE `teacher_registration`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `payment`
--
ALTER TABLE `payment`
  MODIFY `Transaction_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `student_registration`
--
ALTER TABLE `student_registration`
  MODIFY `Id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `teacher_registration`
--
ALTER TABLE `teacher_registration`
  MODIFY `Id` int(10) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
