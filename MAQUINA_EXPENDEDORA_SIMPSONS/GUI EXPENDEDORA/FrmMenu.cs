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
    public partial class FrmMenu : Form
    {
        #region ATRIBUTOS
        FrmExpendedora frmExpendedora;
        FrmBuffet frmBuffet;
        #endregion

        public FrmMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.Text = "Menu de Opcion Simpsonita";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        /// <summary>
        /// Me permite abrir el form de la maquina expendedora
        /// y cerrar este.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaquinaExpendedora_Click(object sender, EventArgs e)
        {
            frmExpendedora = new FrmExpendedora();
            frmExpendedora.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBuffet = new FrmBuffet();
            frmBuffet.Show();
            this.Hide();
        }
    }
}
