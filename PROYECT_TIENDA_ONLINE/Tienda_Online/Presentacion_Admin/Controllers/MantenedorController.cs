using Entidades;
using Negocio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
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
        //++++++++++++++++++++++++++++++++++++++++ CATEGORÍAS ++++++++++++++++++++++++++++++++++++++++ 
        #region                                    CATEGORIAS
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

        //++++++++++++++++++++++++++++++++++++++++ MARCAS ++++++++++++++++++++++++++++++++++++++++ 
        #region                                    MARCAS
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

        //++++++++++++++++++++++++++++++++++++++++ PRODUCTOS ++++++++++++++++++++++++++++++++++++++++ 
        #region                                    PRODUCTOS
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

        [HttpGet]//-->Evito errores,son url que devuelve datos al ejecutarlo.
        /// <summary>
        /// Si luego pongo en Chrome: https://localhost:44320/Home/ListarUsuarios viene
        /// a este metodo si pongo un punto de quiebre.
        /// </summary>
        /// <returns></returns>
        public JsonResult ListarProductos()
        {
            List<Producto> listaProductos = new CN_Productos().Listar();//-->Instancio CN_Productos y llamo al metodo
            return Json(new { data = listaProductos }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]//-->Evito errores,son url que devuelve datos al ejecutarlo.
        /// <summary>
        /// Me permite guardar o editar un producto
        /// mediante la web y almacenarlo en la tabla
        /// de la base de datos.
        /// </summary>
        /// <returns></returns>
        public JsonResult GuardarProducto(string producto, HttpPostedFileBase archivoImagen)
        { 
            string mensaje = string.Empty;
            bool operacionExitosa = true;
            bool pudoGuardarImagen = true;
            Producto oProducto = new Producto();
            oProducto = JsonConvert.DeserializeObject<Producto>(producto);
            double precio;

            if (double.TryParse(oProducto.PrecioTexto, NumberStyles.AllowDecimalPoint, new CultureInfo("es-AR"), out precio))
                oProducto.Precio = precio;
            else
                return Json(new { operacionExitosa = false, mensaje = "El formato del precio debe ser ##.##" },JsonRequestBehavior.AllowGet);

            if (oProducto.IDProducto == 0)
            {
                int idProductoGenerado = new CN_Productos().RegistrarDato(oProducto, out mensaje);

                if (idProductoGenerado != 0)
                    oProducto.IDProducto = idProductoGenerado; // --> Toma el id generado
                else
                    operacionExitosa = false;
            }
            else
                operacionExitosa = new CN_Productos().EditarDato(oProducto, out mensaje);

            // --> Reemplazar la coma por un punto en el precio antes de guardarlo
            oProducto.PrecioTexto = oProducto.PrecioTexto.Replace(",", ".");

            //-->Logica para registrar la imagen:
            if (operacionExitosa)
            {
                if(archivoImagen != null)
                {
                    string rutaGuardar = ConfigurationManager.AppSettings["ServidorDeFotos"];
                    string extensionAGuardar = Path.GetExtension(archivoImagen.FileName);
                    string nombre_Imagen = string.Concat(oProducto.IDProducto.ToString());//-->El nombre d la imgen se guarda con la id del producto y su extension
                    try
                    {
                        archivoImagen.SaveAs(Path.Combine(rutaGuardar,nombre_Imagen));
                    }
                    catch (Exception ex)
                    {
                        string error = ex.Message;
                        pudoGuardarImagen = false;
                    }

                    if (pudoGuardarImagen)
                    {
                        oProducto.RutaImagen = rutaGuardar;
                        oProducto.NombreImagen = nombre_Imagen;
                        bool rta = new CN_Productos().GuardarDatosImagen(oProducto, out mensaje);
                    }
                    else
                        mensaje = "Se ha guardado el producto pero ocurrío un error al guardar la imagen.";
                }
            }
            return Json(new { operacionExitosa = operacionExitosa,idGenerado = oProducto.IDProducto ,mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]//-->Evito errores,son url que devuelve datos al ejecutarlo.
        /// <summary>
        /// Me permite ELIMINAR un Producto 
        /// </summary>
        /// <returns></returns>
        public JsonResult EliminarProducto(int id)
        {
            bool respuesta = false;
            string mensaje = string.Empty;

            respuesta = new CN_Productos().DeleteDato(id, out mensaje);

            return Json(new { resultado = respuesta, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        } 

        [HttpPost]
        public JsonResult ImagenProducto(int idProducto)
        {
            bool conversion;
            Producto producto = new CN_Productos().Listar().Where(p => p.IDProducto == idProducto).FirstOrDefault();

            string txtBase64 = CN_Recursos.ConvertirBase64(Path.Combine(producto.RutaImagen,producto.NombreImagen), out conversion);

            return Json(new { conversion = conversion, txtBase64 = txtBase64, extension = Path.GetExtension(producto.NombreImagen)},
                   JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}