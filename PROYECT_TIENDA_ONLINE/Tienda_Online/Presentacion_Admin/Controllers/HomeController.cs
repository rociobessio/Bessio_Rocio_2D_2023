using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Negocio;

namespace Presentacion_Admin.Controllers
{
    /// <summary>
    /// El HomeController me permitira
    /// crear los controles d la página.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Será del tipo ActionResult y
        /// referencia al apartado 'Inicio'.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 2. Me paro sobre el nombre del metodo
        ///    y agrego la VISTA.
        /// 3. Luego me voy a layout y cambio esta linea:
        ///    class="nav-link" href="@Url.Action("Usuarios","Home")"
        /// </summary>
        /// <returns></returns>
        public ActionResult Usuarios()
        {
            return View();
        }

        [HttpGet]//-->Evito errores,son url que devuelve datos al ejecutarlo.
        /// <summary>
        /// Si luego pongo en Chrome: https://localhost:44320/Home/ListarUsuarios viene
        /// a este metodo si pongo un punto de quiebre.
        /// </summary>
        /// <returns></returns>
        public JsonResult ListarUsuarios()
        {
            List<Usuario> listaUsuarios = new CN_Usuarios().Listar();//-->Instancio CN_Usuarios y llamo al metodo
            return Json(new { data = listaUsuarios },JsonRequestBehavior.AllowGet);
        }

        [HttpPost]//-->Evito errores,son url que devuelve datos al ejecutarlo.
        /// <summary>
        /// Me permite guardar o editar un usuario
        /// mediante la web y almacenarlo en la tabla
        /// de la base de datos.
        /// </summary>
        /// <returns></returns>
        public JsonResult GuardarUsuario(Usuario usuario)
        {
            object resultado;
            string mensaje = string.Empty;

            if (usuario.IDUsuario == 0)//-->Significa que es un nuevo usuario y se tiene que registrar
                resultado = new CN_Usuarios().RegistrarDato(usuario, out mensaje);
            else
                resultado = new CN_Usuarios().EditarDato(usuario,out mensaje);

            return Json(new { resultado = resultado, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]//-->Evito errores,son url que devuelve datos al ejecutarlo.
        /// <summary>
        /// Me permite ELIMINAR un usuario 
        /// </summary>
        /// <returns></returns>
        public JsonResult EliminarUsuario(int id)
        {
            bool respuesta = false;
            string mensaje = string.Empty;

            respuesta = new CN_Usuarios().DeleteDato(id, out mensaje);

            return Json(new { resultado = respuesta, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }
    }
}