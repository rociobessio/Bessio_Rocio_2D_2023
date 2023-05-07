# Primer Parcial: "Carnicería: Felices las vacas".
En este repositorio se desarollo una aplicación del tipo carnicería.

## Inicio de Sesión:
----------------------- 
<img width="468" alt="Screenshot_26" src="https://user-images.githubusercontent.com/98594436/236694799-0e05c828-da78-4e72-b22b-a6884ec68c9a.png">

1) El usuario podrá ingresar bajo dos perfiles, Vendedor y Cliente, dependiendo el perfil se cambiara el color del formulario.
2) Existen 3 botones: el botón 'Cliente' muestra en los textboxes el email y contraseña de un Cliente hardcodeado para facilitar el ingreso a la aplicacion, lo mismo sucederá al presionar el botón 'Vendedor'. El botón 'Iniciar Sesión' buscará de que perfil es lo ingresado por los textboxes.
3) Por último, abrirá los Forms correspondientes a cada perfil.
4) Al pararse sobre el icono 'Ayuda/Call-Center' abajo a la izquierda, imprime un mensaje de ayuda para el usuario.

# Perfil Vendedor:
----------------------
## Reponer stock:
<img width="588" alt="eqwe" src="https://user-images.githubusercontent.com/98594436/236694820-dd0f4420-a11e-43ab-8be7-e848df78ea35.png">

1) El Vendedor podrá reponer productos al stock de la carnicería.
2) Podrá agregar al stock, cambiar el precio de compra por kilo y cambiar el tipo de corte del producto.
3) Siempre y cuando pase las validaciones necesarias, si las pasa entonces se actualiza el stock.
4) Al presionar el botón vender se abrirá un nuevo Form para poder venderle a un cliente los productos.
5) Al pararse sobre el icono 'Ayuda/Call-Center' abajo a la izquierda, imprime un mensaje de ayuda para el usuario.

## Historial de Ventas:
<img width="445" alt="Screenshot_17" src="https://user-images.githubusercontent.com/98594436/236600062-883d030e-f422-4e1a-90ea-5da3553c1635.png">

1) El vendedor podrá ver el historial de ventas que hay.
2) Al pararse sobre el icono 'Ayuda/Call-Center' abajo a la izquierda, imprime un mensaje de ayuda para el usuario.

## Vender producto: 
<img width="501" alt="Screenshot_14" src="https://user-images.githubusercontent.com/98594436/236503620-6d22c9cf-f00d-4e39-9509-a96dead00b14.png">

1) Deberá de seleccionar a un cliente de la lista para venderle un producto que este disponible.
2) Se mostrarán los datos mas relevantes del cliente para el vendedor.
3) Se podrá visualizar el método de pago y calcular el costo del producto vendido.
4) Para vender tendrá que especificar los kilos que necesite.
5) Al pararse sobre el icono 'Ayuda/Call-Center' abajo a la izquierda, imprime un mensaje de ayuda para el usuario.

# Perfil Cliente:
----------------------
## Método de pago:
![MetodoDePagoCliente](https://user-images.githubusercontent.com/98594436/235378605-94bc526a-c778-4cd4-aac2-48f46035ec48.png)

1) El cliente deberá de ingresar su método de pago.
2) Solo contará con una única opción de pago por el momento.
3) Se validarán los datos ingresados para no tener errores.
4) Por último, si pasa las validaciones es redireccionado a un formulario de Compra.
5) Al pararse sobre el icono 'Ayuda/Call-Center' abajo a la izquierda, imprime un mensaje de ayuda para el usuario.

## Compra Productos Cliente:
<img width="478" alt="Screenshot_8" src="https://user-images.githubusercontent.com/98594436/236359129-3008937a-59b3-4a89-87a0-f761a713bfde.png">

1) El cliente podrá comprar un producto disponible de la carnicería.
2) Se mostraran algunos datos, como su billetera que mostrará con que paga,el máximo disponible y el saldo que le va quedando al comprar.
3) Podrá filtrar el corte de carne que requiera para agilizar la busqueda.
4) Al presionar el botón 'Comprar' se realizarán las validaciones necesarias y si puede compra.
5) Si presiona 'Cancelar' eliminará todos los productos del carrito.
6) Al pararse sobre el icono 'Ayuda/Call-Center' abajo a la izquierda, imprime un mensaje de ayuda para el usuario.

# Diagrama de clases:
----------------------
<img width="572" alt="DiagramaDeClases" src="https://user-images.githubusercontent.com/98594436/236694843-2407007f-fed6-45c9-8057-715b6e163186.png">

