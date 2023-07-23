using Entidades;
using Negocio;
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
        #region CATEGORIAS
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

        [HttpGet]//-->Evito errores,son url que devuelve datos al ejecutarlo.
        /// <summary>
        /// Si luego pongo en Chrome: https://localhost:44320/Home/ListarUsuarios viene
        /// a este metodo si pongo un punto de quiebre.
        /// </summary>
        /// <returns></returns>
        public JsonResult ListarCategorias()
        {
            List<Categoria> listaCategorias = new CN_Categorias().Listar();//-->Instancio CN_Categorias y llamo al metodo
            return Json(new { data = listaCategorias }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]//-->Evito errores,son url que devuelve datos al ejecutarlo.
        /// <summary>
        /// Me permite guardar o editar una categoria
        /// mediante la web y almacenarlo en la tabla
        /// de la base de datos.
        /// </summary>
        /// <returns></returns>
        public JsonResult GuardarCategoria(Categoria categoria)
        {
            object resultado;
            string mensaje = string.Empty;

            if (categoria.IDCategoria == 0)//-->Significa que es un nuevo usuario y se tiene que registrar
                resultado = new CN_Categorias().RegistrarDato(categoria, out mensaje);
            else
                resultado = new CN_Categorias().EditarDato(categoria, out mensaje);

            return Json(new { resultado = resultado, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]//-->Evito errores,son url que devuelve datos al ejecutarlo.
        /// <summary>
        /// Me permite ELIMINAR una Categoria 
        /// </summary>
        /// <returns></returns>
        public JsonResult EliminarCategoria(int id)
        {
            bool respuesta = false;
            string mensaje = string.Empty;

            respuesta = new CN_Categorias().DeleteDato(id, out mensaje);

            return Json(new { resultado = respuesta, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region MARCAS
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

        [HttpGet]//-->Evito errores,son url que devuelve datos al ejecutarlo.
        /// <summary>
        /// Si luego pongo en Chrome: https://localhost:44320/Home/ListarUsuarios viene
        /// a este metodo si pongo un punto de quiebre.
        /// </summary>
        /// <returns></returns>
        public JsonResult ListarMarcas()
        {
            List<Marca> listaMarcas = new CN_Marcas().Listar();//-->Instancio CN_Marcas y llamo al metodo
            return Json(new { data = listaMarcas }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]//-->Evito errores,son url que devuelve datos al ejecutarlo.
        /// <summary>
        /// Me permite guardar o editar una marca
        /// mediante la web y almacenarlo en la tabla
        /// de la base de datos.
        /// </summary>
        /// <returns></returns>
        public JsonResult GuardarMarca(Marca marca)
        {
            object resultado;
            string mensaje = string.Empty;

            if (marca.IDMarca == 0)//-->Significa que es una nueva marca y se tiene que registrar
                resultado = new CN_Marcas().RegistrarDato(marca, out mensaje);
            else
                resultado = new CN_Marcas().EditarDato(marca, out mensaje);

            return Json(new { resultado = resultado, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]//-->Evito errores,son url que devuelve datos al ejecutarlo.
        /// <summary>
        /// Me permite ELIMINAR una Marca 
        /// </summary>
        /// <returns></returns>
        public JsonResult EliminarMarca(int id)
        {
            bool respuesta = false;
            string mensaje = string.Empty;

            respuesta = new CN_Marcas().DeleteDato(id, out mensaje);

            return Json(new { resultado = respuesta, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region PRODUCTOS
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
        #endregion
    }
}