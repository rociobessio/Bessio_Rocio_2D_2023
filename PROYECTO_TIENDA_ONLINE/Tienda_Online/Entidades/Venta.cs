using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        #region ATRIBUTOS
        private int _IDVenta;
        private int _IDCliente;
        private int _totalProducto;
        private double _montoTotal;
        private string _IDLocalidad;
        private string _telefono;
        private string _direccion;
        private string _transaccion;
        private List<DetalleVenta> _listaDetalleVenta;
        #endregion

        #region PROPIEDADES
        public int IDVenta { get { return this._IDVenta; } set { this._IDVenta = value;} }
        public int IDCliente { get {  return this._IDCliente; } set { this._IDCliente = value;} }
        public int TotalProducto { get {  return this._totalProducto; } set { this._totalProducto = value;} }
        public double MontoTotal { get {  return this._montoTotal; } set { this._montoTotal = value;} }
        public string IDLocalidad { get {  return this._IDLocalidad; } set { this._IDLocalidad = value; } }
        public string Telefono { get {  return this._telefono; } set { this._telefono = value;} }
        public string Direccion { get { return this._direccion; } set { this._direccion = value;} }
        public string Transaccion { get { return this._transaccion; } set { this._transaccion = value;} }
        public List<DetalleVenta> ListaDetalleVentas { get { return this._listaDetalleVenta; } set { this._listaDetalleVenta = value; } }
        #endregion
    }
}
