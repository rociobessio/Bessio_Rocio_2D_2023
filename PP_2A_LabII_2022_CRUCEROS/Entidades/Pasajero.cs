using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasajero : Pasaporte
    {
        #region ATRIBUTOS
        protected Pasaporte pasaporte;
        protected Clase clase;
        protected Equipaje equipaje;
        protected int edad;
        #endregion

        #region PROPIEDADES
        public int Edad { get { return this.edad; } }
        public Clase Clase { get { return this.clase; } }
        public Equipaje Equipaje { get { return this.equipaje; } } 
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor parametrizado de la clase Pasajero.
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="numeroPasaporte"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="tipo"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="fechaVencimiento"></param>
        /// <param name="genero"></param>
        /// <param name="bolsoDeMano"></param>
        /// <param name="cantidadValijas"></param>
        /// <param name="pesoTotalValijas"></param>
        public Pasajero(Clase clase, string nombre, string apellido, int dni, string numeroPasaporte, string nacionalidad,Tipo tipo,
            DateTime fechaNacimiento, DateTime fechaVencimiento, Genero genero, bool bolsoDeMano, int cantidadValijas, int pesoTotalValijas)
            : base(tipo, fechaNacimiento, fechaVencimiento, genero,nacionalidad,apellido,nombre,dni,numeroPasaporte)
        {
            this.pasaporte = new Pasaporte(tipo, fechaNacimiento, fechaVencimiento, genero, nacionalidad, apellido, nombre, dni, numeroPasaporte) ;
            this.clase = clase;
            this.equipaje = new Equipaje(bolsoDeMano,cantidadValijas,pesoTotalValijas);
            this.edad = DateTime.Today.AddTicks(-fechaNacimiento.Ticks).Year - 1;
        }
        #endregion 

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Dos pasajeros seran iguales si sus dnis son coincidentes.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator == (Pasajero p1,Pasajero p2)
        {
            return p1.dni == p2.dni;
        }

        public static bool operator !=(Pasajero p1, Pasajero p2)
        {
            return !(p1 == p2);
        }
        #endregion

        #region POLIMORFISMO
        /// <summary>
        /// Hago un OVERRIDE del metodo .ToString(),
        /// retornandome toda la informacion sobre el pasajero,
        /// incluyendo su pasaporte y equipaje.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\tINFORMACION DEL PASAJERO");
            sb.AppendLine($"{this.Apellido},{this.Nombre}");
            sb.AppendLine($"Edad: {this.Edad} años.");
            sb.AppendLine($"Clase: {this.Clase}");
            sb.AppendLine($"Equipaje:");
            if (this.Equipaje.EsDeMano)
            {
                sb.AppendLine($"\t1 bolso de mano.");
            }
            if (this.Equipaje.CantValijas > 0)
            {
                sb.AppendLine($"\t{this.Equipaje.CantValijas} valijas con un peso total de {this.Equipaje.PesoTotalValija}kgs.");
            }
            sb.AppendLine($"--------------INFORMACION DEL PASAPORTE--------------");
            sb.AppendLine($"DNI: {this.Dni}");
            sb.AppendLine($"Fecha de nacimiento: {this.Nacimiento:d}");
            sb.AppendLine($"Número de pasaporte: {this.NumeroPasaporte}");
            sb.AppendLine($"Nacionalidad: {this.Nacionalidad}");
            sb.AppendLine($"Género: {this.Genero}");
            sb.AppendLine($"Fecha de Vencimiento: {this.Vencimiento:d}");
            sb.AppendLine($"-----------------------------------------------------");
            sb.AppendLine();
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool esNull = false;
            if (obj is Pasajero)
            {//Comparo si son iguales con el operador de sobrecarga y casteo
                esNull = this == ((Pasajero)obj);
            }
            return esNull;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
