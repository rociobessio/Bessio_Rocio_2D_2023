using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Negocio;

namespace Presentacion_Admin.Controllers
{
    public class AccesoController : Controller
    {
        // GET: Acceso
        /// <summary>
        /// Me mostrará el formulario de
        /// inicio de sesion.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CambiarClave()
        {
            return View();
        }

        public ActionResult ReestablecerClave()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string correo,string clave)
        {
            Usuario usuario = new Usuario();
            usuario = new CN_Usuarios().Listar().Where(u => u.Correo == correo && u.Clave == CN_Recursos.EncriptarClavesSha256(clave)).FirstOrDefault();//-->Filtro el usuario

            if(usuario == null)
            {
                ViewBag.Error = "Correo o contraseña incorrectos.";
                return View();
            }
            else
            {
                ViewBag.Error = null;
                return RedirectToAction("Index","Home");
            }

            return View();
        }
    }
}