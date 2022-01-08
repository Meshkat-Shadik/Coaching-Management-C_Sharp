-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 08, 2022 at 02:19 PM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 8.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
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
(4, 'unknown', 'English=4000', '01777277015', 4000, 'unknown1602058@gmail.com'),
(7, 'shadik', 'Math=5000', '01777277015', 5000, 'shadikmeshkat328@gmail.com'),
(8, 'shadik', 'Math=5000', '01777277015', 5000, 'shadikmeshkat328@gmail.com'),
(8955226, 'Hasan', 'Math=5000', '01777277015', 5000, 'sumoon14@cse.pstu.ac.bd'),
(21260947, 'Hasan', 'Math=5000', '01777277015', 7000, 'sumoon14@cse.pstu.ac.bd');

-- --------------------------------------------------------

--
-- Table structure for table `result`
--

CREATE TABLE `result` (
  `Id` int(10) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `Class` varchar(20) NOT NULL,
  `Bangla` varchar(20) NOT NULL,
  `English` varchar(20) NOT NULL,
  `Math` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `result`
--

INSERT INTO `result` (`Id`, `Name`, `Class`, `Bangla`, `English`, `Math`) VALUES
(4, 'Hasan', 'Class11', '', '', '75');

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
(1, 'shadik', 'Class12', 'july-December', 'shadikmeshkat328@gmail.com', 'PSTU', 'Khulna', '+8801794896487', '+8801794896487', '12345'),
(3, 'Shadik Faysal', 'Class11', 'july-December', 'shadikmeshkat328@gmail.com', 'PSTU', 'bogra', '01794896487', '01794896487', '1234'),
(4, 'Hasan', 'Class11', 'January-june', 'sumoon14@cse.pstu.ac.bd', 'PSTU', 'Sylhet', '01794896487', '01794896487', '1234');

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
-- Dumping data for table `teacher_registration`
--

INSERT INTO `teacher_registration` (`Id`, `Name`, `Subject`, `Qualification`, `Email`, `Address`, `Password`) VALUES
(1, 'sumon', 'Math', 'Honours', 'sumooncse@gmail.com', 'Sylhet', '1234');

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
-- AUTO_INCREMENT for table `student_registration`
--
ALTER TABLE `student_registration`
  MODIFY `Id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `teacher_registration`
--
ALTER TABLE `teacher_registration`
  MODIFY `Id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
