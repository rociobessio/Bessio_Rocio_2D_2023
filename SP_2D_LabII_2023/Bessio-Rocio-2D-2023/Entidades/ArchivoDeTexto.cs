using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArchivoDeTexto
    {
        #region ATRIBUTOS
        public static StreamWriter streamWriter;
        public static StreamReader streamReader;
        public static string path;
        public static Guid guid;//-->De esta forma no se repetiran archivos
        #endregion

        #region CONTRUCTOR
        static ArchivoDeTexto()
        {
            ArchivoDeTexto.path = "HistorialVentas";
            ArchivoDeTexto.guid = Guid.NewGuid();   
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Guardo en un archivo .txt la factura de compra de un cliente.
        /// Este archivo tendrá de nombre su correo,id del carrito y horario asi
        /// no se pisan.
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool GuardarVenta(Cliente cliente)
        {
            bool esValido = false;
            try
            {
                //-->Arrojaba excepcion, asi que modifico las cadenas.
                string guidShort = guid.ToString().Substring(0, 8);//-->El guid lo acorto
                //-->Al mail le quito los caracteres especiales
                string email = cliente.Usuario.Email.Replace("@", "_").Replace(".", "_");
                //-->Creo el nombre del archivo
                string nombreArchivo = $@"Email[{email}]ID[{guidShort}].txt";
                //-->La ruta de dicho archivo
                string rutaArchivo = Path.Combine(ArchivoDeTexto.path, nombreArchivo);

                using (ArchivoDeTexto.streamWriter = new StreamWriter(rutaArchivo))
                {
                    ArchivoDeTexto.streamWriter.WriteLine(cliente.CarritoCompra.ToString());
                }
                esValido = true;
            }
            catch (Exception)
            {  
                esValido = false;//-->Entra igual
            }
            return esValido;
        }

        /// <summary>
        /// Recibo la cadena del archivo
        /// y retorno el contenido del .txt
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public static string LeerVenta(string cadena)
        {
            string venta = string.Empty;

            try
            {
                //-->Combino mi path con la cadena,sino se concatena y rompe
                string rutaArchivo = Path.Combine(ArchivoDeTexto.path, cadena);

                using (ArchivoDeTexto.streamReader = new StreamReader(rutaArchivo))
                {
                    venta = ArchivoDeTexto.streamReader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                venta = "ERROR AL GUARDAR EL CARRITO.";
            }
            return venta;
        }

        /// <summary>
        /// Este metodo estatico me permite recibir la ruta
        /// de mi archivo y retornar el nombre del
        /// archivo.
        /// Luego me servira para seleccionarlo y
        /// mostrarlo.
        /// </summary>
        /// <param name="rutaArchivo"></param>
        /// <returns></returns>
        public static string ObtenerNombreArchivo(string rutaArchivo)
        {
            string nombreArchivo = Path.GetFileName(rutaArchivo);
            return nombreArchivo;
        }
        #endregion
    }
}
