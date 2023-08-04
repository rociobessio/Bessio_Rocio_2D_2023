using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;

namespace Negocio
{
    public class CN_Reporte
    {
        #region ATRIBUTOS
        private static PanelDAO panelDAO; 
        #endregion

        #region METODOS
        /// <summary>
        /// Me permite retornar
        /// los valores del 
        /// panel de control.
        /// </summary>
        /// <returns></returns>
        public PanelControl VerPanelControl()
        {
            CN_Reporte.panelDAO = new PanelDAO();
            return CN_Reporte.panelDAO.VerPanelControl();
        }

        /// <summary>
        /// Este metodo me permite retornar
        /// una lista de reportes sobre
        /// las ventas realizadas con la
        /// fecha de inicio y fin indicadas
        /// y que a su vez tienen ese ID
        /// de transaccion.
        /// </summary>
        /// <param name="fechaInicio"></param>
        /// <param name="fechaFin"></param>
        /// <param name="IDTransaccion"></param>
        /// <returns></returns>
        public List<Reporte> ObtenerVentas(string fechaInicio, string fechaFin, string IDTransaccion)
        {
            CN_Reporte.panelDAO = new PanelDAO();
            return CN_Reporte.panelDAO.ObtenerVentas(fechaInicio, fechaFin, IDTransaccion);
        }
        #endregion
    }
}
