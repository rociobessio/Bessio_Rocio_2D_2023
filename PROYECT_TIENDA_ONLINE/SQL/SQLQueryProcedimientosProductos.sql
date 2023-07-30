USE db_Carrito;

CREATE PROC sp_RegistrarProducto(
	@Nombre VARCHAR (100),
	@Descripcion VARCHAR (1000),
	@IDMarca VARCHAR (100),
	@IDCategoria VARCHAR (100),
	@Precio FLOAT ,
	@Stock INT,
	@Activo BIT,
	@Mensaje VARCHAR (500) OUTPUT,
	@Resultado INT OUTPUT
)
AS
BEGIN
	SET @Resultado = 0
		IF NOT EXISTS (SELECT * FROM PRODUCTOS WHERE Nombre = @Nombre)
			BEGIN
				INSERT INTO PRODUCTOS (Nombre,Descripcion,IDMarca,IDCategoria,Precio,Stock,Activo)
					VALUES (@Nombre,@Descripcion,@IDMarca,@IDCategoria,@Precio,@Stock,@Activo)

					SET @Resultado = SCOPE_IDENTITY();
			END
		ELSE
			SET @Mensaje = 'El producto ya existe';
END

CREATE PROC sp_EditarProducto(
	@IDProducto INT,
	@Nombre VARCHAR (100),
	@Descripcion VARCHAR (1000),
	@IDMarca VARCHAR (100),
	@IDCategoria VARCHAR (100),
	@Precio FLOAT ,
	@Stock INT,
	@Activo BIT,
	@Mensaje VARCHAR (500) OUTPUT,
	@Resultado INT OUTPUT
)
AS
BEGIN
	SET @Resultado = 0
		IF NOT EXISTS (SELECT * FROM PRODUCTOS WHERE Nombre = @Nombre AND IDProducto != @IDProducto)
			BEGIN
				UPDATE PRODUCTOS SET
					Nombre = @Nombre,
					Descripcion = @Descripcion,
					IDMarca  = @IDMarca,
					IDCategoria = @IDCategoria,
					Precio = @Precio,
					Stock = @Stock,
					Activo = @Activo
				WHERE IDProducto = @IDProducto
				SET @Resultado = 1
			END
		ELSE
			SET @Mensaje = 'El producto ya existe';
END

CREATE PROC sp_EliminarProducto(
	@IDProducto INT,
	@Mensaje VARCHAR (500) OUTPUT,
	@Resultado INT OUTPUT
)
AS
BEGIN
	SET @Resultado = 0
		IF NOT EXISTS (SELECT * FROM DETALLE_VENTAS dv 
			INNER JOIN PRODUCTOS p ON p.IDProducto = DV.IDProducto
			WHERE p.IDProducto = @IDProducto)

			BEGIN
				DELETE TOP (1) FROM PRODUCTOS WHERE IDProducto = @IDProducto
				SET @Resultado = 1;
			END
		ELSE
			SET @Mensaje = 'El producto se encuentra relacionado a una venta';
END