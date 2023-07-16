CREATE DATABASE db_Carrito /*-->Creo la base de datos*/

GO

USE db_Carrito/*--->Selecciono la DB_Carrito*/

GO

/*-->Creo las tablas*/
CREATE TABLE CATEGORIAS(
	IDCategoria INT PRIMARY KEY IDENTITY, /*-->PRIMARY KEY, IDENTIDAD*/
	Descripcion VARCHAR (120),
	Activo BIT DEFAULT 1, /*BOOLEANO, POR DEFAULT ESTARA ACTIVO (1 = TRUE)*/
	FechaRegistro DATETIME DEFAULT getdate()/*SETTEA LA FECHA ACTUAL*/
)
GO

CREATE TABLE MARCAS(
	IDMarca INT PRIMARY KEY IDENTITY,
	Descripcion VARCHAR (100),
	Activo BIT DEFAULT 1, /*BOOLEANO, POR DEFAULT ESTARA ACTIVO (1 = TRUE)*/
	FechaRegistro DATETIME DEFAULT getdate() /*SETTEA LA FECHA ACTUAL*/
)
GO

CREATE TABLE PRODUCTOS(
	IDProducto INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR (250),
	Descripcion VARCHAR (300),
	IDMarca int references MARCAS(IDMarca),/*Hago referencia al IDMarca de la tabla MARCA*/
	IDCategoria int references CATEGORIAS(IDCategoria),/*Hago referencia a IDCategoria de la tabla CATEGORIA*/
	Precio FLOAT DEFAULT 0,/*Tipo float y default 0*/
	Stock int,
	RutaImagen VARCHAR(200),/*Contendra el path de la imagen*/
	NombreImagen VARCHAR (200),/*Nombre de la imagen*/
	Activo BIT DEFAULT 1,/*Si producto esta activo*/
	FechaRegistro DATETIME DEFAULT getdate()
)
GO

CREATE TABLE CLIENTES(
	IDCliente INT PRIMARY KEY IDENTITY,
	Nombres VARCHAR (100),
	Apellidos VARCHAR (100),
	Correo VARCHAR (170),
	Clave VARCHAR (170), /*-->La contraseña sera encriptada*/
	Reestablecer BIT DEFAULT 0,/*-->Para saber si va a poder reestablecer su contraseña, 1 si, 2 no debe reestablecer*/
	FechaRegistro DATETIME DEFAULT getdate()
)
GO

CREATE TABLE CARRITOS(
	IDCarrito INT PRIMARY KEY IDENTITY,
	IDCliente INT REFERENCES CLIENTES (IDCliente), /*REFERENCIO AL CLIENTE*/
	IDProducto INT REFERENCES PRODUCTOS (IDProducto),/*REFERENCIO AL PRODUCTO*/
	Cantidad INT
)
GO

CREATE TABLE VENTAS(
	IDVenta INT PRIMARY KEY IDENTITY,
	IDCliente INT REFERENCES CLIENTES (IDCliente),/*Referencio al cliente a cargo*/
	TotalProductos INT,
	MontoTotal FLOAT,
	Contacto VARCHAR (100),
	IDDistrito VARCHAR (10),
	Telefono VARCHAR (50),
	Direccion VARCHAR (200),
	IDTransaccion VARCHAR (100),/*Por definir el ID de transaccion*/
	FechaVenta DATETIME DEFAULT getdate()
)
GO

CREATE TABLE DETALLE_VENTAS(
	IDDetalleVenta INT PRIMARY KEY IDENTITY,
	IDVenta INT REFERENCES VENTAS(IDVenta),
	IDProducto INT REFERENCES PRODUCTOS(IDProducto),
	Cantidad INT,
	Total FLOAT
)
GO

CREATE TABLE USUARIOS(
	IDUsuario INT PRIMARY KEY IDENTITY,
	Nombres VARCHAR (100),
	Apellidos VARCHAR (100),
	Correo VARCHAR (120),
	Clave VARCHAR (120),
	Reestablecer BIT DEFAULT 1,/*Para reestablecer la contraseña*/
	Activo BIT DEFAULT 1, /*Esta Activo*/
	FechaRegistro DATETIME DEFAULT getdate()
)
GO

CREATE TABLE LOCALIDADES(
	IDLocalidades VARCHAR (2) NOT NULL,
	Descripcion VARCHAR (60) NOT NULL
)
GO

CREATE TABLE PROVINCIAS(
	IDProvincia VARCHAR (4) NOT NULL,
	Descripcion VARCHAR (45) NOT NULL,
	IDLocalidades VARCHAR (2) NOT NULL 
)
GO

CREATE TABLE DIRECCIONES(
	IDDireccion VARCHAR (10) NOT NULL,
	Descripcion VARCHAR (45) NOT NULL,
	IDProvincia VARCHAR (4) NOT NULL,
	IDLocalidades VARCHAR (2) NOT NULL, 
)
GO