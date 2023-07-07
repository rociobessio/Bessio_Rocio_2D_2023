using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNIDAD_06_ENTIDADES;

namespace EJERCICIO_C03_UNIDAD_06_GUI
{
    public partial class FrmBuffet : Form
    {
        #region ATRIBUTOS
        Queue<string> filaClientes;
        List<Producto> pedido;
        List<Producto> mesaBuffet;
        FrmAddCliente frmAddCliente;
        #endregion


        public FrmBuffet()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.tbIngresoNumero.Enabled = false;//Para que no ingrese nada en el textbox

            #region INSTACIO OBJETOS
            filaClientes = new Queue<string>();
            filaClientes.Enqueue("Homero");
            filaClientes.Enqueue("Marge");
            filaClientes.Enqueue("Flanders");
            filaClientes.Enqueue("Barni");
            filaClientes.Enqueue("Carl");

            pedido = new List<Producto>();
            frmAddCliente = new FrmAddCliente();

            mesaBuffet = new List<Producto>();
            mesaBuffet.Add(new Producto("Sanguche de Carne", 160));
            mesaBuffet.Add(new Producto("Taco", 120));
            mesaBuffet.Add(new Producto("Nachos", 50));
            mesaBuffet.Add(new Producto("Pancho", 60));
            mesaBuffet.Add(new Producto("Sopa", 40));
            #endregion
        }

        private void FrmBuffet_Load(object sender, EventArgs e)
        {
            this.Text = "La simpsonita buffet";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.tbIngresoNumero.Clear();
        }

        #region BOTONES NUMEROS
        private void btnNum1_Click(object sender, EventArgs e)
        {
            this.tbIngresoNumero.Text += "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            this.tbIngresoNumero.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            this.tbIngresoNumero.Text += "3";
        }

        private void brnNum4_Click(object sender, EventArgs e)
        {
            this.tbIngresoNumero.Text += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            this.tbIngresoNumero.Text += "5";
        }
        #endregion

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.tbIngresoNumero.Text))
            {
                int opcionProducto = int.Parse(this.tbIngresoNumero.Text);//Obtengo el numero 

                if (opcionProducto > 5)
                {
                    this.lblInformacionExpendedora.Text = "Producto inexistente.";
                }
                else if (mesaBuffet.Count > 0 && filaClientes.Count > 0)
                {

                }
                else if (filaClientes.Count == 0)
                {
                    //BONUS: Al terminar de atender a los clientes, informarlo y preguntar si se quiere agregar clientes a la cola.
                    if (MessageBox.Show("No hay más clientes en la fila, ¿Desea añadir a otro?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmAddCliente.ShowDialog();
                        filaClientes.Enqueue(frmAddCliente.DevolverNombre);
                    }
                    else
                    {
                        MessageBox.Show("MAQUINA CERRADA POR FALTA DE CLIENTES!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else if(opcionProducto <= mesaBuffet.Count)
                {
                    string clienteAtendido = filaClientes.Peek();//Obtengo al cliente. pedido.Add(mesaBuffet[opcionProducto-1]);
                    mesaBuffet[opcionProducto - 1].Cantidad--;//Resto la cant del producto

                   /* this.lblInformacionExpendedora.Text = ($"{clienteAtendido} eligió el producto: {productoSeleccionado.Nombre}" +
                            $" - ${productoSeleccionado.Precio} - {productoSeleccionado.Codigo}");*/
                    filaClientes.Dequeue();//Quito al primer cliente de la fila, Cada cliente atendido debe ser borrado de la cola
                }
            }
        }

        private void EliminarFoto(int numeroOpcion)
        {
            if (numeroOpcion == 1)
            {
                this.pictureBoxTacos.Visible = false;
            }
            else if (numeroOpcion == 2)
            {
                this.pictureBoxSoup.Visible = false;
            }
            else if (numeroOpcion == 3)
            {
                this.pictureBoxTacos.Visible = false;
            }
            else if (numeroOpcion == 4)
            {
                this.pictureBoxPancho.Visible = false;
            }
            else if (numeroOpcion == 5)
            {
                this.pictureBoxSanguche.Visible = false;
            }
        }
    }
}
