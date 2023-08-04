using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Localidad
    {
        #region ATRIBUTOS
        private string _IDLocalidad;
        private string _descripcion;
        #endregion

        #region PROPIEDADES
        public string IDLocalidad { get { return this._IDLocalidad;} set { this._IDLocalidad = value;} }
        public string Descripcion { get {  return this._descripcion;} set {  this._descripcion = value;} }
        #endregion
    }
}
