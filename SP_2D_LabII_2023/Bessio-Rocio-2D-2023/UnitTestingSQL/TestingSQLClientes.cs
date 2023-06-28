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
        /// <summary>
        /// Me permite ver si funciona el metodo
        /// ObtenerLista de la clase ClienteDAO.
        /// </summary>
        [TestMethod]
        public void ObtenerListaClientes_OK()
        {
            //-->Arrange, instancio
            ClienteDAO clienteDAO = new ClienteDAO();
            List<Cliente> clientes = clientes = clienteDAO.ObtenerLista();

            //-->Act, verifico que la lista devuelve mas de 0
            bool esValido = clientes.Count > 0; 

            //-->Assert Compruebo si el resultado es el esperado
            Assert.IsTrue(esValido);
        }

        [TestMethod]
        public void ModificarCliente_OK()
        {
            //-->Arrange, instancio
            ClienteDAO clienteDAO = new ClienteDAO();
            List<Cliente> clientes = clientes = clienteDAO.ObtenerLista();

            Cliente cliente = new Cliente("Rocio","Bessio",Sexo.Femenino,Nacionalidad.Argentina,new DateTime(2003,12,11),"320091023",
                "Formosa 2716","1234412321",new Usuario("rocibessio@gmail.com","123"),new Carrito(),12000,false);
            cliente.IDPersona = 7;
            cliente.IDCliente = 2;

            //-->Act, hago Update del cliente
            bool pudoModificar = clienteDAO.UpdateDato(cliente);

            //-->Assert, Compruebo si el resultado obtenido es el esperado.
            Assert.IsTrue(pudoModificar);
        }
    }
}
