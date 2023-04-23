-- phpMyAdmin SQL Dump
-- version 4.6.6deb5ubuntu0.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Nov 30, 2021 at 01:59 AM
-- Server version: 5.7.36-0ubuntu0.18.04.1
-- PHP Version: 7.2.31-1+ubuntu18.04.1+deb.sury.org+1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `projectcorona`
--

-- --------------------------------------------------------

--
-- Table structure for table `Citoyen`
--

CREATE TABLE `Citoyen` (
  `Cin` varchar(8) NOT NULL,
  `NomEtPrenom` varchar(40) NOT NULL,
  `DateDeNaissance` date NOT NULL,
  `NumeroDeTelephone` int(11) NOT NULL,
  `CodeCouleur` varchar(25) NOT NULL DEFAULT 'Green',
  `Adresse` text NOT NULL,
  `Vaccin` tinyint(1) DEFAULT '0',
  `Frequente` tinyint(1) DEFAULT '0',
  `Patient` tinyint(1) NOT NULL DEFAULT '0',
  `Encontact` tinyint(1) DEFAULT '0',
  `testcorona` tinyint(1) DEFAULT '0',
  `symptomatic` tinyint(1) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Citoyen`
--

INSERT INTO `Citoyen` (`Cin`, `NomEtPrenom`, `DateDeNaissance`, `NumeroDeTelephone`, `CodeCouleur`, `Adresse`, `Vaccin`, `Frequente`, `Patient`, `Encontact`, `testcorona`, `symptomatic`) VALUES
('CD122222', 'AMAADOR  SSSS', '2004-06-09', 658333333, 'Orange', 'DFDSFDSF', 0, 0, 0, 1, 0, 0),
('CD312111', 'SADA', '2020-12-29', 654444444, 'Orange', 'SSSSS', 0, 0, 0, 0, 0, 1),
('CD333333', 'SSSSSSSSS', '2020-12-29', 655555555, 'Red', 'DFDSFDS', 0, 0, 0, 0, 0, 1),
('CD000000', 'AMAADOR OMAR', '2001-04-25', 675792589, 'Red', 'TEST', 0, 0, 0, 0, 0, 1),
('cincinci', 'sadsa', '2020-12-29', 611222222, 'Green', 'SDSDS', 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `deces`
--

CREATE TABLE `deces` (
  `Cin` varchar(8) NOT NULL,
  `NomEtPrenom` text NOT NULL,
  `datedeces` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `deces`
--

INSERT INTO `deces` (`Cin`, `NomEtPrenom`, `datedeces`) VALUES
('CD123456', 'TESTACC', '2021-01-19'),
('CD222222', 'MSSSD AFASS', '2021-03-29'),
('CD232323', 'OAD', '2021-01-16'),
('CD33888', 'OAMDSA', '2021-01-16'),
('CD453333', 'SDIIEEE', '2021-01-18'),
('CDSDSSSS', 'DSDS', '2021-02-18'),
('FBI11111', 'TERSA', '2021-01-19'),
('RF333999', 'AMAADORS', '2021-01-16');

-- --------------------------------------------------------

--
-- Table structure for table `historique`
--

CREATE TABLE `historique` (
  `Cin` varchar(8) NOT NULL,
  `Event` text NOT NULL,
  `Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `historique`
--

INSERT INTO `historique` (`Cin`, `Event`, `Date`) VALUES
('CD000000', 'Citoyen Ajouté', '2021-01-16'),
('CD000000', 'Ce Citoyen est Suspect', '2021-01-16'),
('CD000000', 'Ce Citoyen a testé positif', '2021-01-16'),
('CD000000', 'le patient est gueris', '2021-01-16'),
('CD000000', 'Ce Citoyen est Suspect', '2021-01-16'),
('CD000000', 'Ce Citoyen a testé négatif', '2021-01-16'),
('CD000000', 'Ce Citoyen est Suspect', '2021-01-16'),
('CD000000', 'Citoyen Ajouté', '2021-01-16'),
('CD000000', 'Ce Citoyen a testé positif', '2021-01-16'),
('CD000000', 'Ce Citoyen est Suspect', '2021-01-18'),
('CD333333', 'Ce Citoyen a testé positif', '2021-01-18'),
('CD333333', 'Hospitalisé', '2021-01-19'),
('CD333333', 'Reanimation necessaire', '2021-01-19'),
('tetetete', 'Citoyen Ajouté', '2021-01-19'),
('cincinci', 'Citoyen Ajouté', '2021-01-19'),
('CD312111', 'Ce Citoyen est Suspect', '2021-01-19'),
('cincinci', 'Ce Citoyen est Suspect', '2021-01-22'),
('cincinci', 'Ce Citoyen a testé positif', '2021-01-22'),
('cincinci', 'Hospitalisé', '2021-01-22'),
('cincinci', 'Reanimation necessaire', '2021-01-22'),
('cincinci', 'le patient est gueris', '2021-01-22');

-- --------------------------------------------------------

--
-- Table structure for table `localisation`
--

CREATE TABLE `localisation` (
  `Cin` int(11) NOT NULL,
  `Patient` tinyint(1) NOT NULL,
  `Latitude` double NOT NULL,
  `Longitude` double NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `Patient`
--

CREATE TABLE `Patient` (
  `Cin` varchar(8) NOT NULL,
  `symptomegrave` tinyint(1) NOT NULL DEFAULT '0',
  `etataggrave` tinyint(1) NOT NULL DEFAULT '0',
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Patient`
--

INSERT INTO `Patient` (`Cin`, `symptomegrave`, `etataggrave`, `date`) VALUES
('CD000000', 1, 0, '2021-01-16'),
('CD333333', 1, 1, '2021-01-18');

-- --------------------------------------------------------

--
-- Table structure for table `Suspect`
--

CREATE TABLE `Suspect` (
  `Cin` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Suspect`
--

INSERT INTO `Suspect` (`Cin`) VALUES
('CD312111');

-- --------------------------------------------------------

--
-- Table structure for table `Users`
--

CREATE TABLE `Users` (
  `id` int(11) NOT NULL,
  `Cin` varchar(8) NOT NULL,
  `Password` text NOT NULL,
  `admin` text,
  `NomEtPrenom` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Users`
--

INSERT INTO `Users` (`id`, `Cin`, `Password`, `admin`, `NomEtPrenom`) VALUES
(1, 'CD000000', 'admin', '1', 'AMAADOR OMAR'),
(2, 'CD333333', 'dedede', '0', 'TESTY'),
(8, 'cincinci', 'fdfdfd', NULL, 'sadsa');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Citoyen`
--
ALTER TABLE `Citoyen`
  ADD PRIMARY KEY (`Cin`);

--
-- Indexes for table `deces`
--
ALTER TABLE `deces`
  ADD PRIMARY KEY (`Cin`);

--
-- Indexes for table `Suspect`
--
ALTER TABLE `Suspect`
  ADD PRIMARY KEY (`Cin`);

--
-- Indexes for table `Users`
--
ALTER TABLE `Users`
  ADD PRIMARY KEY (`id`),
  ADD KEY `Cin` (`Cin`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Users`
--
ALTER TABLE `Users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `Users`
--
ALTER TABLE `Users`
  ADD CONSTRAINT `Users_ibfk_1` FOREIGN KEY (`Cin`) REFERENCES `Citoyen` (`Cin`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
