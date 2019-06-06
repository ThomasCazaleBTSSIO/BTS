-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  jeu. 06 juin 2019 à 22:45
-- Version du serveur :  5.7.24
-- Version de PHP :  7.2.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `gsb_medic`
--

-- --------------------------------------------------------

--
-- Structure de la table `activites`
--

DROP TABLE IF EXISTS `activites`;
CREATE TABLE IF NOT EXISTS `activites` (
  `idActivite` varchar(10) NOT NULL,
  `bilan` text NOT NULL,
  PRIMARY KEY (`idActivite`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `activites`
--

INSERT INTO `activites` (`idActivite`, `bilan`) VALUES
('activite1', 'blablabla'),
('bla', 'bla'),
('fezfz', 'fzefz'),
('fsfsfs', 'fdfdsfgrz'),
('hrhr', 'htrhr'),
('hrhth', 'htrhrhrhr'),
('zazaza', 'ezazeae');

-- --------------------------------------------------------

--
-- Structure de la table `activitescomp`
--

DROP TABLE IF EXISTS `activitescomp`;
CREATE TABLE IF NOT EXISTS `activitescomp` (
  `numOrdre` varchar(10) NOT NULL,
  `etat` varchar(25) NOT NULL,
  `budgetActivitesComp` double NOT NULL,
  `commentaires` text NOT NULL,
  `salle` varchar(20) NOT NULL,
  `date` varchar(10) NOT NULL,
  `idActivite` varchar(10) NOT NULL,
  `idResponsable` varchar(10) NOT NULL,
  KEY `idActivite` (`idActivite`),
  KEY `idResponsable` (`idResponsable`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `activitescomp`
--

INSERT INTO `activitescomp` (`numOrdre`, `etat`, `budgetActivitesComp`, `commentaires`, `salle`, `date`, `idActivite`, `idResponsable`) VALUES
('fezfez', 'gsfzg', 445, 'hbthe', 'greheh', 'hehrehe', 'fezfz', 'erhhe'),
('fefgg', 'gfdgdgd', 555, 'ghehhe', 'hhehr', 'hrhrh', 'zazaza', 'hrthr'),
('val123', 'en cours', 125, 'blablabla', '001', '18/12/2018', 'activite1', 'bla');

-- --------------------------------------------------------

--
-- Structure de la table `avoir`
--

DROP TABLE IF EXISTS `avoir`;
CREATE TABLE IF NOT EXISTS `avoir` (
  `aIdEffet` varchar(10) NOT NULL,
  `aIdMedicament` varchar(10) NOT NULL,
  KEY `idEffet` (`aIdEffet`),
  KEY `idMedicament` (`aIdMedicament`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `avoir`
--

INSERT INTO `avoir` (`aIdEffet`, `aIdMedicament`) VALUES
('1', '1'),
('2', '2'),
('3', '3'),
('4', '4'),
('5', '5'),
('6', '6'),
('7', '7');

-- --------------------------------------------------------

--
-- Structure de la table `composants`
--

DROP TABLE IF EXISTS `composants`;
CREATE TABLE IF NOT EXISTS `composants` (
  `idComposant` varchar(10) NOT NULL,
  `libelleComposant` varchar(100) NOT NULL,
  PRIMARY KEY (`idComposant`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `composer`
--

DROP TABLE IF EXISTS `composer`;
CREATE TABLE IF NOT EXISTS `composer` (
  `idMedicament` varchar(10) NOT NULL,
  `idComposant` varchar(10) NOT NULL,
  `quantite` double NOT NULL,
  KEY `idMedicament` (`idMedicament`),
  KEY `idComposant` (`idComposant`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `contre`
--

DROP TABLE IF EXISTS `contre`;
CREATE TABLE IF NOT EXISTS `contre` (
  `idMedicament` varchar(10) NOT NULL,
  `idContreIndication` varchar(10) NOT NULL,
  KEY `idMedicament` (`idMedicament`),
  KEY `idContreIndication` (`idContreIndication`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `contreindications`
--

DROP TABLE IF EXISTS `contreindications`;
CREATE TABLE IF NOT EXISTS `contreindications` (
  `idContreIndication` varchar(10) NOT NULL,
  `libelleContreIndication` varchar(100) NOT NULL,
  `descriptionContreIndication` text NOT NULL,
  PRIMARY KEY (`idContreIndication`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `contreindications`
--

INSERT INTO `contreindications` (`idContreIndication`, `libelleContreIndication`, `descriptionContreIndication`) VALUES
('1', 'Antalgique', '- maladie grave du foie,\r\n\r\n- inflammation ou saignement du rectum (suppositoires),\r\n\r\n- intolérance au gluten (comprimé sécable à 500 mg).'),
('2', 'Anti-Inflammatoires', '- en cas d’antécédent d’allergie aux médicaments de la même famille ou aux anti-inflammatoires non stéroïdiens (AINS) ;\r\n\r\n- en cas d’ulcère de l’estomac ou du duodénum ;\r\n\r\n- en cas de risque hémorragique (pendant les règles, prédisposition aux saignements etc.) ;\r\nen cas d\'insuffisance hépatique grave ;\r\n\r\n- en cas d\'insuffisance rénale grave ;\r\n\r\n- en cas d’insuffisance cardiaque non contrôlée par un traitement;\r\n\r\n- chez la femme enceinte à partir du 6e mois de la grossesse'),
('3', 'Antispasmodique', 'Les comprimés ne doivent pas être utilisés en cas d\'allergie au blé (autre que la maladie cœliaque).'),
('4', 'Dermatologie', 'Aucune contre-indication !'),
('5', 'Anti-acides', 'Ce médicament ne doit pas être utilisé chez l\'enfant qui suit un régime sans sel strict.');

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
  `technicien` varchar(50) DEFAULT '""',
  `dated` date DEFAULT NULL,
  `travail` varchar(30) NOT NULL DEFAULT '""',
  PRIMARY KEY (`ticket`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `demande`
--

INSERT INTO `demande` (`ticket`, `materield`, `objetd`, `urgenced`, `etatd`, `technicien`, `dated`, `travail`) VALUES
(1, 'ordi', 'cassé', 5, 'Travail terminé', '1', '2019-06-06', 'Terminé'),
(2, 'pc', 'panne', 5, 'déclaré', '2', '2019-01-18', '');

-- --------------------------------------------------------

--
-- Structure de la table `effets`
--

DROP TABLE IF EXISTS `effets`;
CREATE TABLE IF NOT EXISTS `effets` (
  `idEffet` varchar(10) NOT NULL,
  `libelleEffet` varchar(100) NOT NULL,
  `descriptionEffet` text NOT NULL,
  PRIMARY KEY (`idEffet`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `effets`
--

INSERT INTO `effets` (`idEffet`, `libelleEffet`, `descriptionEffet`) VALUES
('1', 'Antalgique', 'Irritation anale (suppositoire).\r\n\r\nExceptionnellement : réaction allergique cutanée, anomalie de la numération formule sanguine.'),
('2', 'Anti-inflammatoires', 'Nausées, vomissements, gastrite.\r\n\r\nRarement :\r\nulcère de l\'estomac ou du duodénum, hémorragie du tube digestif (vomissements sanglants, selles noires, ou le plus souvent pertes de sang imperceptibles, responsables de l\'apparition progressive d\'une anémie) le plus souvent lors d\'un traitement de longue durée ou à forte dose ;\r\nréaction allergique : éruption cutanée, démangeaisons, œdème, crise d\'asthme, malaise avec chute brutale de la tension artérielle ;\r\nvertiges, maux de tête ;\r\ntroubles de la vision nécessitant un examen ophtalmologique ;\r\nanomalie de la numération formule sanguine, augmentation des transaminases.'),
('3', 'Antispasmodique', 'Irritation anale (suppositoires).\r\n\r\nExceptionnellement : réaction allergique cutanée, anomalie de la numération formule sanguine.\r\n\r\nSachets :\r\n\r\nComme tous les médicaments et confiseries contenant des sucres non absorbables (sorbitol, maltitol...), possibilité de diarrhée en cas d\'apport important.'),
('4', 'Dermatologie', 'Peu fréquents (moins de 1 patient sur 100) : irritation, douleur, rougeur au site d\'application ; urticaire, eczéma, démangeaisons.\r\n\r\nFréquence indéterminée : sensation de brûlure.'),
('5', 'Anti-acides', 'Constipation.\r\n\r\nEn cas d\'usage prolongé de la solution buvable ou des sachets, à forte dose : excès de calcium dans le sang, insuffisance rénale.');

-- --------------------------------------------------------

--
-- Structure de la table `effettherapeutique`
--

DROP TABLE IF EXISTS `effettherapeutique`;
CREATE TABLE IF NOT EXISTS `effettherapeutique` (
  `idEffetT` varchar(10) NOT NULL,
  `libelleEffetT` varchar(25) NOT NULL,
  `descriptionEffetT` text NOT NULL,
  PRIMARY KEY (`idEffetT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `effettherapeutique`
--

INSERT INTO `effettherapeutique` (`idEffetT`, `libelleEffetT`, `descriptionEffetT`) VALUES
('1', 'Doliprane', 'Il est utilisé pour faire baisser la fièvre et dans le traitement des affections douloureuses.'),
('2', 'Aspirine', 'Il est utilisé dans :\r\nle traitement de la fièvre et de la douleur (maux de tête, douleurs dentaires, courbatures, règles douloureuses...) ;\r\nle traitement de la crise de migraine chez l\'adulte, après au moins un avis médical.'),
('3', 'Dafalgan', 'Il est utilisé pour faire baisser la fièvre et dans le traitement des affections douloureuses.\r\n'),
('4', 'Spasfon ', 'Il est utilisé dans le traitement des spasmes douloureux d\'origines digestive (colites spasmodiques), biliaire (coliques hépatiques), urologique (coliques néphrétiques) et gynécologique (règles douloureuses et contractions de l\'utérus pendant la grossesse).'),
('5', 'Nurofen', 'Il est utilisé dans :\r\nle traitement de la fièvre et de la douleur (maux de tête, douleurs dentaires, courbatures, règles douloureuses...) ;\r\nle traitement de la crise de migraine chez l\'adulte, après au moins un avis médical.'),
('6', 'Dexeryl', 'Elle est utilisée dans le traitement d\'appoint de la sécheresse de la peau (notamment en cas de dermatite atopique, d\'ichtyose ou de psoriasis) et des brûlures superficielles peu étendues.'),
('7', 'Gaviscon', 'Il est utilisé dans le traitement des symptômes du reflux gastro-œsophagien (brûlures d\'estomac, remontées acides).');

-- --------------------------------------------------------

--
-- Structure de la table `famille`
--

DROP TABLE IF EXISTS `famille`;
CREATE TABLE IF NOT EXISTS `famille` (
  `idFamille` varchar(10) NOT NULL,
  `libelleFamille` varchar(50) NOT NULL,
  PRIMARY KEY (`idFamille`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `famille`
--

INSERT INTO `famille` (`idFamille`, `libelleFamille`) VALUES
('famille1', 'Antalgique'),
('famille2', 'Anti-inflammatoires  '),
('famille3', ' Antispasmodique'),
('famille4', 'Dermatologie'),
('famille5', 'Anti-acides');

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
  `garantie` varchar(500) DEFAULT NULL,
  `ticket` int(11) DEFAULT NULL,
  PRIMARY KEY (`idm`),
  KEY `FK_materiel_ticket` (`ticket`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `materiel`
--

INSERT INTO `materiel` (`idm`, `processeur`, `disque`, `memoire`, `garantie`, `ticket`) VALUES
('1', 'I9', 'SSD', '1T', 'oui', 1);

-- --------------------------------------------------------

--
-- Structure de la table `medicaments`
--

DROP TABLE IF EXISTS `medicaments`;
CREATE TABLE IF NOT EXISTS `medicaments` (
  `idMedicament` varchar(10) NOT NULL,
  `libelleMedicament` varchar(100) NOT NULL,
  `familleMedicament` varchar(10) NOT NULL,
  PRIMARY KEY (`idMedicament`),
  KEY `idFamille` (`familleMedicament`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `medicaments`
--

INSERT INTO `medicaments` (`idMedicament`, `libelleMedicament`, `familleMedicament`) VALUES
('1', 'Doliprane', 'famille1'),
('2', 'Aspirine', 'famille2'),
('3', 'Dafalgan', 'famille1'),
('4', 'Spasfon', 'famille3'),
('5', 'Nurofen', 'famille2'),
('6', 'Dexeryl', 'famille4'),
('7', 'Gaviscon', 'famille5'),
('8', 'TESTTRIGGER', 'famille5');

--
-- Déclencheurs `medicaments`
--
DROP TRIGGER IF EXISTS `MajusculeMedic`;
DELIMITER $$
CREATE TRIGGER `MajusculeMedic` BEFORE INSERT ON `medicaments` FOR EACH ROW BEGIN
SET new.libelleMedicament = UPPER(new.libelleMedicament);
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `posseder`
--

DROP TABLE IF EXISTS `posseder`;
CREATE TABLE IF NOT EXISTS `posseder` (
  `pIdMedicament` char(7) NOT NULL,
  `pIdContreIndication` varchar(10) NOT NULL,
  PRIMARY KEY (`pIdMedicament`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `posseder`
--

INSERT INTO `posseder` (`pIdMedicament`, `pIdContreIndication`) VALUES
('1', '1'),
('2', '2'),
('3', '1'),
('4', '3'),
('5', '2'),
('6', '4'),
('7', '5');

-- --------------------------------------------------------

--
-- Structure de la table `praticiens`
--

DROP TABLE IF EXISTS `praticiens`;
CREATE TABLE IF NOT EXISTS `praticiens` (
  `idPraticien` varchar(10) NOT NULL,
  `nomPraticien` varchar(25) NOT NULL,
  `prenomPraticien` varchar(25) NOT NULL,
  PRIMARY KEY (`idPraticien`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `praticiens`
--

INSERT INTO `praticiens` (`idPraticien`, `nomPraticien`, `prenomPraticien`) VALUES
('blabla', 'edherjj', 'heejejejtr');

-- --------------------------------------------------------

--
-- Structure de la table `pratiquer`
--

DROP TABLE IF EXISTS `pratiquer`;
CREATE TABLE IF NOT EXISTS `pratiquer` (
  `idActivite` varchar(10) NOT NULL,
  `idPraticien` varchar(10) NOT NULL,
  KEY `idActivite` (`idActivite`),
  KEY `idPraticien` (`idPraticien`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `pratiquer`
--

INSERT INTO `pratiquer` (`idActivite`, `idPraticien`) VALUES
('bla', 'blabla'),
('bla', 'blabla'),
('activite1', 'blabla');

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
  `nivInterventiont` varchar(500) DEFAULT NULL,
  `competencet` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`matriculet`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `technicien`
--

INSERT INTO `technicien` (`matriculet`, `nomt`, `prenomt`, `formationt`, `nivInterventiont`, `competencet`) VALUES
('1', 'Cazalé', 'Hugo', 'BTS SIO', '10', 'Programmation');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateurs`
--

DROP TABLE IF EXISTS `utilisateurs`;
CREATE TABLE IF NOT EXISTS `utilisateurs` (
  `idUtilisateur` varchar(20) NOT NULL,
  `mdpUtilisateur` varchar(20) NOT NULL,
  `Type` varchar(20) NOT NULL,
  PRIMARY KEY (`idUtilisateur`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `utilisateurs`
--

INSERT INTO `utilisateurs` (`idUtilisateur`, `mdpUtilisateur`, `Type`) VALUES
('Arthur', 'arthur', 'visiteur'),
('Axel', 'axel', 'technicien'),
('Thomas', 'thomas', 'responsable ');

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
('1', 'CAUSSE', 'Arthur', 'Chemin 1', 'vendredi 7 juin 2019', 'Bts', 2, '1000', 20000),
('moi', 'cazale', 'thomas', 'Allee', 'jeudi 29 novembre 2018', 'bts', 1100, 'oui', 20000);

--
-- Déclencheurs `visiteur`
--
DROP TRIGGER IF EXISTS `MajuculeNom`;
DELIMITER $$
CREATE TRIGGER `MajuculeNom` BEFORE INSERT ON `visiteur` FOR EACH ROW BEGIN 
SET new.nomv = UPPER(new.nomv);
END
$$
DELIMITER ;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `activitescomp`
--
ALTER TABLE `activitescomp`
  ADD CONSTRAINT `activitescomp_ibfk_1` FOREIGN KEY (`idActivite`) REFERENCES `activites` (`idActivite`);

--
-- Contraintes pour la table `avoir`
--
ALTER TABLE `avoir`
  ADD CONSTRAINT `avoir_ibfk_1` FOREIGN KEY (`aIdEffet`) REFERENCES `effettherapeutique` (`idEffetT`),
  ADD CONSTRAINT `avoir_ibfk_2` FOREIGN KEY (`aIdEffet`) REFERENCES `medicaments` (`idMedicament`);

--
-- Contraintes pour la table `composer`
--
ALTER TABLE `composer`
  ADD CONSTRAINT `composer_ibfk_1` FOREIGN KEY (`idComposant`) REFERENCES `composants` (`idComposant`),
  ADD CONSTRAINT `composer_ibfk_2` FOREIGN KEY (`idMedicament`) REFERENCES `medicaments` (`idMedicament`);

--
-- Contraintes pour la table `contre`
--
ALTER TABLE `contre`
  ADD CONSTRAINT `contre_1` FOREIGN KEY (`idMedicament`) REFERENCES `medicaments` (`idMedicament`),
  ADD CONSTRAINT `contre_2` FOREIGN KEY (`idContreIndication`) REFERENCES `contreindications` (`idContreIndication`);

--
-- Contraintes pour la table `materiel`
--
ALTER TABLE `materiel`
  ADD CONSTRAINT `FK_materiel_ticket` FOREIGN KEY (`ticket`) REFERENCES `demande` (`ticket`);

--
-- Contraintes pour la table `medicaments`
--
ALTER TABLE `medicaments`
  ADD CONSTRAINT `medicaments_ibfk_1` FOREIGN KEY (`familleMedicament`) REFERENCES `famille` (`idFamille`);

--
-- Contraintes pour la table `pratiquer`
--
ALTER TABLE `pratiquer`
  ADD CONSTRAINT `pratiquer_ibfk_1` FOREIGN KEY (`idActivite`) REFERENCES `activites` (`idActivite`),
  ADD CONSTRAINT `pratiquer_ibfk_2` FOREIGN KEY (`idPraticien`) REFERENCES `praticiens` (`idPraticien`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
