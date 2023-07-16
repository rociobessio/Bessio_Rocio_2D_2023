using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        /// Será del tipo ActionResult y
        /// referencia al apartado 'Acerca de '.
        /// </summary>
        /// <returns></returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /// <summary>
        /// Será del tipo ActionResult y
        /// referencia al apartado 'Contacto'.
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
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
        public ActionResult TEST()
        { 

            return View();
        }
    }
}