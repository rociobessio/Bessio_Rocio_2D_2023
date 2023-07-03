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
using Excepciones;

namespace Carniceria_GUI
{
    /// <summary>
    /// En este formulario el Vendedor podrá justamente
    /// venderle un producto a un cliente.
    /// </summary>
    public partial class FrmVentaVendedor : Form
    {
        #region ATRIBUTOS
        private Usuario _vendedorForm;
        private Producto carneSeleccionada;
        private Cliente clienteSeleccionado;
        private SoundPlayer soundPlayer;

        private ClienteDAO clienteDAO;
        private ProductoDAO productoDAO;
        private List<Cliente> listaClientes;
        private List<Producto> listaProductos;

        DataTable _dataTable;
        DataRow auxFilaProduc;

        int indexTablaProductos;
        int codigoProducto;
        double totalAPagar;
        #endregion 

        #region CONSTRUCTORES FORMULARIO
        /// <summary>
        /// Este constructor del Venta me permite asignarle un nombre al form,
        /// centrarlo, instanciar el soundplayer y la datatable
        /// </summary>
        public FrmVentaVendedor()
        {
            InitializeComponent();
            this.Text = "Venta de Productos";
            this.StartPosition = FormStartPosition.CenterScreen;
            this._dataTable = new DataTable();

            this.productoDAO = new ProductoDAO();
            this.clienteDAO = new ClienteDAO();

            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = "CompraSonido.wav";
        }

        /// <summary>
        /// Sobrecarga del constructor del formulario, este recibira una instancia de 
        /// Vendedor.
        /// </summary>
        /// <param name="vendedor"></param>
        public FrmVentaVendedor(Usuario vendedor)
            : this()
        {
            this._vendedorForm = vendedor;
            this.lblVendedorEmail.Text = vendedor;
            this.lblHoraIngreso.Text = vendedor.HoraIngreso.ToShortTimeString();

            //-->Instancio mediante el constructor sin parametros, de esta forma si no selecciona ninguna fila evito errores
            carneSeleccionada = new Producto();
            this.listaProductos = productoDAO.ObtenerLista();
            this.listaClientes = clienteDAO.ObtenerLista();

            #region INSTANCIO AYUDA
            StringBuilder textoAyuda = new StringBuilder();
            textoAyuda.AppendLine("El vendedor podrá seleccionar a un Cliente mediante su usuario,");
            textoAyuda.AppendLine("se mostrará su método de pago y algunos datos relevantes,");
            textoAyuda.AppendLine("mediante el datagrid podrá seleccionar un producto disponible de la lista");
            textoAyuda.AppendLine("para venderlo se necesitara la cantidad y se descontará del stock, actualizandose.");
            textoAyuda.AppendLine("Tambien podrá sumarle dinero al cliente seleccionado.");
            FrmLogin.MostrarAyuda(this.lblPrintHelp, textoAyuda.ToString());
            #endregion
        }
        #endregion

        #region EVENTOS DEL FORM
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
            this.txtPesoTotalStock.Enabled = false;
            this.txtSaldoDisponibleCliente.Enabled = false;
            #endregion

            #region CARGO COLUMNAS DATAGRID
            this._dataTable.Columns.Add("Código");
            this._dataTable.Columns.Add("Tipo");
            this._dataTable.Columns.Add("Corte");
            this._dataTable.Columns.Add("Categoría bovina");
            this._dataTable.Columns.Add("Vencimiento");
            this._dataTable.Columns.Add("Proveedor");
            this._dataTable.Columns.Add("Precio compra Frigorifico");

            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;

            this.CargarProductosDataGrid();//-->Cargo con la información de la lista
            #endregion  

            //-->Cargo combo-box de los emails de usuarios
            foreach (Cliente cliente in this.listaClientes)
            {
                this.cbClientes.Items.Add(cliente.Usuario.Email);
            }
        }

        /// <summary>
        /// En este evento, antes de cerrarlo le paso al formulario heladera
        /// la lista actualizada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVentaVendedor_FormClosing(object sender, FormClosingEventArgs e)
        {

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

            foreach (Producto producto in this.listaProductos)
            {
                auxFilaProduc = _dataTable.NewRow();

                auxFilaProduc[0] = $"{producto.Codigo}";
                auxFilaProduc[1] = $"{producto.Tipo.ToString().Replace("_", " ")}";
                auxFilaProduc[2] = $"{producto.Corte.ToString().Replace("_", " ")}";
                auxFilaProduc[3] = $"{producto.Categoria.ToString().Replace("_", " ")}";
                auxFilaProduc[4] = $"{producto.Vencimiento.ToShortDateString()}";
                auxFilaProduc[5] = $"{producto.Proveedor}";
                auxFilaProduc[6] = $"${producto.PrecioVentaProveedor:f}";

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
            foreach (Cliente cliente in listaClientes)
            {
                if (cliente.Usuario.Email == this.cbClientes.Text)//-->Si los emails coinciden
                {//-->Muestro la informacion:
                    this.txtApellido.Text = cliente.Apellido;
                    this.txtDNI.Text = MetodosDeExtension.ExtensionFormatoDNI(cliente.DNI);
                    this.txtDomicilio.Text = cliente.Domicilio;
                    this.txtNombre.Text = cliente.Nombre;
                    this.txtTelefono.Text = MetodosDeExtension.ExtensionFormatoTelefono(cliente.Telefono);

                    if (cliente.ConTarjeta)
                    {
                        this.ckbTarjeta.Checked = true;
                        this.ckbEfectivo.Checked = false;
                        this.txtSaldoDisponibleCliente.Text = $"${cliente.Tarjeta.DineroDisponible.ToString()}";
                    }
                    else
                    {
                        this.ckbEfectivo.Checked = true;
                        this.ckbTarjeta.Checked = false;
                        this.txtSaldoDisponibleCliente.Text = $"${cliente.DineroEfectivoDisponible.ToString()}";
                    }
                    clienteSeleccionado = cliente;//-->Guardo ese cliente
                }
            }
        }

        /// <summary>
        /// Solo ingresará numeros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPesoEspecificado_KeyPress(object sender, KeyPressEventArgs e)
        {
            FrmMetodoDePago.SoloNumeros(sender, e);
        }

        /// <summary>
        /// Solo ingresara numeros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSumarDineroCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            FrmMetodoDePago.SoloNumeros(sender, e);
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
                codigoProducto = int.Parse(this.dataGridViewProductos.Rows[indexTablaProductos].Cells[0].Value.ToString());//-->Obtengo el codigo
            }

