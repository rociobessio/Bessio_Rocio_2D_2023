using Entidades;
using Microsoft.VisualBasic.Logging;
using System.Media;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Excepciones;

namespace Carniceria_GUI
{
    public partial class FrmLogin : Form
    {
        #region ATRIBUTOS  
        private Cliente clientePrueba; 
        private Persona ingresante;
        private Usuario vendedorHardcodeado;

        private FrmMenuPrincipalVendedor frmMenuPrincipalVendedor; 
        private FrmMetodoDePago frmMetodoDePago;
        private SoundPlayer soundPlayer;
        private UsuariosDAO usuariosDAO;
        private List<Usuario> listaUsuarios;
        #endregion

        public FrmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.usuariosDAO = new UsuariosDAO();
            this.listaUsuarios = new List<Usuario>(); 

            #region INSTANCIO USUARIOS
            this.listaUsuarios = new List<Usuario>();
            listaUsuarios = usuariosDAO.ObtenerLista();
            #endregion

            #region INSTANCIO SOUNDPLAYER
            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = "LoginUnlocked.wav";
            #endregion

            #region CREO LA AYUDA
            StringBuilder textoAyuda = new StringBuilder();
            textoAyuda.AppendLine("Podrás iniciar sesión ingresando tu email y contraseña ");
            textoAyuda.AppendLine("o directamente presionando alguno de los botones de Vendedor o Cliente para agilizar el proceso");
            FrmLogin.MostrarAyuda(this.lblPrintHelp, textoAyuda.ToString());
            #endregion
        }

        /// <summary>
        /// En el evento load le cambio el nombre al form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Felices las vacas";
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
            //-->Creo un usuario con los datos del textboxes 
            UsuariosDAO usuariosDAO = new UsuariosDAO();
            bool esCliente;
            ClienteDAO clienteDAO = new ClienteDAO();

            try
            {
                if (ValidarCampos())//-->Verifico que haya ingresado email y contraseña
                {
                    bool pasa = usuariosDAO.VerificarUser(this.txtEmail.Text, this.txtContrasenia.Text, out esCliente);

                    if (!pasa)//-->Lanzo una excepcion propia sino es valido el usuario
                    {
                        throw new IngresoUsuarioException("Ocurrio un error al verificar usuario, reintente.");
                    }
                    else
                    {
                        if (esCliente)//-->Utilizo la propiedad abstracta para saber si es Cliente
                        {
                            this.BackColor = Color.DarkKhaki;
                            soundPlayer.Play();
                            Cliente cliente = clienteDAO.ObtenerPorEmail(this.txtEmail.Text);
                            frmMetodoDePago = new FrmMetodoDePago(cliente);
                            frmMetodoDePago.Show();
                        }
                        else//-->Si no lo es, quiere decir que es Vendedor
                        {
                            this.BackColor = Color.MediumPurple;
                            soundPlayer.Play();
                            frmMenuPrincipalVendedor = new FrmMenuPrincipalVendedor(
                                                       new Usuario(this.txtEmail.Text, this.txtContrasenia.Text));
                            frmMenuPrincipalVendedor.Show();
                        }
                    }
                }
            }
            catch (IngresoUsuarioException ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salio mal.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        /// <summary>
        /// Al presionarlo me cargara en el texbox los datos del Vendedor 
        /// hardcodeado que cree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVendedor_Click(object sender, EventArgs e)
        {
            this.vendedorHardcodeado = new Usuario("felipeBG@gmail.com","123");
            this.txtContrasenia.Text = this.vendedorHardcodeado.Contrasenia;
            this.txtEmail.Text = this.vendedorHardcodeado.Email;
            this.BackColor = Color.MediumPurple;
        }

        /// <summary>
        /// Al presionarlo me cargara en el texbox los datos del cliente 
        /// hardcodeado que cree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.txtContrasenia.Text = "123";
            this.txtEmail.Text = "rocibessio@gmail.com";
            this.BackColor = Color.DarkKhaki;
        }
        #endregion 
    }
}