using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;

namespace SQLTest
{
    /// <summary>
    /// Esta clase de unit testing
    /// me permite verificar los 
    /// metodos de la clase 
    /// ProductosDAO.
    /// </summary>
    [TestClass]
    public class TestProductosSQL
    {
        /// <summary>
        /// Me permite verificar si el metodo
        /// ObtenerLista de la clase ProductosDAO
        /// retorna al menos un elemento en la lista.
        /// </summary>
        [TestMethod]
        public void ObtenerListaProductos_OK()
        {
            //-->Arrange preparar variables
            ProductosDAO productosDAO = new ProductosDAO();
            List<Producto> listaProductos = productosDAO.ObtenerLista();

            //-->Act verifico que cargue en la lista
            bool esValido = listaProductos.Count > 0;

            //-->Assert compruebo que el resultado sea el esperado
            Assert.IsTrue(esValido);
        }

        /// <summary>
        /// Me permitirá revisar si pudo registrar un Producto
        /// y el metodo devuelve TRUE.
        /// </summary>
        [TestMethod]
        public void RegistrarProducto_OK()
        {
            //-->Arrange
            string mss = string.Empty;
            ProductosDAO productoDAO = new ProductosDAO();
            Producto productoNuevo = new Producto()//-->Instancio un nuevo Producto
            {
                //Nombre = "Televisor",
                //Descripcion = "220 Pulgadas",
                //oMarca = "2",
                //NombreImagen = string.Empty,
                //RutaImagen = string.Empty,
                //Activo = true
            };

            //-->Act, llamo al metodo a testear.
            int idAutoGenerado = productoDAO.RegistrarDato(productoNuevo, out mss);

            //-->Assert verifico
            Assert.AreEqual(6, idAutoGenerado);
        }
    }
}
