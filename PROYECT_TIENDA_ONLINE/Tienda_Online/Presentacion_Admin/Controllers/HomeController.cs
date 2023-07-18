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

        /// <summary>
        /// Si luego pongo en Chrome: https://localhost:44320/Home/ListarUsuarios viene
        /// a este metodo si pongo un punto de quiebre.
        /// </summary>
        /// <returns></returns>
        public JsonResult ListarUsuarios()
        {
            List<Usuario> listaUsuarios = new CN_Usuarios().Listar();//-->Instancio CN_Usuarios y llamo al metodo
            return Json(listaUsuarios,JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Será del tipo ActionResult y
        /// referencia al apartado 'TEST',
        /// 1. primero tuve que ir a _Layout.cshtml 
        /// en la carpeta Shared.
        /// 2. Luego de crear este metodo: 
        /// 3. Tuve que crear la vista, me paro sobre
        ///    el nombre del metodo click derecho y 
        ///    crear vista.
        /// 4. Tengo que, de momento, seleccionar del
        ///    tipo _Layout.
        /// </summary>
        /// <returns></returns>
        //public ActionResult TEST()
        //{ 

        //    return View();
        //}
    }
}