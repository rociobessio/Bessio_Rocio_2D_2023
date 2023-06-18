﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carniceria_GUI
{
    public partial class FrmMenuPrincipalVendedor : Form
    {
        #region ATRIBUTOS
        private Usuario vendedorForm;
        private FrmHeladera frmHeladera;
        private FrmVentaVendedor frmVentaVendedor;
        private FrmVisualizacionProductos frmVisualizarProductos;
        private FrmHistorialVentas frmHistorialVentas;
        #endregion

        #region CONSTRUCTORES
        public FrmMenuPrincipalVendedor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Menu Principal Vendedor";
        }

        public FrmMenuPrincipalVendedor(Usuario user)
            : this()
        {
            vendedorForm = user;
            this.lblVendedorEmail.Text = user;
            this.lblHoraIngreso.Text = user.HoraIngreso.ToShortTimeString();

            #region PRINT AYUDA
            StringBuilder textoAyuda = new StringBuilder();
            textoAyuda.AppendLine("El vendedor podrá reponer el stock de un producto, venderle a un cliente o ver el historial de compras y ventas.");
            FrmLogin.MostrarAyuda(this.lblPrintHelp, textoAyuda.ToString());
            #endregion  
        }
        #endregion

        #region EVENTOS
        private void FrmMenuPrincipalVendedor_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }
        #endregion

        #region BOTONES
        /// <summary>
        /// Abre el formulario de ventas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVender_Click(object sender, EventArgs e)
        {
            frmVentaVendedor = new FrmVentaVendedor(vendedorForm);
            frmVentaVendedor.ShowDialog();
        }

        /// <summary>
        /// Abre el formulario de heladera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReponer_Click(object sender, EventArgs e)
        {
            frmHeladera = new FrmHeladera(vendedorForm);
            frmHeladera.ShowDialog();
        }

        /// <summary>
        /// Abre el formulario de historial.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            //frmVisualizarProductos = new FrmVisualizacionProductos(vendedorForm);
            //frmVisualizarProductos.ShowDialog();
            frmHistorialVentas = new FrmHistorialVentas(vendedorForm);
            frmHistorialVentas.ShowDialog();    
        }
        #endregion 
    }
}