using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        #region ATRIBUTOS
        private int _IDCliente;
        private string _nombres;
        private string _apellidos;
        private string _correo;
        private string _clave;
        private bool _reestablecer;
        #endregion

        #region PROPIEDADES
        public int IDCliente { get { return this._IDCliente; } set { this._IDCliente = value; } }
        public string Nombres { get { return this._nombres; } set { this._nombres = value; } }
        public string Apellidos { get { return this._apellidos; } set { this._apellidos = value;} }
        public string Correo { get { return this._correo; } set { this._correo = value; } }
        public string Clave { get { return this._clave; }  set { this._clave = value; } }
        public bool Reestablecer { get {  return this._reestablecer; } set { this._reestablecer = value;} }
        #endregion
    }
}
