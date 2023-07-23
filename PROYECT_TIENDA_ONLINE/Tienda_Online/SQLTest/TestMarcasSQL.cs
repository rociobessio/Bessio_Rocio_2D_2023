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
    /// MarcasDAO.
    /// </summary>
    [TestClass]
    public class TestMarcasSQL
    {
        /// <summary>
        /// Me permite verificar si el metodo
        /// ObtenerLista de la clase MarcasDAO
        /// retorna al menos un elemento en la lista.
        /// </summary>
        [TestMethod]
        public void ObtenerListaMarcas_OK()
        {
            //-->Arrange preparar variables
            MarcasDAO marcaDAO = new MarcasDAO();
            List<Marca> listaCategorias = marcaDAO.ObtenerLista();

            //-->Act verifico que cargue en la lista
            bool esValido = listaCategorias.Count > 0;

            //-->Assert compruebo que el resultado sea el esperado
            Assert.IsTrue(esValido);
        }

        /// <summary>
        /// Me permitirá revisar si pudo registrar un Marca
        /// y el metodo devuelve TRUE.
        /// </summary>
        [TestMethod]
        public void RegistrarMarca_OK()
        {
            //-->Arrange
            string mss = string.Empty;
            MarcasDAO marcaDAO = new MarcasDAO();
            Marca marcaNueva = new Marca()//-->Instancio una nueva categoria
            {
                Descripcion = "Testing 02",
                Activo = true
            };

            //-->Act, llamo al metodo a testear.
            int idAutoGenerado = marcaDAO.RegistrarDato(marcaNueva, out mss);

            //-->Assert verifico
            Assert.AreEqual(6, idAutoGenerado);
        }

        /// <summary>
        /// Me permitirá revisar si pudo editar una Marca
        /// y el metodo devuelve TRUE.
        /// </summary>
        [TestMethod]
        public void UpdateMarca_OK()
        {
            //-->Arrange
            string mss = string.Empty;
            MarcasDAO marcaDAO = new MarcasDAO();
            Marca MarcaEditar = new Marca()//-->Instancio el usuario
            {
                IDMarca = 6,
                Descripcion = "Editar test",
                Activo = false
            }; 

            //-->Act, llamo al metodo a testear.
            bool pudoEditar = marcaDAO.UpdateDato(MarcaEditar, out mss);

            //-->Assert verifico si pudo editar
            Assert.IsTrue(pudoEditar);
        }

        /// <summary>
        /// Me permitirá revisar si pudo ELIMINAR una Marca
        /// y el metodo devuelve TRUE.
        /// </summary>
        [TestMethod]
        public void DeleteMarca_OK()
        {
            //-->Arrange
            string mss = string.Empty;
            MarcasDAO marcaDAO = new MarcasDAO();
            Marca marcaAEliminar = new Marca()//-->Instancio una nueva categoria para luego eliminarlo
            {
                Descripcion = "Pepito",
                Activo = true
            };

            //-->Act testeo los metodos
            //marcaDAO.RegistrarDato(marcaAEliminar, out mss);//-->Primero la registro
            bool pudoEliminar = marcaDAO.DeleteDato(6, out mss);

            //-->Assert verifico que devolvio.
            Assert.IsTrue(pudoEliminar);
        }
    }
}
