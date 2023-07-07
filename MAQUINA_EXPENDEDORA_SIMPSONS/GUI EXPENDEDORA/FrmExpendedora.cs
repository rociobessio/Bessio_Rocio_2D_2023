using System.Drawing;
using System.Media;
using UNIDAD_06_ENTIDADES;

namespace EJERCICIO_C03_UNIDAD_06_GUI
{
    public partial class FrmExpendedora : Form
    {
        #region ATRIBUTOS
        SoundPlayer soundPlayer;
        SoundPlayer soundPlayerVendingMachine;
        FrmAddCliente frmAddCliente;

        Dictionary<int, Stack<Producto>> maquinaExpendedora;
        Stack<Producto> nukaKolaPremium;
        Stack<Producto> donuts;
        Stack<Producto> nerds;
        Stack<Producto> icedNukaKola;
        Stack<Producto> fanta;
        Stack<Producto> sourPatch;
        Stack<Producto> skittles;
        Stack<Producto> haribo;
        Stack<Producto> kitkat;
        Stack<Producto> oreo;
        Stack<Producto> cheetos;
        Stack<Producto> onionLays;
        Stack<Producto> sweetTarts;
        Stack<Producto> wonkaSpree;
        Stack<Producto> wavyLays;
        Stack<Producto> kinderSurprise;

        Queue<string> filaClientes;
        #endregion
        public FrmExpendedora()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            #region INSTANCIO PRODUCTOS 
            nukaKolaPremium = new Stack<Producto>();
            nukaKolaPremium.Push(new Producto("NUKA-KOLA PREMIUM", 130));//El PUSH me permite AÑADIR un objeto al principio de la pila
            nukaKolaPremium.Push(new Producto("NUKA-KOLA PREMIUM", 130));
            nukaKolaPremium.Push(new Producto("NUKA-KOLA PREMIUM", 130));

            nerds = new Stack<Producto>();
            nerds.Push(new Producto("NERDS", 90));//El PUSH me permite AÑADIR un objeto al principio de la pila
            nerds.Push(new Producto("NERDS", 90));
            nerds.Push(new Producto("NERDS", 90));

            donuts = new Stack<Producto>();
            donuts.Push(new Producto("DONUTS", 20));//El PUSH me permite AÑADIR un objeto al principio de la pila
            donuts.Push(new Producto("DONUTS", 20));
            donuts.Push(new Producto("DONUTS", 20));

            icedNukaKola = new Stack<Producto>();
            icedNukaKola.Push(new Producto("ICED NUKA-KOLA", 100));
            icedNukaKola.Push(new Producto("ICED NUKA-KOLA", 100));
            icedNukaKola.Push(new Producto("ICED NUKA-KOLA", 100));

            fanta = new Stack<Producto>();
            fanta.Push(new Producto("FANTA", 70));
            fanta.Push(new Producto("FANTA", 70));
            fanta.Push(new Producto("FANTA", 70));

            sourPatch = new Stack<Producto>();
            sourPatch.Push(new Producto("SOUR PATCH", 45));
            sourPatch.Push(new Producto("SOUR PATCH", 45));
            sourPatch.Push(new Producto("SOUR PATCH", 45));

            skittles = new Stack<Producto>();
            skittles.Push(new Producto("SKITTLES", 28));
            skittles.Push(new Producto("SKITTLES", 28));
            skittles.Push(new Producto("SKITTLES", 28));

            kitkat = new Stack<Producto>();
            kitkat.Push(new Producto("KIT-KAT", 90));
            kitkat.Push(new Producto("KIT-KAT", 90));
            kitkat.Push(new Producto("KIT-KAT", 90));

            haribo = new Stack<Producto>();
            haribo.Push(new Producto("HARIBO", 16));
            haribo.Push(new Producto("HARIBO", 16));
            haribo.Push(new Producto("HARIBO", 16));

            oreo = new Stack<Producto>();
            oreo.Push(new Producto("OREO ORIGINAL", 70));
            oreo.Push(new Producto("OREO ORIGINAL", 70));
            oreo.Push(new Producto("OREO ORIGINAL", 70));

            cheetos = new Stack<Producto>();
            cheetos.Push(new Producto("FLAMING CHEETOS", 100));
            cheetos.Push(new Producto("FLAMING CHEETOS", 100));
            cheetos.Push(new Producto("FLAMING CHEETOS", 100));

            onionLays = new Stack<Producto>();
            onionLays.Push(new Producto("ONION LAYS", 100));
            onionLays.Push(new Producto("ONION LAYS", 100));
            onionLays.Push(new Producto("ONION LAYS", 100));

            sweetTarts = new Stack<Producto>();
            sweetTarts.Push(new Producto("SWEET TARTS", 68));
            sweetTarts.Push(new Producto("SWEET TARTS", 68));
            sweetTarts.Push(new Producto("SWEET TARTS", 68));

