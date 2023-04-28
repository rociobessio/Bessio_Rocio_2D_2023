using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carniceria_GUI
{
    public partial class FrmHeladera : Form
    {
        #region ATRIBUTOS DEL FORM
        //Producto producto1;
        //Producto producto2;
        //Producto producto3;
        //Producto producto4;
        //List<Producto> listaProductos;

        List<Carne2> listaCarnesDisponibles;
        Carne2 carneIngreso;
        Tipo tipoCarne;
        Corte corteCarne;
        Textura texturaCarne;

        #region DATAGRIDVIEW
        DataTable tablaProductos;
        DataRow auxFilaProduc;
        DataGridViewRow auxFilaCarnes;
        int indexTablaProductos;
        int idSelected;
        int indiceViajFrmInformacionDetallada;
        #endregion

        FrmVentaVendedor frmVentaVendedor;
        Vendedor vendedor1;
        #endregion

        public FrmHeladera(Vendedor vendedor)
        {
            InitializeComponent();
            this.label1.Text = $"Hola {vendedor.Usuario.ToString()}";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Perfil Vendedor";
            vendedor1 = vendedor;

            this.tablaProductos = new DataTable();
            #region INSTANCIO CARNES
            this.listaCarnesDisponibles = new List<Carne2>();
            this.listaCarnesDisponibles.Add(new Carne2(Corte.Lomo, 1900, Textura.Tierno, new DateTime(2023, 12, 10), 900, "Mingo CO", Tipo.Carne, 10, 90));
            this.listaCarnesDisponibles.Add(new Carne2(Corte.Pechuga, 700, Textura.Firme, new DateTime(2023, 11, 22), 100, "La Granjita", Tipo.Pollo, 10, 90));
            this.listaCarnesDisponibles.Add(new Carne2(Corte.Costilla, 1900, Textura.Grasoso, new DateTime(2023, 09, 08), 230, "El Muelle Mardel", Tipo.Cerdo, 10, 90));
            #endregion

            //#region INSTANCIO PRODUCTOS
            //this.listaProductos = new List<Producto>();
            //this.producto1 = new Producto(Tipo.Carne, "Casa Blanco", 10, 5000);
            //this.producto2 = new Producto(Tipo.Pollo, "La Granjita", 100, 120);
            //this.producto3 = new Producto(Tipo.Cerdo, "Cerdos CO.", 900, 1290);
            //this.producto4 = new Producto(Tipo.Pescado, "El Muelle", 100, 800);
            //this.listaProductos.Add(this.producto1);
            //this.listaProductos.Add(this.producto2);
            //this.listaProductos.Add(this.producto3);
            //this.listaProductos.Add(this.producto4);
            //#endregion

            //#region INSTANCIO CARNES
            //this.listaCarnes = new List<Carnes>();
            //this.carne1 = new Carnes(Corte.Lomo, 1900, Textura.Tierno, new DateTime(2024, 01, 12), 1000);
            //#endregion

            #region AYUDA
            StringBuilder textoAyuda = new StringBuilder();
            textoAyuda.AppendLine("El vendedor podrá reponer los productos, visualizarlos");
            textoAyuda.AppendLine("y también podrá seleccionar a un cliente y venderle un producto.");
            FrmLogin.MostrarAyuda(this.lblPrintHelp, textoAyuda.ToString());
            #endregion      

        }

        private void FrmHeladera_Load(object sender, EventArgs e)
        {
            this.tablaProductos.Columns.Add("Tipo");
            this.tablaProductos.Columns.Add("Corte");
            this.tablaProductos.Columns.Add("Textura");
            this.tablaProductos.Columns.Add("Peso");
            this.tablaProductos.Columns.Add("Stock");
            this.tablaProductos.Columns.Add("Precio C/ Unidad");
            this.tablaProductos.Columns.Add("Vencimiento");
            this.tablaProductos.Columns.Add("Proveedor");
            this.tablaProductos.Columns.Add("Precio compra Frigorifico");

            //this.dataGridViewProductos.DataSource = listaProductos;

            //#region AGREGO LAS CARNES A LA LISTA DE PRODUCTOS
            //this.producto1 += listaCarnes;//Al producto le añado la carne
            //#endregion

            foreach (Tipo tipo in Enum.GetValues(typeof(Tipo)))
            {
                //this.cbTipoCarneMostrar.Items.Add(tipo);
                this.cbTipoDeCarneReponer.Items.Add(tipo);
            }

            foreach (Textura textura in Enum.GetValues(typeof(Textura)))
            {
                this.cbTexturaCarne.Items.Add(textura);
            }

            this.CargarProductos();//-->Ponele que no quiero que me lo muestre de porsi
        }

        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Recolecto la celda clickeada de la tabla de viajes, especificamente el primer indice donde
            // se guarda la matricula y el cuarto indice donde se guarda la fecha de salida
            // y recorro la lista de cruceros para buscar el match y la lista de viajes para buscar el match.
            //this.indexTablaProductos = e.RowIndex;

            //// Si el indice es -1 significa que esta clickeando el header de la columna
            //if (this.indexTablaProductos > -1)
            //{
            //    this.indiceViajFrmInformacionDetallada = 0;

            //    this.idSelected = (int)this.dataGridViewProductos.Rows[indexTablaProductos].Cells[0].Value;
            //}

            //foreach (Producto item in this.listaProductos)
            //{
            //    if (item == idSelected)
            //    {
            //        foreach (Carnes carnes in item.ListaCarnes)
            //        {
            //            //richTextBox1.Text = carnes.ToString();
            //        }
            //    }
            //}
            //foreach (Producto product in this.listaProductos)
            //{
            //    if (product == idSelected)
            //    {
            //        // Limpio la lista de pasajeros y muestro los pasajeros del viaje seleccionado
            //        this.dataGridView1.Rows.Clear();

            //        if (product.ListaCarnes.Count == 0)
            //        {
            //            // En caso de no haber pasajeros en la lista se muestra un mensaje aclarandolo
            //            this.auxFilaCarnes = new();
            //            this.auxFilaCarnes.CreateCells(this.dataGridView1);

            //            this.auxFilaCarnes.Cells[0].Value = "PRODUCTO SIN CARNE";

            //            this.dataGridView1.Rows.Add(this.auxFilaCarnes);
            //        }
            //        else
            //        {
            //            // Recorre la lista de pasajeros que tiene el viaje seleccionado
            //            // Por cada uno crea una fila y rellena cada columna con todos sus datos
            //            // Por ultimo agrega la fila al DataGridView de Pasajero
            //            for (int i = 0; i < product.ListaCarnes.Count; i++)
            //            {
            //                this.auxFilaCarnes = new();
            //                this.auxFilaCarnes.CreateCells(this.dataGridView1);

            //                this.auxFilaCarnes.Cells[0].Value = $"{product.ListaCarnes[i].Corte}";
            //                this.auxFilaCarnes.Cells[1].Value = $"{product.ListaCarnes[i].Textura}";
            //                this.auxFilaCarnes.Cells[2].Value = $"{product.ListaCarnes[i].Peso}";
            //                this.auxFilaCarnes.Cells[3].Value = $"{product.ListaCarnes[i].Precio}";
            //                this.auxFilaCarnes.Cells[4].Value = $"{product.ListaCarnes[i].Vencimiento}";

            //                this.dataGridView1.Rows.Add(this.auxFilaCarnes);
            //            }
            //        } 
            //        break;
            //    }
            //    // Guarda el indice viaje seleccionado para poder utilizo por fuera del foreach
            //    indiceViajFrmInformacionDetallada++;


        }

        /// <summary>
        /// Al seleccionar un tipo de carne, se cambiara el tipo de corte y textura que
        /// se pueda seleccionar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbTipoDeCarneReponer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //-->Los dejo sino cada vez que cambie el indice se sumaran a los que ya estan
            this.cbCorteCarne.Items.Clear();
            this.cbTexturaCarne.Items.Clear();

            if (this.cbTipoDeCarneReponer.SelectedItem.ToString() == Tipo.Carne.ToString())
            {
                this.cbCorteCarne.Items.Add(Corte.Nalga);
                this.cbCorteCarne.Items.Add(Corte.Filette);
                this.cbCorteCarne.Items.Add(Corte.Asado);
                this.cbCorteCarne.Items.Add(Corte.Bife);
                this.cbCorteCarne.Items.Add(Corte.Solomillo);
                this.cbCorteCarne.Items.Add(Corte.Vacio);
                this.cbCorteCarne.SelectedIndex = 0;//-->Selecciono el primero de esa opcion, si cambiase el Tipo me quedaria seleccionado el indice anterior

                this.cbTexturaCarne.Items.Add(Textura.Sin_Grasa);
                this.cbTexturaCarne.Items.Add(Textura.Firme);
                this.cbTexturaCarne.Items.Add(Textura.Tierno);
                this.cbTexturaCarne.Items.Add(Textura.Grasoso);
                this.cbTexturaCarne.SelectedIndex = 0;
            }
            else if (this.cbTipoDeCarneReponer.SelectedItem.ToString() == Tipo.Pollo.ToString())
            {
                this.cbCorteCarne.Items.Add(Corte.Pechuga);
                this.cbCorteCarne.Items.Add(Corte.Suprema);
                this.cbCorteCarne.SelectedIndex = 0;
                this.cbTexturaCarne.Items.Add(Textura.Tierno);
                this.cbTexturaCarne.SelectedIndex = 0;
            }
            else if (this.cbTipoDeCarneReponer.SelectedItem.ToString() == Tipo.Cerdo.ToString())
            {
                this.cbCorteCarne.Items.Add(Corte.Filette);
                this.cbCorteCarne.Items.Add(Corte.Costilla);
                this.cbCorteCarne.Items.Add(Corte.Bife);
                this.cbCorteCarne.Items.Add(Corte.Lomo);
                this.cbCorteCarne.SelectedIndex = 0;

                this.cbTexturaCarne.Items.Add(Textura.Sin_Grasa);
                this.cbTexturaCarne.Items.Add(Textura.Firme);
                this.cbTexturaCarne.Items.Add(Textura.Tierno);
                this.cbTexturaCarne.Items.Add(Textura.Grasoso);
                this.cbTexturaCarne.SelectedIndex = 0;
            }
        }

        #region METODOS DEL FORM
        /// <summary>
        /// Metodo privado que me permite cargar los productos de la lista,
        /// la recorre, uso auxiliares de las filas para poder imprimir los atributos
        /// en el datagrid.
        /// 
        /// Es una forma de que me muestre lo que quiero, ya que sino directamente
        /// al datagrid se le puede pasar la lista y mostrara gracias a las propiedades
        /// de la clase.
        /// </summary>
        private void CargarProductos()
        {
            tablaProductos.Rows.Clear();

            foreach (Carne2 carnes in this.listaCarnesDisponibles)
            {
                auxFilaProduc = tablaProductos.NewRow();

                auxFilaProduc[0] = $"{carnes.Tipo}";
                auxFilaProduc[1] = $"{carnes.Corte}";
                auxFilaProduc[2] = $"{carnes.Textura}";
                auxFilaProduc[3] = $"{carnes.Peso}";
                auxFilaProduc[4] = $"{carnes.Stock}";
                auxFilaProduc[5] = $"{carnes.PrecioVenta}";
                auxFilaProduc[6] = $"{carnes.Vencimiento}";
                auxFilaProduc[7] = $"{carnes.Proveedor}";
                auxFilaProduc[8] = $"{carnes.PrecioCompra}";

                tablaProductos.Rows.Add(auxFilaProduc);//-->Añado las Filas
            }
            this.dataGridViewProductos.DataSource = tablaProductos;//-->Al dataGrid le paso la lista
        }

        /// <summary>
        /// Este metodo privado de me permite verificar los datos que ingrese el usuario.
        /// </summary>
        /// <returns>Devuelve true si la informacion es valida, false sino</returns>
        private bool ValidarDatos()
        {
            bool esValido = true;
            double peso;
            double precio;
            double precioCompra;
            double.TryParse(this.txtPrecio.Text, out precio);
            double.TryParse(this.txtPesoCarne.Text, out peso);
            double.TryParse(this.txtPrecioCompra.Text, out precioCompra);


            if (string.IsNullOrEmpty(this.txtProveedor.Text) ||
                string.IsNullOrEmpty(this.txtPrecio.Text) || string.IsNullOrEmpty(this.txtPesoCarne.Text) ||
                string.IsNullOrEmpty(this.cbTipoDeCarneReponer.Text) ||
                string.IsNullOrEmpty(this.cbTexturaCarne.Text) ||
                string.IsNullOrEmpty(this.cbCorteCarne.Text))
            {
                esValido = false;//-->Alguna de todas las cadenas ingresadas es invalida
            }

            //--->Valido los numeros
            if (peso <= 0 || precio <= 0 ||
                this.numericStock.Value <= 0 || precioCompra <= 0)
            {
                esValido = false;//-->Si alguno de los valores ingresado es menor o igual a 0, no lo dejo.
            }

            //-->Valido que no ingrese una fecha invalida, es decir, un producto vencido.
            if (this.dtpFechaVencimiento.Value < DateTime.Now)
            {
                esValido = false;//-->Producto vencido
            }

            if (!esValido)
            {
                MessageBox.Show("Alguno de los datos es incorrecto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return esValido;
        }
        #endregion

        /// <summary>
        /// Al presionar este boton me permitira guardar un nuevo producto en la lista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReponer_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())//-->Valido los datos
            {
                texturaCarne = Enum.Parse<Textura>(this.cbTexturaCarne.SelectedItem.ToString());
                carneIngreso = new Carne2(Enum.Parse<Corte>(this.cbCorteCarne.SelectedItem.ToString()), double.Parse(this.txtPesoCarne.Text),
                    texturaCarne, this.dtpFechaVencimiento.Value, double.Parse(this.txtPrecio.Text),
                    this.txtProveedor.Text, Enum.Parse<Tipo>(this.cbTipoDeCarneReponer.SelectedItem.ToString()), (int)this.numericStock.Value,
                    double.Parse(this.txtPrecioCompra.Text));
                this.listaCarnesDisponibles.Add(carneIngreso);
                this.CargarProductos();//-->Actualizo el dataGrid
            }
        }

        /// <summary>
        /// Le preguntara al usuario si desea realmente cerrar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmHeladera_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea salir?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.No == respuesta)
            {
                e.Cancel = true;
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            frmVentaVendedor = new FrmVentaVendedor(vendedor1);
            frmVentaVendedor.ShowDialog();
        }
    }
}
