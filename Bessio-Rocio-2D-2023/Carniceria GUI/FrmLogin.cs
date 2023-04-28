using Entidades;
using Microsoft.VisualBasic.Logging;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Carniceria_GUI
{
    public partial class FrmLogin : Form
    {
        #region ATRIBUTOS 
        private List<Cliente> clientes;
        private Cliente cliente;
        private List<Vendedor> vendedores;
        private Vendedor vendedor;
        private Persona ingresante;

        private FrmHeladera frmHeladera;
        #endregion


        public FrmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            #region INSTANCIO CLIENTES
            clientes = new List<Cliente>();
            cliente = new Cliente("rocibessio@gmail.com", "123");
            clientes.Add(cliente);
            #endregion

            #region INSTANCIO VENDEDORES
            vendedores = new List<Vendedor>();
            vendedor = new Vendedor("felipe@hotmail.com", "123");
            vendedores.Add(vendedor);//-->Asi lo puedo enviar al formulario si presiona el boton.
            vendedores.Add(new Vendedor("Lucas@yahoo.com.ar", "123"));
            #endregion

            #region INSTANCIO FORMULARIOS
            //frmHeladera = new FrmHeladera(vendedor);//-->Le paso a Felipe
            #endregion

            #region CREO LA AYUDA
            StringBuilder textoAyuda = new StringBuilder();
            textoAyuda.AppendLine("Podrás iniciar sesión ingresando tu email y contraseña ");
            textoAyuda.AppendLine("o directamente presionando alguno de los botones de Vendedor o Cliente para agilizar el proceso");
            FrmLogin.MostrarAyuda(this.lblPrintHelp, textoAyuda.ToString());
            #endregion
        }

        /// <summary>
        /// En el evento load cargo las listas de los vendedores y clientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "App Carnicería";
        }

        #region VALIDACIONES
        /// <summary>
        /// Me permite validar los textboxes del formulario.
        /// Imprime un Message box con el msj de error.
        /// </summary>
        /// <returns>Retorna true si no hay error.</returns>
        private bool ValidarCampos()
        {
            bool puede = true;
            StringBuilder sb = new StringBuilder();
            //Chequeo que complete los campos
            if (string.IsNullOrEmpty(this.txtEmail.Text) ||
                string.IsNullOrEmpty(this.txtContrasenia.Text))
            {
                sb.Append("FALTO COMPLETAR ALGUN CAMPO.");
                puede = false;
            }

            //Si no es true debo mostrar un MessageBox
            if (!puede)
            {
                MessageBox.Show(sb.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return puede;
        }

        /// <summary>
        /// Metodo privado del formulario.
        /// Recibe dos strings, email y password.
        /// Instacio un usuario con el usuario recibido y recorro cada lista (ya que cuento
        /// con dos perfiles en la app) buscando si coincide el usuario instanciado con alguno de la lista,
        /// si hay coincidencia lo retorno, pero como debo retornar uno o el otro retorno una Persona, ya que
        /// ambos (Cliente y Vendedor) heredan de esta.
        /// 
        /// Utilizo la sobrecarga del == de mi clase Usuario.
        /// </summary>
        /// <param name="usuario"></param> 
        /// <returns>Retorna a una persona (la cual puede ser del tipo Vendedor o Cliente), null sino es ninguna</returns>
        private Persona esValidoElUsuario(Usuario usuario)
        {
            foreach (Vendedor vendedorAux in vendedores)
            {
                if (vendedorAux.Usuario == usuario)
                {
                    return vendedorAux;
                }
            }

            foreach (Cliente clienteAux in clientes)
            {
                if (clienteAux.Usuario == usuario)
                {
                    return clienteAux;
                }
            }
            return null;
        }

        /// <summary>
        /// Este metodo privado del formulario me permite principalmente verificar que Persona
        /// no sea nulo, llamo al metodo esValidoElUsuario(), si una persona != null entonces
        /// puede abrir otro formulario.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        private bool PuedeSeguir(Usuario usuario)
        {
            bool retorno = false;//No puede
            ingresante = this.esValidoElUsuario(usuario);//-->Retorna el tipo de Persona

            if (ingresante != null)//-->Verifico que sea distinta de null
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion

        #region BOTONES DEL FORM
        /// <summary>
        /// Al presionar este boton se realizan las validaciones necesarias para, de
        /// esta manera poder abrir el form correspondiente dependiendo de la Entidad
        /// que corresponda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(this.txtEmail.Text, this.txtContrasenia.Text);
            bool ingresaraONo = this.PuedeSeguir(usuario);

            if (ValidarCampos())//-->Verifico que haya ingresado email y contraseña
            {
                if (!ingresaraONo)//-->Si no puede ingresar.
                {
                    MessageBox.Show("Ocurrio un error con los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ingresante.EsCliente)//-->Utilizo la propiedad para saber si es Cliente
                    {
                        MessageBox.Show("Sos cliente");
                    }
                    else //-->Si no lo es, quiere decir que es Vendedor
                    {
                        MessageBox.Show("Sos Vendedor");
                        frmHeladera = new FrmHeladera(vendedor);//-->Le paso a Felipe
                        frmHeladera.ShowDialog();
                        this.Hide();
                    }
                }
            }
        }

        /// <summary>
        /// Le preguntara al usuario si realmente desea cerrar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea salir?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.No == respuesta)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Este metodo estatico me permite mostrarle una ayuda al usuario para que sepa
        /// que hacer.
        /// 
        /// Utilizo la herramienta ToolTip, la cual mostrara como un MessageBox 
        /// imprimiendo el mensaje de ayuda o guia para el usuario.
        /// 
        /// Cada vez que el cursor se pare sobre el icono se mostrara la burbuja con el
        /// mensaje.
        /// </summary>
        /// <param name="etiqueta"></param>
        /// <param name="mensaje"></param>
        public static void MostrarAyuda(Label etiqueta, string mensaje)
        {
            ToolTip yourToolTip = new ToolTip();
            yourToolTip.ToolTipIcon = ToolTipIcon.Info;//-->Icono de la buble
            yourToolTip.IsBalloon = true;//-->Que tenga formato "burbuja" sino por default sera ventana
            yourToolTip.ShowAlways = true;//-->Que siempre lo muestra
            yourToolTip.SetToolTip(etiqueta, mensaje);//-->Lo seteo.
        }
        #endregion

        /// <summary>
        /// Al presionarlo me cargara en el texbox los datos del Vendedor 
        /// hardcodeado que cree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVendedor_Click(object sender, EventArgs e)
        {
            this.txtContrasenia.Text = this.vendedor.Usuario.Contrasenia;
            this.txtEmail.Text = this.vendedor.Usuario.Email;
        }

        /// <summary>
        /// Al presionarlo me cargara en el texbox los datos del cliente 
        /// hardcodeado que cree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.txtContrasenia.Text = this.cliente.Usuario.Contrasenia;
            this.txtEmail.Text = this.cliente.Usuario.Email;
        }
    }
}