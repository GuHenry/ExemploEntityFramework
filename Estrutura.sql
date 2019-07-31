DROP TABLE IF EXISTS habilidades
DROP TABLE  IF EXISTS animais;
CREATE TABLE animais(
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100),
extinto BIT
);

SELECT * FROM animais;
--ALTER TABLE animais ADD peso DECIMAL(4,2) DEFAULT 0.0

--UPDATE animais SET peso = 0;

--ALTER TABLE animais DROP CONSTRAINT DF__animais__peso__276EDEB3;
--ALTER TABLE animais DROP COLUMN peso;

CREATE TABLE habilidades(
id INT PRIMARY KEY IDENTITY(1,1),

id_animal INT,
FOREIGN KEY(id_animal) REFERENCES animais (id),

nome VARCHAR(100)
);