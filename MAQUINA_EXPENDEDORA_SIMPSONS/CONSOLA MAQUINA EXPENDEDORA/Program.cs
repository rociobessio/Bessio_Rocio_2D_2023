using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using UNIDAD_06_ENTIDADES;

namespace EJERCICIO_C03_UNIDAD_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PARTE 01 
            //PARTE 01 EJERCICIO
            //Dictionary<int,string> maquinaExpendedora = new Dictionary<int,string>();

            ////Instancio 10 productos
            //maquinaExpendedora.Add(1,"NUKA-COLA PREMIUM");
            //maquinaExpendedora.Add(2, "ICED NUKA-COLA");
            //maquinaExpendedora.Add(3, "DONUT");
            //maquinaExpendedora.Add(4, "FANTA");
            //maquinaExpendedora.Add(5, "SOUR PATCH");
            //maquinaExpendedora.Add(6, "SKITTLES");
            //maquinaExpendedora.Add(7, "KIT-KAT");
            //maquinaExpendedora.Add(8, "HARIBO");
            //maquinaExpendedora.Add(9, "OREO");
            //maquinaExpendedora.Add(10, "NERDS");

            //string inputUsuario = "";
            //int opcionProducto = 1;//Arrancan en 1

            ////Mientras el input sea distinto a S y la maquina tenga productos todavia
            //while (inputUsuario != "S" && maquinaExpendedora.Count > 0)
            //{
            //    foreach (KeyValuePair<int, string> producto in maquinaExpendedora)//KeyValuePair<int, string> -> tipo de dato = Diccionario
            //    {
            //        Console.WriteLine($"POSICION: {producto.Key} - PRODUCTO: {producto.Value}");
            //    }

            //    Console.WriteLine("SELECCIONE UN PRODUCTO DE LA MÁQUINA O 'S' PARA SALIR: ");
            //    inputUsuario = Console.ReadLine();//Obtengo la opcion

            //    //Verifico el nombre y que EXISTA LA KEY dentro de la expendedora
            //    if (int.TryParse(inputUsuario,out opcionProducto) && maquinaExpendedora.ContainsKey(opcionProducto))
            //    {
            //        maquinaExpendedora.Remove(opcionProducto);//Le paso la key a eliminar de la maquina expendedora
            //        Console.WriteLine("PRODUCTO QUITADO DE LA EXPENDEDORA!");
            //    }
            //    else if(inputUsuario != "S")
            //    {
            //        Console.WriteLine("[OPCION INCORRECTA - SELECCIONE UNA OPCION VALIDA]");
            //    }
            //}
            #endregion

            #region PARTE 02
            //Dictionary<int, Producto> maquinaExpendedoraRecarga = new Dictionary<int, Producto>();

            //maquinaExpendedoraRecarga.Add(1, new Producto("Nuka-Kola", 25.50));
            //maquinaExpendedoraRecarga.Add(2, new Producto("Nerds", 90));
            //maquinaExpendedoraRecarga.Add(3, new Producto("Skittles", 15));
            //maquinaExpendedoraRecarga.Add(4, new Producto("Haribo", 100));
            //maquinaExpendedoraRecarga.Add(5, new Producto("Cheetos", 56));
            //maquinaExpendedoraRecarga.Add(6, new Producto("Fanta", 80.90));
            //maquinaExpendedoraRecarga.Add(7, new Producto("Lays Barbaque", 45));
            //maquinaExpendedoraRecarga.Add(8, new Producto("Wonka Spree", 78));
            //maquinaExpendedoraRecarga.Add(9, new Producto("Kinder", 45));
            //maquinaExpendedoraRecarga.Add(10, new Producto("Nuka-Kola Premium", 30));

            //string inputUsuario = "";
            //int opcionProducto = 1;//Arrancan en 1

            ////Mientras el input sea distinto a S y la maquina tenga productos todavia
            //while (inputUsuario != "S" && maquinaExpendedoraRecarga.Count > 0)
            //{
            //    foreach (KeyValuePair<int, Producto> producto in maquinaExpendedoraRecarga)//KeyValuePair<int, string> -> tipo de dato = Diccionario
            //    {
            //        Console.WriteLine($"POSICION: {producto.Key} - PRODUCTO: {producto.Value} - PRECIO: ${producto.Value.Precio}");
            //    }

            //    Console.WriteLine("SELECCIONE UN PRODUCTO DE LA MÁQUINA O 'S' PARA SALIR: ");
            //    inputUsuario = Console.ReadLine();//Obtengo la opcion

            //    //Verifico el nombre y que EXISTA LA KEY dentro de la expendedora
            //    if (int.TryParse(inputUsuario, out opcionProducto) && maquinaExpendedoraRecarga.ContainsKey(opcionProducto))
            //    {
            //        Console.WriteLine($"PRODUCTO ELEGIDO {maquinaExpendedoraRecarga[opcionProducto].Nombre}" +
            //            $"PRECIO: {maquinaExpendedoraRecarga[opcionProducto].Precio}");//Con la key accedo a la propiedad
            //        maquinaExpendedoraRecarga.Remove(opcionProducto);//Le paso la key a eliminar de la maquina expendedora
            //    }
            //    else if (inputUsuario != "S")
            //    {
            //        Console.WriteLine("[OPCION INCORRECTA - SELECCIONE UNA OPCION VALIDA]");
            //    }
            //}

            #endregion

            #region PARTE 03 - Se acabó la comida  
            //Crear e instanciar 3 Stack distintos que van a contener 1 producto cada uno
            //(simularemos el mecanismo de “reparto” de la máquina expendedora) 
            //Stack<Producto> nukaKolaPremium = new Stack<Producto>();
            //nukaKolaPremium.Push( new Producto("NUKA-KOLA PREMIUM", 30));//El PUSH me permite AÑADIR un objeto al principio de la pila
            //nukaKolaPremium.Push(new Producto("NUKA-KOLA PREMIUM", 30));
            //nukaKolaPremium.Push(new Producto("NUKA-KOLA PREMIUM", 30));

            //Stack<Producto> nerds = new Stack<Producto>();
            //nerds.Push(new Producto("NERDS", 90));//El PUSH me permite AÑADIR un objeto al principio de la pila
            //nerds.Push(new Producto("NERDS", 90));
            //nerds.Push(new Producto("NERDS", 90));

            //Stack<Producto> donuts = new Stack<Producto>();
            //donuts.Push(new Producto("DONUTS", 20));//El PUSH me permite AÑADIR un objeto al principio de la pila
            //donuts.Push(new Producto("DONUTS", 20));
            //donuts.Push(new Producto("DONUTS", 20));

            ////Una vez creadas estas 3 pilas, deberemos modificar nuestra maquina expendedora para que reciba
            ////un par clave-valor que no sea <int,Producto>, sino que va a recibir un int (posición en la máquina)
            ////y un Stack<Producto> (una pila con los productos que van en cada “resorte”). 
            //Dictionary<int, Stack<Producto>> maquinaExpendedora = new Dictionary<int, Stack<Producto>>();

            ////int (posición en la máquina),Stack<Producto> (una pila con los productos que van en cada “resorte”)
            //maquinaExpendedora.Add(1,nukaKolaPremium);
            //maquinaExpendedora.Add(2, nerds);
            //maquinaExpendedora.Add(3,donuts);

            ////Ahora, modificar la lógica de nuestra consola para que al iniciarse muestre posición, nombre y cantidad
            ////de cada producto, y que al seleccionar cada opción nos muestre la información del producto elegido
            ////(incluido el CODIGO, para diferenciar cada producto de nuestra stack) y lo borre de la lista.

            ////Recordar los métodos PEEK = RETORNA EL OBJETO QUE ESTA EN EL TOP DEL STACK SIN REMOVERLO.
            ////POP = Retorna y quita el objeto al top del stack.
            ////PUSH = 

            //string inputUsuario = "";
            //int opcionProducto = 1;//Arrancan en 1

            ////Mientras el input sea distinto a S y la maquina tenga productos todavia
            //while (inputUsuario != "S" && maquinaExpendedora.Count > 0)
            //{
            //    foreach (KeyValuePair<int, Stack<Producto>> producto in maquinaExpendedora)//KeyValuePair<int, string> -> tipo de dato = Diccionario
            //    {
            //        Console.WriteLine($"POSICION: {producto.Key} - PRODUCTO: {producto.Value.Peek().Nombre}" +
            //            $" - PRECIO: ${producto.Value.Peek().Precio} - CANTIDAD: {producto.Value.Count}");
            //    }

            //    Console.WriteLine("SELECCIONE UN PRODUCTO DE LA MÁQUINA O 'S' PARA SALIR: ");
            //    inputUsuario = Console.ReadLine();//Obtengo la opcion

            //    //Verifico el nombre y que EXISTA LA KEY dentro de la expendedora
            //    if (int.TryParse(inputUsuario, out opcionProducto) && maquinaExpendedora.ContainsKey(opcionProducto))
            //    {
            //        Producto productoSeleccionado = maquinaExpendedora[opcionProducto].Pop();//Retorna y quita el objeto al top del stack.

            //        Console.WriteLine($"PRODUCTO ELEGIDO {productoSeleccionado.Nombre}" +
            //            $"PRECIO: {productoSeleccionado.Precio} - CODIGO: {productoSeleccionado.Codigo}");//Con la key accedo a la propiedad

            //        //Si la opcion d la maquina no tiene mas productos la quito de la maquina directamente
            //        if (maquinaExpendedora[opcionProducto].Count == 0)
            //        {
            //            maquinaExpendedora.Remove(opcionProducto);//Le paso la key a eliminar de la maquina expendedora
            //        }
            //        Console.Write("[PRODUCTO SACADO]");
            //        Console.ReadKey();
            //    }
            //    else if (inputUsuario != "S")
            //    {
            //        Console.WriteLine("[OPCION INCORRECTA - SELECCIONE UNA OPCION VALIDA]");
            //    }
            //    Console.Clear();
            //} 
            #endregion

            #region PARTE 04  - Ahora hay que atender también
            //Debido a numerosos incidentes, ahora los usuarios no pueden operar directamente la máquina expendedora,
            //así que harán fila para que los atendamos y les demos su producto.
            //Queue<string> filaClientes = new Queue<string>();//Crear e instanciar la Queue<string> filaDeClientes

            //filaClientes.Enqueue("Mariano");//Enqueue = Añade un nuevo objeto al final d la fila
            //filaClientes.Enqueue("Sebastian");
            //filaClientes.Enqueue("Maria");
            //filaClientes.Enqueue("Sofia");
            //filaClientes.Enqueue("Franco");



            //Stack<Producto> nukaKolaPremium = new Stack<Producto>();
            //nukaKolaPremium.Push(new Producto("NUKA-KOLA PREMIUM", 30));//El PUSH me permite AÑADIR un objeto al principio de la pila
            //nukaKolaPremium.Push(new Producto("NUKA-KOLA PREMIUM", 30));
            //nukaKolaPremium.Push(new Producto("NUKA-KOLA PREMIUM", 30));

            //Stack<Producto> nerds = new Stack<Producto>();
            //nerds.Push(new Producto("NERDS", 90));//El PUSH me permite AÑADIR un objeto al principio de la pila
            //nerds.Push(new Producto("NERDS", 90));
            //nerds.Push(new Producto("NERDS", 90));

            //Stack<Producto> donuts = new Stack<Producto>();
            //donuts.Push(new Producto("DONUTS", 20));//El PUSH me permite AÑADIR un objeto al principio de la pila
            //donuts.Push(new Producto("DONUTS", 20));
            //donuts.Push(new Producto("DONUTS", 20));

            //Dictionary<int, Stack<Producto>> maquinaExpendedora = new Dictionary<int, Stack<Producto>>(); 
            ////int (posición en la máquina),Stack<Producto> (una pila con los productos que van en cada “resorte”)
            //maquinaExpendedora.Add(1, nukaKolaPremium);
            //maquinaExpendedora.Add(2, nerds);
            //maquinaExpendedora.Add(3, donuts);

            //string inputUsuario = "";
            //int opcionProducto = 1;//Arrancan en 1

            ////Mientras el input sea distinto a S y la maquina tenga productos todavia
            //while (inputUsuario != "S" && maquinaExpendedora.Count > 0 && filaClientes.Count > 0)
            //{
            //    string clienteAtendido = filaClientes.Peek();//Devuelve el primer objeto de la fila

            //    foreach (KeyValuePair<int, Stack<Producto>> producto in maquinaExpendedora)//KeyValuePair<int, string> -> tipo de dato = Diccionario
            //    {
            //        Console.WriteLine($"POSICION: {producto.Key} - PRODUCTO: {producto.Value.Peek().Nombre}" +
            //            $" - PRECIO: ${producto.Value.Peek().Precio} - CANTIDAD: {producto.Value.Count}");
            //    }

            //    Console.WriteLine("SELECCIONE UN PRODUCTO DE LA MÁQUINA O 'S' PARA SALIR: ");
            //    inputUsuario = Console.ReadLine();//Obtengo la opcion

            //    //Verifico el nombre y que EXISTA LA KEY dentro de la expendedora
            //    if (int.TryParse(inputUsuario, out opcionProducto) && maquinaExpendedora.ContainsKey(opcionProducto))
            //    {
            //        Producto productoSeleccionado = maquinaExpendedora[opcionProducto].Pop();//Retorna y quita el objeto al top del stack.

            //        Console.WriteLine($"{clienteAtendido} SELECCIONO EL PRODUCTO {productoSeleccionado.Nombre}" +
            //            $"PRECIO: {productoSeleccionado.Precio} - CODIGO: {productoSeleccionado.Codigo}");//Con la key accedo a la propiedad

            //        //Si la opcion d la maquina no tiene mas productos la quito de la maquina directamente
            //        if (maquinaExpendedora[opcionProducto].Count == 0)
            //        {
            //            maquinaExpendedora.Remove(opcionProducto);//Le paso la key a eliminar de la maquina expendedora
            //        }
            //        filaClientes.Dequeue();//Quito al primer cliente de la fila
            //        Console.Write("[PRODUCTO SACADO]");
            //        Console.ReadKey();
            //    }
            //    else if (inputUsuario != "S")
            //    {
            //        Console.WriteLine("[OPCION INCORRECTA - SELECCIONE UNA OPCION VALIDA]");
            //    }
            //    Console.Clear();

            //    if (filaClientes.Count == 0)
            //    {
            //        Console.WriteLine("Llegamos al final de la lista. Desea agregar mas clientes? S (si) o N (no)");
            //        string entradaUsuarioConfirmacion = Console.ReadLine();
            //        if (entradaUsuarioConfirmacion.ToLower() == "s")
            //        {
            //            Console.WriteLine("Cuantos clientes desea agregar: ");
            //            if (int.TryParse(Console.ReadLine(), out opcionProducto))
            //            {
            //                Console.WriteLine($"Se agregarán {opcionProducto} clientes");
            //                for (int i = 0; i < opcionProducto; i++)
            //                {
            //                    Console.WriteLine("Ingrese el nombre del cliente: ");
            //                    filaClientes.Enqueue(Console.ReadLine());
            //                }
            //            }
            //        }
            //    }
            //}
            #endregion


            #region PARTE 05 - BUFFET
            //Debido a numerosos incidentes, ahora los usuarios no pueden operar directamente la máquina expendedora,
            //así que harán fila para que los atendamos y les demos su producto.
            Queue<string> filaClientes = new Queue<string>();//Crear e instanciar la Queue<string> filaDeClientes

            filaClientes.Enqueue("Mariano");//Enqueue = Añade un nuevo objeto al final d la fila
            filaClientes.Enqueue("Sebastian");
            filaClientes.Enqueue("Maria");
            filaClientes.Enqueue("Sofia");
            filaClientes.Enqueue("Franco");

            string inputUsuario = "";
            int opcionProducto = 1;//Arrancan en 1
            List<Producto> pedido = new List<Producto>();

            //La ola de violencia por las medidas anteriores solo fue en aumento,
            //por lo que la gerencia decidió ofrecer servicio buffet, para que cada uno elija lo que quiera

            //Crear e instanciar la List<Producto> mesaBuffet
            List<Producto> mesaBuffet = new List<Producto>();
            //Agregar al menos 5 platos/bebidas
            mesaBuffet.Add(new Producto("Milanesa",160));
            mesaBuffet.Add(new Producto("Agua mineral", 20));
            mesaBuffet.Add(new Producto("Ensalada Caesar", 50));
            mesaBuffet.Add(new Producto("Gaseosa", 60));
            mesaBuffet.Add(new Producto("Sanguchitos de pollo",30));

            //Esta lista va a reemplazar al dictionary maquinaExpendedora,
            //realizar todas las modificaciones necesarias para que todo funcione de manera que cada cliente de la
            //cola vaya avanzando, eligiendo sus productos y saliendo.

            //Mientras el input sea distinto a S y la maquina tenga productos todavia
            while ( mesaBuffet.Count > 0 && filaClientes.Count > 0)
            {
                string clienteAtendido = filaClientes.Peek();//Devuelve el primer objeto de la fila
                
                double acumulador = 0;
                while (inputUsuario != "S")
                {
                    int index = 1;
                    Console.WriteLine($"CLIENTE ATENDIDO: {clienteAtendido}");
                    foreach (Producto producto in mesaBuffet)
                    {
                        Console.WriteLine($"{index} - {producto.Nombre} - Precio: ${producto.Precio}" +
                            $"Cantidad: {producto.Cantidad}");
                        index++;
                    }

                    Console.WriteLine("SELECCIONE UN PRODUCTO DE LA MÁQUINA O 'S' PARA SALIR: ");
                    inputUsuario = Console.ReadLine();//Obtengo la opcion

                    //Verifico el nombre y que EXISTA LA KEY dentro de la expendedora
                    if (int.TryParse(inputUsuario, out opcionProducto) && opcionProducto <= mesaBuffet.Count)
                    {
                        pedido.Add(mesaBuffet[opcionProducto-1]);
                        mesaBuffet[opcionProducto - 1].Cantidad--;//Resto la cant del producto

                        Console.WriteLine($"{clienteAtendido} eligió los siguientes productos: \n");
                        acumulador = 0;
                        foreach (Producto item in pedido)
                        {
                            acumulador += item.Precio;
                            Console.WriteLine($"- {item.Nombre} - ${item.Precio}");
                        }
                        Console.WriteLine($"Total: ${acumulador}\n\n");
                    }
                    else if (inputUsuario != "S")
                    {
                        Console.WriteLine("[OPCION INCORRECTA - SELECCIONE UNA OPCION VALIDA]");
                    }
                    Console.WriteLine($"Terminó el turno de {clienteAtendido} y su total es de ${acumulador}");
                    pedido.Clear();
                    filaClientes.Dequeue();
                } 

                if (filaClientes.Count == 0)
                {
                    Console.WriteLine("Llegamos al final de la lista. Desea agregar mas clientes? S (si) o N (no)");
                    string entradaUsuarioConfirmacion = Console.ReadLine();
                    if (entradaUsuarioConfirmacion.ToLower() == "s")
                    {
                        Console.WriteLine("Cuantos clientes desea agregar: ");
                        if (int.TryParse(Console.ReadLine(), out opcionProducto))
                        {
                            Console.WriteLine($"Se agregarán {opcionProducto} clientes");
                            for (int i = 0; i < opcionProducto; i++)
                            {
                                Console.WriteLine("Ingrese el nombre del cliente: ");
                                filaClientes.Enqueue(Console.ReadLine());
                            }
                        }
                    }
                }
            } 
            #endregion
        }
    }
}