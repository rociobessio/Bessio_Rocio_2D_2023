using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IBaseDeDatos <T>
        where T : class
    {
        /// <summary>
        /// Este metodo lo implentare en
        /// aquellas clases que tengan dicha interfaz.
        /// </summary>
        /// <param name="clase"></param>
        /// <returns></returns>
        bool UpdateDato(T clase, out string mss);

        /// <summary>
        /// Este metodo lo implementare en aquellas
        /// clases que tengan la interfaz, me permitira
        /// eliminar un dato de alguna tabla mediante
        /// su ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteDato(int id, out string mss);

        /// <summary>
        /// Metodo que me permitira devolveer una lista del
        /// tipo T
        /// </summary>
        /// <returns></returns>
        List<T> ObtenerLista();

        /// <summary>
        /// Me permitirá registrar un objeto
        /// en la base que será del tipo T (una clase).
        /// Tendrá un mensaje de salida en caso de
        /// excepcion.
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="mss"></param>
        /// <returns></returns>
        int RegistrarDato(T usuario, out string mss);

        /// <summary>
        /// Metodo que me permitira retornar un objeto
        /// de la base.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
      //  T ObtenerEspecifico(int id);
    }
}
