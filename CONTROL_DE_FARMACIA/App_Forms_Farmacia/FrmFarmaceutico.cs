using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Forms_Farmacia.Farmaceutico;

namespace App_Forms_Farmacia
{
    public partial class FrmFarmaceutico : Form
    {
        #region ATRIBUTOS
        FrmLogin frmLogin;
        FrmPanelInfoFarmaceutico frmPanelInfoFarmaceutico;
        FrmAddMedicina frmAddMedicina;
        FrmVerMedicinas frmVerMedicinas;
        FrmModMedicina FrmModMedicina;
        FrmFechasMedicinas frmFechasMedicinas;
        FrmVenderMedicina frmVenderMedicina;
        #endregion

        #region CONSTRUCTOR
        public FrmFarmaceutico(string user)
        {
            InitializeComponent();
            this.labelUsuario.Text = user;
            frmLogin = new FrmLogin();
            frmPanelInfoFarmaceutico = new FrmPanelInfoFarmaceutico(user);
            frmAddMedicina = new FrmAddMedicina(user);
            frmVerMedicinas = new FrmVerMedicinas();
            FrmModMedicina = new FrmModMedicina();
            frmFechasMedicinas = new FrmFechasMedicinas();
            frmVenderMedicina = new FrmVenderMedicina("VENDER MEDICINAS");
        }
        #endregion

        #region BOTONES
        /// <summary>
        /// Me permite volver al login.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin.Show();
            this.Hide();
        }

        /// <summary>
        /// Abre le panel de informacion para farmacéuticos..
        /// Aun en arreglos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            frmPanelInfoFarmaceutico.ShowDialog();
        }

        /// <summary>
        /// Abre el formulario para añadir nuevas medicinas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddMedicina_Click(object sender, EventArgs e)
        {
            frmAddMedicina.ShowDialog();
        }

        /// <summary>
        /// Al presionar este boton el usuario podra visualizar
        /// todas las medicinas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewMedicina_Click(object sender, EventArgs e)
        {
            frmVerMedicinas.ShowDialog();
        }

        /// <summary>
        /// Al presionar el boton el usuario podra modificar
        /// la medicina que crea correspondiente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModMedicina_Click(object sender, EventArgs e)
        {
            FrmModMedicina.ShowDialog();
        }

        /// <summary>
        /// Me permite ver las medicinas que estan vencidas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidarPrecioMedicina_Click(object sender, EventArgs e)
        {
            frmFechasMedicinas.ShowDialog();
        }

        /// <summary>
        /// Le permite al farmaceutico vender medicina.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVenderMedicina_Click(object sender, EventArgs e)
        {
            frmVenderMedicina.ShowDialog();
        }
        #endregion

    }
}
