using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Crucero
    {
        #region ATRIBUTOS
        private string matricula; //(alfanumerica de 8 digitos), SERIA UNA PATENTE
        private string nombre;

        private int cantCamarotesTurista;
        private int cantCamarotesPremium;

        private int cantComedores;
        private int cantGimnasios;
        private int cantPiscinas;
        private int cantCasinos;
        private int cantSPAS;
        
        private int capacidadBodega; //(en kilogramos)

        private const double porcentajeCamarotesTurista = 0.65;
        private const double porcentajeCamarotesPremium = 0.35;

        #endregion

        #region PROPIEDADES
        public string Matricula { get { return this.matricula; } set { this.matricula = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public int CantCamarotesPremium { get { return this.cantCamarotesPremium; } set { this.cantCamarotesPremium = value; } }
        public int CantCamarotesTuristas { get { return this.cantCamarotesTurista; } set { this.cantCamarotesTurista = value; } }
        public int Comedores { get { return this.cantComedores; } }
        public int Gimnasio { get { return this.cantGimnasios; } }
        public int Piscinia { get { return this.cantPiscinas; } }
        public int Casino { get { return this.cantCasinos; } }
        public int SPA { get { return this.cantSPAS; } set { this.cantSPAS = value; } }
        public int Bodega { get { return this.capacidadBodega; } } 

        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// CONSTRUCTOR POR DEFECTO
        /// </summary>
        private Crucero()
        {
            this.cantComedores = 2;
            this.cantCasinos = 0;
            this.cantGimnasios = 0;
            this.capacidadBodega = 670;
            this.cantPiscinas = 0;
            this.cantSPAS = 0;
        }

        /// <summary>
        /// Constructor parametrizado de la clase Crucero.
        /// Me permite calcular la cantidad de camarotes, tanto Turistas como Premium.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="matricula"></param>
        /// <param name="cantCamarotes"></param>
        public Crucero (string nombre, string matricula,int cantCamarotes) : this()
        {  
            this.matricula = matricula;
            this.nombre = nombre;
            this.cantCamarotesTurista = (int)(Math.Round(cantCamarotes * porcentajeCamarotesTurista, MidpointRounding.AwayFromZero));
            this.cantCamarotesPremium = (int)(Math.Round(cantCamarotes * porcentajeCamarotesPremium, MidpointRounding.ToZero)); 
        }

        /// <summary>
        /// Constructor que me permite cargar los salones disponibles de mi crucero.
        /// </summary>
        /// <param name="matricula"></param>
        /// <param name="nombre"></param>
        /// <param name="cantidadCamarotes"></param>
        /// <param name="cantidadComedores"></param>
        /// <param name="cantidadGimnasios"></param>
        /// <param name="cantidadPiscinas"></param>
        /// <param name="cantidadCasinos"></param>
        /// <param name="pesoBodega"></param>
        public Crucero(string matricula, string nombre, int cantidadCamarotes, int cantidadComedores, int cantidadGimnasios,
        int cantidadPiscinas, int cantidadCasinos, int pesoBodega,int cantSpas) : this(matricula, nombre, cantidadCamarotes)
        {
            this.cantComedores = cantidadComedores;
            this.cantGimnasios = cantidadGimnasios;
            this.cantPiscinas = cantidadPiscinas;
            this.cantCasinos = cantidadCasinos;
            this.capacidadBodega = pesoBodega;
            this.cantSPAS = cantSpas;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// COMPARA DOS CRUCEROS, SERAN IGUALES SIEMPRE Y CUANDO COMPARTAN MATRICULAS
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator ==(Crucero c1,Crucero c2) 
        {
            bool esNull = false;

            if (c1 is not null && c2 is not null)
            {
                esNull = (c1.Matricula == c2.Matricula);
            }
                    
            return esNull;
        }

        public static bool operator !=(Crucero c1,Crucero c2)
        {
            return !(c1 == c2);
        } 

        /// <summary>
        /// Retorna si la matricula del crucero pasado por parametro
        /// es igual a la string que recibe.
        /// </summary>
        /// <param name="crucero1"></param>
        /// <param name="matricula"></param>
        /// <returns></returns>
        public static bool operator ==(Crucero crucero1, string matricula)
        {
            return crucero1.matricula == matricula;
        }
        public static bool operator !=(Crucero crucero1, string matricula)
        {
            return !(crucero1 == matricula);
        }
        #endregion

        #region POLIMORFISMO
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Crucero: {this.nombre} - Matricula {this.matricula}");
            sb.AppendLine($"Tiene un total de {this.cantCamarotesTurista} de camarotes para la clase Turista.");
            sb.AppendLine($"Tiene un total de {this.cantCamarotesPremium} de camarotes para la clase Premium.");
            sb.AppendLine($"Este crucero posee estos salones:");
            if (this.cantGimnasios > 0)
            {
                sb.AppendLine($"\t{this.cantGimnasios} Gimnasio/s");
            }
            if (this.cantPiscinas > 0)
            {
                sb.AppendLine($"\t{this.cantPiscinas} Piscina/s");
            }
            if (this.cantCasinos > 0)
            {
                sb.AppendLine($"\t{this.cantCasinos} Casino/s");
            }
            if (this.cantSPAS > 0)
            {
                sb.AppendLine($"\t{this.cantSPAS} SPA/s");
            }
            sb.AppendLine($"\tY cuenta con una bodega de {this.capacidadBodega}kgs.");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is not null)
            {
                if (obj is Crucero)
                {
                    retorno = this == obj as Crucero;
                }
            }

            return retorno;
        } 

        /// <summary>
        /// Compara e identifica dos objetos,
        /// si son iguales deberan de retornar el mismo Hh
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

    }
}
