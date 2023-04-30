using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carniceria_GUI
{
    /// <summary>
    /// En este formulario el Vendedor podrá justamente
    /// venderle un producto a un cliente.
    /// </summary>
    public partial class FrmVentaVendedor : Form
    {
        #region ATRIBUTOS
        private Vendedor _vendedorForm;
        private Carne2 carneSeleccionada;
        private Cliente clienteSelecccionado;
        private SoundPlayer soundPlayer;

        DataTable _dataTable;
        DataRow auxFilaProduc;
        //FrmHeladera frmHeladera;

        int indexTablaProductos;
        int indiceDetalle;
        int codigoProducto;
        double totalAPagar;
        #endregion

        public FrmVentaVendedor(Vendedor vendedor)
        {
            InitializeComponent();
            _vendedorForm = vendedor;
            this.lblVendedorEmail.Text = _vendedorForm;
            this.Text = "Venta de Productos";
            this.StartPosition = FormStartPosition.CenterScreen;

            this._dataTable = new DataTable();
            //-->Instancio mediante el constructor sin parametros, de esta forma si no selecciona ninguna fila evito errores
            carneSeleccionada = new Carne2();
            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = "C:\\Users\\Rocio\\Desktop\\Primer Parcial 2023\\PP_2D_LabII_2023\\Bessio-Rocio-2D-2023\\Imagenes-Sonido\\CompraSonido.wav";

            #region INSTANCIO AYUDA
            StringBuilder textoAyuda = new StringBuilder();
            textoAyuda.AppendLine("El vendedor podrá seleccionar a un Cliente mediante su usuario,");
            textoAyuda.AppendLine("se mostrará su método de pago y algunos datos relevantes,");
            textoAyuda.AppendLine("mediante el datagrid podrá seleccionar un producto disponible de la lista");
            textoAyuda.AppendLine("para venderlo se necesitara la cantidad y se descontará del stock, actualizandose.");
            textoAyuda.AppendLine("Podrá cancelar la compra si lo requiere.");
            FrmLogin.MostrarAyuda(this.lblPrintHelp, textoAyuda.ToString());
            #endregion
        }

        /// <summary>
        /// En el evento load quito que pueda escribir en los textboxes,
        /// lleno el combo-box de los usuarios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVentaVendedor_Load(object sender, EventArgs e)
        {
            #region TEXTBOXES
            this.txtApellido.Enabled = false;
            this.txtDNI.Enabled = false;
            this.txtDomicilio.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.txtTotalAPagar.Enabled = false;
            this.ckbEfectivo.Enabled = false;
            this.ckbTarjeta.Enabled = false;
            this.txtPrecioPorUnidad.Enabled = false;
            this.txtStockActual.Enabled = false;
            this.txtPesoTotalStock.Enabled = false;
            #endregion

            #region CARGO COLUMNAS DATAGRID
            this._dataTable.Columns.Add("Código");
            this._dataTable.Columns.Add("Tipo");
            this._dataTable.Columns.Add("Corte");
            this._dataTable.Columns.Add("Textura");
            this._dataTable.Columns.Add("Vencimiento");
            this._dataTable.Columns.Add("Proveedor");
            this._dataTable.Columns.Add("Precio compra Frigorifico");

            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;

            this.CargarProductosDataGrid();//-->Cargo con la información de la lista
            #endregion  

            //-->Cargo combo-box de los emails de usuarios
            foreach (Cliente cliente in this._vendedorForm.ListaClientes)
            {
                this.cbClientes.Items.Add(cliente.Usuario.Email);
            }
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

            foreach (Carne2 carnes in this._vendedorForm.ListaProductos)
            {
                auxFilaProduc = _dataTable.NewRow();

                auxFilaProduc[0] = $"{carnes.Codigo}";//-->Muestro el codigo para luego seleccionarlo
                auxFilaProduc[1] = $"{carnes.Tipo}";
                auxFilaProduc[2] = $"{carnes.Corte}";
                auxFilaProduc[3] = $"{carnes.Textura}";
                auxFilaProduc[4] = $"{carnes.Vencimiento.ToShortDateString()}";
                auxFilaProduc[5] = $"{carnes.Proveedor}";
                auxFilaProduc[6] = $"{carnes.PrecioCompra}";

                _dataTable.Rows.Add(auxFilaProduc);//-->Añado las Filas

            }
            this.dataGridViewProductos.DataSource = _dataTable;//-->Al dataGrid le paso la lista
        }


        /// <summary>
        /// Si cambia de usuario elegido, entonces mostrare la informacion correspondiente de este 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Cliente cliente in _vendedorForm.ListaClientes)
            {
                if (cliente.Usuario.Email == this.cbClientes.Text)//-->Si los emails coinciden
                {//-->Muestro la informacion:
                    this.txtApellido.Text = cliente.Apellido;
                    this.txtDNI.Text = cliente.DNI;
                    this.txtDomicilio.Text = cliente.Domicilio;
                    this.txtNombre.Text = cliente.Nombre;
                    this.txtTelefono.Text = cliente.Telefono;

                    if (cliente.ConTarjeta)
                    {
                        this.ckbTarjeta.Checked = true;
                        this.ckbEfectivo.Checked = false;
                    }
                    else
                    {
                        this.ckbEfectivo.Checked = true;
                        this.ckbTarjeta.Checked = false;
                    }
                    clienteSelecccionado = cliente;//-->Guardo ese cliente
                }
            }
        }

        /// <summary>
        /// Al presionar una Celda obtengo los datos de lo uqe este en la fila,
        /// de esta forma imprimire en pantalla lo que creo relevante.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.indexTablaProductos = e.RowIndex;//-->Obtengo el indice

            if (this.indexTablaProductos > -1)//-->Si es mayor a -1 obtengo el codigo, celda [0]
            {
                this.indiceDetalle = 0;
                codigoProducto = int.Parse(this.dataGridViewProductos.Rows[indexTablaProductos].Cells[0].Value.ToString());//-->Obtengo el codigo
            }

            //Recorro la lista en busca de ese producto y lo muestro en los textboxes
            foreach (Carne2 carne in this._vendedorForm.ListaProductos)
            {
                if (carne == codigoProducto)
                {
                    this.txtStockActual.Text = carne.Stock.ToString();
                    this.txtPrecioPorUnidad.Text = carne.PrecioVenta.ToString();
                    this.txtPesoTotalStock.Text = carne.Peso.ToString();
                    carneSeleccionada = carne;//-->Guardo esa carne para realizar las modificaciones o calculos
                }
            }
        }

        #region METODOS
        /// <summary>
        /// Este metodo me valida los campos del Formulario.
        /// </summary>
        /// <returns></returns>
        public bool ValidarCampos()
        {
            bool esValido = true;
            StringBuilder sb = new StringBuilder();
            int peso = 0;
            int.TryParse(this.txtPesoEspecificado.Text, out peso);

            if (this.numericCantidadCompra.Value <= 0 ||
                peso <= 0
                || string.IsNullOrEmpty(this.txtPesoEspecificado.Text))
            {
                esValido = false;
                sb.AppendLine("Alguno de los datos del producto no es valido.");
            }

            if (this.cbClientes.SelectedIndex <= -1)//-->No selecciono ningun usuario
            {
                sb.AppendLine("No se ha seleccionado un cliente de la lista.");
                esValido = false;
            }

            if (this.indexTablaProductos < 0)
            {
                sb.AppendLine("No se ha seleccionado un Producto de la lista.");
                esValido = false;
            }

            if (this.numericCantidadCompra.Value > carneSeleccionada.Stock)
            {
                sb.AppendLine("La cantidad que se quiere vender es mayor al stock disponible.");
                esValido = false;
            }

            if (peso > carneSeleccionada.Peso)
            {
                sb.AppendLine("La cantidad de peso que se quiere vender es mayor al peso total del stock.");
                esValido = false;
            }

            if (!esValido)
            {
                MessageBox.Show(sb.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }

        /// <summary>
        /// Metodo que me permite calcular el precio total del producto seleccionado.
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        private double CalcularPrecioTotal(Cliente cliente)
        {
            double precioCarne = 0;
            double precioFinalTarjeta;
            double peso = double.Parse(this.txtPesoEspecificado.Text);
            int cantidad = int.Parse(this.numericCantidadCompra.Value.ToString());
            double precio = carneSeleccionada.PrecioCompra;

            precioCarne = (peso * cantidad) * precio;

            if (cliente.ConTarjeta)//Si paga con tarjeta
            {
                double conRecargo = precioCarne * 0.05;//-->Recargo del %5
                precioFinalTarjeta = precioCarne + conRecargo;
                precioCarne = precioFinalTarjeta;
            }
            //-->Devuelvo
            return precioCarne;
        }

        /// <summary>
        /// Me permite verificar si el cliente cumple con los requisitios para comprar:
        /// 1.Si es con tarjeta que esta tenga saldo y que sea mayor al total de la compra.
        /// 2.Lo mismo con debito, que tenga saldo y que sea mayor al total.
        /// 3.Le descuento el total de su billetera
        /// 4.Le agrego a su carrito el producto y acumulo el total.
        /// 5.Resto del stock la cantidad y el peso. 
        /// </summary>
        /// <param name="totalCompra"></param>
        /// <param name="cliente"></param>
        /// <param name="cantidad"></param>
        /// <param name="peso"></param>
        /// <returns>True si cumple con los requisitos, false sino.</returns>
        private bool Comprar(double totalCompra, Cliente cliente, int cantidad, double peso)
        {
            bool pudoComprar = false;
            if (cliente.ConTarjeta)
            {
                if (cliente.TarjetaCredito.DineroDisponible > 0 &&
                     cliente.TarjetaCredito.DineroDisponible > totalCompra)
                {
                    cliente.TarjetaCredito.DineroDisponible -= totalCompra;//-->Descuento la plata
                    cliente.CarritoCompra.Productos.Add(carneSeleccionada);//-->Al carrito le añado la carne 
                    cliente.CarritoCompra.PrecioTotal += totalCompra;

                    carneSeleccionada.Stock -= cantidad;//-->Descuento del stock
                    carneSeleccionada.Peso -= peso;//-->Descuento el peso
                    pudoComprar = true;
                }
            }
            else//Es con efectivo
            {
                if (cliente.DineroDebitoDisponible > 0 && cliente.DineroDebitoDisponible > totalCompra)
                {
                    cliente.DineroDebitoDisponible -= totalCompra;
                    cliente.CarritoCompra.Productos.Add(carneSeleccionada);
                    cliente.CarritoCompra.PrecioTotal += totalCompra;//-->Voy acumulando

                    carneSeleccionada.Stock -= cantidad;//-->Descuento del stock
                    carneSeleccionada.Peso -= peso;//-->Descuento el peso

                    pudoComprar = true;
                }
            }

            return pudoComprar;
        }

        /// <summary>
        /// Metodo privado que me permite limpiar los controles del formulario.
        /// </summary>
        private void Limpiar()
        {
            this.txtTotalAPagar.Clear();
            this.txtPrecioPorUnidad.Clear();
            this.txtPesoTotalStock.Clear();
            this.txtPesoEspecificado.Clear();
            this.txtStockActual.Clear();
            this.numericCantidadCompra.ResetText();
        }
        #endregion

        #region BOTONES DEL FORM
        /// <summary>
        /// El vendedor podrá vender un producto a un cliente si cumple con las validaciones requeridas,
        /// 1. Que haya stock del producto.
        /// 2. Que el peso que requiere sea menor al peso total del stock.
        /// 3. Que el Cliente tenga saldo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVender_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())//-->Valido los datos que recibo
            {
                totalAPagar = this.CalcularPrecioTotal(clienteSelecccionado);//-->Obtengo el total.
                int cantidad = int.Parse(this.numericCantidadCompra.Value.ToString());
                double peso = double.Parse(this.txtPesoEspecificado.Text);

                if (this.Comprar(totalAPagar, clienteSelecccionado, cantidad, peso))//-->Intenta comprar.
                {
                    soundPlayer.Play();
                    MessageBox.Show("Venta generada",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (carneSeleccionada.Stock == 0)
                    {
                        this._vendedorForm.ListaProductos.Remove(carneSeleccionada);
                    }

                    this.CargarProductosDataGrid();//-->Recargo el datagrid
                }
                else//-->No pudo comprar.
                {
                    MessageBox.Show("Ocurrio un problema al intentar vender el producto. Probablemente el cliente no tenga saldo.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Limpiar();
        }

        /// <summary>
        /// Me permite calcular el total a pagar del cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                double retorno = this.CalcularPrecioTotal(clienteSelecccionado);
                this.txtTotalAPagar.Text = retorno.ToString();
            }
        }
        #endregion
        #region EVENTOS COLGADOS
        /// <summary>
        /// A medida que incremente la cantidad que requiere el cliente
        /// se realizara el calculo del total a pagar y lo mostrará en un textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericCantidadCompra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPesoEspecificado_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
