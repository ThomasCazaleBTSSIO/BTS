-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mar. 04 déc. 2018 à 08:24
-- Version du serveur :  5.7.19
-- Version de PHP :  5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `gsb`
--

-- --------------------------------------------------------

--
-- Structure de la table `demande`
--

DROP TABLE IF EXISTS `demande`;
CREATE TABLE IF NOT EXISTS `demande` (
  `ticket` int(11) NOT NULL,
  `materield` varchar(500) DEFAULT NULL,
  `objetd` varchar(500) DEFAULT NULL,
  `urgenced` int(11) DEFAULT NULL,
  `etatd` varchar(25) DEFAULT NULL,
  `intervention` varchar(50) DEFAULT NULL,
  `heuredebut` time DEFAULT NULL,
  `heurefin` time DEFAULT NULL,
  `travail` varchar(500) DEFAULT NULL,
  `dated` datetime DEFAULT NULL,
  `idm` char(7) DEFAULT NULL,
  `matriculet` char(7) DEFAULT NULL,
  PRIMARY KEY (`ticket`),
  KEY `FK_demande_idm` (`idm`),
  KEY `FK_demande_matriculet` (`matriculet`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `demande`
--

INSERT INTO `demande` (`ticket`, `materield`, `objetd`, `urgenced`, `etatd`, `intervention`, `heuredebut`, `heurefin`, `travail`, `dated`, `idm`, `matriculet`) VALUES
(1, 'ordi', 'cassé', 5, 'déclaré', 'oui', NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `fournisseur`
--

DROP TABLE IF EXISTS `fournisseur`;
CREATE TABLE IF NOT EXISTS `fournisseur` (
  `idf` varchar(10) NOT NULL,
  `nomf` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`idf`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `logiciels`
--

DROP TABLE IF EXISTS `logiciels`;
CREATE TABLE IF NOT EXISTS `logiciels` (
  `idl` varchar(10) NOT NULL,
  `noml` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`idl`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `materiel`
--

DROP TABLE IF EXISTS `materiel`;
CREATE TABLE IF NOT EXISTS `materiel` (
  `idm` char(7) NOT NULL,
  `processeur` varchar(50) DEFAULT NULL,
  `disque` varchar(15) DEFAULT NULL,
  `memoire` varchar(50) DEFAULT NULL,
  `dateachatlocation` date DEFAULT NULL,
  `garantie` varchar(500) DEFAULT NULL,
  `achatlocation` tinyint(1) DEFAULT NULL,
  `matricule` char(7) DEFAULT NULL,
  `ticket` int(11) DEFAULT NULL,
  `idf` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`idm`),
  KEY `FK_materiel_matricule` (`matricule`),
  KEY `FK_materiel_ticket` (`ticket`),
  KEY `FK_materiel_idf` (`idf`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `matricule` char(7) NOT NULL,
  `nomp` varchar(25) DEFAULT NULL,
  `prenomp` varchar(25) DEFAULT NULL,
  `datep` date DEFAULT NULL,
  PRIMARY KEY (`matricule`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`matricule`, `nomp`, `prenomp`, `datep`) VALUES
('trh', 'trherzh', 'trhreh', NULL);

-- --------------------------------------------------------

--
-- Structure de la table `posseder`
--

DROP TABLE IF EXISTS `posseder`;
CREATE TABLE IF NOT EXISTS `posseder` (
  `idm` char(7) NOT NULL,
  `idl` varchar(10) NOT NULL,
  PRIMARY KEY (`idm`,`idl`),
  KEY `FK_posseder_idl` (`idl`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `region`
--

DROP TABLE IF EXISTS `region`;
CREATE TABLE IF NOT EXISTS `region` (
  `nomr` varchar(50) NOT NULL,
  PRIMARY KEY (`nomr`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `technicien`
--

DROP TABLE IF EXISTS `technicien`;
CREATE TABLE IF NOT EXISTS `technicien` (
  `matriculet` char(7) NOT NULL,
  `nomt` varchar(25) DEFAULT NULL,
  `prenomt` varchar(25) DEFAULT NULL,
  `formationt` varchar(500) DEFAULT NULL,
  `interventiont` varchar(500) DEFAULT NULL,
  `competencet` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`matriculet`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `technicien`
--

INSERT INTO `technicien` (`matriculet`, `nomt`, `prenomt`, `formationt`, `interventiont`, `competencet`) VALUES
('trh', 'trherzh', 'trhreh', 'rhth', 'regegh', 'trhrth');

-- --------------------------------------------------------

--
-- Structure de la table `travailler`
--

DROP TABLE IF EXISTS `travailler`;
CREATE TABLE IF NOT EXISTS `travailler` (
  `matricule` char(7) NOT NULL,
  `nomr` varchar(50) NOT NULL,
  PRIMARY KEY (`matricule`,`nomr`),
  KEY `FK_travailler_nomr` (`nomr`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `visiteur`
--

DROP TABLE IF EXISTS `visiteur`;
CREATE TABLE IF NOT EXISTS `visiteur` (
  `matriculev` char(7) NOT NULL,
  `nomv` varchar(25) DEFAULT NULL,
  `prenomv` varchar(25) DEFAULT NULL,
  `adressev` varchar(100) DEFAULT NULL,
  `datev` varchar(30) DEFAULT NULL,
  `objectifv` varchar(500) DEFAULT NULL,
  `primev` float DEFAULT NULL,
  `avantagev` varchar(500) DEFAULT NULL,
  `budgetv` float DEFAULT NULL,
  PRIMARY KEY (`matriculev`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `visiteur`
--

INSERT INTO `visiteur` (`matriculev`, `nomv`, `prenomv`, `adressev`, `datev`, `objectifv`, `primev`, `avantagev`, `budgetv`) VALUES
('azerty', 'aze', 'rty', 'ici', 'mardi 27 novembre 2018', 'topun', 1, '10000', 2),
('moi', 'cazale', 'thomas', 'chemin', 'jeudi 29 novembre 2018', 'bts', 1100, 'oui', 20000);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `materiel`
--
ALTER TABLE `materiel`
  ADD CONSTRAINT `FK_materiel_idf` FOREIGN KEY (`idf`) REFERENCES `fournisseur` (`idf`),
  ADD CONSTRAINT `FK_materiel_matricule` FOREIGN KEY (`matricule`) REFERENCES `personnel` (`matricule`),
  ADD CONSTRAINT `FK_materiel_ticket` FOREIGN KEY (`ticket`) REFERENCES `demande` (`ticket`);

--
-- Contraintes pour la table `posseder`
--
ALTER TABLE `posseder`
  ADD CONSTRAINT `FK_posseder_idl` FOREIGN KEY (`idl`) REFERENCES `logiciels` (`idl`),
  ADD CONSTRAINT `FK_posseder_idm` FOREIGN KEY (`idm`) REFERENCES `materiel` (`idm`);

--
-- Contraintes pour la table `technicien`
--
ALTER TABLE `technicien`
  ADD CONSTRAINT `FK_matricule_technicien` FOREIGN KEY (`matriculet`) REFERENCES `personnel` (`matricule`);

--
-- Contraintes pour la table `travailler`
--
ALTER TABLE `travailler`
  ADD CONSTRAINT `FK_travailler_matricule` FOREIGN KEY (`matricule`) REFERENCES `personnel` (`matricule`),
  ADD CONSTRAINT `FK_travailler_nomr` FOREIGN KEY (`nomr`) REFERENCES `region` (`nomr`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
