using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Forms_Farmacia.Clientes
{
    public partial class FrmVerTurnos : Form
    {
        #region ATRIBUTOS
        string user;
        String query;
        Database db = new Database();
        string idTurno;
        #endregion

        #region CONSTRUCTOR
        public FrmVerTurnos(string usuario)
        {
            InitializeComponent();
            user = usuario;
        }
        #endregion

        #region BOTONES
        /// <summary>
        /// Me permite cerrar este formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExitPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Boton de ayuda para el usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El usuario podrá visualizar sus turnos y cancelar el que quiera. Para cerrarlo o ir a otra opcion del menu se debe de presionar el botón con la 'X'.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Me permite cancelar un turno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar este turno?","WARNING",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                query = "delete from cliente1 where id = '"+idTurno+"'";
                db.setData(query,"Turno cancelado correctamente.");
                this.FrmVerTurnos_Load(this,null);
            }
        }
        #endregion

        #region METODOS - EVENTOS
        /// <summary>
        /// Cargo los turnos desde la base filtrando por el usuario registrado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVerTurnos_Load(object sender, EventArgs e)
        {
            query = "select * from cliente1 where username = '"+user+"'";
            this.setDatagrid(query);
        }

        /// <summary>
        /// Reutilizo codigo y le paso la query.
        /// </summary>
        /// <param name="query"></param>
        private void setDatagrid(String query)
        {
            DataSet ds = db.obtenerData(query);//obtengo la data
            dataGridViewTurnos.DataSource = ds.Tables[0];//Le paso la data al datagrid
        }

        /// <summary>
        /// Al ir escribiendo los caracteres en el texbox me va
        /// buscando aquellos turnos con la especialidad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMedicina_TextChanged(object sender, EventArgs e)
        {
            query = "select * from cliente1 where username = '"+user+"' and especialidadMedico like '" + this.txtEspecialidad.Text + "%'";
            this.setDatagrid(query);
        }

        /// <summary>
        /// Obtengo la id del turno en aquella casilla que presione.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idTurno = this.dataGridViewTurnos.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch { }
        }

        #endregion


    }
}
