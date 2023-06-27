using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Entidades
{
    /// <summary>
    /// Esta interfaz me permite obtener
    /// la cadena de la conexion a la base de datos,
    /// el metodo ObtenerLista() el cual trae a todos
    /// los objetos de la base y el ObtenerEspecifico
    /// que me permite traer a un especificico de la tabla.
    /// Se podría añadir el agregar, eliminar, modificar.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDataBase <T>
        where T : class//-->T será una clase.
    {
        /// <summary>
        /// Metodo estatico me retorna la cadena de conexion de la base
        /// de datos.
        /// </summary>
        /// <returns></returns>
        static string CadenaConexionBase()
        {
            return @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CARNICERIA_DB;Data Source=DESKTOP-S8KBDM2;Trusted_Connection=True;";
        } 

        /// <summary>
        /// Metodo que me permitira devolveer una lista del
        /// tipo T
        /// </summary>
        /// <returns></returns>
        List<T> ObtenerLista();

        /// <summary>
        /// Metodo que me permitira retornar un objeto
        /// de la base.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T ObtenerEspecifico(int id); 
    }
}
