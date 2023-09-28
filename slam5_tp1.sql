-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : jeu. 28 sep. 2023 à 11:55
-- Version du serveur : 10.4.28-MariaDB
-- Version de PHP : 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `slam5_tp1`
--

-- --------------------------------------------------------

--
-- Structure de la table `auteur`
--

CREATE TABLE `auteur` (
  `NUMAUT` int(11) NOT NULL,
  `NOMAUT` varchar(128) DEFAULT NULL,
  `PRENOMAUT` varchar(128) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `auteur`
--

INSERT INTO `auteur` (`NUMAUT`, `NOMAUT`, `PRENOMAUT`) VALUES
(1, 'Arno', NULL),
(2, 'Djawadi ', 'Ramin');

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE `client` (
  `NUMCLI` int(11) NOT NULL,
  `NOMCLI` varchar(128) DEFAULT NULL,
  `PRENOMCLI` varchar(128) DEFAULT NULL,
  `ADRCLI` varchar(128) DEFAULT NULL,
  `Tel` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`NUMCLI`, `NOMCLI`, `PRENOMCLI`, `ADRCLI`, `Tel`) VALUES
(1, 'Delaud', 'Louis', '12 rue David 49000 Angers', '0754101289'),
(2, 'Maitairie', 'Eloise', '3 rue Félix Faure 49000 Angers', '0745125623'),
(3, 'Liaison', 'Anita', '50 rue Jardin 49130 Les Ponts de Cé', '0712345678');

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

CREATE TABLE `commande` (
  `NUMCLI` int(11) NOT NULL,
  `NUMCDE` int(11) NOT NULL,
  `DATECDE` date DEFAULT NULL,
  `MONTANTCDE` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `commande`
--

INSERT INTO `commande` (`NUMCLI`, `NUMCDE`, `DATECDE`, `MONTANTCDE`) VALUES
(1, 2, '2022-09-05', 5),
(1, 4, '2023-09-28', 0),
(1, 5, '2023-09-28', 0),
(2, 7, '2023-09-28', 5),
(2, 8, '2023-09-06', 4),
(1, 9, '2023-09-28', 0);

-- --------------------------------------------------------

--
-- Structure de la table `contenir`
--

CREATE TABLE `contenir` (
  `NUMCDE` int(11) NOT NULL,
  `NUMPART` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `contenir`
--

INSERT INTO `contenir` (`NUMCDE`, `NUMPART`) VALUES
(2, 2);

-- --------------------------------------------------------

--
-- Structure de la table `ecrire`
--

CREATE TABLE `ecrire` (
  `NUMPART` int(11) NOT NULL,
  `NUMAUT` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `ecrire`
--

INSERT INTO `ecrire` (`NUMPART`, `NUMAUT`) VALUES
(1, 2),
(2, 1),
(3, 1);

-- --------------------------------------------------------

--
-- Structure de la table `partitions`
--

CREATE TABLE `partitions` (
  `NUMPART` int(11) NOT NULL,
  `LIBPART` varchar(128) DEFAULT NULL,
  `PRIXPART` int(11) DEFAULT NULL,
  `NumStyle` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `partitions`
--

INSERT INTO `partitions` (`NUMPART`, `LIBPART`, `PRIXPART`, `NumStyle`) VALUES
(1, 'BO Game Of Thrones Piano', 5, 2),
(2, 'Les yeux de ma mère', 5, 1),
(3, 'Elle pense quand elle danse', 9, 3);

-- --------------------------------------------------------

--
-- Structure de la table `style`
--

CREATE TABLE `style` (
  `NumStyle` int(11) NOT NULL,
  `LibStyle` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `style`
--

INSERT INTO `style` (`NumStyle`, `LibStyle`) VALUES
(1, 'Classique'),
(2, 'Rock'),
(3, 'Flok'),
(4, 'Populaire');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `auteur`
--
ALTER TABLE `auteur`
  ADD PRIMARY KEY (`NUMAUT`);

--
-- Index pour la table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`NUMCLI`);

--
-- Index pour la table `commande`
--
ALTER TABLE `commande`
  ADD PRIMARY KEY (`NUMCDE`),
  ADD KEY `I_FK_COMMANDE_ADHERENT` (`NUMCLI`);

--
-- Index pour la table `contenir`
--
ALTER TABLE `contenir`
  ADD PRIMARY KEY (`NUMCDE`,`NUMPART`),
  ADD KEY `I_FK_CONTENIR_COMMANDE` (`NUMCDE`),
  ADD KEY `NUMPART` (`NUMPART`);

--
-- Index pour la table `ecrire`
--
ALTER TABLE `ecrire`
  ADD PRIMARY KEY (`NUMPART`,`NUMAUT`),
  ADD KEY `I_FK_ECRIRE_PARTITIONS` (`NUMPART`),
  ADD KEY `I_FK_ECRIRE_AUTEUR` (`NUMAUT`);

--
-- Index pour la table `partitions`
--
ALTER TABLE `partitions`
  ADD PRIMARY KEY (`NUMPART`),
  ADD KEY `NumStyle` (`NumStyle`);

--
-- Index pour la table `style`
--
ALTER TABLE `style`
  ADD PRIMARY KEY (`NumStyle`),
  ADD KEY `NumStyle` (`NumStyle`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `auteur`
--
ALTER TABLE `auteur`
  MODIFY `NUMAUT` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `client`
--
ALTER TABLE `client`
  MODIFY `NUMCLI` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `commande`
--
ALTER TABLE `commande`
  MODIFY `NUMCDE` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pour la table `partitions`
--
ALTER TABLE `partitions`
  MODIFY `NUMPART` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `style`
--
ALTER TABLE `style`
  MODIFY `NumStyle` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `commande`
--
ALTER TABLE `commande`
  ADD CONSTRAINT `FK_COMMANDE_ADHERENT` FOREIGN KEY (`NUMCLI`) REFERENCES `client` (`NUMCLI`);

--
-- Contraintes pour la table `contenir`
--
ALTER TABLE `contenir`
  ADD CONSTRAINT `contenir_ibfk_1` FOREIGN KEY (`NUMCDE`) REFERENCES `commande` (`NUMCDE`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `contenir_ibfk_2` FOREIGN KEY (`NUMPART`) REFERENCES `partitions` (`NUMPART`);

--
-- Contraintes pour la table `ecrire`
--
ALTER TABLE `ecrire`
  ADD CONSTRAINT `ecrire_ibfk_1` FOREIGN KEY (`NUMPART`) REFERENCES `partitions` (`NUMPART`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ecrire_ibfk_2` FOREIGN KEY (`NUMAUT`) REFERENCES `auteur` (`NUMAUT`);

--
-- Contraintes pour la table `partitions`
--
ALTER TABLE `partitions`
  ADD CONSTRAINT `NumStyle` FOREIGN KEY (`NumStyle`) REFERENCES `style` (`NumStyle`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
