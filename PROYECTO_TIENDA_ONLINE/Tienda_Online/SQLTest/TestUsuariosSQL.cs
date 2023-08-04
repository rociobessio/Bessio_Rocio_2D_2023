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
        /// Este metodo me permitira retornar un usuario cargado 
        /// de esta forma no se repetira codigo instanciandolo
        /// en todos los metodos de test unitarios de la clase.
        /// </summary>
        /// <returns></returns>
        private Usuario CrearUsuarioPrueba()
        {
            return new Usuario()//-->Instancio un nuevo usuario
            { 
                Nombres = "Usuario de Test",
                Apellidos = "Unit Testing",
                Correo = "userTest@hotmail.com.ar",
                Clave = "dasdasddasddasdad",
                Activo = true
            };
        }

        /// <summary>
        /// Me permite verificar si el metodo
        /// ObtenerLista de la clase UsuariosDAO
        /// retorna al menos un elemento en la lista.
        /// </summary>
        [TestMethod]
        public void ObtenerListaUsuarios_OK()
        {
            //-->Arrange preparar variables 
            List<Usuario> usuarios = new UsuariosDAO().ObtenerLista();

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
            //-->Arrange, prerparo las variables
            string mss = string.Empty;
            Usuario usuarioNuevo = this.CrearUsuarioPrueba();
            List<Usuario> listaUsuarios = new UsuariosDAO().ObtenerLista();
            Usuario ultimoUser = listaUsuarios.Last();//-->Obtengo el ultimo de la lista
            int ultimoID = ultimoUser.IDUsuario;

            //-->Act, llamo al metodo a testear.
            int idAutoGenerado = new UsuariosDAO().RegistrarDato(usuarioNuevo,out mss);

            //-->Assert verifico
            new UsuariosDAO().DeleteDato(usuarioNuevo.IDUsuario,out mss);//-->Elimino para evitar errores
            Assert.AreEqual(idAutoGenerado, ultimoID + 1);
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
            Usuario usuarioEditar = this.CrearUsuarioPrueba();
            int id = new UsuariosDAO().RegistrarDato(usuarioEditar, out mss);//-->Lo registro.

            //-->Act, llamo al metodo a testear.
            usuarioEditar.IDUsuario = id;
            usuarioEditar.Nombres = "Cambiandole el usuario en Unit Test";
            bool pudoEditar = new UsuariosDAO().UpdateDato(usuarioEditar,out mss);

            //-->Assert verifico si pudo editar
            new UsuariosDAO().DeleteDato(usuarioEditar.IDUsuario, out mss);//-->Elimino para evitar errores
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
            Usuario usuarioAEliminar = this.CrearUsuarioPrueba();

            //-->Act testeo los metodos
            int id = new UsuariosDAO().RegistrarDato(usuarioAEliminar, out mss);//-->Lo registro.

            //-->Act, llamo al metodo a testear.
            usuarioAEliminar.IDUsuario = id;
            bool pudoEliminar = new UsuariosDAO().DeleteDato(usuarioAEliminar.IDUsuario, out mss);

            //-->Assert verifico que devolvio.
            Assert.IsTrue(pudoEliminar);
        }
    }
}