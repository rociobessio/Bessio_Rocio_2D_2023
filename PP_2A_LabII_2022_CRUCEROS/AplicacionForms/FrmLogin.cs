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
    public partial class FrmLogin : Form
    {
        #region ATRIBUTOS DEL FORM
        Compañia c = new Compañia(4, "TITANIC RISEN");
        #endregion

        #region CONSTRUCTOR FORM
        public FrmLogin()
        {
            InitializeComponent();
        }
        #endregion 

        #region BOTONES FORM
        /// <summary>
        /// Al presionarlo me permite verificar si el usuario y la contraseña existen,
        /// en ese caso se abrira el menu de la aplicacion.
        /// Caso contrario, se le pedira un reingreso de datos, ya sea por
        /// informacion incorrecta o campos faltantes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = this.tbUserName.Text;
            string password = this.tbPassword.Text;
            Vendedor v = new Vendedor(userName, password);

            if (ValidarIngresoDatos(userName, password))
            {
                if (c.LoguearUser(v))
                {
                    MessageBox.Show("USUARIO LOGUEADO!");

                    //si el usuario logro LOGUEARSE entonces se abre el SEGUNDO FORMULARIO
                    FrmMenu menu = new FrmMenu(userName);

                    menu.Show();//MUESTRO EL SEGUNDO FORM

                    //Y SI QUIERO QIE OCULTE EL PRIMER FORM
                    this.Hide();
                }
                else
                {
                    this.ErrorShow("USUARIO INCORRECTO!");
                }
            }
            else
            {
                this.ErrorShow("LOS CAMPOS DEBEN DE ESTAR COMPLETOS!");
            }
        }

        /// <summary>
        /// Me permite resetear los textbox del usuario
        /// y la contraseña.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.tbPassword.Text = "";
            this.tbUserName.Text = "";
        }

        /// <summary>
        /// Imprime en pantalla un cartel para guiar al usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El usuario debe de ingresar su usuario y contraseña para continuar", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region METODOS DEL FORM
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "USER LOGIN";
            this.lbCompany.Text = c.Nombre;
            this.Dock = DockStyle.Fill;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.toolTipMensaje.SetToolTip(this.tbUserName,"Ingrese el usuario que se encuentra en el readme.");
            this.toolTipMensaje.SetToolTip(this.tbPassword,"Ingrese la contraseña que se encuentra en el readme.");
        }


        /// <summary>
        /// Metodo para validar el usuario y contraseña ingresados.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool ValidarIngresoDatos(string userName, string password)
        {
            return (Validador.ValidarTexto(userName) && Validador.ValidarTexto(password));
        }

        /// <summary>
        /// Me imprime en pantalla un mensaje con error de ingreso de datos.
        /// </summary>
        /// <param name="cadena"></param>
        private void ErrorShow(string cadena)
        {
            MessageBox.Show(cadena, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //LIMPIO CONTENIDO DEL TEXT BOX
            this.tbUserName.Text = string.Empty;
            this.tbPassword.Text = string.Empty;
        }

        /// <summary>
        /// Le pregunta al usuario si realmetne quiere cerrar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea finalizar el programa?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
        #endregion


    }
}
