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
using System.Media;

namespace AplicacionForms
{
    public partial class FrmMenu : Form
    {
        #region ATRIBUTOS FORM

        #region FORMS
        FrmCrearViaje FrmCrearViaje;
        FrmVentaCrucero frmVentaCrucero;
        FrmInformacionViajes frmInformacion;
        FrmContendorEstadisticas frmContendorEstadisticas;
        #endregion

        #region CRUCEROS
        Crucero crucero1;
        Crucero crucero2;
        Crucero crucero3;
        Crucero crucero4;
        Crucero crucero5;
        Crucero crucero6;
        Crucero crucero7;
        List<Crucero> listaCruceros;
        #endregion

        #region VIAJES
        Viaje viaje1;
        Viaje viaje2;
        Viaje viaje3;
        Viaje viaje4;
        Viaje viaje5;
        Viaje viaje6;
        List<Viaje> listaViajes;
        #endregion

        #region PASAJEROS
        Pasajero pasajero1;
        Pasajero pasajero2;
        Pasajero pasajero3;
        Pasajero pasajero4;
        Pasajero pasajero5;
        List<Pasajero> listaPasajeros;
        #endregion

        #region DATAGRIDVIEW
        DataTable tablaViajes;
        DataRow auxFilaViaje;
        DataGridViewRow auxFilaCruceros;
        DataGridViewRow auxFilaPasajeros;
        #endregion

        #region AUX
        int indexTablaViajes;
        string matricula;
        string fecha;
        string[] matriculaFecha;
        int indiceViajFrmInformacionDetallada;
        SoundPlayer player;
        #endregion

        #endregion

        #region CONSTRUCTORES FORM
        /// <summary>
        /// Constructor por defecto del form.
        /// Lo que hace es instanciarme los atributos.
        /// </summary>
        public FrmMenu()
        {
            InitializeComponent();
            this.tablaViajes = new DataTable();

            this.listaCruceros = new List<Crucero>();
            #region INSTANCIO CRUCEROS
            this.crucero1 = new("QUALITY", "WERQ1234", 15);
            this.listaCruceros.Add(this.crucero1);
            this.crucero2 = new("SEISA", "LOQW2451", 20, 2, 1, 0, 1, 500,0);
            this.listaCruceros.Add(this.crucero2);
            this.crucero3 = new("DAAVOS", "TRWQ1539", 23, 3, 1, 2, 1, 600,3);
            this.listaCruceros.Add(this.crucero3);
            this.crucero4 = new("TEJAR", "HJRK0973", 30, 4, 2, 2, 2, 1000,0);
            this.listaCruceros.Add(this.crucero4);
            this.crucero5 = new("VALKYRIA", "PEGR4604", 17, 1, 1, 1, 0, 400,2);
            this.listaCruceros.Add(this.crucero5);
            this.crucero6 = new("HIGH GARDEN", "BFMD6432", 19, 2, 0, 1, 0, 450,1);
            this.listaCruceros.Add(this.crucero6);
            this.crucero7 = new("DRAGONSTONE", "ZXVK1257", 22, 3, 2, 1, 1, 500,2);
            this.listaCruceros.Add(this.crucero7);
            #endregion

            this.listaViajes = new List<Viaje>();
            #region INSTANCIO VIAJES
            this.viaje1 = new(DateTime.Parse("27/09/2022"), crucero1, EDestinoExtraRegional.Atenas_Grecia);
            this.listaViajes.Add(this.viaje1);
            this.viaje2 = new(DateTime.Parse("05/10/2022"), crucero2, EDestinoExtraRegional.Acapulco_Mexico);
            this.listaViajes.Add(this.viaje2);
            this.viaje3 = new(DateTime.Parse("25/11/2022"), crucero3, EDestinoExtraRegional.La1Habana_Cuba);
            this.listaViajes.Add(this.viaje3);
            this.viaje4 = new(DateTime.Parse("05/10/2022"), crucero4, DestinoRegional.Lima_Peru);
            this.listaViajes.Add(this.viaje4);
            this.viaje5 = new(DateTime.Parse("15/11/2022"), crucero5, DestinoRegional.Recife_Brasil);
            this.listaViajes.Add(this.viaje5);
            this.viaje6 = new(DateTime.Parse("15/12/2022"), crucero1, DestinoRegional.Rio1de1Janeiro_Brasil);
            this.listaViajes.Add(this.viaje6);
            #endregion

            this.listaPasajeros = new List<Pasajero>();
            #region INSTANCIO PASAJEROS
            this.pasajero1 = new(Clase.Premium, "Micaela", "Viciconte", 40377289, "AAB224551",Nacionalidades.Australian.ToString(),Tipo.Ordinario,
                DateTime.Parse("18/07/1997"), DateTime.Parse("19/03/2029"), Genero.Femenino, true, 2, 10);
            this.listaPasajeros.Add(this.pasajero1);
            this.pasajero2 = new(Clase.Turista, "Alexander", "Skanicac", 39555844, "BAS424551", Nacionalidades.Dutch.ToString(),Tipo.Oficial,
                DateTime.Parse("19/06/1979"), DateTime.Parse("08/02/2026"), Genero.Masculino, false, 1, 20);
            this.listaPasajeros.Add(this.pasajero2);
            this.pasajero3 = new(Clase.Turista, "Cristina", "Perez", 25415421, "ASC325299", Nacionalidades.Uruguayan.ToString(),Tipo.Provisorio,
                DateTime.Parse("03/05/2000"), DateTime.Parse("15/09/2025"), Genero.Femenino, true, 1, 8);
            this.listaPasajeros.Add(this.pasajero3);
            this.pasajero4 = new(Clase.Premium, "Renato", "Dominguez", 36584575, "CAD292149", Nacionalidades.Panamanian.ToString(),Tipo.Diplomatico,
                DateTime.Parse("25/12/1999"), DateTime.Parse("25/01/2029"), Genero.Masculino, false, 1, 10);
            this.listaPasajeros.Add(this.pasajero4);
            this.pasajero5 = new(Clase.Premium, "Steve", "Rogers", 79665412, "BCS594123", Nacionalidades.American.ToString(),Tipo.Diplomatico,
                DateTime.Parse("01/01/1989"), DateTime.Parse("25/01/2029"), Genero.Masculino, true, 2, 25);
            this.listaPasajeros.Add(this.pasajero5);
            #endregion

            #region INSTANCIAR FORMS
            this.FrmCrearViaje = new FrmCrearViaje(this.listaCruceros,this.listaViajes);
            this.frmVentaCrucero = new FrmVentaCrucero(this.listaCruceros,this.listaViajes);
            this.frmInformacion = new FrmInformacionViajes(this.listaViajes);
            this.frmContendorEstadisticas = new FrmContendorEstadisticas(this.listaViajes);
            #endregion
        }

