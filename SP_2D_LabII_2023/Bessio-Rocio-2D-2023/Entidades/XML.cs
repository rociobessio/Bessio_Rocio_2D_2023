using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
        public static bool SerializacionXML(Carrito carrito)
        {
            bool esValido = false;
            try
            {
                List<Carrito> carritos = new List<Carrito>();

                //-->Si existe el archivo..
                if (File.Exists(XML.path))
                {
                    carritos = XML.DeserializarXML();//-->Reutilizo mi metodo 
                }

                carritos.Add(carrito);//-->Agrego mi nuevo carrito a la lista que me traje, sino se pisa

                //Vuelvo a serializar la lista.
                XmlSerializer serializer = new XmlSerializer(typeof(List<Carrito>));
                using (StreamWriter writer = new StreamWriter(XML.path))
                {
                    serializer.Serialize(writer, carritos);
                }
            }
            catch (Exception ex)
            {
                esValido = false;
                throw new Exception(ex.Message);
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
            catch (Exception e)
            {
                throw new Exception(e.Message);
            } 
            return carritos;//-->Retorno la lista.
        }
        #endregion
    }
}
