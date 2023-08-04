USE db_Carrito; 
/*-->sp_ = STORAGE PROCEDURE*/
CREATE PROC sp_RegistrarCategoria(
	@Descripcion VARCHAR (100),
	@Activo BIT,
	@Mensaje VARCHAR (500) OUTPUT,
	@Resultado INT OUTPUT
)
AS
BEGIN
	SET @Resultado = 0
		IF NOT EXISTS (SELECT * FROM CATEGORIAS WHERE Descripcion = @Descripcion)
			BEGIN
				INSERT INTO CATEGORIAS (Descripcion,Activo) 
				VALUES (@Descripcion,@Activo)

				SET @Resultado = SCOPE_IDENTITY();
			END
		ELSE
			SET @Mensaje = 'La categoria ya existe'
END

SELECT * FROM CATEGORIAS;

CREATE PROC sp_EditarCategoria(
	@IDCategoria INT,
	@Descripcion VARCHAR (100),
	@Activo BIT,
	@Mensaje VARCHAR (500) OUTPUT,
	@Resultado INT OUTPUT
)
AS 
BEGIN
	SET @Resultado = 0
		IF NOT EXISTS (SELECT * FROM CATEGORIAS WHERE Descripcion = @Descripcion AND IDCategoria != @IDCategoria)
			BEGIN
				UPDATE TOP (1) CATEGORIAS SET
				Descripcion = @Descripcion,
				Activo = @Activo
				WHERE IDCategoria = @IDCategoria

				SET @Resultado = 1;
			END
		ELSE
			SET @Mensaje = 'La categoria ya existe'
END

CREATE PROC sp_EliminarCategoria(
	@IDCategoria INT,
	@Mensaje VARCHAR (500) OUTPUT,
	@Resultado INT OUTPUT
)
AS
BEGIN
	SET @Resultado = 0
		IF NOT EXISTS (SELECT * FROM PRODUCTOS p INNER JOIN
						CATEGORIAS c ON c.IDCategoria = p.IDCategoria
						WHERE p.IDCategoria = @IDCategoria)/*-->Verifico que la categoria no esta adjuntada a un producto*/
			BEGIN
				DELETE TOP (1) FROM CATEGORIAS WHERE IDCategoria = @IDCategoria
				SET @Resultado = 1
			END
		ELSE
			SET @Mensaje = 'La categoria se encuentra relacionada a un producto';
END