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
        [TestMethod]
        public void ObtenerListaProductos_OK()
        {
            //-->Arrange, instancio
            ProductoDAO productoDAO = new ProductoDAO();
            List<Producto> productos = new List<Producto>();
            productos = productoDAO.ObtenerLista();

            //-->Act, verifico que me de mas de 0 en la lista.
            bool esValido = productos.Count > 0;

            //-->Assert, Compruebo si el resultado obtenido es el esperado.
            Assert.IsTrue(esValido);
        }
    }
}
