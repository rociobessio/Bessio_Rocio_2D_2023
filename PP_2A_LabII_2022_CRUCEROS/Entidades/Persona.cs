using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public abstract class Persona
    {
        #region ATRIBUTOS
        protected string apellido;
        protected string nombre;
        protected int edad;
        protected Genero genero;
        protected long dni;
        protected Nacionalidades nacionalidad;
        #endregion

        #region PROPIEDADES
        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        public Genero Genero { get { return this.genero; } }
        public int Edad { get { return this.edad; } }
        public long Dni { get { return this.dni; } }
        public Nacionalidades Nacionalidad { get { return this.nacionalidad; } }

        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// CONSTRUCTOR POR DEFECTO
        /// </summary>
        public Persona()
        {
            this.dni = 00;
            this.apellido = "";
            this.edad = 0;
            this.nombre = "";
            this.genero = Genero.Masculino;
            this.nacionalidad = Nacionalidades.Argentine;
        }

        public Persona(string apellido,string nombre, int edad, Genero genero,long dni,Nacionalidades nacionalidad)
        {
            this.dni = dni;
            this.apellido = apellido;
            this.nombre = nombre;
            this.edad = edad;
            this.genero = genero;
            this.nacionalidad = nacionalidad;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// DOS PERSONAS SON IGUALES SIEMPRE Y CUANDO SUS DNIs SEAN COINCIDENTES
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator == (Persona p1, Persona p2)
        {
            bool esIgual = false;
            if (p1 is not null && p2 is not null)
            {
                esIgual = (p1.dni == p2.dni);
            }
            return esIgual;
        }
        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }
        #endregion

        #region POLIMORFISMO
        public override bool Equals(object obj)
        {
            bool esNull = false;
            if (obj is Persona)
            {//Comparo si son iguales con el operador de sobrecarga y casteo
                esNull = this == ((Persona)obj);
            }
            return esNull;
        }

        /// <summary>
        /// GetHashCode compara e identifica dos objetos,
        /// si son iguales deberan de retornar el mismo HashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion

        #region METODO
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"DNI:{this.dni}\nNOMBRE: {this.nombre}\nAPELLIDO: {this.apellido}\nGENERO: {this.genero}\nEDAD: {this.edad}\nNACIONALIDAD: {this.nacionalidad}");
            return sb.ToString();
        }
        #endregion
    }
}
