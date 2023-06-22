using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Carniceria_GUI
{
    public partial class FrmVisualizacionProductos : Form
    {
        #region ATRIBUTOS FORM  
        DataTable _dataTable;
        DataRow auxFilaProduc;
        private List<Carrito> historial;
        private JSON json;
        private XML xML;
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor del formulario.
        /// </summary>
        public FrmVisualizacionProductos()
        {
            InitializeComponent();
            this.Text = "Visualización Productos (Deserialización)";
            this.StartPosition = FormStartPosition.CenterScreen;
            _dataTable = new DataTable();
            this.MaximizeBox = false;
            this.json = new JSON();
            this.xML = new XML();

            #region INSTANCIO AYUDA
            StringBuilder textoAyuda = new StringBuilder();
            textoAyuda.AppendLine("El Vendedor podrá elegir en que formato ver los carritos guardados.");
            textoAyuda.AppendLine("El Carrito ingresado como cliente esta en XML.");
            textoAyuda.AppendLine("Y el Carrito ingresado como Vendedor esta en JSON.");
            FrmLogin.MostrarAyuda(this.lblPrintHelp, textoAyuda.ToString());
            #endregion
        }

        /// <summary>
        /// Sobrecarga del constructor del form,
        /// me permite cargar el atributo historial del frm
        /// y recibir el vendedor.
        /// </summary>
        /// <param name="vendedor"></param>
        public FrmVisualizacionProductos(Usuario vendedor)
            : this()
        {
            this.BackColor = Color.MediumPurple;
            this.lblVendedorEmail.Text = vendedor;
            this.lblHoraIngreso.Text = vendedor.HoraIngreso.ToShortTimeString();
        }
        #endregion 

        #region METODOS/EVENTOS FORM
        /// <summary>
        /// Metodo privado que me permite cargar los productos de la lista,
        /// la recorre, uso auxiliares de las filas para poder imprimir los atributos
        /// en el datagrid.
        /// 
        /// Es una forma de que me muestre lo que quiero, ya que sino directamente
        /// al datagrid se le puede pasar la lista y mostrara gracias a las propiedades
        /// de la clase.
        /// </summary>
        private void CargarProductosDataGridCarritos()
        {
            _dataTable.Rows.Clear();

            foreach (Carrito carrito in this.historial)
            {
                auxFilaProduc = _dataTable.NewRow(); 
                auxFilaProduc[0] = $"{carrito.UsuarioCompra}";
                auxFilaProduc[1] = $"{carrito.FechaCompra.ToShortDateString()}";
                if (carrito.ConTarjeta)
                {
                    auxFilaProduc[2] = "Si";
                }
                else
                    auxFilaProduc[2] = "No";

                auxFilaProduc[3] = $"${carrito.PrecioTotal:f}";
                 
                _dataTable.Rows.Add(auxFilaProduc);//-->Añado las Filas
            }

            this.dataGridViewCarritos.DataSource = _dataTable;//-->Al dataGrid le paso la lista
        }

        /// <summary>
        /// El evento load del formulario me permite crear las columnas del datagridview
        /// y cargarlo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            #region COLUMNAS  
            this._dataTable.Columns.Add("Comprador");
            this._dataTable.Columns.Add("Fecha De Compra");
            this._dataTable.Columns.Add("Con Tarjeta");
            this._dataTable.Columns.Add("Total de la compra");
            #endregion 
        }
        #endregion

        /// <summary>
        /// Al presionar el boton me permite
        /// visualizar aquellos Carritos guardados
        /// en formato JSON.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerHTML_Click(object sender, EventArgs e)
        {
            this.historial = json.Deserializar();//-->Deserializo la lista JSON
            if (historial.Count <= 0)
            {
                MessageBox.Show("No hay Carritos para visualizar en fomato JSON.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                this.CargarProductosDataGridCarritos();//-->Cargo los productos en el datagrid 
        }

        /// <summary>
        /// Me permite ver aquellos carritos
        /// Deserializando en formato XML.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerXML_Click(object sender, EventArgs e)
        {
            this.historial = xML.Deserializar();//-->Deserializo en XML
            if (this.historial.Count <= 0)
            {
                MessageBox.Show("No hay Carritos para visualizar en fomato XML.", "Información",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                this.CargarProductosDataGridCarritos();//-->Cargo los productos
        }

        private void dataGridViewCarritos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
