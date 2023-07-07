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

namespace App_Forms_Farmacia.Farmaceutico
{
    public partial class FrmVenderMedicina : Form
    {
        #region ATRIBUTOS
        String query;
        Database db = new Database();
        DataSet ds = new DataSet();
        protected int totalAmount = 0;
        protected int aux = 0;
        protected Int64 cantidad;
        protected Int64 nuevaCantidad;
        protected int valueAmount;
        protected string valueID;
        protected Int64 numUnits;
        #endregion

        #region CONSTRUCTOR
        public FrmVenderMedicina(string label)
        {
            InitializeComponent();
            this.labelMedicinas.Text = label;
        }
        #endregion

        #region BOTONES
        /// <summary>
        /// Le imprimer un msj de ayuda al usuario para que sepa que hacer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El usuario podra vender/comprar las medicinas que requiera. Para cerrarlo o ir a otra opcion del menu se debe de presionar el botón con la 'X'.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Al presionar la 'X' me permite volver al menu principal-
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExitPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAñadirAlCarrito_Click(object sender, EventArgs e)
        {
            if (this.txtIDMedicina.Text != "")//Chequeo que haya selccionado medicina 
            {
                query = "select cantidad from farmaceutico where mid = '" + this.txtIDMedicina.Text + "'";
                ds = db.obtenerData(query);
                cantidad = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                nuevaCantidad = cantidad - Int64.Parse(this.txtCantMedicina.Text);//La nueva cantidad
                if (nuevaCantidad >=0)//Si la cantidad es mayor o ifual a 0
                {
                    //Cargo los valores de cada columna
                    aux = dataGridViewMedicinas.Rows.Add();
                    dataGridViewMedicinas.Rows[aux].Cells[0].Value = this.txtIDMedicina.Text;
                    dataGridViewMedicinas.Rows[aux].Cells[1].Value = this.txtNombreMedicina.Text;
                    dataGridViewMedicinas.Rows[aux].Cells[2].Value = this.dtpFechaVencimiento.Text;
                    dataGridViewMedicinas.Rows[aux].Cells[3].Value = this.txtPrecioPorUnida.Text;
                    dataGridViewMedicinas.Rows[aux].Cells[4].Value = this.txtCantMedicina.Text;
                    dataGridViewMedicinas.Rows[aux].Cells[5].Value = this.txtPrecioTotal.Text;

                    totalAmount = totalAmount + int.Parse(this.txtPrecioTotal.Text);
                    labelPrecio.Text = "$ "+totalAmount.ToString()+".";

                    query = "update farmaceutico set cantidad = '" + nuevaCantidad+ "' where mid = '" + this.txtIDMedicina.Text+"'";
                    db.setData(query,"Medicina añadida al carrito.");

                }
                else
                {
                    MessageBox.Show("La medicina requerida ya no tiene stock. Solo quedan: "+cantidad+" unidades.","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                this.limpiarAll();
                this.FrmVenderMedicina_Load(this,null);//Añadida al carrito vuelvo a lanzar el load que limpia todo.
            }
            else
            {
                MessageBox.Show("Primero debe seleccionar una medicina para poder añadirla al carrito.","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Me permite eliminar un producto del carrito.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitarDelCarrito_Click(object sender, EventArgs e)
        {
            if (valueID != null)//Si es null no selcciono nada del datagrid
            {
                try
                {
                    dataGridViewMedicinas.Rows.RemoveAt(this.dataGridViewMedicinas.SelectedRows[0].Index);
                }
                catch
                {

                }
                finally
                {
                    query = "select cantidad from farmaceutico where mid = '" + valueID+"'";
                    ds = db.obtenerData(query);
                    cantidad = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    nuevaCantidad = cantidad + numUnits;

                    query = "update farmaceutico set cantidad = '"+nuevaCantidad+"' where mid = '"+valueID+"'";
                    db.setData(query,"La medicina fue elimina del carrito.");
                    totalAmount = totalAmount - valueAmount;
                    labelPrecio.Text = "$ "+ totalAmount.ToString()+".";
                }
                this.FrmVenderMedicina_Load(this,null);
            }
        }

        /// <summary>
        /// Al presionar el boton me permite imprimir el comprobante
        /// de pago.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComprar_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "TICKET COMPRA MEDICINA";
            print.SubTitle = String.Format("Fecha: {0}",DateTime.Now.ToShortDateString());
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "PRECIO FINAL: $"+labelPrecio.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(dataGridViewMedicinas);//Le paso el datagrid para que lo imprima...

            totalAmount = 0;
            labelPrecio.Text = "$ 0.00";
            dataGridViewMedicinas.DataSource = 0;
        }
        #endregion

        /// <summary>
        /// Al cargar el formulario se mostraran las medicinas 
        /// disponibles dentro de un listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVenderMedicina_Load(object sender, EventArgs e)
        {
            this.dtpFechaVencimiento.MinDate = DateTime.Today.AddYears(-9);
            this.dtpFechaVencimiento.MaxDate = DateTime.Today.AddYears(5);

            this.listBoxMedicinas.Items.Clear();
            query = "select mname from farmaceutico where cantidad > '0'";
            ds = db.obtenerData(query);
            for (int i =0;i<ds.Tables[0].Rows.Count;i++)
            {
                this.listBoxMedicinas.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        /// <summary>
        /// Al ir escribiendo dentro del textbox me va mostrando las opciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBuscarMedicina_TextChanged(object sender, EventArgs e)
        {
            this.listBoxMedicinas.Items.Clear();
            query = "select * from farmaceutico where mname like '" + this.txtBuscarMedicina.Text + "%'";
            ds = db.obtenerData(query);
            for (int i = 0;i<ds.Tables[0].Rows.Count;i++)
            {
                this.listBoxMedicinas.Items.Add(ds.Tables[0].Rows[i][2].ToString());
            }
        }

        /// <summary>
        /// Evento que al seleccionar un item del listbox lo que hace es
        /// ponerlo el nombre correspondiente dentro del txtNombreMedicina.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxMedicinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtCantMedicina.Clear();
            string name = this.listBoxMedicinas.GetItemText(this.listBoxMedicinas.SelectedItem);
            this.txtNombreMedicina.Text = name;
            query = "select mid, mVencimiento, porUnidad from farmaceutico where mname = '" + name+"'";
            ds = db.obtenerData(query);
            this.txtIDMedicina.Text = ds.Tables[0].Rows[0][0].ToString();
            this.dtpFechaVencimiento.Text = ds.Tables[0].Rows[0][1].ToString();
            this.txtPrecioPorUnida.Text = ds.Tables[0].Rows[0][2].ToString();

        }

        /// <summary>
        /// A medida que el usuario va escribiendo la cantidad de unidades que quiere se 
        /// va actualizando el precio total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCantMedicina_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCantMedicina.Text !="")
            {
                Int64 unidadPrecio = Int64.Parse(this.txtPrecioPorUnida.Text);
                Int64 numUnidades = Int64.Parse(this.txtCantMedicina.Text);
                Int64 total = numUnidades * unidadPrecio;
                this.txtPrecioTotal.Text = total.ToString();
            }
            else
            {
                this.txtPrecioTotal.Clear();
            }
        }

        /// <summary>
        /// Metodo del form para poder limpiar los textboxes
        /// y el datetimepicker.
        /// </summary>
        private void limpiarAll()
        {
            this.txtCantMedicina.Clear();
            this.txtIDMedicina.Clear();
            this.txtNombreMedicina.Clear();
            this.txtPrecioPorUnida.Clear();
            this.txtPrecioTotal.Clear();
            this.dtpFechaVencimiento.ResetText();
        }

        /// <summary>
        /// Al seleccionar el item luego obtenemos el precio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewMedicinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(dataGridViewMedicinas.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueID = this.dataGridViewMedicinas.Rows[e.RowIndex].Cells[0].Value.ToString();
                numUnits = Int64.Parse(dataGridViewMedicinas.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            {

            }
        } 
    }
}
