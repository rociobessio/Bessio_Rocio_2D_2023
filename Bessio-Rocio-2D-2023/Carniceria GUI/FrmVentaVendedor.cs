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

namespace Carniceria_GUI
{
    /// <summary>
    /// En este formulario el Vendedor podrá justamente
    /// venderle un producto a un cliente.
    /// </summary>
    public partial class FrmVentaVendedor : Form
    {
        public FrmVentaVendedor(Vendedor vendedor)
        {
            InitializeComponent();
            this.Text = "Venta de productos";
            this.StartPosition = FormStartPosition.CenterScreen;

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

        private void FrmVentaVendedor_Load(object sender, EventArgs e)
        {
            #region TEXTBOXES
            this.txtApellido.Enabled = false;
            this.txtDNI.Enabled = false;
            this.txtDomicilio.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.txtTotalAPagar.Enabled = false;
            #endregion
        }
    }
}
