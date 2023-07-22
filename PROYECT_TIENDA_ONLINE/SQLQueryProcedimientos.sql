USE db_Carrito;

SELECT * FROM USUARIOS;

/*-->Es como un método que me permitira REGISTRAR un usuario*/
CREATE PROC sp_RegistrarUsuario(
	@Nombres VARCHAR (100),
	@Apellidos VARCHAR (100),
	@Correo VARCHAR (100),
	@Clave VARCHAR (100),
	@Activo BIT,
	@Mensaje VARCHAR (500) OUTPUT,/*-->MENSAJE DE SALIDA*/
	@Resultado INT OUTPUT /*-->RESULTADO DE SALIDA*/
)/*-->Son los parametros que RECIBE*/
AS
BEGIN
	SET @Resultado = 0
	IF NOT EXISTS (SELECT * FROM USUARIOS WHERE Correo = @Correo)/*-->Verifico que el correo NO EXISTA*/
		BEGIN
			INSERT INTO USUARIOS(Nombres,Apellidos,Correo,Clave,Activo)
			VALUES (@Nombres,@Apellidos,@Correo,@Clave,@Activo)
				SET @Resultado = SCOPE_IDENTITY()
		END
	ELSE
		SET @Mensaje = 'El correo introducido ya existe.';
END

/*-->Es como un método que me permitira EDITAR un usuario*/
CREATE PROC sp_EditarUsuario(
	@IDUsuario INT,
	@Nombres VARCHAR (100),
	@Apellidos VARCHAR (100),
	@Correo VARCHAR (100),
	@Activo BIT,
	@Mensaje VARCHAR (500) OUTPUT,/*-->MENSAJE DE SALIDA*/
	@Resultado INT OUTPUT /*-->RESULTADO DE SALIDA*/
)
AS
BEGIN
	SET @Resultado = 0/*-->Setteo como false el parametro de salida*/
	/*-->Verifico que el correo NO EXISTA en otro usuario Y el ID no coincida*/
	IF NOT EXISTS (SELECT * FROM USUARIOS WHERE Correo = @Correo AND IDUsuario != @IDUsuario)
		BEGIN
			UPDATE TOP (1) USUARIOS SET
			Nombres = @Nombres,
			Apellidos = @Apellidos,
			Correo = @Correo,
			Activo = @Activo
			WHERE IDUsuario = @IDUsuario

			SET @Resultado = 1/*-->Si salio bien retorno true*/
		END
	ELSE
		SET @Mensaje = 'El correo introducido ya existe.';
END
