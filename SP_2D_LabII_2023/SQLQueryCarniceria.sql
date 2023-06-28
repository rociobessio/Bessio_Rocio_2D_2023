CREATE DATABASE CARNICERIA_DB;/*--> CREO LA BASE DE DATOS*/

USE CARNICERIA_DB;
CREATE TABLE Usuarios
(
	IDUsuario INT IDENTITY (1,1) PRIMARY KEY,
	Email varchar(50) not null,
	Contrasenia varchar(50) not null, 
	IDPersona INT not null,/**/-->clave foranea a la persona a la que referencia
	FOREIGN KEY (IDPersona) REFERENCES Personas (IDPersona),
	IDCliente INT,/**/-->Hara referencia a Clientes
	FOREIGN KEY (IDCliente) REFERENCES Clientes (IDCliente),
);

USE CARNICERIA_DB;
CREATE TABLE Personas
(
	IDPersona INT IDENTITY (1,1) PRIMARY KEY,
	Nombre varchar(50) not null,
	Apellido varchar(50) not null,
	DNI varchar(10) not null,
	Telefono varchar(15) not null,
	Domicilio varchar (50) not null,
	IDRol int not null, 
	FOREIGN KEY (IDRol) REFERENCES Rol (IDRol),
);

USE CARNICERIA_DB;
CREATE TABLE Clientes
(
	IDCliente INT IDENTITY (1,1) PRIMARY KEY,
	ConTarjeta BIT not null,/*--> bit = bool --> 1 con, 0 sin*/
	EfectivoDisponible float,
	TarjetaVencimiento DateTime ,
	TarjetaEntidadEmisora varchar(50),
	TarjetaTitular varchar(50),
	TarjetaNumTarjeta varchar(20),
	TarjetaCVV varchar(10),
	TarjetaDineroDisponible float,
	TarjetaEsDebito BIT ,/*--> bit = bool --> 1 si, 0 no*/
);

CREATE TABLE Rol
(
	IDRol INT IDENTITY (1,1) PRIMARY KEY,
	Cargo	varchar(20) not null,
);

SELECT * FROM Usuarios u INNER JOIN Clientes c ON u.IDCliente = c.IDCliente; 

SELECT P.IDRol FROM Usuarios u INNER JOIN Personas P ON U.IDPersona = P.IDPersona WHERE
u.Email = 'rocibessio@gmail.com' AND u.Contrasenia = '123';

SELECT P.IDRol FROM Usuarios U INNER JOIN Personas P ON U.IdPersona = P.IDPersona WHERE U.Email = 'rocibessio@gmail.com' AND U.Contrasenia = '123'; 

USE CARNICERIA_DB;
CREATE TABLE Vendedores/*-->CREO TABLA VENDEDORES*/
(
	IDVendedor  INT IDENTITY (1,1) PRIMARY KEY, 
	Nombre varchar(50) not null,
	Apellido varchar(50) not null,
	DNI varchar(50) not null,
	FOREIGN KEY (IDVendedor) REFERENCES Usuarios(ID)/*Hago referencia al id de usuarios conectando tablas.*/
); 

USE CARNICERIA_DB;
Create TABLE Productos/*-->CREO TABLA DE PRODUCTOS*/
(
	IdProducto INT IDENTITY(1,1) PRIMARY KEY ,
	Tipo varchar(50) not null,
	Corte varchar(50) not null,
	Categoria varchar(50) not null,
	Peso float ,
	PrecioCompraCliente float,
	Proveedor varchar(50) not null,
	PrecioVentaProveedor float,
	Vencimiento varchar(55) not null 
);

USE CARNICERIA_DB;
/*-->CREO PRODUCTOS*/
INSERT INTO Productos (Tipo,Corte,Categoria,Peso,PrecioCompraCliente,
					   Proveedor,PrecioVentaProveedor, Vencimiento)
VALUES ('Carne Vacuna','Lomo','Ternero',19,1200,'Mingo CO',900,'2025-06-29'),
	   ('Pollo','Pollo Entero','No Es Bovino',21,1500,'La Granjita',1200,'2025-09-29'),
	   ('Cerdo','Matambre','No Es Bovino',10,1700,'Chascomus LA',1200,'2025-06-12'),
	   ('Carne Vacuna','Asado','Ternerito',7,500,'Siga la Vaca',250,'2025-07-01'),
	   ('Pollo','Pechuga','No Es Bovino',12,1100,'La Granjita',950,'2025-06-19'),
	   ('Cerdo','Pechito','No Es Bovino',17,2000,'Siga la Vaca',800,'2025-08-08'),
	   ('Carne Vacuna','Bife Angosto','Novillito',5,500,'Chascomus LA',250,'2025-09-13'),
	   ('Cerdo','Costilla','No Es Bovino',10,1500,'Mingo CO',1250,'2025-10-23'),
	   ('Pollo','Pata Y Muslo','No Es Bovino',9,1200,'Siga la Vaca',790,'2025-11-16'),
	   ('Cerdo','Solomillo','No Es Bovino',15,2500,'La Granjita',1250,'2025-08-21'),
	   ('Pollo','Suprema','No Es Bovino',20,2000,'Siga la Vaca',1250,'2025-08-27'),
	   ('Cerdo','Vacio','No Es Bovino',10,1700,'Chascomus LA',1050,'2025-10-16');