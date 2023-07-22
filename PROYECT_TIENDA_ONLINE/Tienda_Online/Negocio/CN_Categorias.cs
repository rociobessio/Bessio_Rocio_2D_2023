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
    public class CN_Categorias
    {
        #region ATRIBUTOS
        private static CategoriasDAO categoriaDAO;
        public List<Categoria> listaCategorias;
        #endregion 

        #region METODOS
        /// <summary>
        /// Retorno la lista de Categorias 
        /// de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Categoria> Listar()
        {
            CN_Categorias.categoriaDAO = new CategoriasDAO();
            return categoriaDAO.ObtenerLista();
        }

        /// <summary>
        /// Me sirve de intermediario, recibe la
        /// categoria y devuelve un int y 
        /// un mensaje.
        /// </summary>
        /// <param name="categoria"></param>
        /// <param name="mss"></param>
        /// <returns></returns>
        public int RegistrarDato(Categoria categoria, out string mss)
        {
            mss = string.Empty;
            CN_Categorias.categoriaDAO = new CategoriasDAO();

            if (string.IsNullOrEmpty(categoria.Descripcion))
                mss = "La descripción de la categoría no puede estar vacia.";

            if (string.IsNullOrEmpty(mss))
            {
                return CN_Categorias.categoriaDAO.RegistrarDato(categoria,out mss);
            }
            else
                return 0;
        }

        /// <summary>
        /// Intermediario entre la capa de negocios,
        /// los metodos de la base y el objeto.
        /// Edito una categoria existente.
        /// </summary>
        /// <param name="categoria"></param>
        /// <param name="mss"></param>
        /// <returns>Retornará true si pudo, false sino.</returns>
        public bool EditarDato(Categoria categoria, out string mss)
        {
            mss = string.Empty;
            CN_Categorias.categoriaDAO = new CategoriasDAO();

            if (string.IsNullOrEmpty(categoria.Descripcion))
                mss = "La descripción de la categoría no puede estar vacia.";

            if (string.IsNullOrEmpty(mss))
                return CN_Categorias.categoriaDAO.UpdateDato(categoria, out mss);
            else
                return false;
        }

        /// <summary>
        /// Intermediario entre la capa de negocios,
        /// los metodos de la base y el objeto.
        /// Elimino una Categoria existente.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mss"></param>
        /// <returns></returns>
        public bool DeleteDato(int id, out string mss)
        {
            CN_Categorias.categoriaDAO = new CategoriasDAO();
            return CN_Categorias.categoriaDAO.DeleteDato(id, out mss);
        }
        #endregion
    }
}
