using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Forms_Farmacia
{
    public partial class FrmPerfiles : Form
    {
        #region ATRIBUTOS
        FrmMenuPrincipal menuPrincipal;
        Database db = new Database();
        String query;

        #endregion

        #region CONSTRUCTOR
        public FrmPerfiles(string usuario)
        {
            InitializeComponent();
            menuPrincipal = new FrmMenuPrincipal(usuario);
            this.labelUsername.Text = usuario;
        }
        #endregion

        #region BOTONES
        /// <summary>
        /// Al presionar la 'X' se cerrara este formulario
        /// y el usuario podra volver al menu principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExitPanel_Click(object sender, EventArgs e)
        {
            menuPrincipal.Show();
            this.Hide();
        }

        /// <summary>
        /// Al presionar este boton se le imprimira un mensaje de ayuda
        /// al usuario para saber que hace el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El usuario podrá modificar su propio perfil. Para cerrarlo o ir a otra opcion del menu se debe de presionar el botón con la 'X'.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Actualizo la informacion del usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String rol = this.cbUserRole.SelectedItem.ToString();
            String name = this.txtNombre.Text;
            String nacimiento = this.txtNacimiento.Text;
            String email = this.txtEmail.Text;
            Int64 celular = Int64.Parse(this.txtNumCelular.Text);
            String usuario = this.labelUsername.Text;
            String pass = this.txtContraseña.Text;

            query = "update users set userRole = '"+rol+"', name = '"+name+"', nacimiento = '"+nacimiento+"', celular = '"+celular+"', email = '"+email+"', pass ='"+pass+"' where username = '"+usuario+"'";
            db.setData(query,"Actualización del perfil realizada correctamente.");
        }

        /// <summary>
        /// Al presionarlo me permite limpiar todos los textbox
        /// y el combobox del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FrmPerfiles_Enter(this,null);
        }

        #endregion

        private void FrmPerfiles_Enter(object sender, EventArgs e)
        {
            query = "select * from users where username = '"+this.labelUsername.Text+"'";
            DataSet ds = db.obtenerData(query);
            cbUserRole.Text = ds.Tables[0].Rows[0][1].ToString();
            txtNombre.Text = ds.Tables[0].Rows[0][2].ToString();
            txtNacimiento.Text = ds.Tables[0].Rows[0][3].ToString();
            txtNumCelular.Text = ds.Tables[0].Rows[0][4].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
            txtContraseña.Text = ds.Tables[0].Rows[0][7].ToString();
        }
    }
}
