using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Marca
    {
        #region ATRIBUTOS
        private int _IDMarca;
        private string _Descripcion;
        private bool _Activo; 
        #endregion

        #region PROPIEDADES
        public int IDCategoria { get { return this._IDMarca; } set { this._IDMarca = value; } }
        public string Descripcion { get { return this._Descripcion; } set { this._Descripcion = value; } }
        public bool Activo { get { return this._Activo; } set { { this._Activo = value; } } } 
        #endregion
    }
}
