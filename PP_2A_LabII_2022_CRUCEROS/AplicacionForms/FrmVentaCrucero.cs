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
    public partial class FrmVentaCrucero : Form
    {
        #region ATRIBUTOS DEL FORM
        List<Crucero> listaCruceros;
        List<Viaje> listaViajes;
        int canSpasSeleccionados;
        int cantCasinosSeleccionados;
        int cantComedoresSeleccionados;
        int cantPiscinasSeleccionados;
        int cantGimnasiosSeleccionados;
        int cantSPASSeleccionados;
        bool seguroCerrar = false;
        double ivaTurista;
        double ivaPremium;
        Crucero cruceroSeleccionado;
        Viaje viajeSeleccionado;
        Pasajero pasajeroNuevo;
        string nombrePasajero;
        string apellidoPasajero;
        string nacionalidadString;
        Genero generoPasajero;
        Tipo tipoPasaportePasajero;
        Clase clasePasajero;
        bool camaroteDisponiblePasajero = false;
        #endregion

        #region CONSTRUCTORES DEL FORM
        /// <summary>
        /// Constructor por defecto del frmVentaCrucero.
        /// </summary>
        public FrmVentaCrucero()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor parametrizado del frmVentaCrucero.
        /// Recibe la lista con los viajes y la lista de cruceros.
        /// </summary>
        /// <param name="listaCruceros"></param>
        /// <param name="listaViajes"></param>
        public FrmVentaCrucero(List<Crucero> listaCruceros, List<Viaje> listaViajes) : this()
        {
            this.listaCruceros = listaCruceros;
            this.listaViajes = listaViajes;
        }
        #endregion

        #region METODOS DEL FORM
        /// <summary>
        /// 1. Agrega todos los cruceros al combo box.
        /// 2. Marco los radio buttons de los destinos en true para 
        /// activar el evento CheckedChanged.
        /// 3. Recorro los enumerados para llenarlos.
        /// 4. Setea el dia minimo para la fecha de nacimiento a 100 años 
        ///    atras y el dia maximo al dia actual.
        /// 5. Setea el dia minimo para la fecha de vencimiento del 
        ///    pasaporte a hoy y el dia maximo a 10 años.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVentaCrucero_Load(object sender, EventArgs e)
        {
            this.cbCruceros.Items.Clear();
            this.cbPasajeroGenero.Items.Clear();
            this.cbTipoPasaporte.Items.Clear();
            this.cbPasajeroNacionalidad.Items.Clear();

            foreach (Crucero item in this.listaCruceros)//1
            {
                this.cbCruceros.Items.Add(item.Nombre);
            }

            //2
            this.rbPasajeroClaseTurista.Checked = true;
            this.rbRegional.Checked = true;

            //3
            foreach (Genero genero in Enum.GetValues(typeof(Genero)))
            {
                this.cbPasajeroGenero.Items.Add(genero);
            }

            foreach (Nacionalidades nacionalidad in Enum.GetValues(typeof(Nacionalidades)))
            {
                this.cbPasajeroNacionalidad.Items.Add(nacionalidad);
            }

            foreach (Tipo tipo in Enum.GetValues(typeof(Tipo)))
            {
                this.cbTipoPasaporte.Items.Add(tipo);
            }

            //4
            this.dateTimePickerPasajeroNacimiento.MinDate = DateTime.Today.AddYears(-100);
            this.dateTimePickerPasajeroNacimiento.MaxDate = DateTime.Today;
            //5
            this.dateTimePickerPasajeroVencimientoPasaporte.MinDate = DateTime.Today;
            this.dateTimePickerPasajeroVencimientoPasaporte.MaxDate = DateTime.Today.AddYears(10);
        }

        public void FiltroDeCrucero(object sender, EventArgs e)
        {
            // Limpia todos los controles del crucero para rellenarlo con nueva informacion
            // O en caso de no encontrar ningun crucero con el filtro dejarlos vacios
            this.cbCruceros.Items.Clear();
            this.tbCamarotesTuristas.Clear();
            this.tbCamarotesPremium.Clear();
            this.tbPrecioTuristasBruto.Clear();
            this.tbPrecioPremiumBruto.Clear();
            this.tbPrecioTuristaIVA.Clear();
            this.tbPrecioPremiumIVA.Clear();
            this.tbPrecioTuristaFinal.Clear();
            this.tbPrecioPremiumFinal.Clear();
            this.tbCapacidadBodega.Clear();
            this.cbFechaSalida.Items.Clear();
            this.cbFechaLlegada.Items.Clear();
            this.cbDestinos.Items.Clear();

            // Recolecta los datos de las caracteristicas del crucero
            cantComedoresSeleccionados = (int)this.numericUpDownCantComedores.Value;
            cantGimnasiosSeleccionados = this.checkBoxGimnasio.Checked ? 0 : -1;
            cantPiscinasSeleccionados = this.checkBoxPiscina.Checked ? 0 : -1;
            cantCasinosSeleccionados = this.checkBoxCasino.Checked ? 0 : -1;
            cantSPASSeleccionados = this.checkBoxSPA.Checked ? 0 : -1;

            // Recorre la lista de cruceros y por cada crucero comprueba si cumple las condiciones
            // Del filtro establecido, si no estan marcadas las checkbox se setean en -1 los valores
            // Para ignorar el filtro de dicho checkbox
            foreach (Crucero crucero in this.listaCruceros)
            {
                if (crucero.Comedores >= cantComedoresSeleccionados)
                {
                    if (crucero.Gimnasio > cantGimnasiosSeleccionados)
                    {
                        if (crucero.Piscinia > cantPiscinasSeleccionados)
                        {
                            if (crucero.Casino > cantCasinosSeleccionados)
                            {
                                if (crucero.SPA > cantSPASSeleccionados)
                                {
                                    this.cbCruceros.Items.Add(crucero.Nombre);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 1. Limpio el combo box de los destinos.
        /// 2. Compruebo que haya un crucero seleccionado.
        /// 3. Recorre la lista buscando viajes que utilicen ese crucero.
        /// 4. Y agrega al combo box de destinos dependiendo de que radio button
        ///    se selecciono.
        /// 5. Si se encuentra al menos un crucero con los filtros se selecciona 
        ///    el primer indice.
        /// 6. Sino se limpia todos los controles para evitar errores.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbRegional_CheckedChanged(object sender, EventArgs e)
        {
            this.cbDestinos.Items.Clear();//1

            //2
            if (this.cbCruceros.SelectedIndex != -1)
            {
                //3
                foreach (Viaje item in this.listaViajes)
                {
                    if (item == cruceroSeleccionado)
                    {
                        if (this.rbRegional.Checked == true)
                        {
                            foreach (DestinoRegional regional in Enum.GetValues(typeof(DestinoRegional)))
                            {
                                if (item.Destino == regional.ToString().Replace("_", ", ").Replace("1", " "))
                                {
                                    this.cbDestinos.Items.Add((item.Destino));//4
                                }
                            }
                        }
                        else
                        {
                            foreach (EDestinoExtraRegional regional in Enum.GetValues(typeof(EDestinoExtraRegional)))
                            {
                                if (item.Destino == regional.ToString().Replace("_", ", ").Replace("1", " "))
                                {
                                    this.cbDestinos.Items.Add((item.Destino));//4
                                }
                            }
                        }
                    }
                }

                //5
                if (this.cbDestinos.Items.Count > 0)
                {
                    this.cbDestinos.SelectedItem = this.cbDestinos.Items[0];
                }
                else//6
                {
                    this.tbCamarotesTuristas.Clear();
                    this.tbCamarotesPremium.Clear();
                    this.tbPrecioTuristasBruto.Clear();
                    this.tbPrecioPremiumBruto.Clear();
                    this.tbPrecioTuristaIVA.Clear();
                    this.tbPrecioPremiumIVA.Clear();
                    this.tbPrecioTuristaFinal.Clear();
                    this.tbPrecioPremiumFinal.Clear();
                    this.tbCapacidadBodega.Clear();
                    this.cbFechaSalida.Items.Clear();
                    this.cbFechaLlegada.Items.Clear();
                } 
            }
        }

        /// <summary>
        /// 1. Se comprueba cada vez que se cambia el indice del combo box de Cruceros
        ///    si se ha seleccionado uno realmente.
        /// 2. De ser asi recolecta el nombre guardado y lo comprueba con
        ///    la lista de cruceros para obtener el objeto y guardarlo en un 
        ///    crucero auxiliar para luego utilizarlo a traves de todo el form.
        /// 3. Por ultimo, activa el evento CheckedChanged para que se realicen los filtros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbCruceros_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1
            if (this.cbCruceros.SelectedIndex != -1)
            {
                foreach (Crucero crucero in this.listaCruceros)//2
                {
                    if (this.cbCruceros.SelectedItem.ToString() == crucero.Nombre)
                    {
                        cruceroSeleccionado = crucero;
                        rbRegional_CheckedChanged(sender,e);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 1. Limpio los controles de las fechas. 
        /// 2. Luego se calculan todos los datos relevantes que posee
        /// 3. Dicho Viaje y guarda el objeto en una variable 
        ///   auxiliar para utilizarlo por fuera del foreach
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbDestinos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1
            this.cbFechaLlegada.Items.Clear();
            this.cbFechaSalida.Items.Clear();

            foreach (Viaje viaje in this.listaViajes)
            {
                if (viaje == cruceroSeleccionado && viaje.Destino == cbDestinos.SelectedItem.ToString())//3
                {
                    //2
                    ivaTurista = viaje.CostoPasajeTurista * 0.21;
                    ivaPremium = viaje.CostoPasajePremium * 0.21;

                    this.cbFechaSalida.Items.Add(viaje.FechaSalida);
                    this.cbFechaLlegada.Items.Add(viaje.FechaVuelta);
                    this.tbCamarotesTuristas.Text = $"{viaje.CantCamarotesTurista} / {cruceroSeleccionado.CantCamarotesTuristas}";
                    this.tbCamarotesPremium.Text = $"{viaje.CantCamarotesPremium} / {cruceroSeleccionado.CantCamarotesPremium}";
                    this.tbPrecioTuristasBruto.Text = $"{viaje.CostoPasajeTurista}";
                    this.tbPrecioPremiumBruto.Text = $"{viaje.CostoPasajePremium}";
                    this.tbPrecioTuristaIVA.Text = $"{ivaTurista}";
                    this.tbPrecioPremiumIVA.Text = $"{ivaPremium}";
                    this.tbPrecioTuristaFinal.Text = $"{viaje.CostoPasajeTurista + ivaTurista}";
                    this.tbPrecioPremiumFinal.Text = $"{viaje.CostoPasajePremium + ivaPremium}";
                    this.tbCapacidadBodega.Text = $"{viaje.CantBodega} / {cruceroSeleccionado.Bodega}";

                    viajeSeleccionado = viaje;//3
                }
            }

            if (this.cbFechaSalida.Items.Count != -1)
            {
                this.cbFechaSalida.SelectedIndex = 0;
            }
        }

        /// <summary> 
        /// Al estar bloqueado la Fecha de llegada la forma de cambiarla es a traves de la Fecha de Inicio.
        /// Para que ambas fechas vayan en sintonia con el viaje y no se preste a confusion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFechaSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbFechaLlegada.SelectedIndex = this.cbFechaSalida.SelectedIndex;
        }

        /// <summary>
        /// Setea los valores maximos de la cantidad de valijas que 
        /// puede llevar el pasajero dependiendo de su clase.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbPasajeroClaseTurista_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbPasajeroClaseTurista.Checked)
            {
                this.numericUpDownCantValijas.Maximum = 1;
            }
            else
            {
                this.numericUpDownCantValijas.Maximum = 2;
            }
        }

        /// <summary>
        /// Chequea que solo se introduzcan letras.
        /// Es un validador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        
        /// <summary>
        /// Evita que se introduzcan letras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Valido el ingreso del numero del pasaporte.
        /// Las primeras 3 deberan ser letras y los proximos
        /// 3 deberan de ser numeros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPasajeroPasaporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.tbPasajeroPasaporte.TextLength < 3)
            {
                SoloLetras(sender,e);
            }
            else
            {
                SoloNumeros(sender, e);
            }
        }

        /// <summary>
        /// Le pregunta al usuario si realmente desea cerrar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVentaCrucero_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!seguroCerrar)
            {
                if (MessageBox.Show("¿Desea cerrar el formulario?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// 1. Si el pasajero no lleva consigo una valija entonces el peso debera de ser 0.
        /// 2. Si el pasajero lleva una valija el peso maximo sera 25kg.
        /// 3. Si el pasajero decide llevar 2 valijas el peso maximo ser 50kg.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownCantValijas_ValueChanged(object sender, EventArgs e)
        {
            if (this.numericUpDownCantValijas.Value == 0)//1
            {
                this.numericUpDownPesoValijas.Maximum = 0;
            }
            else
            {
                if (this.numericUpDownCantValijas.Value == 1)//2
                {
                    this.numericUpDownPesoValijas.Maximum = 25;
                }
                else
                {
                    this.numericUpDownPesoValijas.Maximum = 50;//3
                }
            }
        }
        #endregion

        #region BOTONES DEL FORM
        /// <summary>
        /// 1. Comprobar que efectivamente se selecciono un viaje.
        /// 2. Guardamos los valores ingresados del pasajero.
        /// 3. Elimina los espacios anteriores y posteriores de los text box.
        /// 4. Valida de que se haya ingresado un nombre, se haya ingresado un apellido, se haya ingresado una nacionalidad
        ///    Se haya seleccionado un sexo, que el pasaporte y el dni este escritos por completo,
        ///    Que el peso del equipaje no supere a la capacidad maxima de la bodega y que haya espacio para un pasajero nuevo
        ///    O que el barco ya este viajando.
        /// 5. Si falta algun dato tira un mensaje de error.
        /// 6. Si todo esta bien crea un nuevo pasajero.
        /// 7. Se verifica de que el pasajero nuevo creado no se encuentre ya dentro de la lista
        ///    De pasajeros del viaje. Si se encuentra salta un error y evita la compra, si no se encuentra
        ///    Se efectua la compra, agrega al pasajero a la lista y cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVenderViaje_Click(object sender, EventArgs e)
        {
            if (viajeSeleccionado is not null)//1
            {
                //2
                generoPasajero = this.cbPasajeroGenero.SelectedIndex == 0 ? Genero.Masculino : Genero.Femenino;

                if (this.rbPasajeroClaseTurista.Checked)
                {
                    clasePasajero = Clase.Turista;
                    camaroteDisponiblePasajero = viajeSeleccionado.CantCamarotesTurista > 0;
                }
                else
                {
                    clasePasajero = Clase.Premium;
                    camaroteDisponiblePasajero = viajeSeleccionado.CantCamarotesPremium > 0;
                }

                //3
                nombrePasajero = this.tbPasajeroNombre.Text.Trim();
                apellidoPasajero = this.tbPasajeroApellido.Text.Trim();
                nacionalidadString = this.cbPasajeroNacionalidad.SelectedItem.ToString();

                //4
                if (nombrePasajero.Length == 0 || apellidoPasajero.Length == 0 || nacionalidadString.Length == 0 ||
                    this.cbPasajeroGenero.SelectedIndex == -1 ||  this.tbPasajeroPasaporte.TextLength != this.tbPasajeroPasaporte.MaxLength || 
                    this.tbPasajeroNumDocumento.TextLength != this.tbPasajeroNumDocumento.MaxLength || 
                    viajeSeleccionado.CantBodega < this.numericUpDownPesoValijas.Value ||
                    !camaroteDisponiblePasajero || (DateTime)this.cbFechaSalida.SelectedItem < DateTime.Today)
                {
                    //5
                    MessageBox.Show("Al menos uno de los datos ingresados es incorrecto. Reintente!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    //6
                    pasajeroNuevo = new Pasajero(clasePasajero,this.tbPasajeroNombre.Text,this.tbPasajeroApellido.Text,int.Parse(this.tbPasajeroNumDocumento.Text),
                        this.tbPasajeroPasaporte.Text, nacionalidadString,tipoPasaportePasajero,this.dateTimePickerPasajeroNacimiento.Value,this.dateTimePickerPasajeroVencimientoPasaporte.Value,
                        generoPasajero,this.cbPasajeroBolsoDeMano.Checked,(int)numericUpDownCantValijas.Value,(int)numericUpDownPesoValijas.Value);

                    //7
                    for (int i = 0; i < listaViajes.Count; i++)
                    {
                        if (listaViajes[i] == viajeSeleccionado)
                        {
                            if (viajeSeleccionado.ListaPasajeros.Contains(pasajeroNuevo))
                            {
                                MessageBox.Show("El pasajero ya ha comprado un pasaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                seguroCerrar = true;
                                listaViajes[i] += pasajeroNuevo;
                                this.Close();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado un viaje valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Al presionar el boton 'Cancelar' me permite cerrar
        /// este formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Al presionar el boton de 'Help' se abria un message box
        /// indicandole al usuario para que sirve este formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El usuario podra vender un crucero. Debera de cargar todos los datos de forma correcta para evitar errores.","HELP",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        #endregion


    }
}
