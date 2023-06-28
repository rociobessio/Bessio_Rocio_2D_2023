using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingSQL
{
    [TestClass]
    public class TestingSQLProductos
    {
        /// <summary>
        /// Corroboro si el metodo ObtenerLista()
        /// de la clase ProductoDAO retorna algo.
        /// </summary>
        [TestMethod]
        public void ObtenerListaProductos_OK()
        {
            //-->Arrange, instancio
            ProductoDAO productoDAO = new ProductoDAO();
            List<Producto> productos = productoDAO.ObtenerLista();

            //-->Act, verifico que me de mas de 0 en la lista.
            bool esValido = productos.Count > 0;

            //-->Assert, Compruebo si el resultado obtenido es el esperado.
            Assert.IsTrue(esValido);
        }
        
        /// <summary>
        /// Verifico si el producto SI esta en la
        /// tabla.
        /// </summary>
        [TestMethod]
        public void SeEncuentraElProducto_SI()
        {
            //-->Arrange, instancio
            ProductoDAO productoDAO = new ProductoDAO();
            List<Producto> productos = productoDAO.ObtenerLista();

            Producto producto = new Producto("Bondiola",10,"No Es Bovino",new DateTime(2025,6,12),
                1200,"Chascomus LA","Cerdo",1700);
            producto.Codigo = 3;

            //-->Act, con la sobrecarga del == de Producto verifico si son iguales
            bool sonIguales = false;
            foreach (Producto produc in productos)
            {
                if (produc == producto)
                {
                    sonIguales = true;
                    break;
                }
            }

            //-->Assert, Compruebo si el resultado obtenido es el esperado.
            Assert.IsTrue(sonIguales);
        }

        /// <summary>
        /// Verifico si un producto NO se encuentra
        /// en la tabla.
        /// </summary>
        [TestMethod]
        public void SeEncuentraElProducto_NO()
        {
            //-->Arrange, instancio
            ProductoDAO productoDAO = new ProductoDAO();
            List<Producto> productos = productoDAO.ObtenerLista();

            Producto producto = new Producto("Bondiola", 10, "No Es Bovino", new DateTime(2025, 6, 12),
                1200, "Chascomus LA", "Cerdo", 1700);
            producto.Codigo = 19203;

            //-->Act, con la sobrecarga del == de Producto verifico si son iguales
            bool sonIguales = false;
            foreach (Producto produc in productos)
            {
                if (produc == producto)
                {
                    sonIguales = true;
                    break;
                }
            }

            //-->Assert, Compruebo si el resultado obtenido es el esperado.
            Assert.IsFalse(sonIguales);
        }

        /// <summary>
        /// Unit testing del metodo AgregarProducto()
        /// de la clase ProductoDAO.
        /// </summary>
        [TestMethod]
        public void AgregarProducto_OK()
        {
            //-->Arrange, instancio
            ProductoDAO productoDAO = new ProductoDAO();
            List<Producto> productos = productoDAO.ObtenerLista();

            Producto producto = new Producto("Pechito", 12, "No Es Bovino", new DateTime(2025, 6, 12),
                                             1300, "Mingo CO", "Cerdo", 2100);
            producto.Codigo = 241;

            //-->Act, con la sobrecarga del == de Producto verifico si son iguales
            bool pudoAgregar = productoDAO.AgregarProducto(producto); 

            //-->Assert, Compruebo si el resultado obtenido es el esperado.
            Assert.IsTrue(pudoAgregar);
        }

        /// <summary>
        /// Unit testing del metodo UpdateProducto
        /// de la clase ProductoDAO.
        /// </summary>
        [TestMethod]
        public void ModificarProducto_OK()
        {
            //-->Arrange, instancio
            ProductoDAO productoDAO = new ProductoDAO();
            List<Producto> productos = productoDAO.ObtenerLista();

            Producto producto = new Producto("Bondiola", 12, "No Es Bovino", new DateTime(2025, 6, 12),
                                             1700, "Mingo CO", "Cerdo", 2501);
            producto.Codigo = 8;

            //-->Act, hago Update del producto
            bool pudoModificar = productoDAO.UpdateDato(producto);

            //-->Assert, Compruebo si el resultado obtenido es el esperado.
            Assert.IsTrue(pudoModificar);
        }
    }
}
