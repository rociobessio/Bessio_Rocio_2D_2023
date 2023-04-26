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
        private double _saldoDisponible;
        #endregion

        #region PROPIEDADES
        public DateTime FechaVencimiento { get { return this._fechaVencimiento; } }
        public string CVV { get { return this._cvv; } }
        public string NumeroTarjeta { get { return this._numeroTarjeta;} }
        public string EntidadEmisora { get { return this._entidadEmisora; } }
        public string TItular { get { return this._titular; } }
        public double Saldo { get { return this._saldoDisponible; } set { this._saldoDisponible = value; } }
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
        public Tarjeta(DateTime vencimiento,string titular,string cvv,string numeroTarjeta,
            string entidadEmisora,double saldo)
        {
            this._fechaVencimiento = vencimiento;
            this._titular = titular;
            this._cvv = cvv;
            this._numeroTarjeta = numeroTarjeta;
            this._entidadEmisora = entidadEmisora;
            this._saldoDisponible=saldo;
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
        static bool ValidarTarjeta(Tarjeta tarjetaValidar)
        {
            bool esValida = true;//Como inicio presupongo que es valida.

            //// Eliminar los espacios en blanco y los guiones del número de tarjeta
            //this._numeroTarjeta = this._numeroTarjeta.Replace(" ", "").Replace("-", "");
            
            if (tarjetaValidar._numeroTarjeta.Length < 16 ||
                tarjetaValidar._saldoDisponible < 0 || 
                tarjetaValidar._fechaVencimiento < DateTime.Now)
            {
                esValida = false;
            }

            return esValida;
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
                $"{this._numeroTarjeta}-{this._cvv}-{this._saldoDisponible}";
        }
        #endregion
    }
}
