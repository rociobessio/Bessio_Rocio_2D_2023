using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AplicacionForms
{
    public partial class FrmContendorEstadisticas : Form
    {
        #region ATRIBUTOS DEL FORM
        private Form frmActual;
        List<Viaje> listaViajes;
        #endregion

        #region CONSTRUCTORES DEL FORM
        /// <summary>
        /// Contructor por defecto del formulario.
        /// </summary>
        public FrmContendorEstadisticas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor parametrizado del formulario, recibe la lista de viajes.
        /// </summary>
        /// <param name="listaViajes"></param>
        public FrmContendorEstadisticas(List<Viaje> listaViajes) : this()
        {
            this.listaViajes = listaViajes;
        }

        #endregion

        #region METODO DEL FORM
        private void mostrarEstadisticas(Form frmEstadisticas, object btnUsado)
        {
            if (frmActual is not null)
            {
                frmActual.Close();
            }

            frmActual = frmEstadisticas;
            frmEstadisticas.TopLevel = false;
            frmEstadisticas.Dock = DockStyle.Fill;
            this.panelEstadisticas.Controls.Add(frmEstadisticas);
            this.panelEstadisticas.Tag = frmEstadisticas;
            frmEstadisticas.BringToFront();
            frmEstadisticas.Show(); 
        }
        #endregion

        #region BOTONES DEL FORM
        /// <summary>
        /// Al presionar el boton 'DESTINOS' mostrara las estadisticas de los destinos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDestinos_Click(object sender, EventArgs e)
        {
            mostrarEstadisticas(new FrmEstadisticasDestinos(listaViajes),sender);
        }

        /// <summary>
        /// Al presionar el boton 'PASAJEROS' me permite visualizar las estadisticas
        /// de los pasajeros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPasajeros_Click(object sender, EventArgs e)
        {
            mostrarEstadisticas(new FrmEstadisticasPasajeros(listaViajes), sender);
        }

        /// <summary>
        /// Al presionar el boton 'CRUCEROS' me permite visualizar las estadisticas 
        /// de los cruceros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCruceros_Click(object sender, EventArgs e)
        {
            mostrarEstadisticas(new FrmEstadisticasCruceros(listaViajes), sender);
        } 
        #endregion


    }
}