            wonkaSpree = new Stack<Producto>();
            wonkaSpree.Push(new Producto("WONKA SPREE", 55));
            wonkaSpree.Push(new Producto("WONKA SPREE", 55));
            wonkaSpree.Push(new Producto("WONKA SPREE", 55));

            wavyLays = new Stack<Producto>();
            wavyLays.Push(new Producto("WAVY LAYS", 100));
            wavyLays.Push(new Producto("WAVY LAYS", 100));
            wavyLays.Push(new Producto("WAVY LAYS", 100));

            kinderSurprise = new Stack<Producto>();
            kinderSurprise.Push(new Producto("KINDER SURPRISE", 120));
            kinderSurprise.Push(new Producto("KINDER SURPRISE", 120));
            kinderSurprise.Push(new Producto("KINDER SURPRISE", 120));

            maquinaExpendedora = new Dictionary<int, Stack<Producto>>();
            //int (posición en la máquina),Stack<Producto> (una pila con los productos que van en cada “resorte”)
            maquinaExpendedora.Add(1, nukaKolaPremium);
            maquinaExpendedora.Add(2, donuts);
            maquinaExpendedora.Add(3, icedNukaKola);
            maquinaExpendedora.Add(4, fanta);
            maquinaExpendedora.Add(5, sourPatch);
            maquinaExpendedora.Add(6, skittles);
            maquinaExpendedora.Add(7, kitkat);
            maquinaExpendedora.Add(8, haribo);
            maquinaExpendedora.Add(9, oreo);
            maquinaExpendedora.Add(10, nerds);
            maquinaExpendedora.Add(11, cheetos);
            maquinaExpendedora.Add(12, onionLays);
            maquinaExpendedora.Add(13, sweetTarts);
            maquinaExpendedora.Add(14, wonkaSpree);
            maquinaExpendedora.Add(15, wavyLays);
            maquinaExpendedora.Add(16, kinderSurprise);
            #endregion

            #region INSTACION CLIENTES
            filaClientes = new Queue<string>();
            filaClientes.Enqueue("CAMILO");
            filaClientes.Enqueue("SOLEDAD");
            filaClientes.Enqueue("MATIAS");
            filaClientes.Enqueue("NATALIA");
            filaClientes.Enqueue("JOSÉ");
            #endregion

            #region INSTACION OTROS
            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = "C:/Users/Rocio/Desktop/C#/EJERCICIOS 2023/UTN_LABORATORIO_GUIA_2023/LABORATORIO EJERCICIOS 2023/Bessio.Rocio.2023/Imagenes-Iconos-Sonidos/SuperMario.wav";
            frmAddCliente = new FrmAddCliente();
            soundPlayerVendingMachine = new SoundPlayer();
            soundPlayerVendingMachine.SoundLocation = "C:/Users/Rocio/Desktop/C#/EJERCICIOS 2023/UTN_LABORATORIO_GUIA_2023/LABORATORIO EJERCICIOS 2023/Bessio.Rocio.2023/Imagenes-Iconos-Sonidos/cashSound.wav";
            #endregion
        }

        private void FrmExpendedora_Load(object sender, EventArgs e)
        {
            soundPlayer.PlayLooping();

            this.Text = "La simpsonita";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            this.tbIngresoNumero.Enabled = false;//Para que no ingrese nada en el textbox
        }

