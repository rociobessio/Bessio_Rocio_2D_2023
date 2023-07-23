USE db_Carrito;

SELECT * FROM MARCAS;

/*-->sp_ = STORAGE PROCEDURE*/
CREATE PROC sp_RegistrarMarcas(
	@Descripcion VARCHAR (100),
	@Activo BIT,
	@Mensaje VARCHAR (500) OUTPUT,
	@Resultado INT OUTPUT
)
AS
BEGIN
	SET @Resultado = 0
		IF NOT EXISTS (SELECT * FROM MARCAS WHERE Descripcion = @Descripcion)
			BEGIN
				INSERT INTO MARCAS (Descripcion,Activo) 
				VALUES (@Descripcion,@Activo)

				SET @Resultado = SCOPE_IDENTITY();
			END
		ELSE
			SET @Mensaje = 'La marca ya existe'
END

CREATE PROC sp_EditarMarca(
	@IDMarca INT,
	@Descripcion VARCHAR (100),
	@Activo BIT,
	@Mensaje VARCHAR (500) OUTPUT,
	@Resultado INT OUTPUT
)
AS 
BEGIN
	SET @Resultado = 0
		IF NOT EXISTS (SELECT * FROM MARCAS WHERE Descripcion = @Descripcion AND IDMarca != @IDMarca)
			BEGIN
				UPDATE TOP (1) MARCAS SET
				Descripcion = @Descripcion,
				Activo = @Activo
				WHERE IDMarca = @IDMarca

				SET @Resultado = 1;
			END
		ELSE
			SET @Mensaje = 'La marca ya existe'
END

CREATE PROC sp_EliminarMarca(
	@IDMarca INT,
	@Mensaje VARCHAR (500) OUTPUT,
	@Resultado INT OUTPUT
)
AS
BEGIN
	SET @Resultado = 0
		IF NOT EXISTS (SELECT * FROM PRODUCTOS p INNER JOIN
						MARCAS m ON m.IDMarca = p.IDMarca
						WHERE p.IDMarca = @IDMarca)
			BEGIN
				DELETE TOP (1) FROM MARCAS WHERE IDMarca = @IDMarca
				SET @Resultado = 1
			END
		ELSE
			SET @Mensaje = 'La marca se encuentra relacionada a un producto';
END