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
    public partial class FrmAddUser : Form
    {
        #region ATRIBUTOS
        string usuario;
        FrmMenuPrincipal menuPrincipal;
        string query;
        Database database = new Database();
        #endregion

        #region CONSTRUCTOR
        public FrmAddUser(string username)
        {
            InitializeComponent();
            usuario = username;
        }
        #endregion

        #region BOTONES
        /// <summary>
        /// Al presionar el boton con la 'X' se cerrara este formulario
        /// y se le permitirá al usuario utilizar el frmMenuPrincipal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExitPanel_Click(object sender, EventArgs e)
        {
            menuPrincipal = new FrmMenuPrincipal(usuario);
            this.Hide();
        }

        /// <summary>
        /// Le imprime al usuario un mensaje de ayuda para que sepa que se debe
        /// de hacer en el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El administrador podrá crear nuevos administradores o farmacéuticos llenando la información correspondiente. Para cerrarlo o ir a otra opcion del menu se debe de presionar el botón con la 'X'.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Me permite limpiar todos los textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.txtContraseña.Clear();
            this.txtDireEmail.Clear();
            this.txtNombre.Clear();
            this.txtNroCelular.Clear();
            this.txtUsuario.Clear();
            this.dtpFechaNacimiento.ResetText();
            this.cbUserRole.SelectedIndex = -1; 
        }

        /// <summary>
        /// Me permite guardar un usuario dentro de la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String userRole = this.cbUserRole.SelectedItem.ToString();
            String name = this.txtNombre.Text;
            String nacimiento = this.dtpFechaNacimiento.Text;
            Int64 celular = Int64.Parse(txtNroCelular.Text);
            String email = txtDireEmail.Text;
            String username = txtUsuario.Text;
            String pass = txtContraseña.Text;

            try
            {
                query ="insert into users (userRole,name,nacimiento,celular,email,username,pass) values ('"+userRole+"', '"+name+"', '"+nacimiento+"', "+celular+", '"+email+"', '"+username+"', '"+pass+"')";
                database.setData(query,"Usuario registrado con exito!");
            }
            catch(Exception)
            {
                MessageBox.Show("Username Already exist","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        #endregion

        #region EVENTOS DEL FORM
        /// <summary>
        /// Cuando el usuario comience a escribir su nombre de usuario 
        /// se mostrara al lado del textbox si ese user ya existe en la database o no.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username ='"+txtUsuario.Text+"'";
            DataSet ds = database.obtenerData(query);
            if (ds.Tables[0].Rows.Count ==0)
            {
                pictureBox1.ImageLocation = @"C:\Users\Rocio\Desktop\C#\CSharp_Applications\Control_De_Farmacia\Imagenes-Iconos\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\Users\Rocio\Desktop\C#\CSharp_Applications\Control_De_Farmacia\Imagenes-Iconos\no.png";
            }
        }

        /// <summary>
        /// En el datetimepicker no apareceran fechas antes 
        /// del 1923.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            this.dtpFechaNacimiento.MinDate = DateTime.Today.AddYears(-100);
            this.dtpFechaNacimiento.MaxDate = DateTime.Today;
        }
        #endregion


    }
}
