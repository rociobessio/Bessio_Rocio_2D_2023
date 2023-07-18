using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentacion_Admin.Controllers
{
    /// <summary>
    /// Creo un controlador propio,
    /// Donde tendre 3 formularios y cada uno
    /// retornara una vista
    /// </summary>
    public class MantenedorController : Controller
    {
        /// <summary>
        /// 1. Me paro sobre la carpeta controllers
        /// 2. Me paro sobre el nombre del metodo
        ///    y agrego la VISTA.
        /// 3. Luego me voy a layout y cambio esta linea:
        ///    class="nav-link" href="@Url.Action("Categorias","Mantenedor")"
        /// </summary>
        /// <returns></returns>
        public ActionResult Categorias()
        {
            return View();
        }

        /// <summary>
        /// 1. Me paro sobre la carpeta controllers
        /// 2. Me paro sobre el nombre del metodo
        ///    y agrego la VISTA.
        /// 3. Luego me voy a layout y cambio esta linea:
        ///    class="nav-link" href="@Url.Action("Marcas","Mantenedor")"
        /// </summary>
        /// <returns></returns>
        public ActionResult Marcas()
        {
            return View();
        }

        /// <summary>
        /// 1. Me paro sobre la carpeta controllers
        /// 2. Me paro sobre el nombre del metodo
        ///    y agrego la VISTA.
        /// 3. Luego me voy a layout y cambio esta linea:
        ///    class="nav-link" href="@Url.Action("Producto","Mantenedor")"
        /// </summary>
        /// <returns></returns>
        public ActionResult Producto()
        {
            return View();
        }
    }
}