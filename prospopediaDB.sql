-- --------------------------------------------------------
-- Hôte :                        localhost
-- Version du serveur:           8.0.27 - MySQL Community Server - GPL
-- SE du serveur:                Win64
-- HeidiSQL Version:             9.5.0.5196
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Export de la structure de la base pour prospopediadb
CREATE DATABASE IF NOT EXISTS `prospopediadb` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `prospopediadb`;

-- Export de la structure de la table prospopediadb. actors
CREATE TABLE IF NOT EXISTS `actors` (
  `id` int NOT NULL AUTO_INCREMENT,
  `firstname` varchar(45) NOT NULL,
  `surname` varchar(45) NOT NULL,
  `birthday` datetime NOT NULL,
  `birthplace` varchar(45) NOT NULL,
  `nationality` varchar(45) NOT NULL,
  `biography` varchar(2500) DEFAULT NULL,
  `ranking` double NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  UNIQUE KEY `name_UNIQUE` (`firstname`),
  UNIQUE KEY `surname_UNIQUE` (`surname`),
  UNIQUE KEY `UniqueActors` (`firstname`,`birthday`,`surname`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;

-- Export de données de la table prospopediadb.actors : ~0 rows (environ)
/*!40000 ALTER TABLE `actors` DISABLE KEYS */;
INSERT INTO `actors` (`id`, `firstname`, `surname`, `birthday`, `birthplace`, `nationality`, `biography`, `ranking`) VALUES
	(1, 'Cillian', 'Murphy', '1976-05-25 00:00:00', 'Cork, Ireland', 'Irish', 'Cillian Murphy est un acteur et musicien irlandais, né le 25 mai 1976 à Douglas (Irlande). Il a commencé sa carrière en tant que musicien de rock. Il a ensuite joué d\'abord au théâtre puis dans des courts métrages et des films indépendants à la fin des années 1990. Il se fait connaître dans plusieurs films tels que 28 Jours plus tard (2002), Retour à Cold Mountain (2003), Intermission (2003), Red Eye : Sous haute pression (2005) et Breakfast on Pluto (2005), pour lesquels il est nommé pour un Golden Globes du meilleur acteur dans une comédie musicale ou une comédie en 2006. Il interprète Jonathan Crane / l\'Épouvantail dans la série de films Batman de Christopher Nolan (2005-2012). Au milieu des années 2000, il joue notamment dans Le vent se lève (2006), Sunshine (2007), The Edge of Love (2008), Inception (2010) et Le Secret de Peacock (2010). En 2011, il remporte un Irish Times Theatre Award du meilleur acteur et un Drama Desk Award pour une performance solo exceptionnelle dans Misterman. Il est également devenu parrain du Centre de recherche sur l\'enfance et la famille de l\'UNESCO à l\'université nationale d\'Irlande à Galway. Il est étroitement associé aux travaux du professeur Pat Dolan, directeur de l\'UCFRC et de la Chaire UNESCO sur les enfants, les jeunes et l\'engagement civique1. Au début des années 2010, il apparaît dans les films In Time (2011), Retreat (2011) et Red Lights (2012). Depuis 2013, il incarne Thomas « Tommy » Shelby, le chef de file dans la série Peaky Blinders, pour laquelle il remporte deux Prix du cinéma et de la télévision irlandais du meilleur acteur - Drame, en 2017 et 2018. Il joue aussi dans les films Transcendance (2014), Au cœur de l\'océan (2015), Opération Anthropoid (2016), Dunkerque (2017), The Delinquent Season (en) (2018), Anna (2019) et Sans un bruit 2 (2020). En 2020, le Irish Times le classe 12e des meilleurs acteurs irlandais2.', 9);
/*!40000 ALTER TABLE `actors` ENABLE KEYS */;

-- Export de la structure de la table prospopediadb. actors_has_images
CREATE TABLE IF NOT EXISTS `actors_has_images` (
  `images_id` int NOT NULL,
  `actors_id` int NOT NULL,
  PRIMARY KEY (`images_id`,`actors_id`),
  KEY `fk_images_has_actors_actors1_idx` (`actors_id`),
  KEY `fk_images_has_actors_images1_idx` (`images_id`),
  CONSTRAINT `fk_images_has_actors_actors1` FOREIGN KEY (`actors_id`) REFERENCES `actors` (`id`),
  CONSTRAINT `fk_images_has_actors_images1` FOREIGN KEY (`images_id`) REFERENCES `images` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Export de données de la table prospopediadb.actors_has_images : ~0 rows (environ)
/*!40000 ALTER TABLE `actors_has_images` DISABLE KEYS */;
INSERT INTO `actors_has_images` (`images_id`, `actors_id`) VALUES
	(7, 1);
/*!40000 ALTER TABLE `actors_has_images` ENABLE KEYS */;

-- Export de la structure de la table prospopediadb. actors_play_characters
CREATE TABLE IF NOT EXISTS `actors_play_characters` (
  `actors_id` int NOT NULL,
  `characters_id` int NOT NULL,
  PRIMARY KEY (`actors_id`,`characters_id`),
  KEY `fk_actors_has_characters_characters1_idx` (`characters_id`),
  KEY `fk_actors_has_characters_actors_idx` (`actors_id`),
  CONSTRAINT `fk_actors_has_characters_actors` FOREIGN KEY (`actors_id`) REFERENCES `actors` (`id`),
  CONSTRAINT `fk_actors_has_characters_characters1` FOREIGN KEY (`characters_id`) REFERENCES `characters` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Export de données de la table prospopediadb.actors_play_characters : ~0 rows (environ)
/*!40000 ALTER TABLE `actors_play_characters` DISABLE KEYS */;
INSERT INTO `actors_play_characters` (`actors_id`, `characters_id`) VALUES
	(1, 1);
/*!40000 ALTER TABLE `actors_play_characters` ENABLE KEYS */;

-- Export de la structure de la table prospopediadb. characters
CREATE TABLE IF NOT EXISTS `characters` (
  `id` int NOT NULL AUTO_INCREMENT,
  `firstname` varchar(45) NOT NULL,
  `surname` varchar(45) DEFAULT NULL,
  `birthday` datetime DEFAULT NULL,
  `birthplace` varchar(45) DEFAULT NULL,
  `biography` varchar(2500) DEFAULT NULL,
  `ranking` double NOT NULL,
  `creator` varchar(45) DEFAULT NULL,
  `age` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  UNIQUE KEY `name_UNIQUE` (`firstname`),
  UNIQUE KEY `creators_UNIQUE` (`creator`),
  UNIQUE KEY `UniqueCharacter` (`firstname`,`creator`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;

-- Export de données de la table prospopediadb.characters : ~0 rows (environ)
/*!40000 ALTER TABLE `characters` DISABLE KEYS */;
INSERT INTO `characters` (`id`, `firstname`, `surname`, `birthday`, `birthplace`, `biography`, `ranking`, `creator`, `age`) VALUES
	(1, 'Thomas', 'Shelby', '1890-06-15 00:00:00', 'Small Heath, Birmingham, England', 'Thomas Michael ‘Tommy’ Shelby is the son of Arthur and Mrs Shelby, brother of Arthur, John, Ada and Finn Shelby, father of Charles and Ruby Shelby, as well as being the husband of Grace and Lizzie Shelby. He is the leader of the Birmingham criminal gang, the Peaky Blinders and the patriarch of the Shelby Family. Thomas served in World War I with the rank of Sergeant Major and was decorated for bravery. His experiences in World War I left him disillusioned and beset with ongoing nightmares, and he becomes determined to move his family up in the world. After the vendetta with the New York Mafia, and during the year of the Wall Street Crash, Thomas Shelby became a Member of Parliament as a socialist politician while lending the chair of the illegal business to his older brother, Arthur Shelby.', 10, 'Steven Knight', 39);
/*!40000 ALTER TABLE `characters` ENABLE KEYS */;

-- Export de la structure de la table prospopediadb. characters_has_images
CREATE TABLE IF NOT EXISTS `characters_has_images` (
  `images_id` int NOT NULL,
  `characters_id` int NOT NULL,
  PRIMARY KEY (`images_id`,`characters_id`),
  KEY `fk_images_has_characters_characters1_idx` (`characters_id`),
  KEY `fk_images_has_characters_images1_idx` (`images_id`),
  CONSTRAINT `fk_images_has_characters_characters1` FOREIGN KEY (`characters_id`) REFERENCES `characters` (`id`),
  CONSTRAINT `fk_images_has_characters_images1` FOREIGN KEY (`images_id`) REFERENCES `images` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Export de données de la table prospopediadb.characters_has_images : ~0 rows (environ)
/*!40000 ALTER TABLE `characters_has_images` DISABLE KEYS */;
INSERT INTO `characters_has_images` (`images_id`, `characters_id`) VALUES
	(8, 1);
/*!40000 ALTER TABLE `characters_has_images` ENABLE KEYS */;

-- Export de la structure de la table prospopediadb. genres
CREATE TABLE IF NOT EXISTS `genres` (
  `id` int NOT NULL AUTO_INCREMENT,
  `genre` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  UNIQUE KEY `UniqueGenre` (`genre`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb3;

-- Export de données de la table prospopediadb.genres : ~14 rows (environ)
/*!40000 ALTER TABLE `genres` DISABLE KEYS */;
INSERT INTO `genres` (`id`, `genre`) VALUES
	(5, 'Action'),
	(4, 'Adventure'),
	(13, 'Animation'),
	(6, 'Comedy'),
	(1, 'Crime'),
	(2, 'Drama'),
	(8, 'Fantasy'),
	(9, 'Historical'),
	(7, 'Horror'),
	(14, 'Other'),
	(10, 'Romance'),
	(12, 'Science fiction'),
	(3, 'Thriller'),
	(11, 'Western');
/*!40000 ALTER TABLE `genres` ENABLE KEYS */;

-- Export de la structure de la table prospopediadb. images
CREATE TABLE IF NOT EXISTS `images` (
  `id` int NOT NULL AUTO_INCREMENT,
  `placement` varchar(175) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `UniqueImage` (`placement`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb3;

-- Export de données de la table prospopediadb.images : ~0 rows (environ)
/*!40000 ALTER TABLE `images` DISABLE KEYS */;
INSERT INTO `images` (`id`, `placement`) VALUES
	(7, 'C:\\DB_imgs\\imgs\\actors\\cilian_murphy.jpg'),
	(8, 'C:\\DB_imgs\\imgs\\characters\\thomas_shelby.jpg'),
	(9, 'C:\\DB_imgs\\imgs\\shows\\peaky_blinders.jpg');
/*!40000 ALTER TABLE `images` ENABLE KEYS */;

-- Export de la structure de la table prospopediadb. shows
CREATE TABLE IF NOT EXISTS `shows` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(75) NOT NULL,
  `type` varchar(45) NOT NULL,
  `studio` varchar(45) NOT NULL,
  `director` varchar(45) NOT NULL,
  `realisator` varchar(45) NOT NULL,
  `releaseDate` datetime NOT NULL,
  `nationality` varchar(45) NOT NULL,
  `lenght` varchar(45) NOT NULL,
  `ranking` double NOT NULL,
  `numberOfSeason` int DEFAULT NULL,
  `numberOfEpisode` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  UNIQUE KEY `title_UNIQUE` (`title`),
  UNIQUE KEY `UniqueShow` (`title`,`director`,`nationality`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;

-- Export de données de la table prospopediadb.shows : ~0 rows (environ)
/*!40000 ALTER TABLE `shows` DISABLE KEYS */;
INSERT INTO `shows` (`id`, `title`, `type`, `studio`, `director`, `realisator`, `releaseDate`, `nationality`, `lenght`, `ranking`, `numberOfSeason`, `numberOfEpisode`) VALUES
	(1, 'Peaky Blinders', 'Show', 'BBC studios', 'Anthony Byrne', 'Steven Knight', '2013-07-12 00:00:00', 'United Kingdom', '65', 9, 5, 30);
/*!40000 ALTER TABLE `shows` ENABLE KEYS */;

-- Export de la structure de la table prospopediadb. shows_has_characters
CREATE TABLE IF NOT EXISTS `shows_has_characters` (
  `characters_id` int NOT NULL,
  `shows_id` int NOT NULL,
  PRIMARY KEY (`characters_id`,`shows_id`),
  KEY `fk_characters_has_shows_shows1_idx` (`shows_id`),
  KEY `fk_characters_has_shows_characters1_idx` (`characters_id`),
  CONSTRAINT `fk_characters_has_shows_characters1` FOREIGN KEY (`characters_id`) REFERENCES `characters` (`id`),
  CONSTRAINT `fk_characters_has_shows_shows1` FOREIGN KEY (`shows_id`) REFERENCES `shows` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Export de données de la table prospopediadb.shows_has_characters : ~0 rows (environ)
/*!40000 ALTER TABLE `shows_has_characters` DISABLE KEYS */;
INSERT INTO `shows_has_characters` (`characters_id`, `shows_id`) VALUES
	(1, 1);
/*!40000 ALTER TABLE `shows_has_characters` ENABLE KEYS */;

-- Export de la structure de la table prospopediadb. shows_has_genres
CREATE TABLE IF NOT EXISTS `shows_has_genres` (
  `shows_id` int NOT NULL,
  `genres_id` int NOT NULL,
  PRIMARY KEY (`shows_id`,`genres_id`),
  KEY `fk_shows_has_genres_genres1_idx` (`genres_id`),
  KEY `fk_shows_has_genres_shows1_idx` (`shows_id`),
  CONSTRAINT `fk_shows_has_genres_genres1` FOREIGN KEY (`genres_id`) REFERENCES `genres` (`id`),
  CONSTRAINT `fk_shows_has_genres_shows1` FOREIGN KEY (`shows_id`) REFERENCES `shows` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Export de données de la table prospopediadb.shows_has_genres : ~0 rows (environ)
/*!40000 ALTER TABLE `shows_has_genres` DISABLE KEYS */;
INSERT INTO `shows_has_genres` (`shows_id`, `genres_id`) VALUES
	(1, 1),
	(1, 2),
	(1, 5);
/*!40000 ALTER TABLE `shows_has_genres` ENABLE KEYS */;

-- Export de la structure de la table prospopediadb. shows_has_images
CREATE TABLE IF NOT EXISTS `shows_has_images` (
  `images_id` int NOT NULL,
  `shows_id` int NOT NULL,
  PRIMARY KEY (`images_id`,`shows_id`),
  KEY `fk_images_has_shows_shows1_idx` (`shows_id`),
  KEY `fk_images_has_shows_images1_idx` (`images_id`),
  CONSTRAINT `fk_images_has_shows_images1` FOREIGN KEY (`images_id`) REFERENCES `images` (`id`),
  CONSTRAINT `fk_images_has_shows_shows1` FOREIGN KEY (`shows_id`) REFERENCES `shows` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Export de données de la table prospopediadb.shows_has_images : ~0 rows (environ)
/*!40000 ALTER TABLE `shows_has_images` DISABLE KEYS */;
INSERT INTO `shows_has_images` (`images_id`, `shows_id`) VALUES
	(9, 1);
/*!40000 ALTER TABLE `shows_has_images` ENABLE KEYS */;

-- Export de la structure de la table prospopediadb. users
CREATE TABLE IF NOT EXISTS `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nickname` varchar(45) NOT NULL,
  `email` varchar(75) NOT NULL,
  `password` varchar(75) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `email_UNIQUE` (`email`),
  UNIQUE KEY `UniqueUser` (`nickname`,`email`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;

-- Export de données de la table prospopediadb.users : ~0 rows (environ)
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` (`id`, `nickname`, `email`, `password`) VALUES
	(1, 'andreas', 'andreas.granada@test.ch', '1234');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

-- Export de la structure de la table prospopediadb. users_has_favorite_actors
CREATE TABLE IF NOT EXISTS `users_has_favorite_actors` (
  `users_id` int NOT NULL,
  `actors_id` int NOT NULL,
  PRIMARY KEY (`users_id`,`actors_id`),
  KEY `fk_users_has_actors_actors1_idx` (`actors_id`),
  KEY `fk_users_has_actors_users1_idx` (`users_id`),
  CONSTRAINT `fk_users_has_actors_actors1` FOREIGN KEY (`actors_id`) REFERENCES `actors` (`id`),
  CONSTRAINT `fk_users_has_actors_users1` FOREIGN KEY (`users_id`) REFERENCES `users` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Export de données de la table prospopediadb.users_has_favorite_actors : ~0 rows (environ)
/*!40000 ALTER TABLE `users_has_favorite_actors` DISABLE KEYS */;
INSERT INTO `users_has_favorite_actors` (`users_id`, `actors_id`) VALUES
	(1, 1);
/*!40000 ALTER TABLE `users_has_favorite_actors` ENABLE KEYS */;

-- Export de la structure de la table prospopediadb. users_has_favorite_characters
CREATE TABLE IF NOT EXISTS `users_has_favorite_characters` (
  `users_id` int NOT NULL,
  `characters_id` int NOT NULL,
  PRIMARY KEY (`users_id`,`characters_id`),
  KEY `fk_users_has_characters_characters1_idx` (`characters_id`),
  KEY `fk_users_has_characters_users1_idx` (`users_id`),
  CONSTRAINT `fk_users_has_characters_characters1` FOREIGN KEY (`characters_id`) REFERENCES `characters` (`id`),
  CONSTRAINT `fk_users_has_characters_users1` FOREIGN KEY (`users_id`) REFERENCES `users` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Export de données de la table prospopediadb.users_has_favorite_characters : ~0 rows (environ)
/*!40000 ALTER TABLE `users_has_favorite_characters` DISABLE KEYS */;
INSERT INTO `users_has_favorite_characters` (`users_id`, `characters_id`) VALUES
	(1, 1);
/*!40000 ALTER TABLE `users_has_favorite_characters` ENABLE KEYS */;

-- Export de la structure de la table prospopediadb. users_has_favorite_shows
CREATE TABLE IF NOT EXISTS `users_has_favorite_shows` (
  `users_id` int NOT NULL,
  `shows_id` int NOT NULL,
  PRIMARY KEY (`users_id`,`shows_id`),
  KEY `fk_users_has_shows_shows1_idx` (`shows_id`),
  KEY `fk_users_has_shows_users1_idx` (`users_id`),
  CONSTRAINT `fk_users_has_shows_shows1` FOREIGN KEY (`shows_id`) REFERENCES `shows` (`id`),
  CONSTRAINT `fk_users_has_shows_users1` FOREIGN KEY (`users_id`) REFERENCES `users` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Export de données de la table prospopediadb.users_has_favorite_shows : ~0 rows (environ)
/*!40000 ALTER TABLE `users_has_favorite_shows` DISABLE KEYS */;
INSERT INTO `users_has_favorite_shows` (`users_id`, `shows_id`) VALUES
	(1, 1);
/*!40000 ALTER TABLE `users_has_favorite_shows` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
