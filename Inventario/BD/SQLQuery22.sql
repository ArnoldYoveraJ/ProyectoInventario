--BASE DE DATOS
CREATE DATABASE BDINVENTARIO;

USE BDINVENTARIO
GO
--TABLA PRODUCTO
IF exists(select * from sysobjects where name='PRODUCTOS' AND TYPE='U')
BEGIN
		CREATE TABLE PRODUCTOS(
		COD_PRODUCTO INT IDENTITY PRIMARY KEY,
		NOM_PRODUCTO VARCHAR(30) NOT NULL,
		MARCA VARCHAR(30) NOT NULL,
		MODELO_PLACA VARCHAR(30) NULL,
		SERIE VARCHAR(50) NOT NULL,
		PROCESADOR VARCHAR(20) NULL,
		DD VARCHAR(20)  NULL,
		RAM VARCHAR(20) NULL,
		SO VARCHAR(20) NULL,
		IMAGEN IMAGE NULL,
		ESTADO INT NOT NULL,
		DESCRIPCION VARCHAR(50) NULL,
		--FECHA DATE NOT NULL,
		COD_CAT INT,
		COD_TRABAJADOR INT
	)
	PRINT 'YA EXISTE'
END
ELSE
BEGIN
	SELECT 'YA EXISTE LA TABLA PRODUCTOS';
END
GO

CREATE TABLE TRABAJADOR(
COD_TRABAJADOR INT IDENTITY PRIMARY KEY,
NOMBRES VARCHAR(50) NOT NULL,
APELLIDOS VARCHAR(50) NULL,
DNI CHAR(8) NOT NULL,
EMAIL VARCHAR(60) NULL,
ANEXO CHAR(4) NULL,
COD_AREA INT,
COD_EMPRESA INT
)

CREATE TABLE PROVEEDOR(
COD_PROV INT IDENTITY PRIMARY KEY,
RAZON_SOCIAL VARCHAR(100)  NOT NULL,
SECTOR_COMERCIAL VARCHAR(50) NOT NULL,
TIPO_DOC VARCHAR(20) NOT NULL,
NUM_DOC VARCHAR(11)NOT NULL,
DIRECCION VARCHAR(60) NULL,
TELEFONO VARCHAR(20) NULL,
EMAIL VARCHAR(60) NULL
)

CREATE TABLE EMPRESA(
COD_EMPRESA INT IDENTITY PRIMARY KEY,
NOM_EMPRESA VARCHAR(50) NOT NULL
)

CREATE TABLE AREA(
COD_AREA INT IDENTITY PRIMARY KEY,
NOM_AREA VARCHAR(30) NOT NULL
)

CREATE TABLE CATEGORIA(
COD_CAT INT IDENTITY PRIMARY KEY,
NOM_CAT VARCHAR(30) NOT NULL
)

CREATE TABLE USUARIO(
COD_USU INT IDENTITY PRIMARY KEY,
NOMBRE_COMPLETO VARCHAR(100) NOT NULL,
USUARIO VARCHAR(30)NOT NULL,
CONTRA VARCHAR(20) NOT NULL,
TIPO VARCHAR(20)NOT NULL,
ESTADO INT NOT NULL
)

CREATE TABLE ORDEN(
COD_ORDEN INT IDENTITY PRIMARY KEY,
FECHA DATE NOT NULL,
TIPO_COMPROBANTE VARCHAR(20) NOT NULL,
COD_USU INT,
COD_PROV INT
)

CREATE TABLE DETALLE_ORDEN(
COD_DETORD INT IDENTITY PRIMARY KEY,
--PRECIO DECIMAL NULL,
STOCK_INICIAL INT NOT NULL,
STOCK_ACTUAL INT NOT NULL,
COD_ORDEN INT,
COD_PRODUCTO INT
)

ALTER TABLE PRODUCTOS ADD CONSTRAINT FK_CLIENTE FOREIGN KEY(COD_TRABAJADOR) 
REFERENCES TRABAJADOR(COD_TRABAJADOR)

ALTER TABLE PRODUCTOS ADD CONSTRAINT FK_CATEGORIA FOREIGN KEY(COD_CAT) 
REFERENCES CATEGORIA(COD_CAT)

ALTER TABLE TRABAJADOR ADD CONSTRAINT FK_EMPRESA FOREIGN KEY(COD_EMPRESA) 
REFERENCES EMPRESA(COD_EMPRESA)

ALTER TABLE TRABAJADOR ADD CONSTRAINT FK_AREA FOREIGN KEY (COD_AREA)
REFERENCES AREA(COD_AREA)

ALTER TABLE ORDEN ADD CONSTRAINT FK_ORDEN FOREIGN KEY (COD_USU)
REFERENCES USUARIO(COD_USU)

ALTER TABLE ORDEN ADD CONSTRAINT FK_ORDEN1 FOREIGN KEY (COD_PROV)
REFERENCES PROVEEDOR(COD_PROV)

ALTER TABLE DETALLE_ORDEN ADD CONSTRAINT FK_DET_ORDEN FOREIGN KEY (COD_ORDEN)
REFERENCES ORDEN(COD_ORDEN)

ALTER TABLE DETALLE_ORDEN ADD CONSTRAINT FK_DET_ORDEN1 FOREIGN KEY (COD_PRODUCTO)
REFERENCES PRODUCTOS(COD_PRODUCTO)