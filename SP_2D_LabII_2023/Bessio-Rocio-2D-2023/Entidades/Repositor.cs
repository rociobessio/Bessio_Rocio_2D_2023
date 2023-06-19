using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Repositor
    {
        private List<Producto> productosExistentes;
        private ProductoDAO productoDAO;

        public event Action<Producto> delegadoRepositorEvento;

        public Repositor()
        {
            productoDAO = new ProductoDAO();
            productosExistentes = new List<Producto>();
            delegadoRepositorEvento += ManejarReposicionStock;
        }

        public void IniciarComprobacionPeriodica()
        {
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    ComprobarStock();
                    Thread.Sleep(5000); // Intervalo de 5 segundos (puedes ajustarlo según tus necesidades)
                }
            });
            thread.Start();
        }

        public void ComprobarStock()
        {
            productosExistentes = productoDAO.ObtenerLista();

            foreach (Producto producto in productosExistentes)
            {
                if (producto.Peso <= 0)
                {
                    this.Reponer(producto);
                    delegadoRepositorEvento?.Invoke(producto); // Invoco al evento
                }
            }
        }

        public void Reponer(Producto producto)
        {
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    producto.Peso = 10;
                    if (productoDAO.UpdateProducto(producto))
                    {
                        delegadoRepositorEvento?.Invoke(producto); // Invoco al evento
                    }
                    Thread.Sleep(10000); // Cada 10 segundos
                }
            });
            thread.Start();
        }
        //#region ATRIBUTOS
        //private  List<Producto> productosExistentes; 
        //private ProductoDAO productoDAO;

        //public delegate void DelegadoRepositor();
        //public delegate void DelegadoRepositorDos(Producto p);
        //public event DelegadoRepositor delegadoRepositorEvento;
        //public event DelegadoRepositorDos delegadoRepositorEventoDos;
        //#endregion

        //public Repositor()
        //{
        //    productoDAO = new ProductoDAO();
        //    productosExistentes = new List<Producto>();
        //    //   delegadoRepositorEvento += Reponer;  
        //    delegadoRepositorEvento += IniciarComprobacionPeriodica;
        //}

        //public void IniciarComprobacionPeriodica()
        //{
        //    Thread thread = new Thread(() =>
        //    {
        //        while (true)
        //        {
        //            ComprobarStock();
        //            Thread.Sleep(5000); // Intervalo de 5 segundos (puedes ajustarlo según tus necesidades)
        //        }
        //    });
        //    thread.Start();
        //}

        static void ManejarReposicionStock(Producto producto)
        {
            // Lógica para manejar la reposición de stock del producto
            // Por ejemplo, podrías imprimir un mensaje indicando el producto que se está reponiendo
            Console.WriteLine("Reponiendo stock del producto: " + producto.Tipo);
            // También puedes realizar otras acciones como enviar notificaciones, registrar eventos, etc.
        }

        //public bool ComprobarStock()
        //{
        //    productosExistentes = productoDAO.ObtenerLista();

        //    foreach (Producto producto in productosExistentes)
        //    {
        //        if (producto.Peso <= 0)
        //        {
        //           this.Reponer(producto); 
        //           delegadoRepositorEventoDos?.Invoke(producto);//-->Invoco al evento 
        //        }
        //    }

        //    return true;
        //}

        //public void Reponer(Producto producto)
        //{
        //    Thread thread = new Thread(() =>
        //    {
        //        while (true)
        //        {
        //            producto.Peso = 10;
        //            if (productoDAO.UpdateProducto(producto))
        //            {
        //                delegadoRepositorEventoDos?.Invoke(producto);//-->Invoco al evento
        //            }//-->Modifico
        //            Thread.Sleep(10000);//-->Cada 10 segundos
        //        }
        //    });
        //    thread.Start();
        //} 

    }
}
