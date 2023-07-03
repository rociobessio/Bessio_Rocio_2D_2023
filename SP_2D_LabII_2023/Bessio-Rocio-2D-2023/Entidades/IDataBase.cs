using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Entidades
{
    /// <summary>
    /// Esta interfaz me permite obtener 
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
        /// Este metodo lo implentare en
        /// aquellas clases que tengan dicha interfaz.
        /// </summary>
        /// <param name="clase"></param>
        /// <returns></returns>
        bool UpdateDato(T clase);

        /// <summary>
        /// Este metodo lo implementare en aquellas
        /// clases que tengan la interfaz, me permitira
        /// eliminar un dato de alguna tabla mediante
        /// su ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteDato(int id);

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
