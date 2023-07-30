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
    /// Esta clase me permitirá
    /// testear los metodos de la clase
    /// PanelDAO.
    /// </summary>
    [TestClass]
    public class TestPanelDeControlSQL
    {
        /// <summary>
        /// Me permite verificar si el metodo
        /// VerPanelControl de la clase PanelDAO
        /// retorna al menos un elemento en la lista.
        /// </summary>
        [TestMethod]
        public void VerPanelControl_TotalProductos_OK()
        {
            //-->Arrange preparar variables  
            PanelControl panelDeControl = new PanelDAO().VerPanelControl();

            //-->Act verifico que cargue en la lista
            bool esValido = panelDeControl.TotalProductos > 0;

            //-->Assert compruebo que el resultado sea el esperado
            Assert.IsTrue(esValido);
        }

        /// <summary>
        /// Me permite verificar si el metodo
        /// VerPanelControl de la clase PanelDAO
        /// retorna al menos un elemento en la lista.
        /// </summary>
        [TestMethod]
        public void VerPanelControl_TotalClientes_OK()
        {
            //-->Arrange preparar variables  
            PanelControl panelDeControl = new PanelDAO().VerPanelControl();

            //-->Act verifico que cargue en la lista
            bool esValido = panelDeControl.TotalClientes > 0;

            //-->Assert compruebo que el resultado sea el esperado
            Assert.IsTrue(esValido);
        }

        /// <summary>
        /// Me permite verificar si el metodo
        /// VerPanelControl de la clase PanelDAO
        /// retorna al menos un elemento en la lista.
        /// </summary>
        [TestMethod]
        public void VerPanelControl_TotalVentas_OK()
        {
            //-->Arrange preparar variables  
            PanelControl panelDeControl = new PanelDAO().VerPanelControl();

            //-->Act verifico que cargue en la lista
            bool esValido = panelDeControl.TotalVentas > 0;

            //-->Assert compruebo que el resultado sea el esperado
            Assert.IsTrue(esValido);
        }
    }
}
