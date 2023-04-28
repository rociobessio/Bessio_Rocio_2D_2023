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
        private Textura _texturaCarne;
        private Corte _corteCarne;
        private int _codigo;
        private int _stockActual;
        private string _proveedor;
        private double _peso;
        private DateTime _vencimiento;
        private double _precio;
        private static int ultimoCodigo;
        #endregion

        #region 
        public int Codigo { get { return this._codigo; } }
        public Tipo Tipo { get { return this._tipoCarne; } }
        public Corte Corte { get { return this._corteCarne; } }
        public double Peso { get { return this._peso; } }
        public Textura Textura { get { return this._texturaCarne; } }
        public DateTime Vencimiento { get { return this._vencimiento; } }
        public double Precio { get { return this._precio; } }
        public int Stock { get { return this._stockActual; } }
        public string Proveedor { get { return this._proveedor; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Este constructor lo que hara es setear el ultimo codigo como 100, 
        /// luego ira en incrementandose en los demas constructores.
        /// </summary>
        private Carne2()
        {
            ultimoCodigo = 100; 
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
        public Carne2(Corte corteCarne, double peso, Textura texturaCarne, DateTime vencimiento, double precio,
            string proveedor, Tipo tipoCarne, int stock)
        {
            this._tipoCarne = tipoCarne;
            this._corteCarne = corteCarne;
            this._peso = peso;
            this._texturaCarne = texturaCarne;
            this._vencimiento = vencimiento;
            this._precio = precio;
            this._proveedor = proveedor;
            this._stockActual = stock; 
            this._codigo = ultimoCodigo;
            ultimoCodigo++;//POr cada instancia incrementa el numero del ultcodigo
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
            return $"{this._corteCarne}-{this._peso}-{this._texturaCarne}-{this._vencimiento}-{this._precio}";
        }
        #endregion
    }
}
