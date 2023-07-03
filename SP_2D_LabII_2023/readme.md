# SEGUNDO PARCIAL LABORATORIO II, CARNICERIA: 'FELICES LAS VACAS'
## LOGIN
----------
<img width="468" alt="Screenshot_96" src="https://github.com/rociobessio/PP_2D_LabII_2023/assets/98594436/14086696-1bfb-4318-8bb0-578e7941b6f1">

1) El usuario podrá ingresar bajo dos perfiles, Vendedor y Cliente, dependiendo el perfil se cambiara el color del formulario.
2) Existen 3 botones: el botón 'Cliente' muestra en los textboxes el email y contraseña de un Cliente hardcodeado para facilitar el ingreso a la aplicacion, lo mismo sucederá al presionar el botón 'Vendedor'. El botón 'Iniciar Sesión' buscará de que perfil es lo ingresado por los textboxes.
3) Por último, abrirá los Forms correspondientes a cada perfil.
4) Al pararse sobre el icono 'Ayuda/Call-Center' abajo a la izquierda, imprime un mensaje de ayuda para el usuario.

# Perfil Vendedor:
-------------------
## Menu Principal: 
<img width="440" alt="Screenshot_116" src="https://github.com/rociobessio/Bessio_Rocio_2D_2023/assets/98594436/c5c4ab31-8b59-4347-9b48-c0f5d437bd0b">

1) Se le abrirá un menu principal al vendedor en el cual podrá elegir las distintas acciones que puede realizar.
2) Al pararse sobre el icono 'Ayuda/Call-Center' abajo a la izquierda, imprime un mensaje de ayuda para el usuario.

## Vender: 
<img width="500" alt="Screenshot_98" src="https://github.com/rociobessio/PP_2D_LabII_2023/assets/98594436/949356b6-4821-49a0-8c9f-444b05c4bacd">

1) Deberá de seleccionar a un cliente de la lista para venderle un producto que este disponible.
2) Se mostrarán los datos mas relevantes del cliente para el vendedor.
3) Se podrá visualizar el método de pago y calcular el costo del producto vendido.
4) Para vender tendrá que especificar los kilos que necesite.
5) Además podrá sumarle dinero al cliente seleccionado.
6) Al pararse sobre el icono 'Ayuda/Call-Center' abajo a la izquierda, imprime un mensaje de ayuda para el usuario.

## Heladera: 
 <img width="674" alt="Screenshot_117" src="https://github.com/rociobessio/Bessio_Rocio_2D_2023/assets/98594436/a9899985-e520-44a5-9c46-f28187e86d54">

1) El vendedor será capaz de agregar un nuevo producto a la lista.
2) Podrá eliminar/modificar un producto seleccionado.
3) Será capaz de reponer productos si hay stock en 0 de algún producto, simulando una reposición en tiempo real, utilizando
delegados, eventos, hilos y concurrencia.
4) Para ver los cambios de la reposición se le facilitará ir refrescando el datagridview.
5) A su vez, se podrá generar una copia de seguridad de la lista actual si lo requiere, esta se guarda en formato XML para
luego ser deserializada y mostrada en el form correspondiente.
6) Al pararse sobre el icono 'Ayuda/Call-Center' abajo a la izquierda, imprime un mensaje de ayuda para el usuario.

## Historial de Ventas (.txt):
-------------------------------
<img width="449" alt="Screenshot_100" src="https://github.com/rociobessio/PP_2D_LabII_2023/assets/98594436/e093fab6-914a-4ee3-8a7f-7bd35e4cc4b3">

1) Podrá seleccionar una factura/ticket y visualizar su detalle.
2) Se utilizo txt.
3) Al pararse sobre el icono 'Ayuda/Call-Center' abajo a la izquierda, imprime un mensaje de ayuda para el usuario.

## Visualizar Productos:  
<img width="445" alt="Screenshot_101" src="https://github.com/rociobessio/PP_2D_LabII_2023/assets/98594436/05056bec-cfaa-4513-9629-3ac54fb6247a">

1) Será capaz de ver aquellos tickets guardados pero en este caso utilizando serialización y deserialización en XML y JSON.
2) Aquellas ventas realizadas por el perfil del VENDEDOR fueron serializadas y deserializadas en JSON.
3) Y las compras realizadas bajo el perfil de CLIENTE serán serializadas y deserializadas en XML.
4) Al pararse sobre el icono 'Ayuda/Call-Center' abajo a la izquierda, imprime un mensaje de ayuda para el usuario.

## Ver Copia de Seguridad:
 <img width="523" alt="Screenshot_118" src="https://github.com/rociobessio/Bessio_Rocio_2D_2023/assets/98594436/ff235939-52e4-463a-ac71-a5b093a7beb5">

1) Le permitirá al usuario visualizar la última copia de seguridad realizada por el vendedor.


# Perfil Cliente:
-------------------
## Método de pago: 
<img width="342" alt="Screenshot_102" src="https://github.com/rociobessio/PP_2D_LabII_2023/assets/98594436/2eae6e8b-8068-410a-b67f-a249972c754e">

1) El cliente deberá de ingresar su método de pago.
2) Solo contará con una única opción de pago por el momento.
3) Se validarán los datos ingresados para no tener errores.
4) Por último, si pasa las validaciones es redireccionado a un formulario de Compra.
5) Al pararse sobre el icono 'Ayuda/Call-Center' abajo a la izquierda, imprime un mensaje de ayuda para el usuario.

## Comprar: 
<img width="478" alt="Screenshot_103" src="https://github.com/rociobessio/PP_2D_LabII_2023/assets/98594436/08c834e6-0ca5-4967-8117-73d7aff308b8">

1) El cliente podrá comprar un producto disponible de la carnicería.
2) Se mostraran algunos datos, como su billetera que mostrará con que paga,el máximo disponible y el saldo que le va quedando al comprar.
3) Podrá filtrar el corte de carne que requiera para agilizar la busqueda.
4) Al presionar el botón 'Comprar' se realizarán las validaciones necesarias y si puede compra.
5) Si presiona 'Cancelar' eliminará todos los productos del carrito.
6) Al pararse sobre el icono 'Ayuda/Call-Center' abajo a la izquierda, imprime un mensaje de ayuda para el usuario.

## Diagrama de Clases
---------------------
<img width="770" alt="DiagramaDeClases" src="https://github.com/rociobessio/Bessio_Rocio_2D_2023/assets/98594436/2b1033d6-c122-4f70-9bb2-05871901e732">


## ![medical-14_icon-icons com_73923 (1)](https://github.com/rociobessio/PP_2D_LabII_2023/assets/98594436/4c538339-b72a-44df-a6d3-a014250561d0) Unit Testing:

La aplicación cuenta con 6 clases de Unit Testings sobre métodos de SQL y Deserialización. 

## Correcciones para el recuperatorio:
Lanzar y atrapar las excepciones propias. ![tickcircleregular_106336](https://github.com/rociobessio/Bessio_Rocio_2D_2023/assets/98594436/0a821968-ec37-4016-b6fc-fefd26bef1f8)


Hay uno de los metodos de la interfaz que implementa codigo y no debe de pasar. ![tickcircleregular_106336](https://github.com/rociobessio/Bessio_Rocio_2D_2023/assets/98594436/f71c962d-5b2d-4d23-8d93-fac8380f7ac7)


try-catch en formularios. ![tickcircleregular_106336](https://github.com/rociobessio/Bessio_Rocio_2D_2023/assets/98594436/0381f08e-cb0f-401f-9faa-dd5ff9c65fde)

