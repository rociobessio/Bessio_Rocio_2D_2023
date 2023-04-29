using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carne2
    {
        #region ATRIBUTOS
        private Tipo _tipoCarne;
        private CategoriaBovina _texturaCarne;
        private Corte _corteCarne;
        private int _codigo;
        private int _stockActual;
        private string _proveedor;
        private double _peso;
        private DateTime _vencimiento;
        private double _precioVenta;//--->Precio por el cual lo voy a vender
        private double _precioCompra;//--->Precio por el cual compre en un frigorifico
        private static int ultimoCodigo;
        #endregion

        #region 
        public int Codigo { get { return this._codigo; } }
        public Tipo Tipo { get { return this._tipoCarne; } }
        public Corte Corte { get { return this._corteCarne; } }
        public double Peso { get { return this._peso; } set { this._peso = value; } }
        public CategoriaBovina Textura { get { return this._texturaCarne; } }
        public DateTime Vencimiento { get { return this._vencimiento; } }
        public double PrecioVenta { get { return this._precioVenta; } }
        public int Stock { get { return this._stockActual; } set { this._stockActual = value; } }
        public string Proveedor { get { return this._proveedor; } }
        public double PrecioCompra { get { return this._precioCompra; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Sera mi constructor por defecto.
        /// </summary>
        public Carne2()
        {
            _tipoCarne = Tipo.Carne_Vacuna;
            _texturaCarne = CategoriaBovina.Novillito;
            _corteCarne = Corte.Lomo;
            _stockActual = 0;
            _proveedor = "";
            _peso = 0;
            _vencimiento = DateTime.Now;
            _precioVenta = 0;
            _precioCompra = 0;
        }

        /// <summary>
        /// Constructor parametrizado que me permitira crear una instancia
        /// del tipo Carnes.
        /// </summary>
        /// <param name="tipoCarne"></param>
        /// <param name="corteCarne"></param>
        /// <param name="peso"></param>
        /// <param name="texturaCarne"></param>
        /// <param name="vencimiento"></param>
        public Carne2(Corte corteCarne, double peso, CategoriaBovina texturaCarne, DateTime vencimiento, double precio,
            string proveedor, Tipo tipoCarne, int stock,double precioCompra)
        {
            this._precioCompra = precioCompra;
            this._tipoCarne = tipoCarne;
            this._corteCarne = corteCarne;
            this._peso = peso;
            this._texturaCarne = texturaCarne;
            this._vencimiento = vencimiento;
            this._precioVenta = precio;
            this._proveedor = proveedor;
            this._stockActual = stock;
            this._codigo = ultimoCodigo;
            ultimoCodigo++;//POr cada instancia incrementa el numero del ultcodigo
        }
        #endregion

        #region SOBRECARGA
        /// <summary>
        /// Compara si el codigo de un objeto Carne es igual al int
        /// que recibe.
        /// </summary>
        /// <param name="carne1"></param>
        /// <param name="codigo"></param>
        /// <returns>Retorna true si coinciden,false sino</returns>
        public static bool operator ==(Carne2 carne1,int codigo)
        {
            bool sonIguales = false;
            if (!(carne1 is null) && codigo >= 0)
            {
                sonIguales = carne1._codigo == codigo; 
            }
            return sonIguales;
        }

        public static bool operator !=(Carne2 carne1, int codigo)
        {
            return !(carne1 == codigo);
        }
        #endregion

        #region POLIMORFISMO
        /// <summary>
        /// La sobrecarga del .TOString() me permite devolver
        /// la informacion del objeto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this._corteCarne}-{this._peso}-{this._texturaCarne}-{this._vencimiento}-${this._precioVenta}" +
                $"-${this._precioCompra}";
        }
        #endregion
    }
}
