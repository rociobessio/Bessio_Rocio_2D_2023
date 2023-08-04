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
    /// CategoriasDAO.
    /// </summary>
    [TestClass]
    public class TestCategoriasSQL
    {
        /// <summary>
        /// Me permite verificar si el metodo
        /// ObtenerLista de la clase CategoriasDAO
        /// retorna al menos un elemento en la lista.
        /// </summary>
        [TestMethod]
        public void ObtenerListaCategorias_OK()
        {
            //-->Arrange preparar variables
            CategoriasDAO categoriasDAO = new CategoriasDAO();
            List<Categoria> listaCategorias = categoriasDAO.ObtenerLista();

            //-->Act verifico que cargue en la lista
            bool esValido = listaCategorias.Count > 0;

            //-->Assert compruebo que el resultado sea el esperado
            Assert.IsTrue(esValido);
        }

        /// <summary>
        /// Me permitirá revisar si pudo registrar un Categoria
        /// y el metodo devuelve TRUE.
        /// </summary>
        [TestMethod]
        public void RegistrarCategoria_OK()
        {
            //-->Arrange
            string mss = string.Empty;
            CategoriasDAO categoriasDAO = new CategoriasDAO();
            Categoria categoriaNueva = new Categoria()//-->Instancio una nueva categoria
            { 
                Descripcion = "Testing 02", 
                Activo = true
            };

            //-->Act, llamo al metodo a testear.
            int idAutoGenerado = categoriasDAO.RegistrarDato(categoriaNueva, out mss);

            //-->Assert verifico
            Assert.AreEqual(6, idAutoGenerado);
        }

        /// <summary>
        /// Me permitirá revisar si pudo editar una Categoria
        /// y el metodo devuelve TRUE.
        /// </summary>
        [TestMethod]
        public void UpdateCategoria_OK()
        {
            //-->Arrange
            string mss = string.Empty;
            CategoriasDAO categoriaDAO = new CategoriasDAO();
            Categoria categoriaEditar = new Categoria()//-->Instancio el usuario
            {
                IDCategoria = 5,
                Descripcion = "Carla", 
                Activo = false
            };

            //-->Act, llamo al metodo a testear.
            bool pudoEditar = categoriaDAO.UpdateDato(categoriaEditar, out mss);

            //-->Assert verifico si pudo editar
            Assert.IsTrue(pudoEditar);
        }

        /// <summary>
        /// Me permitirá revisar si pudo ELIMINAR una Categoria
        /// y el metodo devuelve TRUE.
        /// </summary>
        [TestMethod]
        public void DeleteCategoria_OK()
        {
            //-->Arrange
            string mss = string.Empty;
            CategoriasDAO categoriaDAO = new CategoriasDAO();
            Categoria categoriaAEliminar = new Categoria()//-->Instancio una nueva categoria para luego eliminarlo
            {
                Descripcion = "Pepito", 
                Activo = true
            };

            //-->Act testeo los metodos
            categoriaDAO.RegistrarDato(categoriaAEliminar, out mss);//-->Primero la registro
            bool pudoEliminar = categoriaDAO.DeleteDato(categoriaAEliminar.IDCategoria, out mss);

            //-->Assert verifico que devolvio.
            Assert.IsTrue(pudoEliminar);
        }
    }
}
