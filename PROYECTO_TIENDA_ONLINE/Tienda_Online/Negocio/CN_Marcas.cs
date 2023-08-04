using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;

namespace Negocio
{
    /// <summary>
    /// Capa de negocio.
    /// </summary>
    public class CN_Marcas
    {
        #region ATRIBUTOS
        private static MarcasDAO marcaDAO; 
        #endregion

        #region METODOS
        /// <summary>
        /// Retorno la lista de Categorias 
        /// de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Marca> Listar()
        {
            CN_Marcas.marcaDAO = new MarcasDAO();
            return CN_Marcas.marcaDAO.ObtenerLista();
        }

        /// <summary>
        /// Me sirve de intermediario, recibe la
        /// marca y devuelve un int y 
        /// un mensaje.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="mss"></param>
        /// <returns></returns>
        public int RegistrarDato(Marca marca, out string mss)
        {
            mss = string.Empty;
            CN_Marcas.marcaDAO = new MarcasDAO();

            if (string.IsNullOrEmpty(marca.Descripcion))
                mss = "La descripción de la marca no puede estar vacia.";

            if (string.IsNullOrEmpty(mss))
            {
                return CN_Marcas.marcaDAO.RegistrarDato(marca, out mss);
            }
            else
                return 0;
        }

        /// <summary>
        /// Intermediario entre la capa de negocios,
        /// los metodos de la base y el objeto.
        /// Edito una marca existente.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="mss"></param>
        /// <returns>Retornará true si pudo, false sino.</returns>
        public bool EditarDato(Marca marca, out string mss)
        {
            mss = string.Empty;
            CN_Marcas.marcaDAO = new MarcasDAO();

            if (string.IsNullOrEmpty(marca.Descripcion))
                mss = "La descripción de la marca no puede estar vacia.";

            if (string.IsNullOrEmpty(mss))
                return CN_Marcas.marcaDAO.UpdateDato(marca, out mss);
            else
                return false;
        }

        /// <summary>
        /// Intermediario entre la capa de negocios,
        /// los metodos de la base y el objeto.
        /// Elimino una Marca existente.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mss"></param>
        /// <returns></returns>
        public bool DeleteDato(int id, out string mss)
        {
            CN_Marcas.marcaDAO = new MarcasDAO();
            return CN_Marcas.marcaDAO.DeleteDato(id, out mss);
        }
        #endregion
    }
}
