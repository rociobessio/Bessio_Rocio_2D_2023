using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        #region ATRIBUTOS
        private int _IDProducto;
        private string _nombre;
        private string _descripcion;
        private Marca _marca;
        private Categoria _Categoria;
        private double _precio;
        private int _stock;
        private string _rutaImagen;
        private string _nombreImagen;
        private bool _activo;

        private string _precioTexto;
        private string _base64;//-->Formato q mostraré las imagenes  
        #endregion

        #region PROPIEDADES
        public int IDProducto { get { return this._IDProducto; } set { this._IDProducto = value; } }
        public string Nombre { get {  return this._nombre; } set { this._nombre = value; } }
        public string Descripcion { get {  return this._descripcion; }set { this._descripcion = value;} }
        public Marca oMarca { get { return this._marca; } set { this._marca = value; } }
        public Categoria oCategoria { get { return this._Categoria; } set { this._Categoria = value; } }
        public double Precio { get { return this._precio; } set { this._precio = value; } }
        public string RutaImagen { get {  return this._rutaImagen; } set { this._rutaImagen = value; } }
        public int Stock { get { return this._stock; }  set { this._stock = value; } }
        public string NombreImagen { get { return this._nombreImagen; } set { this._nombreImagen = value; } }
        public bool Activo { get { return this._activo; }  set { this._activo = value; } } 
        public string PrecioTexto { get => this._precioTexto; set => this._precioTexto = value; }
        public string Base64 { get => this._base64; set => this._base64 = value; }
        #endregion
    }
}