            //Recorro la lista en busca de ese producto y lo muestro en los textboxes
            foreach (Producto producto in this.listaProductos)
            {
                if (producto.Codigo == codigoProducto)
                {
                    this.txtPrecioPorUnidad.Text = $"${producto.PrecioCompraCliente.ToString():f}";
                    this.txtPesoTotalStock.Text = $"{producto.Stock.ToString()} kgs";
                    carneSeleccionada = producto;//-->Guardo esa carne para realizar las modificaciones o calculos
                    break;
                }
            }
        }
        #endregion

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

            if (peso <= 0
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

            //if (peso > carneSeleccionada.Stock)
            //{
            //    sb.AppendLine("La cantidad de peso que se quiere vender es mayor al peso total del stock.");
            //    esValido = false;
            //}

            if (!esValido)
            {
                MessageBox.Show(sb.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
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
            try
            {
                if (ValidarCampos())//-->Valido los datos que recibo
                {
                    double peso = 0;
                    double.TryParse(this.txtPesoEspecificado.Text, out peso);

                    bool updateBase;
                    //-->Obtengo el total que deberá pagar el cliente.
                    totalAPagar = Producto.CalcularPrecioTotalProducto(clienteSeleccionado, carneSeleccionada, peso);

                    if (!Vendedor.Vender(totalAPagar, clienteSeleccionado, peso, carneSeleccionada, out updateBase))//-->Intenta comprar. 
                        throw new NoPudoVenderException("Ocurrio un error al intentar vender el producto, vuelva a intentarlo."); 

                    soundPlayer.Play();
                    this.ActualizarVentaGenerada();

                    if (!ArchivoDeTexto.GuardarVenta(clienteSeleccionado))//-->Guardo esa venta si puedo.
                        throw new ArchivoDeTextoException("Error al guardar archivo de Texto"); 

                    if (!updateBase) 
                        throw new SQLUpdateException("Ocurrio un error al modificar las tablas."); 

                    this.CargarProductosDataGrid();//-->Recargo el datagrid  
                } 
                this.Limpiar();
            }
            catch(NoHayStockException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArchivoDeTextoException ex)//-->Atrapo
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (SQLUpdateException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NoPudoVenderException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (JSONException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Algo inesperado sucedio, vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Actualizo los txt e imprimo 
        /// que la venta se pudo generar.
        /// </summary>
        private void ActualizarVentaGenerada()
        {
            MessageBox.Show("Venta generada",
                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (clienteSeleccionado.ConTarjeta)//-->Actualizo el mostrar saldo.
            {
                this.txtSaldoDisponibleCliente.Text = $"${clienteSeleccionado.Tarjeta.DineroDisponible.ToString()}";
            }
            else
            {
                this.txtSaldoDisponibleCliente.Text = $"${clienteSeleccionado.DineroEfectivoDisponible.ToString()}";
            }
        }

        /// <summary>
        /// El vendedor podrá modificarle
        /// el saldo a un cliente.
        /// Se le sumara el ingreso a lo que
        /// tiene.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModDineroCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cbClientes.SelectedIndex <= -1)//-->Primero verifico que haya seleccionado.
                {
                    MessageBox.Show("No se ha seleccionado a un cliente.",
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else//-->Selecciono
                {
                    double dinero = 0;
                    double.TryParse(this.txtSumarDineroCliente.Text, out dinero);

                    if (dinero > 1)
                    {
                        if (clienteSeleccionado.ConTarjeta)
                        {
                            clienteSeleccionado.Tarjeta.DineroDisponible += dinero;

                        }
                        else
                            clienteSeleccionado.DineroEfectivoDisponible += dinero;

                        if (!clienteDAO.UpdateDato(clienteSeleccionado))//-->Lo modifico.
                        {
                            throw new SQLUpdateException("Error al intentar modificar la tabla, reintente.");
                        }
                        else
                        {
                            if (clienteSeleccionado.ConTarjeta)
                                this.txtSaldoDisponibleCliente.Text = $"${clienteSeleccionado.Tarjeta.DineroDisponible.ToString()}";
                            else
                                this.txtSaldoDisponibleCliente.Text = $"${clienteSeleccionado.DineroEfectivoDisponible.ToString()}";
                        }
                        this.txtSumarDineroCliente.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Dinero a agregar no valido.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SQLUpdateException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//-->La muestro
            }
            catch (Exception)
            {
                MessageBox.Show("Algo inesperado sucedio, vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//-->La muestro
            }
        }

        /// <summary>
        /// Me permite calcular el total a pagar del cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    double peso = double.Parse(this.txtPesoEspecificado.Text);
                    double retorno = Producto.CalcularPrecioTotalProducto(clienteSeleccionado, carneSeleccionada, peso);
                    this.txtTotalAPagar.Text = $"${retorno.ToString():f}";
                }
            } 
            catch (Exception)
            {
                MessageBox.Show("Algo inesperado sucedio, vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//-->La muestro
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

        private void dataGridViewProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion 
    }
}
