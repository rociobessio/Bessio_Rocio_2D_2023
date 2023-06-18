using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase abstracta.
    /// </summary>
    public abstract class Persona
    {
        #region ATRIBUTOS
        protected string nombre;
        protected string apellido;
        protected DateTime fechaDeNacimiento;
        protected string dni;
        protected Nacionalidad nacionalidad;
        protected Sexo sexo;
        protected string domicilio;
        protected string telefono; 
        protected Usuario usuario;//->Cada persona en nuestro sistema contará con un usuario.
        protected int idPersona;
        #endregion

        #region PROPIEDADES
        public int IDPersona { get { return this.idPersona; } set { this.idPersona = value; } }
        /// <summary>
        /// Propiedad de lectura que retorna el DNI de la persona.
        /// </summary>
        public string DNI { get { return this.dni; } set { this.dni = value; } }
        /// <summary>
        /// Esta propiedad abstracta, me permite implementarla en las clases derivadas, 
        /// de esta forma retornara en cliente true y en vendedor false, para poder usarla.
        /// </summary>
        public abstract bool EsCliente { get; }
        /// <summary>
        /// Propiedad de lectura, me permite obtener el Usuario de 
        /// la persona.
        /// </summary>
        public Usuario Usuario { get {  return this.usuario; } }
        /// <summary>
        /// Propiedad de lectura.
        /// </summary>
        public string Nombre { get { return this.nombre; }  set { this.nombre = value; } }
        /// <summary>
        /// Propiedad de lectura.
        /// </summary>
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        /// <summary>
        /// Propiedad de lectura.
        /// </summary>
        public string Telefono { get { return this.telefono; } set { this.telefono = value; } }
        /// <summary>
        /// Propiedad de lectura.
        /// </summary>
        public string Domicilio { get { return this.domicilio; } set { this.domicilio = value; } }
        #endregion

        #region CONTRUCTORES
        /// <summary>
        /// Constructor privado que inicializa con datos vacios un objeto derivado de persona.
        /// </summary>
        private Persona()
        {
            this.nombre = "BBB";
            this.apellido = "AAAA";
            this.domicilio = "Calle Falsa";
            this.dni = "00.000.000";
            this.nacionalidad = Nacionalidad.Argentina;
            this.sexo = Sexo.Femenino;
            this.fechaDeNacimiento = new DateTime();
            this.usuario = new Usuario("","");
            this.telefono = "000"; 
        }

        /// <summary>
        /// Constructor parametrizado que me permite incializar una instancia Persona
        /// con los parametros email y constrasenia para poder crearles un usuario en el
        /// login.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        protected Persona(Usuario user)
            : this()
        {
            this.usuario = user; 
        }

        /// <summary>
        /// Sobrecarga del constructor que me permite inicializar una instancia Persona
        /// con el resto de los atributos.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="dni"></param>
        /// <param name="domicilio"></param> 
        protected Persona(string nombre, string apellido,Sexo sexo, Nacionalidad nacionalidad, DateTime fechaNacimiento,
            string dni,string domicilio,string telefono,Usuario user) 
            : this(user)//--->Sobrecarga
        {
            this.sexo = sexo;
            this.nacionalidad = nacionalidad;
            this.fechaDeNacimiento= fechaNacimiento;
            this.dni = dni;
            this.domicilio = domicilio;
            this.apellido = apellido;
            this.nombre = nombre;
            this.telefono= telefono;
        }

        //protected Persona(string nombre, string apellido, Sexo sexo, Nacionalidad nacionalidad, DateTime fechaNacimiento,
        //    string dni, string domicilio, string telefono, Usuario user)
        //    : this(nombre,apellido,sexo,nacionalidad,fechaNacimiento,dni,domicilio,telefono,user)
        //{
        //    this.idPersona = idPersona;
        //}
        #endregion

        #region SOBRECARGA
        /// <summary>
        /// Operador implicito que me devuelve el email de la persona.
        /// </summary>
        /// <param name="persona"></param>
        public static implicit operator string(Persona persona)
        {
            return persona.Usuario.Email;
        } 
        #endregion

        #region POLIMORFISMO
        /// <summary>
        /// Codigo Hash del objeto, es unico.
        /// </summary>
        /// <returns>Codigo Hash del objeto </returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// La sobrecarga del .ToString() me devuelve la informacion
        /// de la objeto.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Nombre: {this.nombre} - Apellido: {this.apellido} - Sexo: {this.sexo} - Nacionalidad: {this.nacionalidad}" +
                $" - Fecha de nacimiento: {this.fechaDeNacimiento} - DNI: {this.dni} - Domicilio: {this.domicilio} - Telefono: {this.telefono}" +
                $" - Usuario: {this.usuario.ToString()}";
        }
        #endregion
    }
}