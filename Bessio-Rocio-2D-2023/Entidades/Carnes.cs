using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carnes
    {
        #region ATRIBUTOS
        private Corte _corteCarne;
        private double _peso;
        private CategoriaBovina _texturaCarne;
        private DateTime _vencimiento;
        private double _precio;
        #endregion

        #region 
        public Corte Corte { get { return this._corteCarne;} }
        public double Peso { get { return this._peso;} }
        public CategoriaBovina Textura { get { return this._texturaCarne;} } 
        public DateTime Vencimiento { get { return this._vencimiento;} }
        public double Precio { get { return this._precio; } }
        #endregion 

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor parametrizado que me permitira crear una instancia
        /// del tipo Carnes.
        /// </summary>
        /// <param name="tipoCarne"></param>
        /// <param name="corteCarne"></param>
        /// <param name="peso"></param>
        /// <param name="texturaCarne"></param>
        /// <param name="vencimiento"></param>
        public Carnes( Corte corteCarne, double peso, CategoriaBovina texturaCarne,DateTime vencimiento,double precio)
        {
            this._corteCarne = corteCarne;
            this._peso = peso;
            this._texturaCarne = texturaCarne;
            this._vencimiento = vencimiento;
            this._precio = precio;
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
