using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipaje
    {
        #region ATRIBUTOS
        private int pesoTotalValija;
        private int cantValijas;
        //private int cantBolsos;
        //private bool esValija;
        private bool esDeMano;
        #endregion

        #region PROPIEDADES
        public bool EsDeMano { get { return this.esDeMano; } }
        public int CantValijas { get { return this.cantValijas; } }
        public int PesoTotalValija { get { return this.pesoTotalValija; }  }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor parametrizado de la clase Equipaje.
        /// </summary>
        public Equipaje(bool esDeMano, int cantValija, int pesoValija)
        {
            this.esDeMano = esDeMano;
            this.cantValijas = cantValija;
            this.pesoTotalValija = pesoValija;
        }
        #endregion

    }
}
