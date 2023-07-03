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
using Excepciones;

namespace Carniceria_GUI
{
    public partial class FrmCopiaSeguridad : Form
    {
        #region ATRIBUTOS
        private List<Producto> copiaProductos;
        private DataTable dataTable;
        private DataRow auxFilaProduc;
        #endregion

        #region CONSTRUCTORES
        public FrmCopiaSeguridad()
        {
            InitializeComponent();
            this.Text = "Copia de seguridad";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.dataTable = new DataTable(); 

            #region INSTANCIO AYUDA
            StringBuilder textoAyuda = new StringBuilder();
            textoAyuda.AppendLine("Podrá ver la última copia de seguridad (XML).");
            FrmLogin.MostrarAyuda(this.lblPrintHelp, textoAyuda.ToString());
            #endregion
        }

        public FrmCopiaSeguridad(Usuario vendedor)
            : this()
        {
            this.BackColor = Color.MediumPurple;
            this.lblVendedorEmail.Text = vendedor;
            this.lblHoraIngreso.Text = vendedor.HoraIngreso.ToShortTimeString();
            this.copiaProductos = new List<Producto>();

            #region COLUMNAS DATATABLE
            this.dataTable.Columns.Add("Código");
            this.dataTable.Columns.Add("Tipo");
            this.dataTable.Columns.Add("Corte");
            this.dataTable.Columns.Add("Categoría bovina");
            this.dataTable.Columns.Add("Total de Kilos en Stock");
            this.dataTable.Columns.Add("Precio C/ Unidad");
            this.dataTable.Columns.Add("Vencimiento");
            this.dataTable.Columns.Add("Proveedor");
            this.dataTable.Columns.Add("Precio compra Frigorifico");
            #endregion
        }
        #endregion

        #region EVENTOS Y METODOS
        private void FrmCopiaSeguridad_Load(object sender, EventArgs e)
        {
            try
            {
                this.copiaProductos = XML.TraerCopiaDeSeguridadXML();
                if (this.copiaProductos.Count <= 0)
                    throw new XMLException("Ocurrio un problema al intentar mostrar la copia de seguridad.");

                this.CargarProductosDataGrid(this.copiaProductos);
            }
            catch (XMLException ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show($"Ocurrio un problema al intentar mostrar la ultima copia de seguridad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Me permite cargar los productos al 
        /// datagridview.
        /// </summary>
        /// <param name="listaProductos"></param>
        private void CargarProductosDataGrid(List<Producto> listaProductos)
        {  
            dataTable.Rows.Clear();

            foreach (Producto producto in listaProductos)
            {
                auxFilaProduc = dataTable.NewRow();

                auxFilaProduc[0] = $"{producto.Codigo}";
                auxFilaProduc[1] = $"{producto.Tipo.ToString().Replace("_", " ")}";
                auxFilaProduc[2] = $"{producto.Corte.ToString().Replace("_", " ")}";
                auxFilaProduc[3] = $"{producto.Categoria.ToString().Replace("_", " ")}";
                auxFilaProduc[4] = $"{producto.Stock}kgs";
                auxFilaProduc[5] = $"${producto.PrecioCompraCliente:f}";
                auxFilaProduc[6] = $"{producto.Vencimiento.ToShortDateString()}";
                auxFilaProduc[7] = $"{producto.Proveedor}";
                auxFilaProduc[8] = $"${producto.PrecioVentaProveedor:f}";

                dataTable.Rows.Add(auxFilaProduc);//-->Añado las Filas
            }
            this.dataGridViewCopiaSeguridad.DataSource = dataTable;//-->Al dataGrid le paso la lista  
        }
        #endregion
    }
}
