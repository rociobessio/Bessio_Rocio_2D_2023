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
        private Carne carneSeleccionada;
        private Cliente clienteSelecccionado;
        private SoundPlayer soundPlayer;

        DataTable _dataTable;
        DataRow auxFilaProduc;
        FrmHeladera frmHeladera;

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

            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = "CompraSonido.wav";
        }

        /// <summary>
        /// Sobrecarga del constructor del formulario, este recibira una instancia de 
        /// Vendedor.
        /// </summary>
        /// <param name="vendedor"></param>
        public FrmVentaVendedor(Vendedor vendedor)
            : this()
        {
            _vendedorForm = vendedor;
            this.lblVendedorEmail.Text = _vendedorForm;
            //-->Instancio mediante el constructor sin parametros, de esta forma si no selecciona ninguna fila evito errores
            carneSeleccionada = new Carne();

            frmHeladera = new FrmHeladera();

            #region INSTANCIO AYUDA
            StringBuilder textoAyuda = new StringBuilder();
            textoAyuda.AppendLine("El vendedor podrá seleccionar a un Cliente mediante su usuario,");
            textoAyuda.AppendLine("se mostrará su método de pago y algunos datos relevantes,");
            textoAyuda.AppendLine("mediante el datagrid podrá seleccionar un producto disponible de la lista");
            textoAyuda.AppendLine("para venderlo se necesitara la cantidad y se descontará del stock, actualizandose.");
            textoAyuda.AppendLine("Podrá cancelar la compra si lo requiere.");
            textoAyuda.AppendLine("Al presionar 'Historial' será capaz de visualizar el historial de compras.");
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
            foreach (Cliente cliente in this._vendedorForm.ListaClientes)
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
            DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea salir?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.No == respuesta)
            {
                e.Cancel = true;
            }
            else
            {
                frmHeladera = new FrmHeladera(_vendedorForm);//-->Le paso al vendedor con los datos actualizados
                frmHeladera.Show();
                this.Hide();
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

            foreach (Carne carnes in this._vendedorForm.ListaProductos)
            {
                auxFilaProduc = _dataTable.NewRow();

                auxFilaProduc[0] = $"{carnes.Codigo}";//-->Muestro el codigo para luego seleccionarlo
                auxFilaProduc[1] = $"{carnes.Tipo}";
                auxFilaProduc[2] = $"{carnes.Corte}";
                auxFilaProduc[3] = $"{carnes.Categoria.ToString().Replace("_", " ")}";
                auxFilaProduc[4] = $"{carnes.Vencimiento.ToShortDateString()}";
                auxFilaProduc[5] = $"{carnes.Proveedor}";
                auxFilaProduc[6] = $"{carnes.PrecioVentaProveedor}";

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
        /// Solo ingresará numeros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPesoEspecificado_KeyPress(object sender, KeyPressEventArgs e)
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
            foreach (Carne carne in this._vendedorForm.ListaProductos)
            {
                if (carne == codigoProducto)
                {
                    this.txtPrecioPorUnidad.Text = carne.PrecioCompraCliente.ToString();
                    this.txtPesoTotalStock.Text = carne.Peso.ToString();
                    carneSeleccionada = carne;//-->Guardo esa carne para realizar las modificaciones o calculos
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
            if (ValidarCampos())//-->Valido los datos que recibo
            {
                double peso = double.Parse(this.txtPesoEspecificado.Text);

                //-->Obtengo el total que deberá pagar el cliente.
                totalAPagar = Carne.CalcularPrecioTotal(clienteSelecccionado, carneSeleccionada, peso);

                if (Vendedor.Vender(totalAPagar, clienteSelecccionado, peso, carneSeleccionada))//-->Intenta comprar.
                {
                    soundPlayer.Play();
                    MessageBox.Show("Venta generada",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (carneSeleccionada.Peso == 0)//-->Si no hay mas stock del producto lo saco
                    {
                        this._vendedorForm.ListaProductos.Remove(carneSeleccionada);
                    }

                    Vendedor.ObtenerHistorialVentas(clienteSelecccionado);//-->Al vendedor le paso el historial

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
                double peso = double.Parse(this.txtPesoEspecificado.Text);
                double retorno = Carne.CalcularPrecioTotal(clienteSelecccionado, carneSeleccionada, peso);
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
