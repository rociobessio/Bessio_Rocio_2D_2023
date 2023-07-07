using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Forms_Farmacia.Farmaceutico
{
    public partial class FrmPanelInfoFarmaceutico : Form
    {
        #region ATRIBUTOS
        FrmFarmaceutico frmFarmaceutico;
        #endregion

        #region CONSTRUCTOR
        public FrmPanelInfoFarmaceutico(string usuario)
        {
            InitializeComponent();
            //frmFarmaceutico = new FrmFarmaceutico(usuario);
        }
        #endregion

        #region BOTONES
        /// <summary>
        /// Al presionar la 'X' me permite cerrar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExitPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Imprime un mensaje de ayuda para el usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se muestra en pantalla las estadísticas de las medicinas. Para cerrarlo o ir a otra opcion del menu se debe de presionar el botón con la 'X'.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion


    }
}
