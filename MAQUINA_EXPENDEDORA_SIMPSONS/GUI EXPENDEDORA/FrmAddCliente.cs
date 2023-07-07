using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_C03_UNIDAD_06_GUI
{
    public partial class FrmAddCliente : Form
    {
        public FrmAddCliente()
        {
            InitializeComponent();
            this.Text = "Agregar Simpsonito";

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        /// <summary>
        /// Propiedad del form que me devuelve el nombre del textbox
        /// </summary>
        public string DevolverNombre { get { return this.tbNombreCliente.Text; } }

        /// <summary>
        /// Al presionarlo se cerrara este form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
