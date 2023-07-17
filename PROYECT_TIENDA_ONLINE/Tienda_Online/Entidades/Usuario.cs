using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Cliente
    {
        #region ATRIBUTOS
        private int _IDUsuario; 
        private bool _activo;
        #endregion

        #region PROPIEDADES
        public int IDUsuario { get { return this._IDUsuario; } set { this._IDUsuario = value; } }
        public bool Activo { get {  return this._activo; } set { this._activo = value; } }
        #endregion
    }
}