        private void btnSoundOff_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
        }

        private void btnSoundOn_Click(object sender, EventArgs e)
        {
            soundPlayer.PlayLooping();
        }

        #region BOTONES NUMEROS
        /// <summary>
        /// Imprimo en el textbox el numero 1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNum1_Click(object sender, EventArgs e)
        {
            this.tbIngresoNumero.Text += "1";
        }

        /// <summary>
        /// Imprimo en el textbox el numero 2.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNum2_Click(object sender, EventArgs e)
        {
            this.tbIngresoNumero.Text += "2";
        }

        /// <summary>
        /// Imprimo en el textbox el numero 3.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNum3_Click(object sender, EventArgs e)
        {
            this.tbIngresoNumero.Text += "3";
        }

        /// <summary>
        /// Imprimo en el textbox el numero 4.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void brnNum4_Click(object sender, EventArgs e)
        {
            this.tbIngresoNumero.Text += "4";
        }

        /// <summary>
        /// Imprimo en el textbox el numero 5.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNum5_Click(object sender, EventArgs e)
        {
            this.tbIngresoNumero.Text += "5";
        }

        /// <summary>
        /// Imprimo en el textbox el numero 6.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNum6_Click(object sender, EventArgs e)
        {
            this.tbIngresoNumero.Text += "6";
        }

        /// <summary>
        /// Imprimo en el textbox el numero 7.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNum7_Click(object sender, EventArgs e)
        {
            this.tbIngresoNumero.Text += "7";
        }

        /// <summary>
        /// Imprimo en el textbox el numero 8.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNum8_Click(object sender, EventArgs e)
        {
            this.tbIngresoNumero.Text += "8";
        }

        /// <summary>
        /// Imprimo en el textbox el numero 9.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNum9_Click(object sender, EventArgs e)
        {
            this.tbIngresoNumero.Text += "9";
        }

        /// <summary>
        /// Imprimo en el textbox el numero 0.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNum0_Click(object sender, EventArgs e)
        {
            this.tbIngresoNumero.Text += "0";
        }
        #endregion

        #region BOTONES
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.tbIngresoNumero.Text))
            {
                int opcionMaquina = int.Parse(this.tbIngresoNumero.Text);//Obtengo la opcion ingresada

                if (maquinaExpendedora.Count > 0)
                {
                    //Si la opcion d la maquina no tiene mas productos la quito de la maquina directamente
                    if (opcionMaquina > 16 || opcionMaquina == 0)
                    {
                        this.lblInformacionExpendedora.Text = "Error el producto ya no existe.";
                    }
                    else if(maquinaExpendedora[opcionMaquina].Count == 0)
                    {
                        maquinaExpendedora.Remove(opcionMaquina);//Le paso la key a eliminar de la maquina expendedora
                        this.lblInformacionExpendedora.Text = "Error el producto ya no esta disponible.";
                        this.EliminarFoto(opcionMaquina);
                    }
                    else if (filaClientes.Count == 0)
                    {
                        //BONUS: Al terminar de atender a los clientes, informarlo y preguntar si se quiere agregar clientes a la cola.
                        if (MessageBox.Show("No hay más clientes en la fila, ¿Desea añadir a otro?","Información",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                        {
                            frmAddCliente.ShowDialog();
                            filaClientes.Enqueue(frmAddCliente.DevolverNombre);
                        }
                        else
                        {
                            MessageBox.Show("MAQUINA CERRADA POR FALTA DE CLIENTES!","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        string clienteAtendido = filaClientes.Peek();//Obtengo al cliente.
                        this.lblNombreCliente.Text = clienteAtendido;

                        Producto productoSeleccionado = maquinaExpendedora[opcionMaquina].Pop();//Obtengo el objeto

                        this.lblInformacionExpendedora.Text = ($"{clienteAtendido} eligió el producto: {productoSeleccionado.Nombre}" +
                                $" - ${productoSeleccionado.Precio} - {productoSeleccionado.Codigo}");
                        soundPlayerVendingMachine.Play();
                        filaClientes.Dequeue();//Quito al primer cliente de la fila, Cada cliente atendido debe ser borrado de la cola
                    }
                }
            }
            else
            {
                MessageBox.Show("Se debe ingresar una opción", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Me borra el contenido impreso en el textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.tbIngresoNumero.Clear();
        }
        #endregion

        /// <summary>
        /// Metodo temporal, elimina la foto del producto si este no existe.
        /// </summary>
        /// <param name="numeroOpcion"></param>
        private void EliminarFoto(int numeroOpcion)
        {
            if (numeroOpcion == 1)
            {
                this.pictureBoxNukaColaPremium.Visible = false;
            }
            else if (numeroOpcion == 2)
            {
                this.pictureBoxDonut.Visible = false;
            }
            else if (numeroOpcion == 3)
            {
                this.pictureBoxNukaColaNormal.Visible = false;
            }
            else if (numeroOpcion == 4)
            {
                this.pictureBoxFanta.Visible = false;
            }
            else if (numeroOpcion == 5)
            {
                this.pictureBoxSourPatch.Visible = false;
            }
            else if (numeroOpcion == 6)
            {
                this.pictureBoxSkittles.Visible = false;
            }
            else if (numeroOpcion == 7)
            {
                this.pictureBoxKitKat.Visible = false;
            }
            else if (numeroOpcion == 8)
            {
                this.pictureBoxHaribo.Visible = false;
            }
            else if (numeroOpcion == 9)
            {
                this.pictureBoxOreos.Visible = false;
            }
            else if (numeroOpcion == 10)
            {
                this.pictureBoxNerds.Visible = false;
            }
            else if (numeroOpcion == 11)
            {
                this.pictureBoxCheetos.Visible = false;
            }
            else if (numeroOpcion == 12)
            {
                this.pictureBoxLaysBacon.Visible = false;
            }
            else if (numeroOpcion == 13)
            {
                this.pictureBoxSweetTarts.Visible = false;
            }
            else if (numeroOpcion == 14)
            {
                this.pictureBoxWonkaSpree.Visible = false;
            }
            else if (numeroOpcion == 15)
            {
                this.pictureBoxLaysWavy.Visible = false;
            }
            else if (numeroOpcion == 16)
            {
                this.pictureBoxKinder.Visible = false;
            }
        }




    }
}