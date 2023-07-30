using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Esta clase servirá para 
    /// llevar un control de las
    /// cantidades de productos,
    /// clientes y ventas realizadas.
    /// </summary>
    public class PanelControl
    {
        #region ATRIBUTOS
        private int _totalClientes;
        private int _totalProductos;
        private int _totalVentas;
        #endregion

        #region PROPIEDADES
        public int TotalClientes { get {  return this._totalClientes; } set {  this._totalClientes = value; } }
        public int TotalProductos { get { return this._totalProductos; } set { this._totalProductos = value; } }
        public int TotalVentas { get { return this._totalVentas; } set { this._totalVentas = value; } } 
        #endregion
    }
}
