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
        #endregion
    }
}
