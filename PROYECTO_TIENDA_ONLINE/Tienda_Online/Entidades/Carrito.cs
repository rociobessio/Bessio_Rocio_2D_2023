using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrito
    {
        #region ATRIBUTOS
        private int _IDCarrito;
        private Cliente _cliente;
        private Producto _producto;
        private int _cantidad;
        #endregion

        #region PROPIEDADES
        public int IDCarrito { get { return this._IDCarrito; }  set { this._IDCarrito = value; } }
        public Cliente Cliente { get { return this._cliente; } set { this._cliente = value; } }
        public Producto Producto { get { return this._producto; } set { this._producto = value; } }
        public int Cantidad { get {  return this._cantidad; } set { this._cantidad = value; } }
        #endregion
    }
}
