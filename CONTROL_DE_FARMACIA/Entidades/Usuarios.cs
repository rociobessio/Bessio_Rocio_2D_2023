using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        #region ATRIBUTOS
        private int id;
        private string usuario;
        private string contraseña;
        #endregion

        #region PROPIEDADES
        public int ID { get { return this.id; } set { this.id = value; } }
        public string Usuario { get { return this.usuario; } set { this.usuario = value; } }
        public string Contraseña { get { return this.contraseña; } set { this.contraseña = value; } }
        #endregion

        #region CONSTRUCTORES
        public Usuarios(string usuario,string contraseña)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
        }

        public Usuarios(int id,string usuario,string contraseña) : this(usuario, contraseña)
        {
            this.id = id;
        }
        #endregion

        #region METODOS DE LA CLASE
        /// <summary>
        /// Confirmo si el usuario esta en la lista...
        /// </summary>
        /// <param name="listaUsuarios"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool ConfirmarUsuario(List<Usuarios> listaUsuarios, Usuarios user)
        {
            bool estaEnLaBase = false;
            foreach (Usuarios item in listaUsuarios)
            {
                if (item == user)//Usuario coincidente
                {
                    estaEnLaBase = true;
                    break;
                }
            }
            return estaEnLaBase;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Dos usuarios seran iguales si sus usuarios y constraseñas son coincidentes
        /// </summary>
        /// <param name="user1"></param>
        /// <param name="user2"></param>
        /// <returns></returns>
        public static bool operator ==(Usuarios user1, Usuarios user2)
        {
            bool sonIguales = false;
            if (user1 is not null && user2 is not null)
            {
                sonIguales = user1.usuario == user2.usuario && user1.contraseña == user2.contraseña;
            }
            else if (user1 is null && user2 is null)
                sonIguales = true;
            return sonIguales;
        }

        public static bool operator !=(Usuarios user1, Usuarios user2)
        {
            return !(user1 == user2);
        }
        #endregion

        #region POLIMORFISMO
        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is not null)
            {
                if (obj is Usuarios)
                {
                    retorno = this == obj as Usuarios;
                }
            }

            return retorno;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
