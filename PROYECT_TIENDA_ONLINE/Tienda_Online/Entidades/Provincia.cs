using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincia
    {
        #region ATRIBUTOS
        private string _IDProvincia;
        private string _descripcion;
        private string _IDLocalidad;
        #endregion

        #region PROPIEDADES
        public string IDProvincia { get { return this._IDProvincia; } set { this._IDProvincia = value;} }
        public string Descripcion { get {  return this._descripcion;} set {  this._descripcion = value;} }
        public string IDLocalidad { get { return this._IDLocalidad;} set { this._IDLocalidad = value;} }
        #endregion
    }
}
