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
    public partial class FrmPanelInformacion : Form
    {
        #region ATRIBUTOS
        FrmMenuPrincipal menuPrincipal;
        string usuario;
        Database db = new Database();
        String query;
        DataSet ds = new DataSet();
        #endregion

        #region CONSTRUCTOR
        public FrmPanelInformacion(string user)
        {
            InitializeComponent();
            usuario = user;
        }
        #endregion

        #region BOTONES
        /// <summary>
        /// Una vez presionada la 'X' se dejara de mostrar el panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExitPanel_Click(object sender, EventArgs e)
        {
            menuPrincipal = new FrmMenuPrincipal(usuario);
            this.Hide();
        }

        /// <summary>
        /// Imprime un mensaje de ayuda para el usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se muestra en pantalla lo que puede realizar cada perfil y la cantidad que hay de cada uno de estos. Para cerrarlo o ir a otra opcion del menu se debe de presionar el botón con la 'X'.","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        /// <summary>
        /// Al presionar el boton de Syn se actualizaran la cantidad de 
        /// usuarios y sus roles correspondientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSync_Click(object sender, EventArgs e)
        {
            FrmPanelInformacion_Load(this,null);//LLamo nuevamente al evento LOAD.
        }
        #endregion

        #region METODOS - EVENTOS
        /// <summary>
        /// Me traigo de la base de datos la cantidad que hay de cada rol.
        /// Llamo a un metodo para que lo setee.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPanelInformacion_Load(object sender, EventArgs e)
        {
            query = "select count(userRole) from users where userRole = 'Administrador'"; //count es un metodo en sql
            ds = db.obtenerData(query);//Devuelve valores y los seteamos al label
            this.actualizarLabel(ds,labelNrAdministradores);

            query = "select count(userRole) from users where userRole = 'Farmacéutico'";
            ds = db.obtenerData(query);
            this.actualizarLabel(ds,labelNroFarmaceuticos);

            query = "select count(userRole) from users where userRole = 'Cliente'";
            ds = db.obtenerData(query);
            this.actualizarLabel(ds, labelNroClientes);
        }

        /// <summary>
        /// Metodo que se fija cuantos userRole hay,
        /// si no los hay settea el lbl a 0.
        /// </summary>
        /// <param name="dataSet"></param>
        /// <param name="lbl"></param>
        private void actualizarLabel(DataSet dataSet,Label lbl)
        {
            if (dataSet.Tables[0].Rows.Count != 0)
            {
                lbl.Text = dataSet.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }
        #endregion

    }
}
