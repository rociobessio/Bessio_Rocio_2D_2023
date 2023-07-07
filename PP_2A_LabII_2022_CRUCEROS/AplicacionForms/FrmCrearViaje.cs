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
    public partial class FrmCrearViaje : Form
    {
        #region ATRIBUTOS DEL FORM
        List<Crucero> listaCruceros;
        List<Viaje> listaViajes;
        Crucero cruceroElegido;
        int indexCrucero;
        bool validacionFecha = false;
        bool validacionViaje = false;
        #endregion

        #region CONSTRUCTORES DEL FORM
        public FrmCrearViaje()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor parametrizado del formulario.
        /// Me permite recibir del menu principal la lista de cruceros
        /// y de viajes.
        /// </summary>
        /// <param name="listaCruceros"></param>
        /// <param name="listaViajes"></param>
        public FrmCrearViaje(List<Crucero> listaCruceros, List<Viaje> listaViajes) : this()
        {
            this.listaCruceros = listaCruceros;
            this.listaViajes = listaViajes;
        }

        #endregion

        #region METODOS DEL FORM
        private void FrmCrearViaje_Load(object sender, EventArgs e)
        {
            this.cbCruceros.Items.Clear();

            //Recorro la lista de cruceros y al combo box le agrego sus nombres.
            foreach (Crucero item in this.listaCruceros)
            {
                this.cbCruceros.Items.Add(item.Nombre);
            }

            //Inicializo el radio button de destinos Regionales en true.
            this.rbRegional.Checked = true;
        }

        /// <summary>
        /// Compruebo si el radio button de Destinos Regionales esta checked (seleccionado)
        /// Limpio los items que ya estaban anteriormente en el combo box de Destinos.
        /// Por ultimo, cargo todos los destinos regionales y selecciono el primero.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbRegional_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbRegional.Checked == true)
            {
                this.cbDestino.Items.Clear();

                foreach (DestinoRegional destino in Enum.GetValues(typeof(DestinoRegional)))
                {
                    this.cbDestino.Items.Add((destino).ToString().Replace("_",",").Replace("1"," "));
                }

                this.cbDestino.SelectedItem = this.cbDestino.Items[0];
            }
        }

        /// <summary>
        /// Compruebo si el radio button de Destinos EXTRA Regionales esta checked (seleccionado)
        /// Limpio los items que ya estaban anteriormente en el combo box de Destinos.
        /// Por ultimo, cargo todos los destinos extra regionales y selecciono el primero.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbExtraRegional_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbExtraRegional.Checked == true)
            {
                this.cbDestino.Items.Clear();

                foreach (EDestinoExtraRegional destino in Enum.GetValues(typeof(EDestinoExtraRegional)))
                {
                    this.cbDestino.Items.Add((destino).ToString().Replace("_", ",").Replace("1", " "));
                }

                this.cbDestino.SelectedItem = this.cbDestino.Items[0];
            }
        }

        private void cbCruceros_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.indexCrucero = this.cbCruceros.SelectedIndex;
            this.cruceroElegido = this.listaCruceros[this.indexCrucero];

            this.cbFechaInicio.Items.Clear();
            this.cbFechaLlegada.Items.Clear();

            //Recorro la lista de viajes en busca de todos los viajes en los cuales participe
            //el crucero elegido. E informa las fechas de llegada y salida de dicho crucero.
            foreach (Viaje item in this.listaViajes)
            {
                if (item == this.cruceroElegido)
                {
                    this.cbFechaInicio.Items.Add(item.FechaSalida);
                    this.cbFechaLlegada.Items.Add(item.FechaVuelta);
                }
            }

            //Selecciona las fechas de salida y llegada del primer viaje que encuentre.
            if (this.cbFechaInicio.Items.Count != 0)
            {
                this.cbFechaInicio.SelectedItem = this.cbFechaInicio.Items[0];
                this.cbFechaLlegada.SelectedItem = this.cbFechaLlegada.Items[0];
            }
        }

        /// <summary>
        /// Si el radio button de viajes regionales esta en check (selccionado) recorre el
        /// combo box de Fecha de Inicio para verificar si es que el crucero tiene algun viaje cargado, 
        /// asi evita que este pueda ser seleccionadas las fechas del DataTimePicker en las que el crucero esta en viaje,
        /// ni tampoco las fechas anteriores hasta el maximo de dias que podria durar el viaje creado para evitar una superposicion.
        /// De seleccionar una fecha invalida aparece un mensaje de error avisandolo. En caso contrario se valida la fecha.
        /// El mismo proceso se realiza para los viajes Extra Regionales.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerFechaSalida_CloseUp(object sender, EventArgs e)
        {
            if (this.rbRegional.Checked == true)
            {
                for (int i = 0; i < this.cbFechaInicio.Items.Count; i++)
                {
                    if (this.dateTimePickerFechaSalida.Value.AddDays(Viaje.DuracionMaximaRegional / 24) > ((DateTime)this.cbFechaInicio.Items[i]) &&
                        this.dateTimePickerFechaSalida.Value < ((DateTime)this.cbFechaLlegada.Items[i]).AddDays(1))
                    {
                        MessageBox.Show("La fecha elegida, no esta disponible!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        this.validacionFecha = false;
                        break;
                    }
                    else
                    {
                        this.validacionFecha = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < this.cbFechaInicio.Items.Count; i++)
                {
                    if (this.dateTimePickerFechaSalida.Value.AddDays(Viaje.DuracionMaximaExtraRegional / 24) > ((DateTime)this.cbFechaInicio.Items[i]) &&
                        this.dateTimePickerFechaSalida.Value < ((DateTime)this.cbFechaLlegada.Items[i]).AddDays(1))
                    {
                        MessageBox.Show("La fecha elegida, no esta disponible!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.validacionFecha = false;
                        break;
                    }
                    else
                    {
                        this.validacionFecha = true;
                    }
                }
            }
        } 

        /// <summary>
        /// Si cambia la fecha de inicio del crucero se visualizara tambien
        /// la fecha de llegada en conjunto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFechaInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbFechaLlegada.SelectedIndex = this.cbFechaInicio.SelectedIndex;
        } 
        #endregion

        #region BOTONES DEL FORM
        /// <summary>
        /// Boton de ayuda para el usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este formulario permite crear un nuevo viaje. Se debe de elegir el crucero, la fecha de salida (dicha fecha no podra coincidir con alguna fecha ya ocupada por el mismo.) y su destino.","HELP",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        /// <summary>
        /// 1. En caso de que el crucero no tenga ningun viaje cargado no se debera de validar la fecha.
        /// 2.Verifica si se selecciono incorrectamente los Destinos, el Crucero o la Fecha.
        /// 3. Informa si hubo error.
        /// 4.En caso contrario verifica cual radio button esta en Check y crea un viaje nuevo.
        /// 5. Recorre el Enum de Destinos Regionales/Extra Regionales hasta encontrar el match con el seleccionado.
        /// 6. Si el viaje fue creado correctamente actualiza la lista de viajes del Form Index
        /// y cierra este formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearViaje_Click(object sender, EventArgs e)
        {
            if (this.cbFechaInicio.Items.Count == 0)//1
            {
                this.validacionFecha = true;
            }

            if (this.cbDestino.SelectedIndex == -1 || this.cbCruceros.SelectedIndex == -1
                || this.validacionFecha == false)//2
            {
                MessageBox.Show("Al menos uno de los datos ingresados es invalido, reintente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);//3
            }
            else
            {
                if (this.rbRegional.Checked == true)//4
                {
                    foreach (DestinoRegional item in Enum.GetValues(typeof(DestinoRegional)))//5
                    {
                        if (this.cbDestino.SelectedIndex == (int)item)
                        {
                            this.listaViajes.Add(new Viaje(this.dateTimePickerFechaSalida.Value, this.cruceroElegido, item));
                            this.validacionViaje = true;
                            break;
                        }
                    }
                }
                else
                {
                    foreach (EDestinoExtraRegional item in Enum.GetValues(typeof(EDestinoExtraRegional)))//5
                    {
                        if (this.cbDestino.SelectedIndex == (int)item)
                        {
                            this.listaViajes.Add(new Viaje(this.dateTimePickerFechaSalida.Value, this.cruceroElegido, item));
                            this.validacionViaje = true;
                            break;
                        }
                    }
                }

                if (this.validacionViaje)//6
                {
                    this.validacionFecha = false;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }


        /// <summary>
        /// Al presionar el boton 'CANCELAR' me permite cerrar este formulario
        /// y volver al menu principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
