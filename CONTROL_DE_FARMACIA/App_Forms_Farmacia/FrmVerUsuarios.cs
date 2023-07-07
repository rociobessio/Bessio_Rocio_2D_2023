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
    public partial class FrmVerUsuarios : Form
    {
        #region ATRIBUTOS
        FrmMenuPrincipal menuPrincipal;
        string username;
        String query;
        Database db = new Database();
        string auxUser;
        #endregion

        #region CONSTRUCTOR
        public FrmVerUsuarios(string user)
        {
            InitializeComponent();
            username = user;
        }
        #endregion 

        #region BOTONES
        /// <summary>
        /// Al presionar la 'X' se cerrará este formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExitPanel_Click(object sender, EventArgs e)
        {
            menuPrincipal = new FrmMenuPrincipal(username);
            menuPrincipal.Show();
            this.Hide();
        }

        /// <summary>
        /// Imprime un mensaje de ayuda para el usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El administrador podra visualizar a los usuarios y si lo desea eliminarlos. Para cerrarlo o ir a otra opcion del menu se debe de presionar el botón con la 'X'.", "INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        /// <summary>
        /// Primero le pregunta al usuario si realmente desea eliminar al usuario.
        /// Luego se fija que no se intente autoeliminar.
        /// Si no es el mismo usuario lo elimina de la base de datos y
        /// vuelve a llamar al evento load para que vuelva a mostrar el datagridview actualizado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea realmente eliminar al usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (username != auxUser)//No se intenta autoeliminar
                {
                    query = "delete from users where username = '" + auxUser + "'";
                    db.setData(query, "Usuario eliminado.");
                    FrmVerUsuarios_Load(this, null);
                }
                else//Se intenta autoeliminar
                {
                    MessageBox.Show("No se puede autoeliminar al mismo usuario.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion

        #region EVENTOS - METODOS
        /// <summary>
        /// Evento que al ir escribiendo dentro del textbox de usuario me va mostrando
        /// los que comiencen con esa letra y asi sucesivamente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username like '"+txtUsuario.Text+"%'";//Me va mostrando los que comienzan con la letra que escribo
            DataSet ds = db.obtenerData(query);
            this.dataGridViewUsuarios.DataSource = ds.Tables[0];
        }

        /// <summary>
        /// El load lo que hace es directamente visualizarme todos los usuarios de la base de datos
        /// dentro del datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVerUsuarios_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            DataSet ds = db.obtenerData(query);
            this.dataGridViewUsuarios.DataSource = ds.Tables[0];
        }

        /// <summary>
        /// Obtengo el user mediante el evento CellClick para poder eliminarlo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                auxUser = dataGridViewUsuarios.Rows[e.RowIndex].Cells[6].Value.ToString();//Obtengo el nombre de usuario que esta en la celda 6
            }
            catch
            {

            }
        }
        #endregion


    }
}
