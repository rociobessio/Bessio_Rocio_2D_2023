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
    public partial class FrmModMedicina : Form
    {
        #region ATRIBUTOS
        String query;
        Database db = new Database();
        Int64 cantMedicinaNueva;

        #endregion

        #region CONSTRUCTOR
        public FrmModMedicina()
        {
            InitializeComponent();
        }
        #endregion

        #region BOTONES
        /// <summary>
        /// Al presionar la 'X' el usuario podra volver al menu principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExitPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Le imprime al usuario un mensaje de ayuda para que sepa 
        /// que hacer dentro del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El usuario podrá modificar la medicina que quiera. Para cerrarlo o ir a otra opcion del menu se debe de presionar el botón con la 'X'.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Busca en la base de datos si existe la id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtIDMedicina.Text !="")
            {
                query = "select * from farmaceutico where mid = '"+this.txtIDMedicina.Text+"'";
                DataSet ds = db.obtenerData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    this.txtNombreMedicina.Text = ds.Tables[0].Rows[0][2].ToString();
                    this.txtNumMedicina.Text = ds.Tables[0].Rows[0][3].ToString(); 
                    this.dtpFechaElaboracion.Text = ds.Tables[0].Rows[0][4].ToString();
                    this.dtpFechaVencimiento.Text = ds.Tables[0].Rows[0][5].ToString();
                    this.txtCantMedicina.Text = ds.Tables[0].Rows[0][6].ToString();
                    this.txtPrecioPorUnida.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró una medicina con ID = "+this.txtIDMedicina.Text+".","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                limpiarAll();
            }
        }

        /// <summary>
        /// Me permite limpiar los textbox y los dtp.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.limpiarAll();
        }

        /// <summary>
        /// Me permite modificar una medicina.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string mname = this.txtNombreMedicina.Text;
            string mnumber = this.txtNumMedicina.Text;
            string mElaboracion = this.dtpFechaElaboracion.Text;
            string mVencimiento = this.dtpFechaVencimiento.Text;
            Int64 cantidad = Int64.Parse(this.txtCantMedicina.Text);
            Int64 addCantidad = Int64.Parse(this.txtAddDisponible.Text);
            Int64 porUnidad = Int64.Parse(this.txtPrecioPorUnida.Text);
            cantMedicinaNueva = cantidad + addCantidad;

            query = "update farmaceutico set mname = '" + mname+ "', mnumero = '" + mnumber+ "', mElaboracion = '" + mElaboracion+ "', mVencimiento = '" + mVencimiento+ "', cantidad = " + cantMedicinaNueva+ ", porUnidad = " + porUnidad+ " where mid = '" + this.txtIDMedicina.Text + "'";
            db.setData(query,"Medicina modificada con exitó.");
        }
        #endregion

        #region METODOS - EVENTOS
        private void limpiarAll()
        {
            this.txtAddDisponible.Clear();
            this.txtCantMedicina.Clear();
            this.txtIDMedicina.Clear();
            this.txtNombreMedicina.Clear();
            this.txtNumMedicina.Clear();
            this.txtPrecioPorUnida.Clear();
            this.dtpFechaElaboracion.ResetText();
            this.dtpFechaVencimiento.ResetText();
            if (this.txtAddDisponible.Text != "0")
            {
                this.txtAddDisponible.Text = "0";
            }
            else
            {
                this.txtAddDisponible.Text = "0";
            }
        }

        /// <summary>
        /// Seteo los datetimepicker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmModMedicina_Load(object sender, EventArgs e)
        {
            this.dtpFechaElaboracion.MinDate = DateTime.Today.AddYears(-9);
            this.dtpFechaElaboracion.MaxDate = DateTime.Today;
            this.dtpFechaVencimiento.MinDate = DateTime.Today.AddYears(-9);
            this.dtpFechaVencimiento.MaxDate = DateTime.Today.AddYears(5);
        }
        #endregion


    }
}
