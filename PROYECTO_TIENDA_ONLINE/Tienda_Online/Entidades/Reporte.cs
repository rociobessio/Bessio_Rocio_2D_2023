using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reporte
    {
        #region ATRIBUTOS
        private string _fechaVenta;
        private string _cliente;
        private string _producto;
        private double _precio;
        private int _cantidad;
        private double _total;
        private string _idTransaccion;
        #endregion

        #region PROPIEDADES
        public string FechaVenta { get { return this._fechaVenta; } set {  this._fechaVenta = value; } }
        public string Cliente { get {  return this._cliente; } set { this._cliente = value; } }
        public string Producto { get { return this._producto; } set { this._producto = value; } }
        public double Precio { get { return this._precio; } set { this._precio = value; } }
        public int Cantidad { get {  return this._cantidad; } set { this._cantidad = value; } } 
        public double Total { get { return this._total; } set { this._total = value; } }
        public string IDTransaccion { get {  return this._idTransaccion; } set { this._idTransaccion = value;} }
        #endregion
    }
}
