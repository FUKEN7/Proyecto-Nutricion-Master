CREATE DATABASE Nutrisoft;

USE Nutrisoft;


CREATE TABLE Persona(
id VARCHAR(11) PRIMARY KEY,
tipoIdentificacion VARCHAR(40),
nombre VARCHAR(40),
apellido VARCHAR(40),
sexo VARCHAR,
fecha_Nacimiento DATE,
telefono VARCHAR(12),
email VARCHAR(100) Unique,
Password VARCHAR(100),
role int NOT NULL,
);

CREATE TABLE Deportista(
id VARCHAR(11) NOT NULL,
peso FLOAT NULL,
altura FLOAT NULL,
deporte VARCHAR(50),
pesoActual FLOAT NULL,
fechaEgreso DATE,
caloriasDiarias FLOAT NULL,
metabolismoBasal FLOAT NULL,
termogenesisActividadFisica VARCHAR(50) NULL,
CONSTRAINT FK_Deportista FOREIGN KEY (id) REFERENCES Persona(id),
);

SELECT *FROM Alimento;

CREATE TABLE Alimento (
id VARCHAR(10) PRIMARY KEY,
nombre VARCHAR(10),
caloria FLOAT NULL,
carbohidrato FLOAT NULL,
proteinas FLOAT NULL,
liquidos FLOAT NULL
);

CREATE TABLE Plantilla(
nombrePlantilla VARCHAR(50) PRIMARY KEY
);

CREATE TABLE Alimento_Plantilla(
id int IDENTITY(1,1000) PRIMARY KEY,
idPlantilla VARCHAR(50),
idAlimento VARCHAR(10),
porcion INT NULL,
categoria VARCHAR(50),
CONSTRAINT FK_ALIMPLANTI_PLANTILLA FOREIGN KEY (idPlantilla) REFERENCES Plantilla(nombrePlantilla),
CONSTRAINT FK_APLIMPLANTI_ALIMENTO FOREIGN KEY (idAlimento) REFERENCES Alimento(id),
);



CREATE TABLE Dieta(
id INT IDENTITY(1,1000) PRIMARY KEY,
diasAplicada VARCHAR(100),
recomendacionAlimentaria VARCHAR(MAX),
recomendacionNutriccional VARCHAR(MAX),
idDeportista VARCHAR(11),
idPlantilla VARCHAR(50),
CONSTRAINT PK_DIETA_DEPORTISTA FOREIGN KEY (idDeportista) REFERENCES Persona(id),
CONSTRAINT FK_DIETA_PLANTILLA FOREIGN KEY (idPlantilla) REFERENCES Plantilla(nombrePlantilla)
);
