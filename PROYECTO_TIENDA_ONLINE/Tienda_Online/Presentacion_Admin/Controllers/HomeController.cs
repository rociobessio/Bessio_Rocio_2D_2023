using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using ClosedXML.Excel;
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
        //++++++++++++++++++++++++++++++++++++++++ PANEL ++++++++++++++++++++++++++++++++++++++++ 
        #region PANEL DE CONTROL
        /// <summary>
        /// Será del tipo ActionResult y
        /// referencia al apartado 'Inicio'.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult VisualizarPanelControl()
        {
            PanelControl panelControl = new CN_Reporte().VerPanelControl();
            return Json(new { resultado = panelControl}, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult ListarReportes(string fechaInicio, string fechaFin, string IDTransaccion)
        {
            List<Reporte> olista = new List<Reporte>();
            olista = new CN_Reporte().ObtenerVentas(fechaInicio,fechaFin,IDTransaccion);
            return Json(new { data = olista }, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Me permitirá exportar un XML con las
        /// ventas realizadas durante Xs fechas
        /// </summary>
        /// <param name="fechaInicio"></param>
        /// <param name="fechaFin"></param>
        /// <param name="IDTransaccion"></param>
        /// <returns></returns>
        [HttpPost]
        public FileResult ExportarVentas(string fechaInicio, string fechaFin, string IDTransaccion)
        {
            List<Reporte> listaReportes = new CN_Reporte().ObtenerVentas(fechaInicio,fechaFin,IDTransaccion);
            DataTable dataTable = new DataTable();

            dataTable.Locale = new System.Globalization.CultureInfo("es-PE");
            dataTable.Columns.Add("Fecha Venta",typeof(string));
            dataTable.Columns.Add("Cliente", typeof(string));
            dataTable.Columns.Add("Producto", typeof(string));
            dataTable.Columns.Add("Precio", typeof(double));
            dataTable.Columns.Add("Cantidad", typeof(int));
            dataTable.Columns.Add("Total", typeof(double));
            dataTable.Columns.Add("ID Transaccion", typeof(string));

            foreach (Reporte reporte in listaReportes)
            {
                dataTable.Rows.Add(new object[]
                {
                    reporte.FechaVenta,
                    reporte.Cliente,
                    reporte.Producto,
                    reporte.Precio,
                    reporte.Cantidad,
                    reporte.Total,
                    reporte.IDTransaccion
                });
            }
            dataTable.TableName = "Datos";

            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dataTable);

                using (MemoryStream ms = new MemoryStream())
                {
                    wb.SaveAs(ms);
                    return File(ms.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ReporteVenta" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx");
                }
            }
        }
        #endregion

        //++++++++++++++++++++++++++++++++++++++++ USUARIOS ++++++++++++++++++++++++++++++++++++++++ 
        #region USUARIOS
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
        #endregion
    }
}