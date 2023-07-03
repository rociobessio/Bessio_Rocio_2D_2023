using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestings
{
    [TestClass]
    public class TestingXML
    {

        [TestMethod]
        public void DeserializarXML_OK()
        {
            //-->Arrange -->Instancio 
            List<Carrito> carritos = XML.DeserializarXML();

            //-->Act -->Verifico 
            bool esValido = carritos.Count > 0;

            //-->Assert -->Compruebo si el resultado es el esperado
            Assert.IsTrue(esValido);
        }

        [TestMethod]
        public void DeserializarXML_FAIL()
        {
            //-->Arrange -->Instancio 
            List<Carrito> carritos = XML.DeserializarXML();

            //-->Act -->Verifico 
            bool esValido = carritos.Count == 0 || carritos == null;

            //-->Assert -->Compruebo si el resultado es el esperado
            Assert.IsFalse(esValido);
        }
         
    }
}
