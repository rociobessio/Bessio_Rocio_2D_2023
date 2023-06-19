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
        Repositor repositor;
        #region CARNE
        private Producto carneSeleccionada;
        private double peso;
        private double precioCompraCliente;
        private Producto productoNuevo;
        #endregion

        #region DATAGRIDVIEW
        DataTable tablaProductos;
        DataRow auxFilaProduc;
        int indexTablaProductos;
        int codigoProducto;
        #endregion
        
        private ProductoDAO productoDAO;
        private List<Producto> listaProductos;    
         
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Consrtuctor del form sin parametros, me permite 
        /// centrar el form, e instanciar atributos.
        /// </summary>
        public FrmHeladera()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Heladera - Reponer Stock";

            this.tablaProductos = new DataTable();//-->Instancio la dataTable.
            this.repositor = new Repositor();
            this.carneSeleccionada = new Producto();//-->Instancio par evitar nulls 
        }

        /// <summary>
        /// sobrecarga del constructor del form que recibe un vendedor,
        /// le asigna valores.
        /// </summary>
        /// <param name="vendedor"></param>
        public FrmHeladera(Usuario vendedor)
            : this()
        {
            this.lblVendedorEmail.Text = vendedor;
            this.lblHoraIngreso.Text = vendedor.HoraIngreso.ToShortTimeString();


            this.listaProductos = new List<Producto>();
            this.productoDAO = new ProductoDAO();

            #region PRINT AYUDA
            StringBuilder textoAyuda = new StringBuilder();
            textoAyuda.AppendLine("El vendedor podrá reponer el stock de un producto, modificarlo, agregar uno nuevo u eliminarlo, además podrá visualizarlos.");
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

            this.listaProductos = productoDAO.ObtenerLista();//-->Obtengo la lista de la DB 
 
            this.CargarProductosDataGrid();//-->Ponele que no quiero que me muestre los datos que quiero yo 
        }

        /// <summary>
        /// Me permite seleccionar un producto del datagrid para poder reponerlo.
        /// Unicamente me dejara editar su peso, lo cargo y se lo paso a una nueva variable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnAgregar.Enabled = false;//-->Al presionar una celda deshabilito el btnAgregar.

            this.indexTablaProductos = e.RowIndex;//-->Obtengo el indice

            if (this.indexTablaProductos > -1)//-->Si es mayor a -1 obtengo el codigo, celda [0]
            {
                codigoProducto = int.Parse(this.dataGridViewProductos.Rows[indexTablaProductos].Cells[0].Value.ToString());//-->Obtengo el codigo
            }

            //Recorro la lista en busca de ese producto y lo muestro en los textboxes
            foreach (Producto producto in this.listaProductos)
            {
                if (producto.Codigo == codigoProducto)
                {
                    this.txtPrecioVentaClientes.Text = producto.PrecioCompraCliente.ToString();
                    this.txtPrecioCompraFrigorifico.Text = producto.PrecioVentaProveedor.ToString();
                    this.txtProveedor.Text = producto.Proveedor;
                    this.cbCorteCarne.Text = producto.Corte.ToString();
                    this.cbTexturaCarne.Text = producto.Categoria.ToString();
                    this.cbTipoDeCarneReponer.Text = producto.Tipo.ToString();
                    this.dtpFechaVencimiento.Value = producto.Vencimiento;

                    carneSeleccionada = producto;//-->Guardo esa carne para realizar las modificaciones o calculos
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
                this.cbCorteCarne.Items.Add(Corte.Bife_Angosto.ToString().Replace("_", " "));
                this.cbCorteCarne.Items.Add(Corte.Lomo);
                this.cbCorteCarne.Items.Add(Corte.Vacio);
                this.cbCorteCarne.Items.Add(Corte.Matambre);
                this.cbCorteCarne.SelectedIndex = 0;//-->Selecciono el primero de esa opcion, si cambiase el Tipo me quedaria seleccionado el indice anterior

                this.cbTexturaCarne.Items.Add(CategoriaBovina.Novillito);
                this.cbTexturaCarne.Items.Add(CategoriaBovina.Ternero);
                this.cbTexturaCarne.SelectedIndex = 0;
                this.cbTexturaCarne.Enabled = true;
            }
            else if (this.cbTipoDeCarneReponer.SelectedItem.ToString() == Tipo.Pollo.ToString())
            {
                this.cbCorteCarne.Items.Add(Corte.Pechuga);
                this.cbCorteCarne.Items.Add(Corte.Suprema);
                this.cbCorteCarne.Items.Add(Corte.Pata_Y_Muslo.ToString().Replace("_", " "));
                this.cbCorteCarne.Items.Add(Corte.Pollo_Entero.ToString().Replace("_", " "));
                this.cbCorteCarne.SelectedIndex = 0;

                this.cbTexturaCarne.Items.Add(CategoriaBovina.No_Es_Bovino.ToString().Replace("_", " "));
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

                this.cbTexturaCarne.Items.Add(CategoriaBovina.No_Es_Bovino.ToString().Replace("_", " "));
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

            foreach (Producto producto in this.listaProductos)
            {
                auxFilaProduc = tablaProductos.NewRow();

                auxFilaProduc[0] = $"{producto.Codigo}";
                auxFilaProduc[1] = $"{producto.Tipo.ToString().Replace("_", " ")}";
                auxFilaProduc[2] = $"{producto.Corte.ToString().Replace("_", " ")}";
                auxFilaProduc[3] = $"{producto.Categoria.ToString().Replace("_", " ")}";
                auxFilaProduc[4] = $"{producto.Peso}kgs";
                auxFilaProduc[5] = $"${producto.PrecioCompraCliente:f}";
                auxFilaProduc[6] = $"{producto.Proveedor}";
                auxFilaProduc[7] = $"${producto.PrecioVentaProveedor:f}";
                auxFilaProduc[8] = $"{producto.Vencimiento.ToShortDateString()}";

                tablaProductos.Rows.Add(auxFilaProduc);//-->Añado las Filas
            }
            this.dataGridViewProductos.DataSource = tablaProductos;//-->Al dataGrid le paso la lista
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
            //-->Peso puede ser 0, no suma nada mantiene stock, por si quisiese cambiar el precio.
            if (peso < 0 || precioCompraCliente <= 0 || precioCompra <= 0 || precioCompra > precioCompraCliente ||
                peso > 120)
            {
                esValido = false;//-->Si alguno de los valores ingresado es menor o igual a 0, no lo dejo.
            }

            if (this.cbCorteCarne.SelectedIndex < 0 || this.cbTexturaCarne.SelectedIndex < 0 ||
                this.cbTipoDeCarneReponer.SelectedIndex < 0)
            {
                esValido = false;//--->Quiere decir que no selecciono alguna opcion.
            }

            //-->Valido que no ingrese una fecha invalida, es decir, un producto vencido.
            if (this.dtpFechaVencimiento.Value <= DateTime.Now)
            {
                esValido = false;//-->Producto vencido
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
        private void btnReponer_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatos() && indexTablaProductos > 0)
            {
                carneSeleccionada.Peso += peso;//-->Le agrego el peso nuevo a lo que tenia. 

                if (productoDAO.UpdateProducto(carneSeleccionada))
                {
                    MessageBox.Show("Stock de producto modificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error, no se pudo modificar el stock del producto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.CargarProductosDataGrid();//-->Actualizo el dataGrid
                this.txtPesoCarne.Clear();
                this.txtPrecioVentaClientes.Clear();
            }
            else
            {
                MessageBox.Show("Alguno de los datos es incorrecto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.btnAgregar.Enabled = true;
        }

        /// <summary>
        /// Este boton me permitira eliminar un producto
        /// de la heladera y de la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (codigoProducto > 0)
            {
                if (productoDAO.DeleteProducto(codigoProducto))
                {
                    MessageBox.Show("El producto se ha eliminado de la Heladera.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al intentar eliminar el producto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar un producto valido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.CargarProductosDataGrid();//-->Actualizo el dataGrid
            this.btnAgregar.Enabled = true;
        }

        /// <summary>
        /// Este boton me permitira modificar
        /// un producto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() && indexTablaProductos > 0)
            {
                //Selecciono una carne y le cargo los nuevos valores
                carneSeleccionada.Categoria = this.cbTexturaCarne.SelectedItem.ToString();
                carneSeleccionada.Tipo = this.cbTipoDeCarneReponer.SelectedItem.ToString();
                carneSeleccionada.Vencimiento = this.dtpFechaVencimiento.Value;
                carneSeleccionada.PrecioVentaProveedor = int.Parse(this.txtPrecioCompraFrigorifico.Text);
                carneSeleccionada.Proveedor = this.txtProveedor.Text;
                carneSeleccionada.PrecioCompraCliente = int.Parse(this.txtPrecioVentaClientes.Text);
                carneSeleccionada.Peso = peso;//Setteo nuevo precio
                carneSeleccionada.PrecioCompraCliente = precioCompraCliente;//-->Setteo nuevo precio
                carneSeleccionada.Corte = this.cbCorteCarne.SelectedItem.ToString();

                if (productoDAO.UpdateProducto(carneSeleccionada))
                {
                    MessageBox.Show("Producto modificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error, no se pudo modificar el producto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Alguno de los datos es incorrecto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.CargarProductosDataGrid();//-->Actualizo el dataGrid
            this.btnAgregar.Enabled = true;
        }

        /// <summary>
        /// Me permitira agregar un nuevo producto a la heladera.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                productoNuevo = new Producto(this.cbCorteCarne.SelectedItem.ToString(), double.Parse(this.txtPesoCarne.Text),
                    this.cbTexturaCarne.Text, this.dtpFechaVencimiento.Value, double.Parse(this.txtPrecioCompraFrigorifico.Text),
                    this.txtProveedor.Text, this.cbTipoDeCarneReponer.Text, double.Parse(this.txtPrecioVentaClientes.Text));

                if (productoDAO.AgregarProducto(productoNuevo))
                {
                    MessageBox.Show("Producto agregado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error, no se pudo agregar el producto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Alguno de los datos es incorrecto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.CargarProductosDataGrid();//-->Actualizo el dataGrid
        }
        #endregion

        #region EVENTOS Colgados 
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
