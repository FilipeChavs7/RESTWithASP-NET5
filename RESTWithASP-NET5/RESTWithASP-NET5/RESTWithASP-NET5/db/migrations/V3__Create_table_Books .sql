CREATE TABLE `books` (
  `id` int(20) NOT NULL AUTO_INCREMENT PRIMARY KEY,
  `name_book` varchar(80) NOT NULL,
  `author` varchar(80) NOT NULL,
  `launch_date` datetime(6) NOT NULL,
  `price` decimal(65,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;