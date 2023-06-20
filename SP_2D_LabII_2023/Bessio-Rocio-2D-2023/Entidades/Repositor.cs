using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Repositor
    {
        #region ATRIBUTOS
        private List<Producto> productosExistentes;
        private ProductoDAO productoDAO;

        /// <summary>
        /// Declaro mi delegado de repositor,
        /// retorna void y no recibe nada.
        /// </summary>
        public delegate void DelegadoRepositor();

        /// <summary>
        /// Declaro mi evento del tipo delegate
        /// DelegadoRepositor DelegadoRepositorEvento.
        /// </summary>
        public event DelegadoRepositor DelegadoRepositorEvento;
        #endregion

        #region CONSTRUCTOR
        public Repositor()
        {
            productoDAO = new ProductoDAO();
            productosExistentes = new List<Producto>(); 
        }
        #endregion

        #region METODOS
        /// <summary>
        /// El metodo comprobar stock:
        /// 1. Me traigo la lista de productos
        /// 2. Recorro en busca de aquellos productos
        /// cuyo stock sea menor o igual a 0.
        /// 3. Si ese es el caso, comienzo mi
        /// reposicion pasandole el producto.
        /// </summary>
        /// <returns></returns>
        public bool ComprobarStock()
        {
            productosExistentes = productoDAO.ObtenerLista();//1.

            foreach (Producto producto in productosExistentes)//2.
            {
                if (producto.Peso <= 0)
                {
                    this.ComenzarReposicion(producto);//3.
                }
            } 
            return true;
        }

        /// <summary>
        /// El metodo reponer me permite que:
        /// 1. Mientras stock de producto sea menor
        /// o igual a 10 siga reponiendo su stock.
        /// 2. Lo modifico de mi base
        /// 3. "Duermo"/Detengo el hilo por 3 segundos.
        /// </summary>
        /// <param name="producto"></param>
        public void Reponer(Producto producto)
        {
            //1.
            while (producto.Peso <= 10)
            {
                producto.Peso += 1;
                productoDAO.UpdateProducto(producto);//2.
                Thread.Sleep(3000);//3.
            } 
        }

        /// <summary>
        /// Este metodo me permite crear un nuevo hilo,
        /// donde llamaré al metodo Reponer().
        /// 1. Instancio el hilo utilizando 
        ///    EXPRESIONES LAMBDA.
        /// 2. Doy comienzo a este.
        /// </summary>
        /// <param name="producto"></param>
        public void ComenzarReposicion(Producto producto)
        {
            Thread hilo = new Thread(() =>
                Reponer(producto)
            );//1

            hilo.Start();//2
        }
        #endregion
    }
}
