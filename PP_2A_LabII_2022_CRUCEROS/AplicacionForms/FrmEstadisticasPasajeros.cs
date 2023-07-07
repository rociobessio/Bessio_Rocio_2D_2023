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
    public partial class FrmEstadisticasPasajeros : FrmPadreEstadisticas
    {
        #region ATRIBUTOS DEL FORM
        List<Viaje> listaViajes;
        DataGridViewRow auxFilaDgv;
        int aux;
        #endregion

        #region CONSTRUCTORES DEL FORM
        /// <summary>
        /// Constructor por defecto del formulario.
        /// </summary>
        public FrmEstadisticasPasajeros()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor parametrizado que recibe la lista de viajes.
        /// </summary>
        /// <param name="listaViajes"></param>
        public FrmEstadisticasPasajeros(List<Viaje> listaViajes) : this()
        {
            this.listaViajes = listaViajes;
        }
        #endregion

        #region METODOS DEL FORM
        /// <summary>
        /// 1. Primero se pone el titulo y los encabezados correspondientes.
        /// 2. Primero recorre la lista de viajes y luego la de pasajeros,
        ///    Se verifica si el pasajero se encuentra dentro del diccionario.
        ///    Si lo encuentra aumenta la cantidad de viajes que realizo, si no
        ///    se agrega al diccionario.
        /// 3. Imprime los valores del diccionario en el datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEstadisticasPasajeros_Load(object sender, EventArgs e)
        {
            //1
            this.labeltitulo.Text = "ESTADÍSTICAS DE PASAJEROS";
            this.ColumnaNombre.HeaderText = "PASAJEROS";
            this.ColumnaValor.HeaderText = "CANTIDAD DE VIAJES REALIZADOS";

            Dictionary<string, int> diccionario = new();

            //2
            foreach (Viaje viaje in this.listaViajes)
            {
                foreach (Pasajero pasajero in viaje.ListaPasajeros)
                {
                    if (diccionario.ContainsKey(pasajero.NombreCompleto))
                    {
                        diccionario.TryGetValue(pasajero.NombreCompleto, out aux);
                        diccionario[pasajero.NombreCompleto] = aux + 1;
                    }
                    else
                    {
                        diccionario.Add(pasajero.NombreCompleto, 1);
                    }
                }
            }
            //3
            foreach (KeyValuePair<string,int> dicc in diccionario)
            {
                this.auxFilaDgv = new();
                this.auxFilaDgv.CreateCells(this.dgv);

                this.auxFilaDgv.Cells[0].Value = dicc.Key;
                this.auxFilaDgv.Cells[1].Value = $"{dicc.Value} viajes.";

                this.dgv.Rows.Add(this.auxFilaDgv);
            }
        }
        #endregion
         
    }
}
