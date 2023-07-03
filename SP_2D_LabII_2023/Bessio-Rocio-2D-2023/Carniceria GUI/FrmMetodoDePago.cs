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
    public partial class FrmMetodoDePago : Form
    {
        #region ATRIBUTOS
        private Cliente clienteForm;
        private Tarjeta tarjetaCliente;
        private FrmCompraCliente frmCompraCliente;
        private ClienteDAO clienteDAO;
        #endregion 

        #region CONSTRUCTOR FORM
        /// <summary>
        /// El formulario recibirá un cliente.
        /// </summary>
        /// <param name="cliente"></param>
        public FrmMetodoDePago(Cliente cliente)
        {
            InitializeComponent();
            this.Text = "Seleccionar método de pago";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.lblClienteEmail.Text = cliente;//-->Muestro el email del cliente.
            this.dtpFechaVencimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaVencimiento.Format = DateTimePickerFormat.Custom;

            clienteForm = cliente;//-->Paso al cliente que recibo
            tarjetaCliente = null;
            clienteDAO = new ClienteDAO();

            #region DESHABILITO TEXTBOXES
            this.DeshabilitarDatosTarjeta();
            this.txtEfectivoAGastar.Enabled = false;
            #endregion

            #region PRINT AYUDA
            StringBuilder textoAyuda = new StringBuilder();
            textoAyuda.AppendLine("Para poder comprar primero se deberá introducir si compra con efectivo o tarjeta");
            textoAyuda.AppendLine("ingresando los datos de la tarjeta y el monto que tiene disponible,");
            textoAyuda.AppendLine(" en el caso de usar efectivo solo tendrá que ingresar el monto.");
            FrmLogin.MostrarAyuda(this.lblPrintHelp, textoAyuda.ToString());
            #endregion    
        }
        #endregion

        #region EVENTOS DEL FORM
        private void FrmMetodoDePago_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        /// <summary>
        /// Si el radiobutton de pago en efectivo esta checked entonces deshabilito
        /// que ingrese datos de la tarjeta, sino los habilito.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbEfectivo.Checked)//-->Si elije efectivo, habilito su textbox.
            {
                this.txtEfectivoAGastar.Enabled = true;
                this.DeshabilitarDatosTarjeta();//-->No ingrese datos en la tarjeta
            }
            else
                this.HabilitarDatosTarjeta();
        }

        /// <summary>
        /// Si el radiobutton de pago con tarjeta esta checked entonces habilito
        /// que ingrese datos de la tarjeta, sino los deshabilito.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbTarjetaCredito.Checked)
            {
                this.HabilitarDatosTarjeta();
                this.txtEfectivoAGastar.Enabled = false;
            }
            else
            {
                this.DeshabilitarDatosTarjeta();
            }
        }

        /// <summary>
        /// Si el radiobutton de pago con tarjeta esta checked entonces habilito
        /// que ingrese datos de la tarjeta, sino los deshabilito.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbTarjetaDebito_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbTarjetaDebito.Checked)
            {
                this.HabilitarDatosTarjeta();
                this.txtEfectivoAGastar.Enabled = false;
            }
            else
            {
                this.DeshabilitarDatosTarjeta();
            }
        }

        /// <summary>
        /// Este evento llama al metodo SoloNumeros, validando que solo se ingresen numeros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            FrmMetodoDePago.SoloNumeros(sender, e);
        }

        /// <summary>
        /// Este evento llama al metodo SoloNumeros, validando que solo se ingresen numeros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            FrmMetodoDePago.SoloNumeros(sender, e);
        }

        /// <summary>
        /// Este evento llama al metodo SoloNumeros, validando que solo se ingresen numeros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTotalTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            FrmMetodoDePago.SoloNumeros(sender, e);
        }

        /// <summary>
        /// Este evento llama al metodo SoloNumeros, validando que solo se ingresen numeros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEfectivoAGastar_KeyPress(object sender, KeyPressEventArgs e)
        {
            FrmMetodoDePago.SoloNumeros(sender, e);
        }

        /// <summary>
        /// Este evento llama al metodo SoloLetras, validando unicamente el ingreso de letras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTitular_KeyPress(object sender, KeyPressEventArgs e)
        {
            FrmMetodoDePago.SoloLetras(sender, e);
        }

        private void FrmMetodoDePago_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        #endregion 

        #region METODOS
        /// <summary>
        /// Metodo privado que me permite deshabilitar los datos de la tarjeta, en
        /// caso de que sea efectivo. Acoplo todo en un metodo para no repetir codigo 
        /// siempre que necesite aplicarlos.
        /// </summary>
        private void DeshabilitarDatosTarjeta()
        {
            this.txtCVV.Enabled = false;
            this.txtNumTarjeta.Enabled = false;
            this.txtTitular.Enabled = false;
            this.txtTotalTarjeta.Enabled = false;
            this.cbEntidadBancaria.Enabled = false;
            this.dtpFechaVencimiento.Enabled = false;
        }

        /// <summary>
        /// Metodo privado que me permite habilitar los datos de la tarjeta, en
        /// caso de que sea efectivo. Acoplo todo en un metodo para no repetir codigo 
        /// siempre que necesite aplicarlos.
        /// </summary>
        private void HabilitarDatosTarjeta()
        {
            this.txtCVV.Enabled = true;
            this.txtNumTarjeta.Enabled = true;
            this.txtTitular.Enabled = true;
            this.txtTotalTarjeta.Enabled = true;
            this.cbEntidadBancaria.Enabled = true;
            this.dtpFechaVencimiento.Enabled = true;
        }

        /// <summary>
        /// Metodo privado que me permite verificar el ingreso 
        /// de datos por parte del usuario.
        /// </summary>
        /// <returns>Devuelve true si puede comprar, false sino puede.</returns>
        private bool ValidarInput()
        {
            bool puedeComprar = true;
            StringBuilder sb = new StringBuilder();
            double montoEfectivo;
            double.TryParse(this.txtEfectivoAGastar.Text, out montoEfectivo);

            if (this.rbEfectivo.Checked)//-->Si es efectivo
            {
                if (string.IsNullOrEmpty(this.txtEfectivoAGastar.Text)
                    || montoEfectivo <= 0)//-->Que haya ingresado y sea mayor a 0
                {
                    sb.AppendLine("El monto en efectivo ingresado es invalido.");
                    puedeComprar = false;
                }
            }

            if (this.rbTarjetaCredito.Checked || this.rbTarjetaDebito.Checked)//-->Si es tarjeta
            {
                if (string.IsNullOrEmpty(this.txtCVV.Text) || string.IsNullOrEmpty(this.txtNumTarjeta.Text) ||
                    string.IsNullOrEmpty(this.txtTitular.Text) || string.IsNullOrEmpty(this.txtTotalTarjeta.Text) ||
                    this.cbEntidadBancaria.SelectedIndex < -1)
                {
                    puedeComprar = false;
                    sb.AppendLine("Alguno de los datos de ingreso de la tarjeta falta completar.");
                }
            }

            if (!puedeComprar)
            {
                MessageBox.Show(sb.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return puedeComprar;
        }

        /// <summary>
        /// Me permite obtener los datos de la tarjeta ingresada.
        /// </summary>
        /// <returns></returns>
        private Tarjeta CargarTarjeta()
        {
            Tarjeta tarjeta;
            bool esDebito = false;
            string titular = this.txtTitular.Text;
            string numeroTarjeta = this.txtNumTarjeta.Text;
            string cvv = this.txtCVV.Text;
            DateTime vencimiento = this.dtpFechaVencimiento.Value;
            double dinero = double.Parse(this.txtTotalTarjeta.Text);
            string entidad = this.cbEntidadBancaria.SelectedItem.ToString();

            if (this.rbTarjetaDebito.Checked)//-->Si es de debito
            {
                esDebito = true;
            }

            //-->Instancio la tarjeta cargando sus datos
            tarjeta = new Tarjeta(vencimiento, titular, cvv, numeroTarjeta, entidad, dinero, esDebito);

            return tarjeta;
        }

        /// <summary>
        /// Evita que se introduzcan letras al ingresar valores.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Chequea que solo se introduzcan letras y el espacio.
        /// Es un validador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) &&
                (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region BOTONES FORM
        /// <summary>
        /// Una vez el usuario ingrese los datos del pago
        /// se abrira un formulario de compra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarInput())//-->Valido los ingresos
                {
                    if (this.rbTarjetaDebito.Checked || this.rbTarjetaCredito.Checked)//-->Me fijo de que es
                    {
                        tarjetaCliente = this.CargarTarjeta();//-->Cargo la tarjeta

                        if (!Tarjeta.ValidarTarjeta(tarjetaCliente))//-->Si no pudo validarla, lanzo una excepcion
                            throw new TarjetaNoValidaException("Ocurrio un error al generar la tarjeta, datos no validos. Reintente.");

                        clienteForm.Tarjeta = tarjetaCliente;//-->Le asigno la tarjeta
                        clienteForm.ConTarjeta = true;

                        if (!clienteDAO.UpdateDato(clienteForm))//-->Intento actualizar al cliente.
                            throw new SQLUpdateException("Ocurrio un problema al intentar actualizar el saldo del cliente.");

                        frmCompraCliente = new FrmCompraCliente(clienteForm);
                        frmCompraCliente.ShowDialog();//-->Abro el form de compra
                        this.Hide();
                    }

                    if (this.rbEfectivo.Checked)//-->Efectivo, le asigno el valor
                    {
                        clienteForm.DineroEfectivoDisponible = double.Parse(this.txtEfectivoAGastar.Text);
                        clienteForm.ConTarjeta = false;

                        if (!clienteDAO.UpdateDato(clienteForm))//-->Intento actualizar al cliente
                            throw new SQLUpdateException("Ocurrio un problema al intentar actualizar el saldo del cliente.");

                        frmCompraCliente = new FrmCompraCliente(clienteForm);
                        frmCompraCliente.ShowDialog();//-->Abro el form de compra
                        this.Hide();
                    }
                }
            }
            catch(TarjetaNoValidaException ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (SQLUpdateException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, reintente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion 
    }
}
