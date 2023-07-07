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
    public partial class FrmFechasMedicinas : Form
    {
        #region ATRIBUTOS
        String query;
        Database db = new Database();
        #endregion

        #region CONSTRUCTOR
        public FrmFechasMedicinas()
        {
            InitializeComponent();
        }
        #endregion

        #region BOTONES
        /// <summary>
        /// Al presionarlo le imprime al usuario un msj de ayuda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El usuario podrá ordenar las medicinas dependiendo de si estan vencidad o no. Para cerrarlo o ir a otra opcion del menu se debe de presionar el botón con la 'X'.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Al presionar la 'X' vuelve al menu principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExitPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        #endregion

        #region METODOS - EVENTOS
        /// <summary>
        /// Cuando se seleccione una opcion del combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFechasMedicinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbFechasMedicinas.SelectedIndex == 0)//Medicinas validas
            {
                query = "select * from farmaceutico where mVencimiento >= getDate()";//getDate es un metodo de SQL, cuadno el vencimiento sea mas que el dia de hoy
                this.dataGridSetValues(query,"MEDICINAS VALIDAS",Color.Black);
            }
            else if (this.cbFechasMedicinas.SelectedIndex == 1)
            {
                query = "select * from farmaceutico where mVencimiento <= getDate()";//getDate es un metodo de SQL, cuadno el vencimiento sea menor que el dia de hoy
                this.dataGridSetValues(query,"MEDICINAS VENCIDAS",Color.DarkRed);
            }
            else if (this.cbFechasMedicinas.SelectedIndex == 2)
            {
                query = "select * from farmaceutico";//getDate es un metodo de SQL, cuadno el vencimiento sea menor que el dia de hoy
                this.dataGridSetValues(query,"",Color.Aqua);
            }
        }

        private void FrmFechasMedicinas_Load(object sender, EventArgs e)
        {
            this.labelSet.Text = "";//Asi no aparece.
        }
        
        /// <summary>
        /// Setea los valores del datagrid, recibe la query, la string para el label
        /// y el color del label
        /// </summary>
        /// <param name="query"></param>
        /// <param name="label"></param>
        /// <param name="color"></param>
        private void dataGridSetValues(String query, string label,Color color)
        {
            DataSet ds = db.obtenerData(query);
            this.dataGridViewMedicinas.DataSource = ds.Tables[0];
            this.labelSet.Text = label;
            this.labelSet.ForeColor = color;
        }

        #endregion


    }
}
