using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleVenta
    {
        #region ATRIBUTOS
        private int _IDDetalleVenta;
        private int _IDVenta;
        private Producto _producto;
        private int _cantidad;
        private double _total;
        #endregion

        #region PROPIEDADES
        public int IDDetalleVenta { get { return this._IDDetalleVenta; } set { this._IDDetalleVenta = value; } }
        public int IDVenta { get { return this._IDVenta; } set { this._IDVenta = value; } }
        public Producto Producto { get { return this._producto; } set { this._producto = value; } }
        public int Cantidad { get {  return this._cantidad; } set { this._cantidad = value; } }
        public double Total { get { return this._total; } set { this._total = value; } }
        public string Transaccion { get; set; }
        #endregion
    }
}
