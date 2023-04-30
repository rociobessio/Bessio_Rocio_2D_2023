using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tarjeta
    {
        #region ATRIBUTOS
        private string _entidadEmisora;
        private string _titular;
        private string _numeroTarjeta;//16 numeros
        private string _cvv;//4 numeros mas importantes
        private DateTime _fechaVencimiento;
        private double _dineroDisponible;
        private bool _esDebito;//-->Puede ser debito o credito
        #endregion

        #region PROPIEDADES
        public DateTime FechaVencimiento { get { return this._fechaVencimiento; } }
        public string CVV { get { return this._cvv; } }
        public string NumeroTarjeta { get { return this._numeroTarjeta;} }
        public string EntidadEmisora { get { return this._entidadEmisora; } }
        public string Titular { get { return this._titular; } }
        public double DineroDisponible { get { return this._dineroDisponible; } set { this._dineroDisponible = value; } }
        public bool EsDebito { get { return this._esDebito; } set { this._esDebito = value; } }
        #endregion 

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor parametrizado de la clase Tarjeta, me permite crear una instancia
        /// con valores.
        /// </summary>
        /// <param name="vencimiento"></param>
        /// <param name="titular"></param>
        /// <param name="cvv"></param>
        /// <param name="numeroTarjeta"></param>
        /// <param name="entidadEmisora"></param>
        /// <param name="saldo"></param>
        public Tarjeta(DateTime vencimiento,string titular, string cvv, string numeroTarjeta,
            string entidadEmisora, double saldo, bool esDebito)
        {
            this._fechaVencimiento = vencimiento;
            this._titular = titular;
            this._cvv = cvv;
            this._numeroTarjeta = numeroTarjeta;
            this._entidadEmisora = entidadEmisora;
            this._dineroDisponible = saldo;
            this._esDebito = esDebito;
        }
        #endregion

        #region METODOS 
        /// <summary>
        /// Este metodo estatico me permite verificar si la tarjeta
        /// es valida, mediante su numero (cant digitos), su fecha de vencimiento
        /// y si tiene saldo disponible.
        /// </summary>
        /// <param name="tarjetaValidar"></param>
        /// <returns>Retornara true si es valida, false sino.</returns>
        public static bool ValidarTarjeta(Tarjeta tarjetaValidar)
        {
            bool esValida = true;//Como inicio presupongo que es valida. 
            
            if (tarjetaValidar._numeroTarjeta.Length < 16 ||
                tarjetaValidar._numeroTarjeta.Length > 16 ||
                tarjetaValidar._dineroDisponible < 0 || 
                tarjetaValidar._fechaVencimiento < DateTime.Now ||
                tarjetaValidar._cvv.Length < 4 || tarjetaValidar._cvv.Length > 4)
            {
                esValida = false;
            }

            return esValida;
        }
        #endregion

        #region SOBRECARGA
        /// <summary>
        /// Dos tarjetas seran iguales si tienen el mismo numero y titular.
        /// </summary>
        /// <param name="tarjeta1"></param>
        /// <param name="tarjeta2"></param>
        /// <returns></returns>
        public static bool operator ==(Tarjeta tarjeta1, Tarjeta tarjeta2)
        {
            bool sonIguales = false;
            if (!(tarjeta1 is null) && !(tarjeta2 is null))
            {
                sonIguales = (tarjeta1._titular == tarjeta2._titular) &&
                             (tarjeta1._numeroTarjeta == tarjeta2._numeroTarjeta);
            }
            return sonIguales;
        }

        public static bool operator !=(Tarjeta tarjeta1, Tarjeta tarjeta2)
        {
            return !(tarjeta1 == tarjeta2);
        }
        #endregion

        #region POLIMORFISMO
        /// <summary>
        /// Sobrecarga del .ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this._entidadEmisora}-{this._titular}-{this._fechaVencimiento}-" +
                $"{this._numeroTarjeta}-{this._cvv}-{this._dineroDisponible}-{this._esDebito}";
        }
        #endregion
    }
}
