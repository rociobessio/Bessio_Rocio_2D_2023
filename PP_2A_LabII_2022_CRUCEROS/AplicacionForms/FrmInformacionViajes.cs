using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AplicacionForms
{
    public partial class FrmInformacionViajes : Form
    {
        #region ATRIBUTOS FORM
        List<Viaje> listaViajes;
        Viaje viajeAux;
        int indiceViajeSeleccionado;
        int filtroContador;
        #endregion

        #region CONSTRUCTORES DEL FORM
        /// <summary>
        /// Constructor por defecto del formulario.
        /// </summary>
        public FrmInformacionViajes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor parametrizado que recibe la lista de viajes.
        /// </summary>
        /// <param name="listaViajes"></param>
        public FrmInformacionViajes(List<Viaje> listaViajes) : this()
        {
            this.listaViajes = listaViajes;
        }
        #endregion

        #region METODOS/EVENTOS DEL FORM
        /// <summary>
        /// Carga en el combo box los viajes que hay en la lista y selecciona el indice
        /// del viaje seleccionado en el frmMenu.
        /// Tambien carga las nacionalidades en el combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmInformacionViajes_Load(object sender, EventArgs e)
        {
            foreach (Nacionalidades nacionalidades in Enum.GetValues(typeof(Nacionalidades)))
            {
                this.cbNacionalidad.Items.Add(nacionalidades);
            }

            foreach (Viaje viaje in this.listaViajes)
            {
                this.cbViajes.Items.Add($"Viaje de {viaje.CiudadPartida} hasta {viaje.Destino} de día {viaje.FechaSalida:d} con el crucero {viaje.Crucero.Nombre}");
            }

            this.cbViajes.SelectedIndex = indiceViajeSeleccionado;
        }

        /// <summary>
        /// LLamado desde el frmMenu para almacenar el valor del viaje
        /// seleccionado.
        /// </summary>
        /// <param name="i"></param>
        public void ConseguirIndicePrimerViaje(int i)
        {
            this.indiceViajeSeleccionado = i;
        }
        
        /// <summary>
        /// 1. Limpiar los text box.
        /// 2. Recorre la lista de pasajeros del viaje seleccionado,
        ///    imprime los pasajeros pares en el text box de la izq. y los impares
        ///    en la derecha.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TodosLosPasajeros(object sender,EventArgs e)
        {
            //1
            this.txtPasajeros1.Clear();
            this.txtPasajeros2.Clear();

            //2
            for (int i = 0; i < viajeAux.ListaPasajeros.Count; i++)
            {
                if (i % 2 == 0)//par
                {
                    this.txtPasajeros1.Text += viajeAux.ListaPasajeros[i].ToString();
                }
                else//impar
                {
                    this.txtPasajeros2.Text += viajeAux.ListaPasajeros[i].ToString();
                }
            }
        }
        
        /// <summary>
        /// Imprime en los text box la sobrecarga de ToString() de su viaje y crucero.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbViajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            viajeAux = listaViajes[cbViajes.SelectedIndex];

            this.txtViajes.Text = viajeAux.ToString();
            this.txtCrucero.Text = viajeAux.Crucero.ToString();

            TodosLosPasajeros(sender,e);
        }
        private void FrmInformacionViajes_FormClosing(object sender, FormClosingEventArgs e)
        { 
            if (MessageBox.Show("¿Desea cerrar el formulario?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region BOTONES DEL FORM
        /// <summary>
        /// 1. Comprueba de que no se hayan ingresado solo espacios
        /// 2. Limpia los text box y reinicia el contador.
        /// 3. Recorre la lista de pasajeros del viaje seleccionado
        ///    y busca si alguno de sus pasajeros inicia su apellido con lo
        ///    ingresado en el textbox Apellido De ser así imprime los pares 
        ///    en el textbox de la izquierda y los pares en el de la derecha.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApellido_Click(object sender, EventArgs e)
        {
            //1
            if (textBoxApellido.Text.Trim().Length > 0)
            {
                //2
                txtPasajeros1.Clear();
                txtPasajeros2.Clear();
                filtroContador = 0;

                //3
                for (int i = 0; i < viajeAux.ListaPasajeros.Count; i++)
                {
                    if (viajeAux.ListaPasajeros[i].Apellido.Contains(textBoxApellido.Text.Trim()))
                    {
                        if (filtroContador % 2 == 0)
                        {
                            txtPasajeros1.Text += viajeAux.ListaPasajeros[i].ToString();
                        }
                        else
                        {
                            txtPasajeros2.Text += viajeAux.ListaPasajeros[i].ToString();
                        }
                        filtroContador++;
                    }
                }
            }
        }

        /// <summary>
        /// 1. Comprueba que NO se hayan ingresado solo espacios.
        /// 2. Limpia los text box y reinicia el contador.
        /// 3. Recorre la lista de pasajeros del viaje seleccionado y busca 
        ///    si alguno de sus pasajeros inicia su dni con lo ingresado en 
        ///    el textbox DNI, de ser así imprime los pares en el textbox de
        ///    la izquierda y los impares en el de la derecha.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDNI_Click(object sender, EventArgs e)
        {
            if (this.textBoxDNI.Text.Trim().Length > 0)//1
            {
                //2
                txtPasajeros1.Clear();
                txtPasajeros2.Clear();
                filtroContador = 0;

                //3
                for (int i = 0; i < viajeAux.ListaPasajeros.Count; i++)
                {
                    if (viajeAux.ListaPasajeros[i].Dni.ToString().Contains(textBoxDNI.Text.Trim()))
                    {
                        if (filtroContador % 2 == 0)
                        {
                            txtPasajeros1.Text += viajeAux.ListaPasajeros[i].ToString(); 
                        }
                        else
                        {
                            txtPasajeros2.Text += viajeAux.ListaPasajeros[i].ToString();
                        }
                        filtroContador++;
                    }
                }
            }
        }

        /// <summary>
        /// 1. Limpia los text box y resetea el contador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNacionalidad_Click(object sender, EventArgs e)
        {

            if (this.cbNacionalidad.SelectedIndex != -1)
            {
                txtPasajeros1.Clear();
                txtPasajeros2.Clear();
                filtroContador = 0;

                for (int i = 0; i < viajeAux.ListaPasajeros.Count; i++)
                {
                    if (viajeAux.ListaPasajeros[i].Nacionalidad.Contains(this.cbNacionalidad.SelectedItem.ToString()))
                    {
                        if (filtroContador % 2 == 0)
                        {
                            txtPasajeros1.Text += viajeAux.ListaPasajeros[i].ToString();
                        }
                        else
                        {
                            txtPasajeros2.Text += viajeAux.ListaPasajeros[i].ToString();
                        }
                    }
                    filtroContador++;
                }
            }
        }

        /// <summary>
        /// Al presionar el boton me permite limpiar los text box y
        /// el combo box de los filtros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSacarFiltro_Click(object sender, EventArgs e)
        {
            this.textBoxDNI.Text = "";
            this.textBoxApellido.Text = "";
        }

        #endregion


    }
}
