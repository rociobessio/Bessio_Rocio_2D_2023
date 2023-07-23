using Entidades;
using CapaDatos;

namespace SQLTest
{
    /// <summary>
    /// Esta clase de unit testing
    /// me permite verificar los 
    /// metodos de la clase 
    /// UsuariosDAO.
    /// </summary>
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

        /// <summary>
        /// Me permitirá revisar si pudo registrar un Usuario
        /// y el metodo devuelve TRUE.
        /// </summary>
        [TestMethod]
        public void RegistrarUsuario_OK()
        {
            //-->Arrange
            string mss = string.Empty;
            UsuariosDAO usuariosDAO = new UsuariosDAO();
            Usuario usuarioNuevo = new Usuario()//-->Instancio un nuevo usuario
            {
                IDUsuario = 5,
                Nombres = "Maximiliano Ignacio",
                Apellidos = "De Paul",
                Correo = "maxipaul@hotmail.com.ar",
                Clave = "114bd151f8fb0c58642d2170da4ae7d7c57977260ac2cc8905306cab6b2acabc",
                Activo = true
            };

            //-->Act, llamo al metodo a testear.
            int idAutoGenerado = usuariosDAO.RegistrarDato(usuarioNuevo,out mss);

            //-->Assert verifico
            Assert.AreEqual(5,idAutoGenerado);
        }

        /// <summary>
        /// Me permitirá revisar si pudo editar un Usuario
        /// y el metodo devuelve TRUE.
        /// </summary>
        [TestMethod]
        public void UpdateUsuario_OK()
        {
            //-->Arrange
            string mss = string.Empty;
            UsuariosDAO usuariosDAO = new UsuariosDAO();
            Usuario usuarioEditar = new Usuario()//-->Instancio el usuario
            {
                IDUsuario = 4,
                Nombres = "Carla",
                Apellidos = "Bologne",
                Correo = "carbol@gmail.com",
                Clave = "cebe3d9d614ba5c19f633566104315854a11353a333bf96f16b5afa0e90abdc4",
                Activo = false
            };

            //-->Act, llamo al metodo a testear.
            bool pudoEditar = usuariosDAO.UpdateDato(usuarioEditar,out mss);

            //-->Assert verifico si pudo editar
            Assert.IsTrue(pudoEditar);
        }

        /// <summary>
        /// Me permitirá revisar si pudo ELIMINAR un Usuario
        /// y el metodo devuelve TRUE.
        /// </summary>
        [TestMethod]
        public void DeleteUsuario_OK()
        {
            //-->Arrange
            string mss = string.Empty;
            UsuariosDAO usuariosDAO = new UsuariosDAO();
            Usuario usuarioAEliminar = new Usuario()//-->Instancio un nuevo usuario para luego eliminarlo
            {  
                Nombres = "Pepito",
                Apellidos = "El Grillo",
                Correo = "pepge@yahoo.com.ar",
                Clave = "f8fbd159d4e3e913a2db46923c74d69dbf93136935b5c964b9c752db257bb11c",
                Activo = true
            };

            //-->Act testeo los metodos
            usuariosDAO.RegistrarDato(usuarioAEliminar, out mss);//-->Primero lo registro
            bool pudoEliminar = usuariosDAO.DeleteDato(usuarioAEliminar.IDUsuario, out mss);

            //-->Assert verifico que devolvio.
            Assert.IsTrue(pudoEliminar);
        }
    }
}