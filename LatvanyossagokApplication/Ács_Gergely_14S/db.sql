﻿CREATE TABLE rendezok
(
	id INT PRIMARY KEY AUTO_INCREMENT,
	nev VARCHAR(1000) NOT NULL,
	szuletes DATE NOT NULL,
	szarmazas VARCHAR(1000) NOT NULL
);

CREATE TABLE filmek
(
	id INT PRIMARY KEY AUTO_INCREMENT,
	cim VARCHAR(1000) NOT NULL,
	kiadas DATE NOT NULL,
	hossz INT NOT NULL,
	rendezo_id INT NOT NULL,
	FOREIGN KEY (rendezo_id) 
	REFERENCES rendezok(id)
);