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
    public partial class FrmEstadisticasDestinos : FrmPadreEstadisticas
    {
        #region ATRIBUTOS DEL FORM
        List<Viaje> listaViajes;
        DataGridViewRow auxFilaDgv;
        double acumulador;
        double aux;
        #endregion

        #region CONSTRUCTORES DEL FORM
        /// <summary>
        /// Constructor por defecto del form
        /// </summary>
        public FrmEstadisticasDestinos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor parametrizado del frm y setea la lista de viajes.
        /// </summary>
        /// <param name="listaViajes"></param>
        public FrmEstadisticasDestinos(List<Viaje> listaViajes) : this()
        {
            this.listaViajes = listaViajes;
        }
        #endregion

        #region METODOS DEL FORM
        /// <summary>
        /// 1. Setea el titulo y los nombres de las filas del datagridview.
        /// 2. Recorre la lista de viajes y calcula la cantidad total de 
        ///    pasajes vendidos en dicho viaje. Luego verifica si el Destino 
        ///    se encuentra dentro del diccionario.Si se encuentra aumenta 
        ///    la facturacion total. Si no se encuentra lo agrega al diccionario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEstadisticasDestinos_Load(object sender, EventArgs e)
        {
            //1
            this.labeltitulo.Text = "ESTADÍSTICAS DE DESTINOS";
            this.ColumnaNombre.HeaderText = "DESTINOS VISITADOS";
            this.ColumnaValor.HeaderText = "FACTURACIÓN TOTAL";

            Dictionary<string, double> diccionario = new();

            //2
            foreach (Viaje viaje in this.listaViajes)
            {
                acumulador = 0;
                acumulador = viaje.CostoPasajeTurista * viaje.CantCamarotesTurista + viaje.CostoPasajePremium * viaje.CantCamarotesPremium;
                if (diccionario.ContainsKey(viaje.Destino))
                {
                    diccionario.TryGetValue(viaje.Destino, out aux);
                    diccionario[viaje.Destino] = aux + acumulador;
                }
                else
                {
                    diccionario.Add(viaje.Destino, acumulador);
                }
            }

            //3 
            foreach (KeyValuePair<string, double> dicc in diccionario)
            {
                this.auxFilaDgv = new();
                this.auxFilaDgv.CreateCells(this.dgv);

                this.auxFilaDgv.Cells[0].Value = dicc.Key;
                this.auxFilaDgv.Cells[1].Value = $"{dicc.Value:c}";

                this.dgv.Rows.Add(this.auxFilaDgv);
            } 
        }
        #endregion
    }
}
