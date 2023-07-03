using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public static class JSON
    {
        #region ATRIBUTOS
        public static StreamWriter writer;
        public static StreamReader reader;
        public static string path;
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Contiene el path de donde esta
        /// el archivo.
        /// </summary>
        static JSON()
        {
            if(!Directory.Exists("..\\Archivos"))//-->Pregunto si NO existe la ruta
            {
                Directory.CreateDirectory("..\\Archivos");
            }

            JSON.path = $"..\\Archivos\\ProductosJSON.json";
        }
        #endregion

        #region METODOS
        ///// <summary>
        ///// Este metodo me permite serializar un producto.
        ///// </summary>
        ///// <param name="producto"></param>
        ///// <returns></returns>
        ///// <exception cref="JSONException"></exception>
        //public static bool SerializacionJSON(Producto producto)
        //{
        //    bool esValido = false;

        //    try
        //    {
        //        //-->Si existe hace append con el true, y escribe en el, no elimina lo que habia
        //        using (JSON.writer = new StreamWriter($"..\\Archivos\\ProductosGuardados.json", true))//-->Escribo en el archivo JSON
        //        {
        //            string json = JsonSerializer.Serialize(producto);//-->Serializo carrito en formato JSON.

        //            JSON.writer.WriteLine(json);//-->Salto de linea
        //            esValido = true;
        //        }
        //    }
        //    catch (JSONException)
        //    {
        //        esValido = false;
        //        throw new JSONException("Ocurrio un error al intentar serializar JSON.");
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //    return esValido;
        //}

        /// <summary>
        /// Metodo que me permitirá serializar una
        /// instancia de Carrito.
        /// </summary>
        /// <param name="carrito"></param>
        /// <returns></returns>
        public static bool SerializacionJSON(Carrito carrito)
        {
            bool esValido = false;

            try
            {
                //-->Si existe hace append con el true, y escribe en el, no elimina lo que habia
                using (JSON.writer = new StreamWriter(JSON.path,true))//-->Escribo en el archivo JSON
                {
                    string json = JsonSerializer.Serialize(carrito);//-->Serializo carrito en formato JSON.

                    JSON.writer.WriteLine(json);//-->Salto de linea
                    esValido = true;
                }
            }
            catch(JSONException)
            {
                esValido = false;
                throw new JSONException("Ocurrio un error al intentar serializar JSON.");
            }
            catch (Exception)
            {
                throw;
            }

            return esValido;
        }

        /// <summary>
        /// Me permite deserializar y retornar una lista de 
        /// carritos para luego mostrarla.
        /// </summary>
        /// <returns></returns>
        public static List<Carrito> DeserializarJSON()
        {
            List<Carrito> carritos = new List<Carrito>();
            Carrito carritoAUX =  new Carrito();
            string json = string.Empty;

            try
            {
                if(File.Exists(JSON.path))//-->Verifico si existe
                {
                    using (JSON.reader = new StreamReader(JSON.path))//-->Al reader le paso donde leera.
                    {
                        while ((json = JSON.reader.ReadLine()) is not null)//-->Mientras pueda leer y no sea null
                        {
                            carritoAUX = JsonSerializer.Deserialize<Carrito>(json);//-->Deserializo

                            if (!(carritoAUX is null))//-->Si NO es null
                                carritos.Add(carritoAUX);//-->Lo añado. 
                        }
                    }
                } 
            }
            catch (JSONException)
            {
                throw new JSONException("Ocurrio un error al intentar deserializar.");
            }
            catch (Exception)
            {
                throw;
            }

            return carritos;//-->Retorno la lista.
        }
        #endregion
    }
}
