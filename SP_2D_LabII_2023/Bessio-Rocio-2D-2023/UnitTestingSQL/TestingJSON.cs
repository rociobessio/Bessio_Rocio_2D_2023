using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestings
{
    [TestClass]
    public class TestingJSON
    {

        [TestMethod]
        public void DeserializarJSON_OK()
        {
            //-->Arrange -->Instancio 
            List<Carrito> carritos = JSON.DeserializarJSON();

            //-->Act -->Verifico 
            bool esValido = carritos.Count > 0;

            //-->Assert -->Compruebo si el resultado es el esperado
            Assert.IsTrue(esValido);
        }

        [TestMethod]
        public void DeserializarJSON_FAIL()
        {
            //-->Arrange -->Instancio 
            List<Carrito> carritos = JSON.DeserializarJSON();

            //-->Act -->Verifico 
            bool esValido = carritos.Count == 0 || carritos == null;

            //-->Assert -->Compruebo si el resultado es el esperado
            Assert.IsFalse(esValido);
        }
    }
}
