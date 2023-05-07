using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carniceria_GUI
{
    public partial class FrmHeladera : Form
    {
        #region ATRIBUTOS DEL FORM 

        #region CARNE
        Producto carneSeleccionada;
        double peso;
        double precioCompraCliente;
        #endregion

        #region DATAGRIDVIEW
        DataTable tablaProductos;
        DataRow auxFilaProduc;
        int indexTablaProductos;
        int codigoProducto;
        #endregion

        //  bool terminoDeReponer;
        FrmVentaVendedor frmVentaVendedor;
        Vendedor vendedorForm;
        FrmHistorial frmHistorial;
        #endregion

        #region CONSTRUCTOR

        public FrmHeladera()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Reponer Stock";

            this.tablaProductos = new DataTable();//-->Instancio la dataTable.
            this.carneSeleccionada = new Producto();//-->Instancio par evitar nulls
        }
        public FrmHeladera(Vendedor vendedor)
            : this()
        {
            this.lblVendedorEmail.Text = vendedor;

            #region ASIGNACION VENDEDOR
            vendedorForm = vendedor;//-->Asigno el vendedor que recibo 
            #endregion

            #region PRINT AYUDA
            StringBuilder textoAyuda = new StringBuilder();
            textoAyuda.AppendLine("El vendedor podrá reponer el stock de un producto, cambiarle el precio y el tipo de corte, además podrá visualizarlos");
            textoAyuda.AppendLine("y al presionar el botón 'Vender' se abrirá un nuevo formulario para que le venda un producto a un cliente.");
            textoAyuda.AppendLine("Será capaz de ver el historial de ventas realizadas.");
            FrmLogin.MostrarAyuda(this.lblPrintHelp, textoAyuda.ToString());
            #endregion       
        }
        #endregion

        #region EVENTOS DEL FORM
        /// <summary>
        /// El evento load del form me permitirá añadir las columnas a la datatable.
        /// Cargar los combo-boxes y cargar el datagrid con los productos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmHeladera_Load(object sender, EventArgs e)
        {
            this.tablaProductos.Columns.Add("Código");
            this.tablaProductos.Columns.Add("Tipo");
            this.tablaProductos.Columns.Add("Corte");
            this.tablaProductos.Columns.Add("Categoría bovina");
            this.tablaProductos.Columns.Add("Total de Kilos en Stock");
            this.tablaProductos.Columns.Add("Precio C/ Unidad");
            this.tablaProductos.Columns.Add("Vencimiento");
            this.tablaProductos.Columns.Add("Proveedor");
            this.tablaProductos.Columns.Add("Precio compra Frigorifico");

            foreach (Tipo tipo in Enum.GetValues(typeof(Tipo)))
            {
                this.cbTipoDeCarneReponer.Items.Add(tipo);
            }

            foreach (CategoriaBovina categoria in Enum.GetValues(typeof(CategoriaBovina)))
            {
                this.cbTexturaCarne.Items.Add(categoria.ToString().Replace("_", " "));
            }

            this.dtpFechaVencimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaVencimiento.Format = DateTimePickerFormat.Custom;

            this.ManejoTextBoxes();//-->Por eso deshabilito los textboxes
            this.CargarProductosDataGrid();//-->Ponele que no quiero que me muestre los datos que quiero yo
                                           //  this.terminoDeReponer = true;
        }

        /// <summary>
        /// Me permite seleccionar un producto del datagrid para poder reponerlo.
        /// Unicamente me dejara editar su peso, lo cargo y se lo paso a una nueva variable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // this.terminoDeReponer = false;//-->Si selecciona una celda quiere decir que repone

            this.indexTablaProductos = e.RowIndex;//-->Obtengo el indice

            if (this.indexTablaProductos > -1)//-->Si es mayor a -1 obtengo el codigo, celda [0]
            {
                codigoProducto = int.Parse(this.dataGridViewProductos.Rows[indexTablaProductos].Cells[0].Value.ToString());//-->Obtengo el codigo
            }

            //Recorro la lista en busca de ese producto y lo muestro en los textboxes
            foreach (KeyValuePair<int, Producto> dic in this.vendedorForm.ListaProductos)
            {
                if (dic.Key == codigoProducto)
                {
                    this.txtPrecioVentaClientes.Text = dic.Value.PrecioCompraCliente.ToString();
                    this.txtPrecioCompraFrigorifico.Text = dic.Value.PrecioVentaProveedor.ToString();
                    this.txtProveedor.Text = dic.Value.Proveedor;
                    this.cbCorteCarne.Text = dic.Value.Corte.ToString();
                    this.cbTexturaCarne.Text = dic.Value.Categoria.ToString();
                    this.cbTipoDeCarneReponer.Text = dic.Value.Tipo.ToString();
                    this.dtpFechaVencimiento.Value = dic.Value.Vencimiento;

                    carneSeleccionada = dic.Value;//-->Guardo esa carne para realizar las modificaciones o calculos
                }
            }
        }

        /// <summary>
        /// Le preguntara al usuario si desea realmente cerrar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmHeladera_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        /// <summary>
        /// Al seleccionar un tipo de carne, se cambiara el tipo de corte y textura que
        /// se pueda seleccionar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbTipoDeCarneReponer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //-->Los dejo sino cada vez que cambie el indice se sumaran a los que ya estan
            this.cbCorteCarne.Items.Clear();
            this.cbTexturaCarne.Items.Clear();

            if (this.cbTipoDeCarneReponer.SelectedItem.ToString() == Tipo.Carne_Vacuna.ToString())
            {
                this.cbCorteCarne.Items.Add(Corte.Nalga);
                this.cbCorteCarne.Items.Add(Corte.Asado);
                this.cbCorteCarne.Items.Add(Corte.Bife_Angosto);
                this.cbCorteCarne.Items.Add(Corte.Lomo);
                this.cbCorteCarne.Items.Add(Corte.Vacio);
                this.cbCorteCarne.Items.Add(Corte.Matambre);
                this.cbCorteCarne.SelectedIndex = 0;//-->Selecciono el primero de esa opcion, si cambiase el Tipo me quedaria seleccionado el indice anterior

                this.cbTexturaCarne.Items.Add(CategoriaBovina.Novillito);
                this.cbTexturaCarne.Items.Add(CategoriaBovina.Ternero);
                this.cbTexturaCarne.Items.Add(CategoriaBovina.Novillo);
                this.cbTexturaCarne.SelectedIndex = 0;
                this.cbTexturaCarne.Enabled = true;
            }
            else if (this.cbTipoDeCarneReponer.SelectedItem.ToString() == Tipo.Pollo.ToString())
            {
                this.cbCorteCarne.Items.Add(Corte.Pechuga);
                this.cbCorteCarne.Items.Add(Corte.Suprema);
                this.cbCorteCarne.Items.Add(Corte.Pata_Y_Muslo);
                this.cbCorteCarne.Items.Add(Corte.Pollo_Entero);
                this.cbCorteCarne.SelectedIndex = 0;

                this.cbTexturaCarne.Items.Add(CategoriaBovina.No_Es_Bovino);
                this.cbTexturaCarne.SelectedIndex = 0;
                this.cbTexturaCarne.Enabled = false;
            }
            else if (this.cbTipoDeCarneReponer.SelectedItem.ToString() == Tipo.Cerdo.ToString())
            {
                this.cbCorteCarne.Items.Add(Corte.Bondiola);
                this.cbCorteCarne.Items.Add(Corte.Costilla);
                this.cbCorteCarne.Items.Add(Corte.Pechito);
                this.cbCorteCarne.Items.Add(Corte.Solomillo);
                this.cbCorteCarne.Items.Add(Corte.Matambre);
                this.cbCorteCarne.SelectedIndex = 0;

                this.cbTexturaCarne.Items.Add(CategoriaBovina.No_Es_Bovino);
                this.cbTexturaCarne.SelectedIndex = 0;
                this.cbTexturaCarne.Enabled = false;
            }
        }

        /// <summary>
        /// Solo ingresará numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            FrmMetodoDePago.SoloNumeros(sender, e);
        }

        /// <summary>
        /// Solo ingresará numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            FrmMetodoDePago.SoloNumeros(sender, e);
        }

        /// <summary>
        /// Solo ingresará numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPesoCarne_KeyPress(object sender, KeyPressEventArgs e)
        {
            FrmMetodoDePago.SoloNumeros(sender, e);
        }
        #endregion

        #region METODOS/VALIDACIONES DEL FORM
        /// <summary>
        /// Metodo privado que me permite cargar los productos de la lista,
        /// la recorre, uso auxiliares de las filas para poder imprimir los atributos
        /// en el datagrid.
        /// 
        /// Es una forma de que me muestre lo que quiero, ya que sino directamente
        /// al datagrid se le puede pasar la lista y mostrara gracias a las propiedades
        /// de la clase.
        /// </summary>
        public void CargarProductosDataGrid()
        {
            tablaProductos.Rows.Clear();

            foreach (KeyValuePair<int, Producto> dic in this.vendedorForm.ListaProductos)
            {
                auxFilaProduc = tablaProductos.NewRow();

                auxFilaProduc[0] = $"{dic.Key}";
                auxFilaProduc[1] = $"{dic.Value.Tipo.ToString().Replace("_", " ")}";
                auxFilaProduc[2] = $"{dic.Value.Corte.ToString().Replace("_", " ")}";
                auxFilaProduc[3] = $"{dic.Value.Categoria.ToString().Replace("_", " ")}";
                auxFilaProduc[4] = $"{dic.Value.Peso}kgs";
                auxFilaProduc[5] = $"${dic.Value.PrecioCompraCliente:f}";
                auxFilaProduc[6] = $"{dic.Value.Vencimiento.ToShortDateString()}";
                auxFilaProduc[7] = $"{dic.Value.Proveedor}";
                auxFilaProduc[8] = $"${dic.Value.PrecioVentaProveedor:f}";

                tablaProductos.Rows.Add(auxFilaProduc);//-->Añado las Filas
            }
            this.dataGridViewProductos.DataSource = tablaProductos;//-->Al dataGrid le paso la lista
        }

        /// <summary>
        /// Me permite habilitar o deshabilitar los textboxes del formulario y limpiarlos
        /// </summary>
        private void ManejoTextBoxes()
        {
            this.txtPesoCarne.Clear();
            this.txtPrecioCompraFrigorifico.Clear();
            this.txtPrecioVentaClientes.Clear();
            this.txtProveedor.Clear();
            this.txtPrecioCompraFrigorifico.Enabled = false;
            this.txtProveedor.Enabled = false; 
            this.cbTexturaCarne.Enabled = false;
            this.cbTipoDeCarneReponer.Enabled = false;
            this.dtpFechaVencimiento.Enabled = false;
        }

        /// <summary>
        /// Este metodo privado de me permite verificar los datos que ingrese el usuario.
        /// </summary>
        /// <returns>Devuelve true si la informacion es valida, false sino</returns>
        private bool ValidarDatos()
        {
            bool esValido = true;
            double precioCompra;

            double.TryParse(this.txtPrecioVentaClientes.Text, out precioCompraCliente);
            double.TryParse(this.txtPesoCarne.Text, out peso);
            double.TryParse(this.txtPrecioCompraFrigorifico.Text, out precioCompra);


            if (string.IsNullOrEmpty(this.txtPrecioVentaClientes.Text) || string.IsNullOrEmpty(this.txtPesoCarne.Text) ||
                string.IsNullOrEmpty(this.cbCorteCarne.Text))
            {
                esValido = false;//-->Alguna de todas las cadenas ingresadas es invalida
            }

            //--->Valido los numeros, EL PRECIO DE COMPRA DEL FRIGORIFICO DEBERA DE SER MAYOR AL PRECIO DE VENTA EL PUBLICO
            if (peso <= 0 || precioCompraCliente <= 0 || precioCompra <= 0 || precioCompra > precioCompraCliente)
            {
                esValido = false;//-->Si alguno de los valores ingresado es menor o igual a 0, no lo dejo.
            }

            if (indexTablaProductos < 0)
            {
                esValido = false;//-->No selecciono.
            }

            //-->Valido que no ingrese una fecha invalida, es decir, un producto vencido.
            if (this.dtpFechaVencimiento.Value < DateTime.Now)
            {
                esValido = false;//-->Producto vencido
            }

            if (!esValido)
            {
                MessageBox.Show("Alguno de los datos es incorrecto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return esValido;
        }
        #endregion

        #region BOTONES DEL FORM
        /// <summary>
        /// Al presionar este boton me permitira reponer un nuevo producto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReponer_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                carneSeleccionada.Peso += peso;//-->Le agrego el peso nuevo a lo que tenia. 
                carneSeleccionada.PrecioCompraCliente = precioCompraCliente;//-->Setteo nuevo precio
                carneSeleccionada.Corte = Enum.Parse<Corte>(this.cbCorteCarne.SelectedItem.ToString());

                this.CargarProductosDataGrid();//-->Actualizo el dataGrid
                this.txtPesoCarne.Clear();
                this.txtPrecioVentaClientes.Clear();
            }
            else
            {
                MessageBox.Show("Ocurrio un error al intentar reponer el producto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //terminoDeReponer = true;//-->Habilito los textboxes nuevamente ya que termino de reponer.
            // this.ManejoTextBoxes();
        }

        /// <summary>
        /// Me permite abrir otro formulario para que el vendedor pueda venderle un producto al cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVender_Click(object sender, EventArgs e)
        {
            frmVentaVendedor = new FrmVentaVendedor(vendedorForm);
            frmVentaVendedor.Show();
            this.Close();//-->Cierro este formualario.
        }

        /// <summary>
        /// Al presionarlo me permitira ver el historial de las compras realizadas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            frmHistorial = new FrmHistorial(vendedorForm);
            frmHistorial.ShowDialog();
        }
        #endregion 

        #region EVENTOS Colgados
        /// <summary>
        /// Este botón me permite instanciar un nuevo producto y agregarlo al stock.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarAlStock_Click(object sender, EventArgs e)
        {
            //if (ValidarDatos() && terminoDeReponer)//-->Valido los datos y verifico si reponer no es true
            //{
            //    categoriaCarne = Enum.Parse<CategoriaBovina>(this.cbTexturaCarne.SelectedItem.ToString());

            //    carneIngresada = new Carne(Enum.Parse<Corte>(this.cbCorteCarne.SelectedItem.ToString()), double.Parse(this.txtPesoCarne.Text),
            //        categoriaCarne, this.dtpFechaVencimiento.Value, double.Parse(this.txtPrecioCompraFrigorifico.Text),
            //        this.txtProveedor.Text, Enum.Parse<Tipo>(this.cbTipoDeCarneReponer.SelectedItem.ToString()),
            //        double.Parse(this.txtPrecioVentaClientes.Text));

            //    this.vendedorForm.ListaProductos.Add(carneIngresada);

            //    this.CargarProductosDataGrid();//-->Actualizo el dataGrid
            //}
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void txtPrecioCompraFrigorifico_TextChanged(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void cbTexturaCarne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion


    }
}
