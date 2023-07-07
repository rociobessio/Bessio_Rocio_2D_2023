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

namespace App_Forms_Farmacia
{
    public partial class FrmMenuPrincipal : Form
    {
        #region ATRIBUTOS
        FrmLogin frmLogin;
        FrmPanelInformacion frmPanelInformacion;
        FrmAddUser FrmAddUser;
        FrmVerUsuarios frmVerUsuarios;
        FrmPerfiles frmPerfiles;
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor que recibe el nombre del usuario
        /// </summary>
        /// <param name="userName"></param>
        public FrmMenuPrincipal(string username)
        {
            InitializeComponent();
            labelUsuario.Text = username;

            #region INSTANCIAR FORMS
            frmLogin = new FrmLogin();
            #endregion
        }
        #endregion

        #region BOTONES DEL FORM
        /// <summary>
        /// Al presionar el botón de salir, se cerrara este formulario
        /// y abrira nuevamente el Login.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin.Show();
            this.Hide();
        }

        /// <summary>
        /// Le permite al administrador ver cuantos usuarios hay de cada rol
        /// y las tareas que realizan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            frmPanelInformacion = new FrmPanelInformacion(labelUsuario.Text);
            frmPanelInformacion.ShowDialog();
        }

        /// <summary>
        /// Me abre el frm para agregar un usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            FrmAddUser = new FrmAddUser(labelUsuario.Text);
            FrmAddUser.ShowDialog();
        }

        /// <summary>
        /// Se abre el frm para visualizar a los usuarios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            frmVerUsuarios = new FrmVerUsuarios(labelUsuario.Text);
            frmVerUsuarios.ShowDialog();
        }

        /// <summary>
        /// Al presionarlo el adminstrador podra ver los perfiles de 
        /// los usuarios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmPerfiles = new FrmPerfiles(labelUsuario.Text);
            frmPerfiles.ShowDialog();
        }
        #endregion


    }
}
