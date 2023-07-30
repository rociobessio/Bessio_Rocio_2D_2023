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
        /// Este metodo me permitira retornar una Marca cargado 
        /// de esta forma no se repetira codigo instanciandola
        /// en todos los metodos de test unitarios de la clase.
        /// </summary>
        /// <returns></returns>
        private Marca CrearMarcaPrueba()
        {
            return new Marca()//-->Instancio una nueva Marca
            {
                Descripcion = "Unit Testing Marcas",
                Activo = true
            };
        }

        /// <summary>
        /// Me permite verificar si el metodo
        /// ObtenerLista de la clase MarcasDAO
        /// retorna al menos un elemento en la lista.
        /// </summary>
        [TestMethod]
        public void ObtenerListaMarcas_OK()
        {
            //-->Arrange preparar variables 
            List<Marca> listaCategorias = new MarcasDAO().ObtenerLista();

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
            Marca marcaNueva = this.CrearMarcaPrueba();

            List<Marca> listaMarcas = new MarcasDAO().ObtenerLista();
            Marca ultimaMarcaRegistrada = listaMarcas.Last();
            int ultimoID = ultimaMarcaRegistrada.IDMarca;

            //-->Act, llamo al metodo a testear.
            int idAutoGenerado = new MarcasDAO().RegistrarDato(marcaNueva, out mss);

            //-->Assert verifico
            new MarcasDAO().DeleteDato(idAutoGenerado,out mss);//--> Ya lo registre, lo elimino y evito errores.
            Assert.AreEqual(idAutoGenerado, ultimoID + 1);
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
            Marca MarcaEditar = this.CrearMarcaPrueba();
            int id = new MarcasDAO().RegistrarDato(MarcaEditar,out mss);

            //-->Act, llamo al metodo a testear.
            bool pudoEditar = new MarcasDAO().UpdateDato(MarcaEditar, out mss);

            //-->Assert verifico si pudo editar
            new MarcasDAO().DeleteDato(id, out mss);//--> Ya lo registre, lo elimino y evito errores.
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
