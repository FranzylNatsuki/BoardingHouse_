-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 28, 2026 at 01:52 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `boardinghouse`
--

-- --------------------------------------------------------

--
-- Table structure for table `boarder`
--

CREATE TABLE `boarder` (
  `BoarderID` int(11) NOT NULL,
  `FirstName` varchar(15) NOT NULL,
  `LastName` varchar(15) NOT NULL,
  `ContactNo` varchar(11) NOT NULL,
  `EmergencyContactName` varchar(30) NOT NULL,
  `EmergencyContactNo` varchar(11) NOT NULL,
  `RoomID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `boarder`
--

INSERT INTO `boarder` (`BoarderID`, `FirstName`, `LastName`, `ContactNo`, `EmergencyContactName`, `EmergencyContactNo`, `RoomID`) VALUES
(1001, 'John Paul', 'Casiwan', '09678939123', 'Miguel Jumawan', '0977877563', 501),
(1002, 'Jordan', 'Steinberg', '09459302934', 'Kendrick Yamamoto', '0933864283', 502),
(1003, 'Charleston', 'Winfrey', '09568744543', 'Javier Cruz', '0956959503', 503);

-- --------------------------------------------------------

--
-- Table structure for table `facility`
--

CREATE TABLE `facility` (
  `FacilityID` int(11) NOT NULL,
  `FacilityName` varchar(15) NOT NULL,
  `FacilityCost` decimal(10,0) NOT NULL,
  `RoomID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `facility`
--

INSERT INTO `facility` (`FacilityID`, `FacilityName`, `FacilityCost`, `RoomID`) VALUES
(8001, 'Faucet', 200, 501),
(8002, 'Refrigerator', 18000, 502),
(8003, 'AC Unit', 30000, 503);

-- --------------------------------------------------------

--
-- Table structure for table `facility_request`
--

CREATE TABLE `facility_request` (
  `RequestID` int(11) NOT NULL,
  `FacilityID` int(11) DEFAULT NULL,
  `RequestDate` date NOT NULL,
  `RequestDescription` varchar(100) NOT NULL,
  `FR_BoarderID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `facility_request`
--

INSERT INTO `facility_request` (`RequestID`, `FacilityID`, `RequestDate`, `RequestDescription`, `FR_BoarderID`) VALUES
(1102, 8001, '2026-03-13', 'Pls Fix Faucet', 1001),
(1103, 8002, '2026-04-15', 'Fridge isn’t cold...', 1002),
(1104, 8003, '2026-02-28', 'AC needs cleaning', 1003);

-- --------------------------------------------------------

--
-- Table structure for table `rental_payment`
--

CREATE TABLE `rental_payment` (
  `TransactionID` int(11) NOT NULL,
  `AmountPaid` decimal(10,0) NOT NULL,
  `BillingPeriod` date NOT NULL,
  `ReceiptNo` varchar(6) NOT NULL,
  `PayMethod` varchar(15) NOT NULL,
  `PaymentDate` date NOT NULL,
  `RP_BoarderID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rental_payment`
--

INSERT INTO `rental_payment` (`TransactionID`, `AmountPaid`, `BillingPeriod`, `ReceiptNo`, `PayMethod`, `PaymentDate`, `RP_BoarderID`) VALUES
(50210, 6000, '2026-03-26', 'OR3003', 'G-Cash', '2026-01-23', 1001),
(50211, 5200, '2026-03-26', 'OR3004', 'Cash', '2026-02-10', 1002),
(50212, 5000, '2026-03-26', 'OR3005', 'Bank Transfer', '2026-02-12', 1003);

-- --------------------------------------------------------

--
-- Table structure for table `rent_termination`
--

CREATE TABLE `rent_termination` (
  `TerminationID` int(11) NOT NULL,
  `TerminationDate` date NOT NULL,
  `Deposit` decimal(10,0) NOT NULL,
  `Deductions` decimal(10,0) NOT NULL,
  `Cleared` tinyint(1) NOT NULL,
  `Remarks` varchar(100) NOT NULL,
  `RT_BoarderID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rent_termination`
--

INSERT INTO `rent_termination` (`TerminationID`, `TerminationDate`, `Deposit`, `Deductions`, `Cleared`, `Remarks`, `RT_BoarderID`) VALUES
(6412, '2027-01-25', 10000, 2000, 1, '', 1001),
(6413, '2027-03-12', 5000, 1000, 1, '', 1002),
(6414, '2027-02-15', 7500, 3500, 0, 'Follow up about his repair fine', 1003);

-- --------------------------------------------------------

--
-- Table structure for table `resident_log`
--

CREATE TABLE `resident_log` (
  `RecordID` int(11) NOT NULL,
  `LogDate` date NOT NULL,
  `TimeIn` time NOT NULL,
  `TimeOut` time NOT NULL,
  `Remarks` varchar(100) NOT NULL,
  `BoarderID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `resident_log`
--

INSERT INTO `resident_log` (`RecordID`, `LogDate`, `TimeIn`, `TimeOut`, `Remarks`, `BoarderID`) VALUES
(10005, '2026-05-23', '05:30:00', '10:32:00', 'Buying Food', 1001),
(10006, '2026-05-24', '05:40:00', '10:50:00', 'Going to school', 1002),
(10007, '2026-05-25', '05:42:00', '11:02:00', 'Drinking', 1003);

-- --------------------------------------------------------

--
-- Table structure for table `room`
--

CREATE TABLE `room` (
  `RoomID` int(11) NOT NULL,
  `RoomNo` int(11) NOT NULL,
  `RoomType` varchar(15) NOT NULL,
  `MonthlyRate` decimal(10,0) NOT NULL,
  `Capacity` int(11) NOT NULL,
  `Occupying` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `room`
--

INSERT INTO `room` (`RoomID`, `RoomNo`, `RoomType`, `MonthlyRate`, `Capacity`, `Occupying`) VALUES
(501, 4, 'Single Room', 6000, 1, 1),
(502, 5, 'Loft', 6000, 2, 1),
(503, 6, 'Shared Room', 5000, 3, 1);

-- --------------------------------------------------------

--
-- Table structure for table `utility`
--

CREATE TABLE `utility` (
  `UtilityID` int(3) NOT NULL,
  `UtilityName` varchar(15) NOT NULL,
  `UnitRate` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `utility`
--

INSERT INTO `utility` (`UtilityID`, `UtilityName`, `UnitRate`) VALUES
(2211, 'Water', 61),
(2212, 'Electricity', 14),
(2213, 'LPG', 40);

-- --------------------------------------------------------

--
-- Table structure for table `utility_payment`
--

CREATE TABLE `utility_payment` (
  `UtilityPayID` int(11) NOT NULL,
  `UtilityID` int(11) DEFAULT NULL,
  `UP_BoarderID` int(11) DEFAULT NULL,
  `PaymentDate` date NOT NULL,
  `Usage_` decimal(10,0) NOT NULL,
  `AmountToPay` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `utility_payment`
--

INSERT INTO `utility_payment` (`UtilityPayID`, `UtilityID`, `UP_BoarderID`, `PaymentDate`, `Usage_`, `AmountToPay`) VALUES
(1001, 2211, 1001, '2026-01-01', 3, 0),
(1002, 2212, 1001, '2026-01-03', 24, 0),
(1003, 2213, 1003, '2026-03-02', 26, 1040);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `boarder`
--
ALTER TABLE `boarder`
  ADD PRIMARY KEY (`BoarderID`),
  ADD KEY `RoomID` (`RoomID`);

--
-- Indexes for table `facility`
--
ALTER TABLE `facility`
  ADD PRIMARY KEY (`FacilityID`);

--
-- Indexes for table `facility_request`
--
ALTER TABLE `facility_request`
  ADD PRIMARY KEY (`RequestID`),
  ADD KEY `FacilityID` (`FacilityID`),
  ADD KEY `facility_request_ibfk_1` (`FR_BoarderID`);

--
-- Indexes for table `rental_payment`
--
ALTER TABLE `rental_payment`
  ADD PRIMARY KEY (`TransactionID`),
  ADD KEY `RP_BoarderID` (`RP_BoarderID`);

--
-- Indexes for table `rent_termination`
--
ALTER TABLE `rent_termination`
  ADD PRIMARY KEY (`TerminationID`),
  ADD KEY `RT_BoarderID` (`RT_BoarderID`);

--
-- Indexes for table `resident_log`
--
ALTER TABLE `resident_log`
  ADD PRIMARY KEY (`RecordID`),
  ADD KEY `BoarderID` (`BoarderID`);

--
-- Indexes for table `room`
--
ALTER TABLE `room`
  ADD PRIMARY KEY (`RoomID`);

--
-- Indexes for table `utility`
--
ALTER TABLE `utility`
  ADD PRIMARY KEY (`UtilityID`);

--
-- Indexes for table `utility_payment`
--
ALTER TABLE `utility_payment`
  ADD PRIMARY KEY (`UtilityPayID`),
  ADD KEY `UtilityID` (`UtilityID`),
  ADD KEY `UP_BoarderID` (`UP_BoarderID`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `boarder`
--
ALTER TABLE `boarder`
  ADD CONSTRAINT `RoomID` FOREIGN KEY (`RoomID`) REFERENCES `room` (`RoomID`) ON DELETE SET NULL ON UPDATE SET NULL;

--
-- Constraints for table `facility_request`
--
ALTER TABLE `facility_request`
  ADD CONSTRAINT `FacilityID` FOREIGN KEY (`FacilityID`) REFERENCES `facility` (`FacilityID`) ON DELETE SET NULL ON UPDATE SET NULL,
  ADD CONSTRAINT `facility_request_ibfk_1` FOREIGN KEY (`FR_BoarderID`) REFERENCES `boarder` (`BoarderID`) ON DELETE SET NULL ON UPDATE SET NULL;

--
-- Constraints for table `rental_payment`
--
ALTER TABLE `rental_payment`
  ADD CONSTRAINT `RP_BoarderID` FOREIGN KEY (`RP_BoarderID`) REFERENCES `boarder` (`BoarderID`) ON DELETE SET NULL ON UPDATE SET NULL;

--
-- Constraints for table `rent_termination`
--
ALTER TABLE `rent_termination`
  ADD CONSTRAINT `RT_BoarderID` FOREIGN KEY (`RT_BoarderID`) REFERENCES `boarder` (`BoarderID`) ON DELETE SET NULL ON UPDATE SET NULL;

--
-- Constraints for table `resident_log`
--
ALTER TABLE `resident_log`
  ADD CONSTRAINT `BoarderID` FOREIGN KEY (`BoarderID`) REFERENCES `boarder` (`BoarderID`) ON DELETE SET NULL ON UPDATE SET NULL;

--
-- Constraints for table `utility_payment`
--
ALTER TABLE `utility_payment`
  ADD CONSTRAINT `UP_BoarderID` FOREIGN KEY (`UP_BoarderID`) REFERENCES `boarder` (`BoarderID`) ON DELETE SET NULL ON UPDATE SET NULL,
  ADD CONSTRAINT `UtilityID` FOREIGN KEY (`UtilityID`) REFERENCES `utility` (`UtilityID`) ON DELETE SET NULL ON UPDATE SET NULL;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
