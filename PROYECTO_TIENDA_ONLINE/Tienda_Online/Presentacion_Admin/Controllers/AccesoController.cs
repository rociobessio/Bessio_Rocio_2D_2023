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
                ViewBag.Error = "Correo o contraseña incorrectos!";//-->Guarda información
                return View();
            }
            else
            {
                if (usuario.Reestablecer)//-->Primera vez que ingresará al sistema
                {
                    TempData["IDUsuario"] = usuario.IDUsuario;//-->TempData guarad info y la comparte dentro de distintas vistas d un mismo controlador
                    return RedirectToAction("CambiarClave");//-->Nuevo formulario que le dejará registrarse 
                }

                ViewBag.Error = null;
                return RedirectToAction("Index","Home");
            } 
        }

        [HttpPost]
        public ActionResult CambiarClave(string idUsuario,string claveActual,string nuevaClave, string confirmarClave)
        {
            string mensaje = string.Empty;
            Usuario usuario = new Usuario();
            usuario = new CN_Usuarios().Listar().Where(u => u.IDUsuario == int.Parse(idUsuario)).FirstOrDefault();//-->Filtro el usuario

            if(usuario.Clave != CN_Recursos.EncriptarClavesSha256(claveActual))//--> Si las contraseñas NO coinciden!
            {
                TempData["IDUsuario"] = idUsuario;
                ViewBag.Error = "Contraseña actual es incorrecta!";//-->Lanzo un mensaje
                ViewData["vClave"] = string.Empty;//-->En caso de ingresar mal, limpio el txt de contraseña actual.
                return View();
            }
            else if(nuevaClave != confirmarClave)
            {
                TempData["IDUsuario"] = idUsuario;
                ViewData["vClave"] = claveActual;//-->Contraseña correcta la mantengo asi no vuelve a ingresarla.
                ViewBag.Error = "Las contraseñas NO coinciden!";//-->Lanzo un mensaje 
                return View();
            } 
            ViewData["vClave"] = string.Empty;

            nuevaClave = CN_Recursos.EncriptarClavesSha256(nuevaClave);
            bool respuesta = new CN_Usuarios().CambiarClave(int.Parse(idUsuario), nuevaClave, out mensaje);//-->Actualizo la clave

            if (respuesta)
                return RedirectToAction("Index");
            else
            {
                TempData["IDUsuario"] = idUsuario;
                ViewBag.Error = mensaje;
                return View();
            } 
        }
    }
}