        /// <summary>
        /// Constructor parametrizado, recibe el usuario loggueado
        /// y realiza una sobre carga del mismo constructor.
        /// </summary>
        /// <param name="userLoggued"></param>
        public FrmMenu(string userLoggued) : this()
        {
            this.labelUsername.Text =$"{userLoggued}";
            this.labelFecha.Text = $"{DateTime.Today.ToShortDateString()}";
        }
        #endregion

        #region METODO DEL FORM
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            //Probando ponerle musica al form
            player = new SoundPlayer();
            player.SoundLocation = "C:/Users/Rocio/Desktop/C#/Primer Parcial/Bessio.Rocio.Lab.RPP.2A/Bessio.Rocio.PP.2A/Imagenes-Audio/InstrumentalAB.wav";


            // Creo las columna de la tabla de Viaje
            this.tablaViajes.Columns.Add("Crucero");
            this.tablaViajes.Columns.Add("Origen");
            this.tablaViajes.Columns.Add("Destino");
            this.tablaViajes.Columns.Add("Dia de Salida");
            this.tablaViajes.Columns.Add("Dia de Llegada");
            this.tablaViajes.Columns.Add("Precio Turista");
            this.tablaViajes.Columns.Add("Precio Premium");

            // Carga los viajes actuales a la tabla de viaje
            this.CargarViajes();

            // Agrega pasajeros a algunos viajes creados
            this.viaje1 += listaPasajeros;
            this.viaje2 += listaPasajeros;
            this.viaje3 += listaPasajeros;
            this.viaje1 += listaPasajeros;
        }

