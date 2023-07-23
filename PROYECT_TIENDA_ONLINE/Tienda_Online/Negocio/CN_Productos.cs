using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;


namespace Negocio
{
    /// <summary>
    /// Capa de reglas negocio
    /// para la clase Producto
    /// </summary>
    public class CN_Productos
    {
        #region ATRIBUTOS
        private static ProductosDAO productoDAO;
        #endregion

        #region METODOS
        /// <summary>
        /// Retorno la lista de ProductosDAO 
        /// de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Producto> Listar()
        {
            CN_Productos.productoDAO = new ProductosDAO();
            return CN_Productos.productoDAO.ObtenerLista();
        }

        /// <summary>
        /// Me sirve de intermediario, recibe la
        /// producto y devuelve un int y 
        /// un mensaje.
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="mss"></param>
        /// <returns></returns>
        public int RegistrarDato(Producto producto, out string mss)
        {
            mss = string.Empty;
            CN_Productos.productoDAO = new ProductosDAO();

            if (string.IsNullOrEmpty(producto.Descripcion) || string.IsNullOrEmpty(producto.Descripcion))
                mss = "La descripción del producto no puede estar vacia.";
            else if (string.IsNullOrEmpty(producto.Nombre) || string.IsNullOrEmpty(producto.Nombre))
                mss = "El nombre del producto no puede estar vacio.";
            else if (producto.oMarca.IDMarca == 0)
                mss = "Debe de seleccionar una marca.";
            else if (producto.oCategoria.IDCategoria == 0)
                mss = "Debe de seleccionar una categoría.";
            else if (producto.Precio == 0)
                mss = "Debe ingresar un precio valido para el producto.";
            else if(producto.Stock == 0)
                mss = "Debe ingresar un stock valido para el producto.";

            if (string.IsNullOrEmpty(mss)) 
                return CN_Productos.productoDAO.RegistrarDato(producto, out mss); 
            else
                return 0;
        }

        /// <summary>
        /// Intermediario entre la capa de negocios,
        /// los metodos de la base y el objeto.
        /// Edito un producto existente.
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="mss"></param>
        /// <returns>Retornará true si pudo, false sino.</returns>
        public bool EditarDato(Producto producto, out string mss)
        {
            mss = string.Empty;
            CN_Productos.productoDAO = new ProductosDAO();

            if (string.IsNullOrEmpty(producto.Descripcion) || string.IsNullOrEmpty(producto.Descripcion))
                mss = "La descripción del producto no puede estar vacia.";
            else if (string.IsNullOrEmpty(producto.Nombre) || string.IsNullOrEmpty(producto.Nombre))
                mss = "El nombre del producto no puede estar vacio.";
            else if (producto.oMarca.IDMarca == 0)
                mss = "Debe de seleccionar una marca.";
            else if (producto.oCategoria.IDCategoria == 0)
                mss = "Debe de seleccionar una categoría.";
            else if (producto.Precio == 0)
                mss = "Debe ingresar un precio valido para el producto.";
            else if (producto.Stock == 0)
                mss = "Debe ingresar un stock valido para el producto.";

            if (string.IsNullOrEmpty(mss))
                return CN_Productos.productoDAO.UpdateDato(producto, out mss);
            else
                return false;
        }

        /// <summary>
        /// Intermediario entre la capa de negocios,
        /// los metodos de la base y el objeto.
        /// Elimino un Producto existente.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mss"></param>
        /// <returns></returns>
        public bool DeleteDato(int id, out string mss)
        {
            CN_Productos.productoDAO = new ProductosDAO();
            return CN_Productos.productoDAO.DeleteDato(id, out mss);
        }

        public bool GuardarDatosImagen(Producto producto, out string mss)
        {
            CN_Productos.productoDAO = new ProductosDAO();
            return CN_Productos.productoDAO.GuardarDatosImagen(producto, out mss);
        }
        #endregion
    }
}
