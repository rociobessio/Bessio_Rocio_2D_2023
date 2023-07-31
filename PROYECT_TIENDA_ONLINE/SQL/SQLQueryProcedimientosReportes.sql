USE db_Carrito 



CREATE PROC sp_ReporteVentas(
	@fechaInicio VARCHAR (10),
	@fechaFin VARCHAR (10),
	@IDTransaccion VARCHAR (50)
)
AS
BEGIN
	SET DATEFORMAT dmy;
/*--> Lo que quiero obtener*/
	SELECT CONVERT(char(10), v.FechaVenta, 103)[FechaVenta],/*-->CONVIERTO LA FECHA a dd/mm/aaaa y le pongo un alias [FechaVenta]*/
	CONCAT(c.Nombres,' ',c.Apellidos)[Cliente],/*-->CONCATENO LOS NOMBRES*/
	p.Nombre[Producto], p.Precio, dv.Cantidad, dv.Total, v.IDTransaccion
	FROM DETALLE_VENTAS dv
	INNER JOIN PRODUCTOS p on p.IDProducto = dv.IDProducto
	INNER JOIN VENTAS v on v.IDVenta = dv.IDVenta
	INNER JOIN CLIENTES c on c.IDCliente = dv.IDCliente
		WHERE CONVERT(date, v.fechaVenta) BETWEEN @fechaInicio AND @fechaFin
		AND v.IDTransaccion = IIF(@IDTransaccion = '', v.IDTransaccion, @IDTransaccion)/*-->Si no ingresa una fecha*/
END