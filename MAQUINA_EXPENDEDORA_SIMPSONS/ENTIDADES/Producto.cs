using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_06_ENTIDADES
{
    public class Producto
    {
        #region ATRIBUTOS
        private string nombre;
        private int codigo;//Parte 02 - Adicionar el atributo código de producto (debe ser único e irrepetible)
        private double precio;
        private static int ultimoCodigo;
        private int cantidad;
        #endregion

        #region PROPIEDADES
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public double Precio { get { return this.precio; } set { this.precio = value; } }
        public int Codigo { get { return this.codigo; } }
        public int Cantidad { get { return this.cantidad; } set { this.cantidad = value; } }
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Sirve de punto de partida, se ejecuta una unica vez.
        /// </summary>
        static Producto()
        {
            ultimoCodigo = 1000;
        }

        public Producto(string nombre,double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.codigo = ultimoCodigo;
            ultimoCodigo++;//POr cada instancia incrementa el numero del ultcodigo
        }

        /// <summary>
        /// Sobrecarga del constructor que carga la cantidad.
        /// Agregado de parte V.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        public Producto (string nombre, double precio, int cantidad)
            : this(nombre,precio)
        { 
            this.cantidad = cantidad;
        } 
        #endregion
    }
}
