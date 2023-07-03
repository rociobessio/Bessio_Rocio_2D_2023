using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Excepciones;

namespace Entidades
{
    /// <summary>
    /// Clase static que me permite
    /// Deserializar y Serializar en
    /// formato XML. En este caso
    /// es con aquellas compras
    /// realizas con el Perfil 
    /// Cliente.
    /// </summary>
    public static  class XML 
    {
        #region ATRIBUTOS
        public static StreamWriter writer;
        public static StreamReader reader;
        public static string path;
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor estatico de la
        /// clase estatica XML.
        /// </summary>
        static  XML()
        {
            if (!Directory.Exists("..\\Archivos"))//-->Pregunto si NO existe la ruta
            {
                Directory.CreateDirectory("..\\Archivos");
            }

            XML.path = $"..\\Archivos\\ProductosXML.xml";
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Sobrecarga de metodo que en este caso me 
        /// permitira crear una copia de seguridad de
        /// la lista actual de productos. Al momento de 
        /// serializar se pisa la copia anterior.
        /// </summary>
        /// <param name="listaProductos"></param>
        /// <returns></returns>
        /// <exception cref="XMLException"></exception>
        public static bool SerializacionXML(List<Producto> listaProductos)
        {
            try
            {  
                //--->Serializo
                XmlSerializer serializer = new XmlSerializer(typeof(List<Producto>));
                using (StreamWriter writer = new StreamWriter("..\\Archivos\\CopiaSeguridadXML.xml"))
                {
                    serializer.Serialize(writer, listaProductos);
                }

                return true;
            }
            catch (Exception)
            {
                throw new XMLException("Ocurrió un error al intentar serializar en XML.");
            }
        }

        /// <summary>
        /// Me permite serializar UN carrito en
        /// formato XML.
        /// </summary>
        /// <param name="carrito"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool SerializacionXML(Carrito carrito)
        {
            bool esValido = false;
            try
            {
                List<Carrito> carritos = new List<Carrito>();

                //-->Si existe el archivo..
                if (File.Exists(XML.path))
                {
                    carritos = XML.DeserializarXML();//-->Reutilizo mi metodo, me traigo los carritos
                }

                carritos.Add(carrito);//-->Agrego mi nuevo carrito a la lista que me traje, sino se pisa

                //Vuelvo a serializar la lista.
                XmlSerializer serializer = new XmlSerializer(typeof(List<Carrito>));
                using (StreamWriter writer = new StreamWriter(XML.path))
                {
                    serializer.Serialize(writer, carritos);
                }
                esValido = true;
            }
            catch (Exception)
            {
                esValido = false;
                throw new XMLException("Ocurrio un error al intentar serializar en XML.");
            }
            return esValido;
        }

        /// <summary>
        /// Me permite deserializar una instancia de
        /// Carrito en formato XML.
        /// </summary>
        /// <param name="carrito"></param>
        /// <returns></returns>
        public  static List<Carrito> DeserializarXML()
        {
            List<Carrito> carritos = new List<Carrito>(); 

            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Carrito>)); 

                if (File.Exists(XML.path))//-->Si existe el archivo...
                { 
                    using (StreamReader reader = new StreamReader(XML.path))//-->Leo
                    {
                        carritos = (List<Carrito>)xmlSerializer.Deserialize(reader);//-->Traigo
                    } 
                } 
            }
            catch (XMLException)
            {
                throw new XMLException();
            }
            catch (Exception)
            {
                throw;
            }
            return carritos;//-->Retorno la lista.
        }

        /// <summary>
        /// Este metodo me permitira deserializar la lista
        /// del archivo de la copia de seguridad.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="XMLException"></exception>
        public static List<Producto> TraerCopiaDeSeguridadXML()
        {
            List<Producto> productos = new List<Producto>();

            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Producto>));

                if (File.Exists("..\\Archivos\\CopiaSeguridadXML.xml"))
                {
                    using (StreamReader reader = new StreamReader("..\\Archivos\\CopiaSeguridadXML.xml"))
                    {
                        productos = (List<Producto>)xmlSerializer.Deserialize(reader);
                    }
                }
            }
            catch (XMLException)
            {
                throw new XMLException("Ocurrió un error al intentar deserializar el XML.");
            }
            catch (Exception)
            {
                throw;
            }
            return productos;
        }
        #endregion
    }
}
