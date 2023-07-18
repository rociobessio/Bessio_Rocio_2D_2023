/*CONSULTAS*/
USE db_Carrito/*--->Selecciono la DB_Carrito*/

GO
/*AÑADO UN USUARIO DE PRUEBA*/
INSERT INTO USUARIOS(Nombres,Apellidos,Correo,Clave)/*Activo y reestablecer son por default al momento de este INSERT*/
/*Clave es encriptada y que no sea visualizada por un programador, la d este usuario es 123456 o 12345 o 123*/
VALUES ('Gaston','Ramiréz','gastrami@gmail.com','5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5');
SELECT * FROM USUARIOS

INSERT INTO USUARIOS(Nombres,Apellidos,Correo,Clave)/*Activo y reestablecer son por default al momento de este INSERT*/
/*Clave es encriptada y que no sea visualizada por un programador, la de este usuario es 456*/
VALUES ('Federico Valentín','Estevanez','fedvalest@yahoo.com.ar','b3a8e0e1f9ab1bfe3a36f231f676f78bb30a519d2b21e6c530c0eee8ebb4a5d0');
SELECT * FROM USUARIOS

INSERT INTO USUARIOS(Nombres,Apellidos,Correo,Clave)/*Activo y reestablecer son por default al momento de este INSERT*/
/*Clave es encriptada y que no sea visualizada por un programador, la de este usuario es 678*/
VALUES ('Carla','Bolgne','carbol@gmail.com','cebe3d9d614ba5c19f633566104315854a11353a333bf96f16b5afa0e90abdc4');
SELECT * FROM USUARIOS

/*AÑADO ALGUNAS CATEGORIAS*/
INSERT INTO CATEGORIAS(Descripcion) VALUES ('Tecnologia'),
										   ('Muebles'),
										   ('Deportes'),
										   ('Dormitorio');
SELECT * FROM CATEGORIAS

/*AÑADO ALGUNAS MARCAS*/
INSERT INTO MARCAS (Descripcion) VALUES 
										('SONY'),
										('PHILIPS'),
										('LG'),
										('CANON'),
										('BLUESKY');
SELECT * FROM MARCAS

/*DONDE SE ENVIA EL PRODUCTO, PARA EL CLIENTE*/
INSERT INTO LOCALIDADES (IDLocalidades,Descripcion) VALUES
															  ('01','Lanús Oeste'),
															  ('02','Avellaneda'),
															  ('03','Caballito');
SELECT * FROM LOCALIDADES 

/*PROVINCIA DE DONDE SE ENVIARA*/
INSERT INTO PROVINCIAS (IDProvincia,Descripcion,IDLocalidades) VALUES 
																      ('0101','GBA (Buenos Aires)','01'),
																	  ('0201','GBA (Buenos Aires)','02'),
																	  ('0301','Capital Federal','03');
SELECT * FROM PROVINCIAS;

/*Direcciones*/
INSERT INTO DIRECCIONES (IDDireccion,Descripcion,IDProvincia,IDLocalidades)
VALUES 
	  ('010101','Av. Hipólito Yrigoyen 2193','0101','01'),/*IDDireccion = 01 (IDLocalidad) 01 (IDProv) 01 (IDDireccion)*/
	  ('020101','Av. Mitre 782','0201','02'), /*IDDireccion = 02 (IDLocalidad) 01 (IDProv) 01 (IDDireccion)*/
	  ('030101','Rosario 400','0301','03'), /*IDDireccion = 03 (IDLocalidad) 01 (IDProv) 01 (IDDireccion)*/
	  ('030102','Neuquén 1600','0302','03')
SELECT * FROM DIRECCIONES;