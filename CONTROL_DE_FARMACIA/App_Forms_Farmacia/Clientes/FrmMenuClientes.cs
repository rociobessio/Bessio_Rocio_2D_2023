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

namespace App_Forms_Farmacia.Clientes
{
    public partial class FrmMenuClientes : Form
    {
        #region ATRIBUTOS
        FrmLogin frmLogin;
        FrmPedirTurno frmPedirTurno;
        FrmVenderMedicina frmVenderMedicina;
        FrmVerTurnos frmVerTurnos;
        #endregion

        #region CONSTRUCTOR
        public FrmMenuClientes(string usuario)
        {
            InitializeComponent();
            this.labelUsuario.Text = usuario;
            frmLogin = new FrmLogin();
            frmPedirTurno = new FrmPedirTurno(usuario);
            frmVenderMedicina = new FrmVenderMedicina("COMPRAR MEDICINA ONLINE");
            frmVerTurnos = new FrmVerTurnos(usuario);
        }
        #endregion

        #region BOTONES
        /// <summary>
        /// Al presionar el boton 'LOG OUT' el cliente podra
        /// cerrar sesion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin.Show();
            this.Hide();
        }

        /// <summary>
        /// El cliente podra solicitar un turno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTurno_Click(object sender, EventArgs e)
        {
            frmPedirTurno.ShowDialog();
        }

        /// <summary>
        /// El usuario podra comprar medicina.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComprarMedicina_Click(object sender, EventArgs e)
        {
            frmVenderMedicina.ShowDialog();
        }
        #endregion

        private void btnViewTurnos_Click(object sender, EventArgs e)
        {
            frmVerTurnos.ShowDialog();
        }
    }
}
