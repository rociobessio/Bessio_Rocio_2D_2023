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

namespace AplicacionForms
{
    public partial class FrmEstadisticasCruceros : FrmPadreEstadisticas
    {
        #region ATRIBUTOS DEL FORMULARIO
        List<Viaje> listaViajes;
        DataGridViewRow auxFilaDgv;
        int aux;
        #endregion

        #region CONSTRUCTORES DEL FORM
        /// <summary>
        /// Constructor por defecto del formulario.
        /// </summary>
        public FrmEstadisticasCruceros()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor paramtrizado del formulario, recibe la lista de viajes.
        /// </summary>
        /// <param name="listaViajes"></param>
        public FrmEstadisticasCruceros(List<Viaje> listaViajes) : this()
        {
            this.listaViajes = listaViajes;
        }
        #endregion

        #region METODOS DEL FORM
        /// <summary>
        /// 1. Setea los titulos y encabezados del datagrid.
        /// 2. Recorre la lista de viajes y comprueba si el crucero ya esta
        ///    dentro del diccionario. SI esta aumenta la cantidad de horas que viajo
        ///    sino las agrega al diccionario.
        /// 3. Imprime los valores del diccionario dentro del datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEstadisticasCruceros_Load(object sender, EventArgs e)
        {
            //1
            this.labeltitulo.Text = "ESTADÍSTICAS DE CRUCEROS";
            this.ColumnaNombre.HeaderText = "CRUCEROS";
            this.ColumnaValor.HeaderText = "HORAS DE VIAJES TOTALES";

            Dictionary<string,int> diccionario = new ();

            //2
            foreach (Viaje viaje in this.listaViajes)
            {
                if (diccionario.ContainsKey(viaje.Crucero.Nombre))
                {
                    diccionario.TryGetValue(viaje.Crucero.Nombre, out aux);
                    diccionario[viaje.Crucero.Nombre] = aux + viaje.DuracionDelViaje;
                }
                else
                {
                    diccionario.Add(viaje.Crucero.Nombre, viaje.DuracionDelViaje);
                }
            }

            //3
            foreach (KeyValuePair<string,int> dicc in diccionario)
            {
                this.auxFilaDgv = new();
                this.auxFilaDgv.CreateCells(this.dgv);

                this.auxFilaDgv.Cells[0].Value = dicc.Key;
                this.auxFilaDgv.Cells[1].Value = $"{dicc.Value} hs.";

                this.dgv.Rows.Add(this.auxFilaDgv);
            }
        } 
        #endregion

    }
}
