using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{ 
    public class Pasaporte
    {
        #region ATRIBUTOS
        private DateTime fechaNacimiento;
        private DateTime fechaVencimiento;
        protected Tipo tipoPasaporte;
        protected string apellido;
        protected string nombre;
        protected Genero genero;
        protected int dni;
        protected string nacionalidad;
        protected string numeroPasaporte;//Formato AAA000000 (3 letras y 6 digitos)
        #endregion

        #region PROPIEDADES
        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        public string NombreCompleto { get { return $"{this.Apellido}, {this.Nombre}"; } }
        public Genero Genero { get { return this.genero; } }
        public int Dni { get { return this.dni; } }
        public string Nacionalidad { get { return this.nacionalidad; } }
        public string NumeroPasaporte { get { return this.numeroPasaporte; } set { this.numeroPasaporte = value; } }
        public Tipo TipoPasaporte { get { return this.tipoPasaporte; } set { this.tipoPasaporte = value; } }
        public DateTime Vencimiento { get { return this.fechaVencimiento; } set { this.fechaVencimiento = value; } }
        public DateTime Nacimiento { get { return this.fechaVencimiento; } set { this.fechaNacimiento = value; } }
        #endregion

        #region CONSTRUCTOR 
        /// <summary>
        /// Constructor parametrizado de la clase Pasaporte.
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="vencimiento"></param>
        /// <param name="nacimiento"></param>
        /// <param name="genero"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="dni"></param>
        /// <param name="numeroPasaporte"></param>
        public Pasaporte(Tipo tipo,DateTime vencimiento,DateTime nacimiento, Genero genero, string nacionalidad,
            string apellido, string nombre, int dni,string numeroPasaporte) 
        {
            this.fechaVencimiento = vencimiento;
            this.tipoPasaporte = tipo;
            this.fechaNacimiento = nacimiento;
            this.genero = genero;
            this.nacionalidad = nacionalidad;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.numeroPasaporte = numeroPasaporte;
        }
        #endregion

    }
}
