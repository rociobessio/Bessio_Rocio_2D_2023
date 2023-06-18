using Entidades;

namespace UnitTestingSQL
{
    [TestClass]
    public class TestingSQLUsuarios
    {
        [TestMethod]
        public void ObtenerListaUsuarios_OK()
        {
            //-->Arrange preparar variables
            UsuariosDAO usuarasDAO = new UsuariosDAO();
            List<Usuario> usuarios = new List<Usuario>();
            usuarios = usuarasDAO.ObtenerLista();

            //-->Act verifico que cargue en la lista
            bool esValido = usuarios.Count > 0;

            //-->Assert compruebo que el resultado sea el esperado
            Assert.IsTrue(esValido);
        }
    } 
}