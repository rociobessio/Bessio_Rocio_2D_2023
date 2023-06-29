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
    public partial class FrmHistorialVentas : Form
    {
        #region ATRIBUTOS
        private Usuario usuarioForm;
        private string[] archivos;
        #endregion

        #region CONSTRUCTORES
        public FrmHistorialVentas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Historial de Ventas";

            //-->Obtengo TODOS los archivos .txt del directorio.
            this.archivos = Directory.GetFiles(ArchivoDeTexto.path, "*.txt");
        }

        /// <summary>
        /// Constructor que recibe una instancia de 
        /// Usuario.
        /// </summary>
        /// <param name="user"></param>
        public FrmHistorialVentas(Usuario user)
            : this()
        {
            this.usuarioForm = user;
            this.lblVendedorEmail.Text = user;
            this.lblHoraIngreso.Text = user.HoraIngreso.ToShortTimeString();

            #region CREO LA AYUDA
            StringBuilder textoAyuda = new StringBuilder();
            textoAyuda.AppendLine("Se podrán visualizar los tickets de compra y venta generados, ");
            textoAyuda.AppendLine("seleccionando uno del listbox se verá el detalle de factura en el richbox. ");
            FrmLogin.MostrarAyuda(this.lblPrintHelp, textoAyuda.ToString());
            #endregion
        }
        #endregion

        #region METODOS 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmHistorialVentas_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.rtbHistorial.ReadOnly = true;//-->No podrá escribir en el richtextbox

            //-->Cargo los nombres de los archivos que tengo en mi array de strings
            foreach (string archivo in this.archivos)
            {
                string nombreArchivo = ArchivoDeTexto.ObtenerNombreArchivo(archivo);//-->Retorna el nombre del archivo.

                //-->Lo agrego al listbox
                lstbArchivosNombres.Items.Add(nombreArchivo);
            }
        }

        /// <summary>
        /// Dependiendo del item seleccionado mostrare 
        /// la factura correspondiente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstbArchivosNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreArchivoSeleccionado = string.Empty;

            //-->En el item seleccionado le paso el nombre del archivo a la variabel
            nombreArchivoSeleccionado = lstbArchivosNombres.SelectedItem.ToString();

            //-->Obtengo la string de retorno del .txt
            string contenidoVenta = ArchivoDeTexto.LeerVenta(nombreArchivoSeleccionado);

            rtbHistorial.Text = contenidoVenta;//-->Muestro el retorno que es string en el richbox

            //-->Para que quede mas armonioso lo centro.
            this.rtbHistorial.SelectAll();
            this.rtbHistorial.SelectionAlignment = HorizontalAlignment.Center;
        }
        #endregion
    }
}
