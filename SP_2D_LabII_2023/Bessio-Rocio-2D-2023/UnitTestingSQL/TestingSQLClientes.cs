using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingSQL
{
    [TestClass]
    public class TestingSQLClientes
    {
        [TestMethod]
        public void ObtenerListaClientes_OK()
        {
            //-->Arrange, instancio
            ClienteDAO clienteDAO = new ClienteDAO();
            List<Cliente> clientes = new List<Cliente>();
            clientes = clienteDAO.ObtenerLista();

            //-->Act, verifico que la lista devuelve mas de 0
            bool esValido = clientes.Count > 0; 

            //-->Assert Compruebo si el resultado es el esperado
            Assert.IsTrue(esValido);
        }
    }
}
