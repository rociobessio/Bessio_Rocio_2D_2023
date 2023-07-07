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
    public partial class FrmAddMedicina : Form
    {
        #region ATRIBUTOS
        String query;
        Database db = new Database();
        #endregion

        #region CONSTRUCTOR
        public FrmAddMedicina(string user)
        {
            InitializeComponent();
        }
        #endregion

        #region BOTONES
        /// <summary>
        /// Al presionar la 'X' el usuario podra volver a interactuar
        /// con el menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExitPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Al presionar el boton '?' se le mostrara un msj al usuario
        /// para que sepa que hacer con el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El farmacéutico podra añadir nuevas medicinas al inventario. Para cerrarlo o ir a otra opcion del menu se debe de presionar el botón con la 'X'.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Me permite añadir medicina a la base de datos.
        /// Chequea que esten los textbox con informacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (this.txtNombreMedicina.Text != "" && this.txtIDMedicina.Text != "" &&
                this.txtCantMedicina.Text != "" && this.txtNumMedicina.Text != "" && this.txtPrecioPorUnida.Text != "")
            {
                string mid = this.txtIDMedicina.Text;
                string mname = this.txtNombreMedicina.Text;
                string mnumero = this.txtNumMedicina.Text;
                string mElaboracion = this.dtpFechaElaboracion.Text;
                string mVencimiento = this.dtpFechaVencimiento.Text;
                Int64 cantidad = Int64.Parse(this.txtCantMedicina.Text);
                Int64 porUnidad = Int64.Parse(this.txtPrecioPorUnida.Text);

                query = "insert into farmaceutico(mid,mname,mnumero,mElaboracion,mVencimiento,cantidad,porUnidad) values ('" + mid + "', '" + mname + "', '" + mnumero + "', '" + mElaboracion + "', '" + mVencimiento + "', " + cantidad + ", " + porUnidad + ")";
                db.setData(query, "Medicina guardada correctamente.");
            }
            else
            {
                MessageBox.Show("Complete toda la información.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Me permite limpiar los textbox y datetimepicker
        /// del form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.dtpFechaElaboracion.ResetText();
            this.dtpFechaVencimiento.ResetText();
            this.txtCantMedicina.Clear();
            this.txtIDMedicina.Clear();
            this.txtNombreMedicina.Clear();
            this.txtNumMedicina.Clear();
            this.txtPrecioPorUnida.Clear();
        }

        #endregion

        /// <summary>
        /// Seteo los datetimepicker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAddMedicina_Load(object sender, EventArgs e)
        {
            this.dtpFechaElaboracion.MinDate = DateTime.Today.AddYears(-9);
            this.dtpFechaElaboracion.MaxDate = DateTime.Today;
            this.dtpFechaVencimiento.MinDate = DateTime.Today.AddYears(-9);
            this.dtpFechaVencimiento.MaxDate = DateTime.Today.AddYears(5);
        }
    }
}
