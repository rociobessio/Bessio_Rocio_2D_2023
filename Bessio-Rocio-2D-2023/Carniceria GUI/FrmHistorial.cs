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
        private Vendedor vendedorForm;
        private Cliente clienteForm;
        DataTable _dataTable;
        DataRow auxFilaProduc;
        private List<Carrito> historial;

        public FrmHistorial()
        {
            InitializeComponent();
            this.Text = "Historial de compras";
            this.StartPosition = FormStartPosition.CenterScreen;
            _dataTable = new DataTable();
        }

        public FrmHistorial(Cliente cliente)
            : this()
        {
            this.cbFiltrarPorUsuario.Visible = false;
            this.lblUsuario.Text = "";
            this.BackColor = Color.DarkKhaki;
            clienteForm = cliente; 
        }

        public FrmHistorial(Vendedor vendedor)
            : this()
        {
            this.BackColor = Color.MediumPurple;

            //-->Cargo combo-box de los emails de usuarios
            foreach (Cliente cliente in this.vendedorForm.ListaClientes)
            {
                this.cbFiltrarPorUsuario.Items.Add(cliente.Usuario.Email);
            }
            vendedorForm = vendedor;
        }

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

                for (int i = 0; i < carrito.Productos.Count; i++)
                {
                    auxFilaProduc[0] = $"{carrito.Productos[i].Tipo.ToString().Replace("_", " ")}";//-->Muestro el codigo para luego seleccionarlo
                    auxFilaProduc[1] = $"{carrito.Productos[i].Corte.ToString().Replace("_", " ")}";
                    auxFilaProduc[2] = $"{carrito.Productos[i].Categoria.ToString().Replace("_", " ")}";
                    auxFilaProduc[3] = $"{carrito.Productos[i].Peso.ToString().Replace("_", " ")}";
                    auxFilaProduc[4] = $"{carrito.Productos[i].PrecioCompraCliente}";
                }

                _dataTable.Rows.Add(auxFilaProduc);//-->Añado las Filas
            }
            this.dataGridViewProductos.DataSource = _dataTable;//-->Al dataGrid le paso la lista
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            #region COLUMNAS DATAGRID
            this._dataTable.Columns.Add("Tipo");
            this._dataTable.Columns.Add("Corte");
            this._dataTable.Columns.Add("Categoría bovina");
            this._dataTable.Columns.Add("Peso");
            this._dataTable.Columns.Add("Precio compra"); 

            this.CargarProductosDataGrid();//-->Cargo los productos disponibles en el datagrid
            #endregion
        }
    }
}
