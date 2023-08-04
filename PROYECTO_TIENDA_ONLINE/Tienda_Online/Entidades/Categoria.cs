using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        #region ATRIBUTOS
        private int _IDCategoria;
        private string _Descripcion;
        private bool _Activo;
        private DateTime _FechaRegistro;
        #endregion

        #region PROPIEDADES
        public int IDCategoria { get { return this._IDCategoria; } set { this._IDCategoria = value; } }
        public string Descripcion { get {  return this._Descripcion; } set { this._Descripcion = value; } }
        public  bool Activo { get {  return this._Activo; } set { {  this._Activo = value; } } }
        public DateTime FechaRegistro { get { return this._FechaRegistro; } set { this._FechaRegistro = value; } }
        #endregion
    }
}
