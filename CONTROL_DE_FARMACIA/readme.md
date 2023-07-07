# *FARMACIA UOM*

Esta aplicación fue desarrollada con el objetivo de conocer más el lenguaje de C# y las herramientas que brinda, a su vez la utilización de SQLManagment para poder crear 
una base de datos.

## Resumen de la aplicación 
1. Al iniciarla se abrirá un formulario de Login para que le usuario pueda registrarse. Existen tres tipos de perfiles en la aplicación: *Farmacéutico*,
*Administrador* y *Cliente* cada uno de estos puede realizar tareas totalmente distintas.
2. Dependiendo del perfil que ingrese se abrirán tres formularios totalmente distintos:
### PERFIL DE ADMINISTRADOR: 

![Screenshot (5)](https://user-images.githubusercontent.com/98594436/223005873-a21d004b-ccc3-4586-9bfc-9a64cadff60f.png)
1. Al seleccionar el botón 'PANEL' podrá visualizar que tarea puede realizar cada perfil dentro de la aplicación.
2. Al seleccionar el botón 'AGREGAR USUARIO' podrá añadir un nuevo usuario con el perfil que quiera al sistema de la aplicación.
3. Al seleccionar el botón 'VER USUARIOS' el administrador podrá visualizar toda la data que tiene cada usuario (Username, password, email, nacimiento, etc.).
4. Al seleccionar el botón 'PERFIL' podrá actualizar su propio perfil, es decir, cambiar su información.
5. Por último, al presionar 'LOG OUT' el administrador cerrará sesión con su cuenta y podrá utilizar otra, ya sea cuenta de administrador, farmacéutico o cliente.

### PERFIL DE FARMACÉUTICO:

![Menu Farmaceutico](https://user-images.githubusercontent.com/98594436/223008073-7d9ebc68-21cd-4b22-867a-f5f98e9ca198.png)
1. Al presionar el botón 'PANEL' podrá ver un chart de las medicinas, las expiradas y las que aún no expiraron. *(ARREGLAR)*
2. Al presionar el botón 'AGREGAR MEDICINA' el farmacéutico podrá añadir una nueva medicina al sistema, cargando su vencimiento, fecha de elaboración, nombre, etc.
3. Al presionar el botón 'VER MEDICAMENTOS' podrá visualizar todos los medicamentos y buscar el que requiera dentro de la base de datos.
4. Al presionar el botón 'MODIFCAR MEDICINA' el usuario podrá buscar y modificar la medicina que requiera.
5. Al presionar el botón 'VALIDAR FECHAS MEDICINAS' el farmacéutico a cargo podrá filtrar aquellas medicinas expiradas, sin expirar y todas las medicinas.
6. Al presionar el botón 'VENDER MEDICINA' podrá vender una medicina y las cantidades que requiera un cliente. Puede añadirlas al carrito, eliminarlas e incluso
imprimir un comprobante de compra.
7. Por último, al presionar 'LOG OUT' el farmacéutico cerrará sesión con su cuenta y podrá utilizar otra, ya sea cuenta de administrador, farmacéutico o cliente.

### PERFIL DE Cliente:
![Menu Clientes](https://user-images.githubusercontent.com/98594436/223311079-640f8d8f-6211-4064-8edf-c4b28b5c8edc.png)
1. Al presionar el botón 'PANEL' el cliente podrá....(A resolver)
2. Al presionar el botón 'PEDIR TURNO' el cliente podrá pedir un turno con la especialidad que requiera e imprimir ticket del turno. (Quedan validaciones)
3. Al presionar el botón 'VER TURNOS' el cliente podrá visualizar todos sus turnos adjuntados.
4. Al presionar el botón 'COMPRAR MEDICINA' podrá comprar medicina de la farmacia e imprimir su comprobante de pago.
5. Por último, al presionar 'LOG OUT' el farmacéutico cerrará sesión con su cuenta y podrá utilizar otra, ya sea cuenta de administrador, farmacéutico o cliente.

### USUARIOS Y CONTRASEÑAS:
User: Rocio  || Contraseña: 123  || Perfil: Administrador

User: Lucas  || Contraseña: 123  || Perfil: Administrador

User: Pau    || Contraseña: 123  || Perfil: Administrador

User: Marcos || Contraseña: 123  || Perfil: Farmacéutico

User: Gas    || Contraseña: 123  || Perfil: Cliente

User: MariaG || Contraseña: 123  || Perfil: Cliente

### ARREGLOS - MEJORAS A FUTURO
A. Crear las entidades Administrador, Farmacéutico, Cliente y sus respectivas clases para conectar a la base de datos.

B. Arreglar Panel Farmacéutico (Poner un chart) y Validar medicinas Farmacéutico (Arreglar).

C. En cliente queda realizar el PANEL y validaciones dentro del apartado de PEDIR TURNOS.


