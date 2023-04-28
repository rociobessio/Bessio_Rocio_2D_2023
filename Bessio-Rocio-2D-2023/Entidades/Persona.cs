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
        protected string nombre;
        protected string apellido;
        protected DateTime fechaDeNacimiento;
        protected string dni;
        protected Nacionalidad nacionalidad;
        protected Sexo sexo;
        protected string domicilio;
        protected string telefono;

        //protected string contraseña;
        //protected string mail;
        protected Usuario usuario;//->Cada persona en nuestro sistema contara con un usuario.
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Propiedad de lectura que retorna el DNI de la persona.
        /// </summary>
        public string DNI { get { return this.dni; } }

        /// <summary>
        /// Esta propiedad abstracta, me permite implementarla en las clases derivadas, 
        /// de esta forma retornara en cliente true y en vendedor false, para poder usarla.
        /// </summary>
        public abstract bool EsCliente { get; }
        public Usuario Usuario { get {  return this.usuario; } }
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
            //this.contraseña = "aaaa";
            //this.mail = "1234";
        }

        /// <summary>
        /// Constructor parametrizado que me permite incializar una instancia Persona
        /// con los parametros email y constrasenia para poder crearles un usuario en el
        /// login.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        protected Persona(string email,string contrasenia)
            : this()
        {
            this.usuario = new Usuario(email,contrasenia); 
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
        /// <param name="contraseña"></param>
        /// <param name="usuario"></param>
        protected Persona(string nombre, string apellido,Sexo sexo, Nacionalidad nacionalidad, DateTime fechaNacimiento,
            string dni,string domicilio,string telefono) 
        {
            this.sexo = sexo;
            this.nacionalidad = nacionalidad;
            this.fechaDeNacimiento= fechaNacimiento;
            this.dni = dni;
            this.domicilio = domicilio;
            this.apellido = apellido;
            this.nombre = nombre;
            this.telefono= telefono;
            //this.contraseña = contraseña;
            //this.mail = usuario;
            this.usuario = new Usuario("","");
        }
        #endregion 

        #region POLIMORFISMO
        /// <summary>
        /// Codigo Hash del objeto 
        /// </summary>
        /// <returns>Codigo Hash del objeto </returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Compara si el objeto actual this es igual al objeto del parametro, es comparado por la sobrecarga del ==
        /// </summary>
        /// <param name="obj">de tipo object</param>
        /// <returns>si son iguales retorna true sino false</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Persona)
            {
                retorno = this == ((Persona)obj);
            }
            return retorno;
        }

        /// <summary>
        /// La sobrecarga del .ToString() me devuelve la informacion
        /// de la objeto.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.nombre}-{this.apellido}-{this.sexo}-{this.nacionalidad}" +
                $"-{this.fechaDeNacimiento}-{this.dni}-{this.domicilio}";
        }
        #endregion
    }
}