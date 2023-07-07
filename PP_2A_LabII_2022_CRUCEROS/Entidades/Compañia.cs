using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Compañia
    {
        #region ATRIBUTOS
        private short cantidadVendedores;
        private List<Vendedor> listVendedores;
        private string nombreCompañia;
        private List<Crucero> listaCruceros;
        #endregion

        #region PROPIEDADES
        public string Nombre { get { return this.nombreCompañia; } set { this.nombreCompañia = value; } }
        public List<Vendedor> Vendedores { get { return listVendedores; } }
        public List<Crucero> Embarcaciones { get { return listaCruceros; } }        
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// CONSTRUCTOR POR DEFECTO
        /// </summary>
        private Compañia()
        {
            this.cantidadVendedores = 0;
            this.listVendedores = new List<Vendedor>();
            this.listaCruceros = new List<Crucero>();
            this.nombreCompañia = "";
            HardcodearUsuarios();
        }

        /// <summary>
        /// CONSTRUCTOR PARAMETRIZADO
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="nombre"></param>
        public Compañia(short cantidad,string nombre) : this()
        {
            this.cantidadVendedores = cantidad;
            this.nombreCompañia = nombre;
        }
        #endregion

        #region SOBRECARGA DE OPERADOR
        /// <summary>
        /// Busca si el vendedor esta dentro de la compañia, si NO esta lo añade a la lista.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool operator + (Compañia c, Vendedor v)
        {
            bool rta = false;
            bool auxVendedor = true;
            if (!(c is null) && c.listVendedores.Count < c.cantidadVendedores)
            {
                foreach (Vendedor item in c.listVendedores)
                {
                    if (item == v)
                    {
                        auxVendedor = false;
                        break;
                    }
                }
                if (auxVendedor)
                {
                    c.listVendedores.Add(v);
                    rta = true;
                }
            }
            return rta;
        }

        /// <summary>
        /// Si Crucero NO esta en la lista de cruceros lo añade.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="crucero"></param>
        /// <returns></returns>
        public static bool operator +(Compañia c, Crucero crucero)
        {
            bool rta = false;
            bool auxBarco = true;
            if (c is not null && crucero is not null)
            {
                foreach (Crucero item in c.listaCruceros)
                {
                    if (item == crucero)
                    {
                        auxBarco = false;
                        break;
                    }
                }
                if (auxBarco)
                {
                    c.listaCruceros.Add(crucero);
                    rta = true;
                }
            }
            return rta;
        }
        #endregion

        #region METODOS

        public bool LoguearUser(Vendedor v)
        {
            bool esIgual = false;
            foreach (Vendedor item in listVendedores)
            {
                if (item == v)
                {
                    esIgual = true;
                }
            }
            return esIgual;
        }



        /// <summary>
        /// METODO QUE ME HARDCODEA A LOS USUARIOS
        /// </summary>
        public void HardcodearUsuarios()
        {
            listVendedores.Add(new Vendedor("Paula", "Pau123"));
            listVendedores.Add(new Vendedor("Lucas", "Lucas123"));
            listVendedores.Add(new Vendedor("Rocio", "Bessio"));
        }
        #endregion

    }
}
