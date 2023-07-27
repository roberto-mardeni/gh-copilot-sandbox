CREATE DATABASE MyApp;
USE MyApp;
CREATE TABLE Users (
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    PRIMARY KEY (id)
);

-- Store procedure to retrieve all users
DELIMITER $$
CREATE PROCEDURE GetAllUsers()
BEGIN
    SELECT * FROM Users;
END$$
DELIMITER ;