        /// <summary>
        /// Recorre todos los viajes que hay cargados en la lista. 
        /// Crea tantas filas de la tabla de viajes como viajes haya cargados, 
        /// rellena sus campos con los datos de cada viaje y agrega la tabla hecha al DataGrivView de Viajes.
        /// </summary>
        private void CargarViajes()
        {
            foreach (Viaje viaje in this.listaViajes)
            {
                auxFilaViaje = tablaViajes.NewRow();

                auxFilaViaje[0] = viaje.Crucero.Matricula;
                auxFilaViaje[1] = viaje.CiudadPartida;
                auxFilaViaje[2] = $"{viaje.Destino:c}";
                auxFilaViaje[3] = $"{viaje.FechaSalida:d}";
                auxFilaViaje[4] = $"{viaje.FechaVuelta:d}";
                auxFilaViaje[5] = $"{viaje.CostoPasajeTurista:c}";
                auxFilaViaje[6] = $"{viaje.CostoPasajePremium:c}";

                tablaViajes.Rows.Add(auxFilaViaje);
            }

            this.dataGridViajes.DataSource = tablaViajes;
        }

        private void dataGridViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Recolecto la celda clickeada de la tabla de viajes, especificamente el primer indice donde
            // se guarda la matricula y el cuarto indice donde se guarda la fecha de salida
            // y recorro la lista de cruceros para buscar el match y la lista de viajes para buscar el match.
            this.indexTablaViajes = e.RowIndex;

            // Si el indice es -1 significa que esta clickeando el header de la columna
            if (this.indexTablaViajes > -1)
            {
                this.indiceViajFrmInformacionDetallada = 0;

                this.matricula = this.dataGridViajes.Rows[indexTablaViajes].Cells[0].Value.ToString();
                this.fecha = this.dataGridViajes.Rows[indexTablaViajes].Cells[3].Value.ToString();

                this.matriculaFecha = new string[] { matricula, fecha };
            }

