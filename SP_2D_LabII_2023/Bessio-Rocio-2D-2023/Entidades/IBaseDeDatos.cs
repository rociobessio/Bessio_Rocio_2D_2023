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
