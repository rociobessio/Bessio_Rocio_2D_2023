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
        /// Este metodo me permitira retornar un producto cargado 
        /// de esta forma no se repetira codigo instanciandolo
        /// en todos los metodos de test unitarios de la clase.
        /// </summary>
        /// <returns></returns>
        private Producto CrearProductoPrueba()
        {
            return new Producto()
            {
                Nombre = "Prueba de Producto II",
                Descripcion = "Descripción de prueba",
                oMarca = new Marca()
                {
                    IDMarca = 3,
                    Descripcion = "Descripción de prueba de marca"
                },
                oCategoria = new Categoria()
                {
                    IDCategoria = 2,
                    Descripcion = "Descripción de prueba de categoría"
                },
                Precio = 1000,
                Stock = 12,
                NombreImagen = string.Empty,
                RutaImagen = string.Empty,
                Activo = true
            };
        }

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
        //[TestMethod]
        //public void RegistrarProducto_OK()
        //{
        //    //-->Arrange
        //    string mss = string.Empty;
        //    ProductosDAO productoDAO = new ProductosDAO();
        //    Producto productoNuevo = this.CrearProductoPrueba();
        //    List<Producto> listaProductos = productoDAO.ObtenerLista();//-->Obtengo la lista

        //    //-->Act, llamo al metodo a testear.
        //    Producto ultimoProducto = listaProductos.Last();//-->Obtengo el ultimo producto
        //    int ultimaID = ultimoProducto.IDProducto;//-->Obtengo la ID

        //    int idAutoGenerado = productoDAO.RegistrarDato(productoNuevo, out mss);

        //    //-->Assert verifico, que IDAutoGenerado que retorna el metodo a probar es igual
        //    // a la ultima ID registrada en la base  + 1.  
        //    Assert.AreEqual(idAutoGenerado,ultimaID + 1);
        //    //-->Si registro lo elimino.
        //    productoDAO.DeleteDato(productoNuevo.IDProducto,out mss);
        //}

        /// <summary>
        /// Me permitirá revisar si pudo editar un Producto
        /// y el metodo devuelve TRUE.
        /// </summary>
        [TestMethod]
        public void UpdateProducto_OK()
        {
            //-->Arrange
            string mss = string.Empty;
            ProductosDAO productoDAO = new ProductosDAO();
            Producto productoEditar = this.CrearProductoPrueba();
            productoDAO.RegistrarDato(productoEditar,out mss);//-->Lo registro primero

            //-->Act, llamo al metodo a testear.
            productoEditar.Nombre = "Este producto esta editado";//-->Modifico su Nombre
            bool pudoEditar = productoDAO.UpdateDato(productoEditar, out mss);//-->Lo modifico

            //-->Assert verifico si pudo editar
            Assert.IsTrue(pudoEditar);
        }

        /// <summary>
        /// Me permitirá revisar si pudo ELIMINAR un PRODUCTO
        /// y el metodo devuelve TRUE.
        /// </summary>
        [TestMethod]
        public void DeleteProducto_OK()
        {
            //-->Arrange
            string mss = string.Empty;
            ProductosDAO productosDAO = new ProductosDAO();
            Producto producto = this.CrearProductoPrueba();

            //-->Act testeo los metodos 
            bool pudoEliminar = productosDAO.DeleteDato(producto.IDProducto, out mss);

            //-->Assert verifico que devolvio.
            Assert.IsTrue(pudoEliminar);
        }
    }
}