            // Recorre la lista de viajes hasta encontrar el viaje seleccionado
            foreach (Viaje viaje in this.listaViajes)
            {
                if (viaje == matriculaFecha)
                {
                    // Limpia la celda de crucero por si tiene datos cargados anteriormente
                    // Crea una fila y rellena las columna con los datos del crucero del viaje seleccionado
                    // Agrega la fila al DataGridView de Crucero
                    this.dgvCrucero.Rows.Clear();
                    this.auxFilaCruceros = new();

                    this.auxFilaCruceros.CreateCells(this.dgvCrucero);

                    this.auxFilaCruceros.Cells[0].Value = $"{viaje.Crucero.Nombre} - {viaje.Crucero.Matricula}";
                    this.auxFilaCruceros.Cells[1].Value = $"{viaje.CantCamarotesTurista}/{viaje.Crucero.CantCamarotesTuristas}";
                    this.auxFilaCruceros.Cells[2].Value = $"{viaje.CantCamarotesPremium}/{viaje.Crucero.CantCamarotesPremium}";
                    this.auxFilaCruceros.Cells[3].Value = $"{viaje.Crucero.Comedores}";
                    this.auxFilaCruceros.Cells[4].Value = $"{viaje.Crucero.Gimnasio}";
                    this.auxFilaCruceros.Cells[5].Value = $"{viaje.Crucero.Piscinia}";
                    this.auxFilaCruceros.Cells[6].Value = $"{viaje.Crucero.Casino}";
                    this.auxFilaCruceros.Cells[7].Value = $"{viaje.CantBodega}/{viaje.Crucero.Bodega}";

                    // Verifica si el crucero ya salió o la bodega esta vacia o ambos camarotes se encuentran sin espacio
                    // y pinta de color rojo el crucero para advertir del estado
                    if (viaje.FechaSalida < DateTime.Today || viaje.CantBodega == 0 || (viaje.CantCamarotesTurista == 0 && viaje.CantCamarotesPremium == 0))
                    {
                        this.auxFilaCruceros.DefaultCellStyle.SelectionBackColor = Color.Red;
                    }
                    else
                    {
                        // Verifica si le queda poco espacio a la bodega o algunos de los camarotes se encuentra sin espacio
                        // y pinta de color amarillo el crucero para advertir del estado
                        if (viaje.CantBodega < 100 || viaje.CantCamarotesTurista == 0 || viaje.CantCamarotesPremium == 0)
                        {
                            this.auxFilaCruceros.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                        }
                    }

                    this.dgvCrucero.Rows.Add(this.auxFilaCruceros);

                    // Limpio la lista de pasajeros y muestro los pasajeros del viaje seleccionado
                    this.dgvPasajero.Rows.Clear();

                    if (viaje.ListaPasajeros.Count == 0)
                    {
                        // En caso de no haber pasajeros en la lista se muestra un mensaje aclarandolo
                        this.auxFilaPasajeros = new();
                        this.auxFilaPasajeros.CreateCells(this.dgvPasajero);

                        this.auxFilaPasajeros.Cells[0].Value = "Viaje SIN pasajeros";

                        this.dgvPasajero.Rows.Add(this.auxFilaPasajeros);
                    }
                    else
                    {
                        // Recorre la lista de pasajeros que tiene el viaje seleccionado
                        // Por cada uno crea una fila y rellena cada columna con todos sus datos
                        // Por ultimo agrega la fila al DataGridView de Pasajero
                        for (int i = 0; i < viaje.ListaPasajeros.Count; i++)
                        {
                            this.auxFilaPasajeros = new();
                            this.auxFilaPasajeros.CreateCells(this.dgvPasajero);

                            this.auxFilaPasajeros.Cells[0].Value = $"{viaje.ListaPasajeros[i].Apellido}, {viaje.ListaPasajeros[i].Nombre}";
                            this.auxFilaPasajeros.Cells[1].Value = $"{viaje.ListaPasajeros[i].Dni}";
                            this.auxFilaPasajeros.Cells[2].Value = $"{viaje.ListaPasajeros[i].Genero}";
                            this.auxFilaPasajeros.Cells[3].Value = $"{viaje.ListaPasajeros[i].Edad}";
                            this.auxFilaPasajeros.Cells[4].Value = $"{viaje.ListaPasajeros[i].Equipaje.EsDeMano}";
                            this.auxFilaPasajeros.Cells[5].Value = $"{viaje.ListaPasajeros[i].Equipaje.CantValijas} - {viaje.ListaPasajeros[i].Equipaje.PesoTotalValija}";

                            this.dgvPasajero.Rows.Add(this.auxFilaPasajeros);
                        }
                    }

                    break;
                }
                // Guarda el indice viaje seleccionado para poder utilizo por fuera del foreach
                indiceViajFrmInformacionDetallada++;
            }
        }

        /// <summary>
        /// Le pregunta al usuario si realmente desea cerrar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea finalizar el programa?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
        #endregion

        #region BOTONES FORM
        /// <summary>
        /// Boton de ayuda/guia para el usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este formulario le permite al usuario visualizar los viajes disponibles, al selecionnarlo ver los cruceros asignados y los pasajeros abordo. También le permitira abrir nuevos formularios para crear viajes, vender un crucero, informacion detallada de los pasajeros y ver el historial de los viajes.", "HELP", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        /// <summary>
        /// Al presionar el boton 'Crear nuevo viaje' me permite guardar
        /// un nuevo viaje  si todo es correcto se agrega a la tabla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarVuelo_Click(object sender, EventArgs e)
        {
            if (this.FrmCrearViaje.ShowDialog() == DialogResult.OK)
            {
                this.CargarViajes();
            }
        }

        /// <summary>
        /// Me permite abrir el formulario para poder vender un crucero.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.frmVentaCrucero.ShowDialog();
        }

        /// <summary>
        /// Me permite abrir el frmInformacionDetallada para visualizar todo sobre los viajes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerPasajeros_Click(object sender, EventArgs e)
        {
            this.frmInformacion.ConseguirIndicePrimerViaje(indiceViajFrmInformacionDetallada);
            this.frmInformacion.ShowDialog();
        }

        /// <summary>
        /// Me permite ver el historial de los viajes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            this.frmContendorEstadisticas.ShowDialog();
        }

        /// <summary>
        /// Al presionarlo activa la musica.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSoundOn_Click(object sender, EventArgs e)
        {
            player.PlayLooping();
        }

        /// <summary>
        /// Se desactiva la musica.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSoundOff_Click(object sender, EventArgs e)
        {
            player.Stop();
        }



        #endregion


    }
}
