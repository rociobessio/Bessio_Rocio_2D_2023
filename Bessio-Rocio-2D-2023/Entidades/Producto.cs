using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        #region ATRIBUTOS
        private int _codigo;
        private TipoCorte _tipoCorte;
        private float _peso;
        private double _precio;
        private int _stock;
        private string _proveedor;

        private static int ultimoCodigo;
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Este constructor lo que hara es setear el ultimo codigo como 100, 
        /// luego ira en incrementandose en los demas constructores.
        /// </summary>
        private Producto()
        {
            ultimoCodigo = 100;
        }

        /// <summary>
        /// Constructor parametrizado que me permite crear una instancia parametrizada de
        /// Producto.
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="precio"></param>
        /// <param name="proveedor"></param>
        /// <param name="peso"></param>
        public Producto(TipoCorte tipo, double precio,string proveedor,float peso)
        {
            this._peso = peso;
            this._proveedor = proveedor;
            this._tipoCorte = tipo;
            this._precio = precio;
            this._codigo = ultimoCodigo;
            ultimoCodigo++;//POr cada instancia incrementa el numero del ultcodigo
        }

        /// <summary>
        /// Constructor que me permite cargar el stock realizando una sobrecarga.
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="precio"></param>
        /// <param name="proveedor"></param>
        /// <param name="stock"></param>
        /// /// <param name="peso"></param>
        public Producto(TipoCorte tipo, double precio,string proveedor,float peso ,int stock)
                : this(tipo, precio,proveedor,peso)
        {
            this._stock = stock;
        }
        #endregion
    }
}
