using Entidades;
using CapaDatos;

namespace SQLTest
{
    [TestClass]
    public class TestUsuariosSQL
    {
        /// <summary>
        /// Me permite verificar si el metodo
        /// ObtenerLista de la clase UsuariosDAO
        /// retorna al menos un elemento en la lista.
        /// </summary>
        [TestMethod]
        public void ObtenerListaUsuarios_OK()
        {
            //-->Arrange preparar variables
            UsuariosDAO usuariosDAO = new UsuariosDAO();
            List<Usuario> usuarios = usuariosDAO.ObtenerLista();

            //-->Act verifico que cargue en la lista
            bool esValido = usuarios.Count > 0;

            //-->Assert compruebo que el resultado sea el esperado
            Assert.IsTrue(esValido);
        }
    }
}