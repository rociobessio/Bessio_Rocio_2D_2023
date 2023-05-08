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
    public partial class FrmHistorial : Form
    {
        #region ATRIBUTOS FORM  
        DataTable _dataTable;
        DataRow auxFilaProduc;
        private List<Carrito> historial;
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor del formulario.
        /// </summary>
        public FrmHistorial()
        {
            InitializeComponent();
            this.Text = "Historial de Ventas";
            this.StartPosition = FormStartPosition.CenterScreen;
            _dataTable = new DataTable();
            this.MaximizeBox = false;

            #region INSTANCIO AYUDA
            StringBuilder textoAyuda = new StringBuilder();
            textoAyuda.AppendLine("El vendedor podrá visualizar el historial de ventas a cargo suyo.");
            FrmLogin.MostrarAyuda(this.lblPrintHelp, textoAyuda.ToString());
            #endregion
        }

        /// <summary>
        /// Sobrecarga del constructor del form,
        /// me permite cargar el atributo historial del frm
        /// y recibir el vendedor.
        /// </summary>
        /// <param name="vendedor"></param>
        public FrmHistorial(Vendedor vendedor)
            : this()
        {
            this.BackColor = Color.MediumPurple;
            this.lblVendedorEmail.Text = vendedor;
            this.lblHoraIngreso.Text = vendedor.FechaIngreso.ToShortTimeString();
            historial = Vendedor.HistorialVentas;
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
        private void CargarProductosDataGrid()
        {
            _dataTable.Rows.Clear();

            foreach (Carrito carrito in this.historial)
            {
                auxFilaProduc = _dataTable.NewRow();
                auxFilaProduc[0] = $"{carrito.FechaCompra.ToShortDateString()}";
                for (int i = 0; i < carrito.Productos.Count; i++)
                {
                    auxFilaProduc[1] = $"{carrito.Productos[i].Tipo.ToString().Replace("_", " ")}";//-->Muestro el codigo para luego seleccionarlo
                    auxFilaProduc[2] = $"{carrito.Productos[i].Corte.ToString().Replace("_", " ")}";
                    auxFilaProduc[3] = $"{carrito.Productos[i].Categoria.ToString().Replace("_", " ")}";
                    auxFilaProduc[4] = $"{carrito.Productos[i].Peso.ToString().Replace("_", " ")}kgs.";
                    auxFilaProduc[5] = $"${carrito.Productos[i].PrecioCompraCliente:f}";
                }

                _dataTable.Rows.Add(auxFilaProduc);//-->Añado las Filas
            }
            this.dataGridViewProductos.DataSource = _dataTable;//-->Al dataGrid le paso la lista
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
            this._dataTable.Columns.Add("Fecha De Compra");
            this._dataTable.Columns.Add("Tipo");
            this._dataTable.Columns.Add("Corte");
            this._dataTable.Columns.Add("Categoría bovina");
            this._dataTable.Columns.Add("Kilos");
            this._dataTable.Columns.Add("Total");

            this.CargarProductosDataGrid();//-->Cargo los productos disponibles en el datagrid
            #endregion
        }
        #endregion
    }
}
