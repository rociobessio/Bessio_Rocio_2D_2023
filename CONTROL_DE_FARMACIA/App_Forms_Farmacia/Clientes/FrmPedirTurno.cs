using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace App_Forms_Farmacia.Clientes
{
    public partial class FrmPedirTurno : Form
    {
        #region ATRIBUTOS
        String query;
        Database db = new Database();
        string user;
        int aux = 0;
        #endregion

        #region CONSTRUCTOR
        public FrmPedirTurno(string usuario)
        {
            InitializeComponent();
            user = usuario;
        }
        #endregion

        #region BOTONES
        /// <summary>
        /// Al presionar la 'X' el usuario cerrara este formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExitPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Le imprime al usuario un msj de ayuda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El cliente podra pedir nuevos turnos. Para cerrarlo o ir a otra opcion del menu se debe de presionar el botón con la 'X'.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Me permite resetear todos los valores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.cbEspecialidadMedico.SelectedIndex = -1;
            this.cbHorarios.SelectedIndex = -1;
            this.cbLocalidad.SelectedIndex = -1;
            this.cbNombreMedico.SelectedIndex = -1;
            this.cbObraSocial.SelectedIndex = -1;
            this.dtpFechaTurno.ResetText();
        }

        /// <summary>
        /// Se guardara el turno dentro de la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPedirTurno_Click(object sender, EventArgs e)
        {
            if (this.cbEspecialidadMedico.SelectedIndex != -1 && this.cbHorarios.SelectedIndex != -1
                && this.cbLocalidad.SelectedIndex != -1 && this.cbNombreMedico.SelectedIndex != -1 && this.cbObraSocial.SelectedIndex != -1)
            {
                string especialidadMedico = this.cbEspecialidadMedico.SelectedItem.ToString();
                string nombreMedico = this.cbNombreMedico.SelectedItem.ToString();
                string fechaTurno = this.dtpFechaTurno.Text;
                string horarioTurno = this.cbHorarios.SelectedItem.ToString();
                string obraSocial = this.cbObraSocial.SelectedItem.ToString();
                string localidad = this.cbLocalidad.SelectedItem.ToString();

                query = "insert into cliente1(username,fechaTurno,especialidadMedico,nombreMedico,horarioTurno,obraSocial,localidad) values ('" + user + "', '" + fechaTurno + "', '" + especialidadMedico + "', '" + nombreMedico + "', '" + horarioTurno + "', '" + obraSocial + "' , '" + localidad + "')";
                db.setData(query,"TURNO GUARDADO CORRECTAMENTE.");

                aux = dataGridViewTurno.Rows.Add();
                dataGridViewTurno.Rows[aux].Cells[0].Value = this.cbEspecialidadMedico.SelectedItem.ToString();
                dataGridViewTurno.Rows[aux].Cells[1].Value = this.cbNombreMedico.SelectedItem.ToString();
                dataGridViewTurno.Rows[aux].Cells[2].Value = this.dtpFechaTurno.Text;
                dataGridViewTurno.Rows[aux].Cells[3].Value = this.cbHorarios.SelectedItem.ToString();
                dataGridViewTurno.Rows[aux].Cells[4].Value = this.cbLocalidad.SelectedItem.ToString();
                dataGridViewTurno.Rows[aux].Cells[5].Value = this.cbObraSocial.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Complete toda la información.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.limpiarAll();
        }

        /// <summary>
        /// Permite imprimir el ticket con la informacion del turno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImprimirTurno_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "TICKET INFORMACIÓN SOBRE TURNO MÉDICO";
            print.SubTitle = String.Format("Fecha: {0}", DateTime.Now.ToShortDateString());
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "TURNO GENERADO CORRECTAMENTE";
            print.FooterSpacing = 15;
            print.PrintDataGridView(dataGridViewTurno);//Le paso el datagrid para que lo imprima...
            dataGridViewTurno.DataSource = 0;//Lo limpio
        }
        #endregion

        #region EVENTOS - METODOS
        /// <summary>
        /// Los turnos podran aparecer desde hoy hasta dentro de 1 año...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPedirTurno_Load(object sender, EventArgs e)
        {
            this.dtpFechaTurno.MinDate = DateTime.Today;
            this.dtpFechaTurno.MaxDate = DateTime.Today.AddYears(1);
            this.btnRefresh_Click(sender,e);
        }

        /// <summary>
        /// Dependiendo de la especialidad seleccionada me permitara mostrar
        /// dentro de los distintos combo boxes los horarios y especialistas,
        /// a su vez la localidad disponible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbEspecialidadMedico_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (this.cbEspecialidadMedico.SelectedIndex != -1)
            {
                this.limpiarAll();
                if (this.cbEspecialidadMedico.Text =="OTORRINO")
                {
                    this.cbNombreMedico.Items.Add("HERNANDEZ JOSÉ");
                    this.cbNombreMedico.Items.Add("BUONANOTTE MARIA");
                    this.cbHorarios.Items.Add("11 hs.");
                    this.cbHorarios.Items.Add("14 hs.");
                    this.cbHorarios.Items.Add("17 hs.");
                    this.cbLocalidad.Items.Add("AVELLANEDA");
                    this.cbLocalidad.Items.Add("LANÚS ESTE");
                    this.cbLocalidad.Items.Add("CABALLITO");
                }
                else if (this.cbEspecialidadMedico.Text == "CLINICO")
                {
                    this.cbNombreMedico.Items.Add("LAMONTHE MARIANO");
                    this.cbNombreMedico.Items.Add("SOLIS LAURA");
                    this.cbNombreMedico.Items.Add("GUEVARA MARTÍN");
                    this.cbHorarios.Items.Add("08 hs.");
                    this.cbHorarios.Items.Add("13 hs.");
                    this.cbHorarios.Items.Add("11.15 hs.");
                    this.cbHorarios.Items.Add("17 hs.");
                    this.cbHorarios.Items.Add("18.30 hs.");
                    this.cbHorarios.Items.Add("19 hs.");
                    this.cbLocalidad.Items.Add("AVELLANEDA");
                    this.cbLocalidad.Items.Add("LANÚS ESTE");
                    this.cbLocalidad.Items.Add("CABALLITO");
                    this.cbLocalidad.Items.Add("BOEDO");
                }
                else if (this.cbEspecialidadMedico.Text == "OFTALMOLOGO")
                {
                    this.cbNombreMedico.Items.Add("AVIGAL RICARDO");
                    this.cbNombreMedico.Items.Add("LECLERC IVANA");
                    this.cbHorarios.Items.Add("10 hs.");
                    this.cbHorarios.Items.Add("11.00 hs.");
                    this.cbHorarios.Items.Add("11.45 hs.");
                    this.cbHorarios.Items.Add("16 hs.");
                    this.cbHorarios.Items.Add("17.30 hs.");
                    this.cbHorarios.Items.Add("19 hs.");
                    this.cbLocalidad.Items.Add("AVELLANEDA");
                    this.cbLocalidad.Items.Add("LANÚS ESTE");
                    this.cbLocalidad.Items.Add("BOEDO");
                }
                else if (this.cbEspecialidadMedico.Text == "GINECOLOGO")
                {
                    this.cbNombreMedico.Items.Add("WASOWS HERNAN");
                    this.cbNombreMedico.Items.Add("MINUJIN CARMEN");
                    this.cbHorarios.Items.Add("10.15 hs.");
                    this.cbHorarios.Items.Add("11.00 hs.");
                    this.cbHorarios.Items.Add("11.45 hs.");
                    this.cbHorarios.Items.Add("16 hs.");
                    this.cbHorarios.Items.Add("17.30 hs.");
                    this.cbHorarios.Items.Add("19 hs.");
                    this.cbLocalidad.Items.Add("AVELLANEDA");
                    this.cbLocalidad.Items.Add("LANÚS ESTE");
                }
                else if (this.cbEspecialidadMedico.Text == "NUTRICIONISTA")
                {
                    this.cbNombreMedico.Items.Add("VAL AGUSTINA");
                    this.cbNombreMedico.Items.Add("GARCIA LUCAS");
                    this.cbNombreMedico.Items.Add("ESTEVANEZ DAMIAN");
                    this.cbHorarios.Items.Add("10.15 hs.");
                    this.cbHorarios.Items.Add("11.00 hs.");
                    this.cbHorarios.Items.Add("11.45 hs.");
                    this.cbHorarios.Items.Add("16 hs.");
                    this.cbHorarios.Items.Add("17.30 hs.");
                    this.cbHorarios.Items.Add("19 hs.");
                    this.cbLocalidad.Items.Add("AVELLANEDA");
                    this.cbLocalidad.Items.Add("LANÚS ESTE");
                    this.cbLocalidad.Items.Add("FLORES");
                }
                else if (this.cbEspecialidadMedico.Text == "PEDIATRA")
                {
                    this.cbNombreMedico.Items.Add("GOMÉZ PATRICIA");
                    this.cbNombreMedico.Items.Add("DANIEL RODRIGO");
                    this.cbNombreMedico.Items.Add("RODRIGUEZ MARCOS");
                    this.cbHorarios.Items.Add("10.15 hs.");
                    this.cbHorarios.Items.Add("11.00 hs.");
                    this.cbHorarios.Items.Add("11.45 hs.");
                    this.cbHorarios.Items.Add("16 hs.");
                    this.cbHorarios.Items.Add("17.30 hs.");
                    this.cbHorarios.Items.Add("19 hs.");
                    this.cbLocalidad.Items.Add("AVELLANEDA");
                    this.cbLocalidad.Items.Add("LANÚS ESTE");
                    this.cbLocalidad.Items.Add("CABALLITO");
                    this.cbLocalidad.Items.Add("ITUZAINGO");
                }
                else if (this.cbEspecialidadMedico.Text == "UROLOGO")
                {
                    this.cbNombreMedico.Items.Add("LEON GASTON");
                    this.cbNombreMedico.Items.Add("LARRETA PABLO");
                    this.cbHorarios.Items.Add("10.15 hs.");
                    this.cbHorarios.Items.Add("11.00 hs.");
                    this.cbHorarios.Items.Add("11.45 hs.");
                    this.cbHorarios.Items.Add("16 hs.");
                    this.cbHorarios.Items.Add("17.30 hs.");
                    this.cbHorarios.Items.Add("19 hs.");
                    this.cbLocalidad.Items.Add("AVELLANEDA");
                    this.cbLocalidad.Items.Add("LANÚS ESTE");
                }
            }
        }

        private void limpiarAll()
        {
            this.cbHorarios.SelectedIndex = -1;
            this.cbLocalidad.SelectedIndex = -1;
            this.cbNombreMedico.SelectedIndex = -1;
            this.cbObraSocial.SelectedIndex = -1;
            this.dtpFechaTurno.ResetText();
        }

        #endregion


    }
}
