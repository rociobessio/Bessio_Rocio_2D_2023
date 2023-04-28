using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AA
    {
        //#region ATRIBUTOS
        //private Tipo _tipoCarne;
        //private int _codigo;
        //private int _stockActual;
        //private string _proveedor;
        //private int _capacidadMaximaCarnicaeria;//--> El stock no podra superar la cantidad maxima que permite el producto

        //private static int ultimoCodigo;
        //private List<Carnes> _listaCarnes;
        //#endregion

        //#region PROPIEDADES
        //public int Codigo { get { return this._codigo; } }
        //public Tipo Tipo { get { return this._tipoCarne; } }
        //public int Stock { get { return this._stockActual; } }    
        //public string Proveedor { get { return this._proveedor;} }  
        //public List<Carnes> ListaCarnes { get { return this._listaCarnes; } }
        //public int CapacidadMaxima { get { return this._capacidadMaximaCarnicaeria; } }
        //#endregion

        //#region CONSTRUCTOR
        ///// <summary>
        ///// Este constructor lo que hara es setear el ultimo codigo como 100, 
        ///// luego ira en incrementandose en los demas constructores.
        ///// </summary>
        //private Carne2()
        //{
        //    ultimoCodigo = 100;
        //    this._listaCarnes = new List<Carnes>();
        //}

        ///// <summary>
        ///// Constructor parametrizado que me permite crear una instancia parametrizada de
        ///// Producto.
        ///// </summary>
        ///// <param name="tipo"></param>
        ///// <param name="precio"></param>
        ///// <param name="proveedor"></param>
        ///// <param name="peso"></param>
        //public Carne2(string proveedor)
        //{
        //    this._proveedor = proveedor;
        //    this._codigo = ultimoCodigo;
        //    ultimoCodigo++;//POr cada instancia incrementa el numero del ultcodigo
        //}

        ///// <summary>
        ///// Constructor que me permite cargar el stock realizando una sobrecarga.
        ///// </summary> 
        ///// <param name="precio"></param>
        ///// <param name="proveedor"></param>
        ///// <param name="stock"></param>
        ///// <param name="capacidadMaxima"></param>
        //public Carne2(Tipo tipoCarne, string proveedor,int stock,int capacidadMaxima)
        //        : this(proveedor)
        //{
        //    this._tipoCarne = tipoCarne;
        //    this._stockActual = stock;
        //    this._capacidadMaximaCarnicaeria = capacidadMaxima;
        //}
        //#endregion

        //#region SOBRECARGA DE OPERADORES
        //public static Carne2 operator + (Carne2 producto,Carnes carnes)
        //{
        //    if(!(producto is null) && !(carnes is null))
        //    {
        //        if(carnes.Peso > 0 )//--> Verifico que sea mayor a 0 su pesaje
        //        {
        //            //verifico que el stock del producto sea mayor a 0 y menor a la cantidadMaxima que puedo tener
        //            if (producto._stockActual > 0 && producto._stockActual < producto._capacidadMaximaCarnicaeria)
        //            {
        //                producto._listaCarnes.Add(carnes);
        //            }
        //        }
        //    }
        //    return producto;
        //}

        ///// <summary>
        ///// Esta sobrecarga del + me permite una carne a la lista del viaje,
        ///// utilizando la otra sobrecarga del +.
        ///// </summary>
        ///// <param name="producto"></param>
        ///// <param name="carnes"></param>
        ///// <returns></returns>
        //public static Carne2 operator + (Carne2 producto,List<Carnes> carnes)
        //{
        //    foreach (Carnes carne in carnes)
        //    {
        //        producto += carne;
        //    }
        //    return producto;
        //}

        //public static bool operator ==(Carne2 producto,int id)
        //{
        //    return producto._codigo == id;
        //}

        //public static bool operator !=(Carne2 producto, int id)
        //{
        //    return !(producto == id);
        //}
        //#endregion
    }
}
