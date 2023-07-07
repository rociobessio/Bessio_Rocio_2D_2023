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
using App_Forms_Farmacia.Clientes;

namespace App_Forms_Farmacia
{
    public partial class FrmLogin : Form
    {
        #region ATRIBUTOS
        FrmMenuPrincipal menuPrincipal;
        List<Usuarios> listaUsuarios;
        Database db = new Database();
        String query;
        DataSet ds;
        FrmFarmaceutico frmFarmaceutico;
        FrmMenuClientes frmMenuClientes;
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor que me permite crear una nueva instancia del FrmLogin,
        /// a su vez me permite instanciar al FrmMenuPrincipal y a los usuarios.
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
            listaUsuarios = new List<Usuarios>();

            #region USUARIOS
            Usuarios user1 = new Usuarios("Rocio","123");
            Usuarios user2 = new Usuarios("Paula", "123");
            Usuarios user3 = new Usuarios("Lucas", "123");
            listaUsuarios.Add(user1);
            listaUsuarios.Add(user2);
            listaUsuarios.Add(user3);
            #endregion
        }
        #endregion

        #region BOTONES DEL FORM
        /// <summary>
        /// Me permite cerrar la aplicacion al presionar el boton con la 'X'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Al presionar el boton Refrescar me permite eliminar el contenido
        /// escrito dentro de los textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.txtUsername.Clear();
            this.txtPassword.Clear();
        }

        /// <summary>
        /// Al presionar el boton '?' le mostrara un MessageBox al usuario 
        /// sobre que se basa el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se deberá de introducir usuario y contraseña correctos para poder ingresar a la aplicación.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Si el usuario es correcto me permite ingresar a la aplicación.
        /// La primera vez que se abra si no hay Administradores dentro de la base de datos
        /// se podrá loguear como root y root para luego crear nuevos Administradores.
        /// Dependiendo de el usuario que se loguee se abrira un formulario para el
        /// Administrador, Farmacéutico o Cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        { 
            query = "select * from users";//Todos los usuarios
            ds = db.obtenerData(query);
            if (ds.Tables[0].Rows.Count==0)
            {
                if (txtUsername.Text=="root" && txtPassword.Text=="root")
                {
                    menuPrincipal = new FrmMenuPrincipal(this.txtUsername.Text);
                    this.menuPrincipal.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from users where username = '"+this.txtUsername.Text+"' and pass = '"+txtPassword.Text+"'";
                ds = db.obtenerData(query);
                if (ds.Tables[0].Rows.Count !=0)//Si coincide...
                {
                    String rol = ds.Tables[0].Rows[0][1].ToString();//Obtengo el rol del usuario
                    if (rol =="Administrador")
                    {
                        menuPrincipal = new FrmMenuPrincipal(this.txtUsername.Text);
                        this.menuPrincipal.Show();
                        this.Hide();
                    }
                    else if(rol == "Farmacéutico")//Si el rol es farmacéutico abro su formulario
                    {
                        frmFarmaceutico = new FrmFarmaceutico(this.txtUsername.Text);
                        this.frmFarmaceutico.Show();
                        this.Hide();
                    }
                    else if (rol == "Cliente")
                    {
                        frmMenuClientes = new FrmMenuClientes(this.txtUsername.Text);
                        this.frmMenuClientes.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

            //Usuarios UsuarioNuevo = new Usuarios(txtUsername.Text,txtPassword.Text);
            //if (Usuarios.ConfirmarUsuario(listaUsuarios,UsuarioNuevo))
            //{
            //    menuPrincipal = new FrmMenuPrincipal(txtUsername.Text);
            //    this.menuPrincipal.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Usuario o contraseña incorrectos, reintente.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //}
        }

        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
