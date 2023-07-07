using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Forms_Farmacia.Farmaceutico
{
    public partial class FrmVerMedicinas : Form
    {
        #region ATRIBUTOS
        String query;
        Database db = new Database();
        String idMedicina;
        #endregion

        #region CONSTRUCTOR
        public FrmVerMedicinas()
        {
            InitializeComponent();
        }
        #endregion

        #region BOTONES
        /// <summary>
        /// Al presionar el boton se cerrara este formulario
        /// para que el usuario pueda seguir utilizando la aplicacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExitPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Al presionarlo le imprimar ene pantalla un MessageBox al usuario
        /// para que sepa que se hace dentro del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El usuario podrá seleccionar una medicina de la grilla y eliminarla del inventario. Para cerrarlo o ir a otra opcion del menu se debe de presionar el botón con la 'X'.", "INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        
        /// <summary>
        /// Al presionar en una celda me permite eliminar una medicina.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar esa medicina?","WARNING",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                query = "delete from  farmaceutico where mid = '"+idMedicina+"'";
                db.setData(query,"Medicina eliminada del sistema.");
                this.FrmVerMedicinas_Load(this,null);//Vuelvo a cargar el datagrid con el load
            }
        }
        #endregion

        #region EVENTOS - METODOS
        /// <summary>
        /// Al iniciar el form se carga la data en el datagrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVerMedicinas_Load(object sender, EventArgs e)
        {
            query = "select * from farmaceutico";
            this.setDatagrid(query);
        }

        /// <summary>
        /// Al ir ingresando las letras me va mostrando la medicina correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMedicina_TextChanged(object sender, EventArgs e)
        {
            query = "select * from farmaceutico where mname like '"+this.txtMedicina.Text+ "%'";
            this.setDatagrid(query);
        }

        /// <summary>
        /// Reutilizo codigo y le paso la query.
        /// </summary>
        /// <param name="query"></param>
        private void setDatagrid(String query)
        {
            DataSet ds = db.obtenerData(query);//obtengo la data
            dataGridViewMedicinas.DataSource = ds.Tables[0];//Le paso la data al datagrid
        }

        private void dataGridViewMedicinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idMedicina =this.dataGridViewMedicinas.Rows[e.RowIndex].Cells[1].Value.ToString();//Obtengo la ID de la primer columna
            }
            catch
            {

            }

        }

        #endregion 
    }
}
