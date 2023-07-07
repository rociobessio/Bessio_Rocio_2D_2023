using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        #region ATRIBUTOS
        public string userName;
        public string password;//PUEDE SER ALFANUMERICA
        #endregion

        #region PROPIEDADES
        public string UserName { get { return this.userName; } set { this.userName = value; } }

        public string Password { get { return this.password; } set { this.password = value; } }

        #endregion

        #region CONSTRUCTORES
        public Vendedor(string userName,string password)
        {
            this.userName = userName;
            this.password = password;
        }
        #endregion

        #region METODOS DE CLASE
        /// <summary>
        /// Muestra los datos de los usuarios utilizando las propiedades de la clase
        /// </summary>
        /// <returns></returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"USERNAME: {UserName}\nPASSWORD: {Password}");
            return sb.ToString();
        }
        #endregion


        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// DOS USUARIOS SERAN IGUALES SI COINCIDEN SU USERNAME Y PASSWORD
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vendedor v1,Vendedor v2)
        {
            bool esNull = false;
            if (v1 is not null && v2 is not null)
            {
                esNull = (v1.userName == v2.userName && v1.password == v2.password);
            }
            else if (v1 is null && v2 is null)
                esNull = true;
            return esNull;
        }

        public static bool operator !=(Vendedor v1,Vendedor v2)
        {
            return !(v1 == v2);
        }

        #endregion

        #region POLIMORFISMO
        public override bool Equals(object obj)
        {
            bool esNull = false;
            if (obj is Vendedor)
            {//Comparo si son iguales con el operador de sobrecarga y casteo
                esNull = this == ((Vendedor)obj);
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
