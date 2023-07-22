using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;//-->Using para poder encriptar contraseñas
using System.Net.Mail;
using System.Net;
using System.IO;

namespace Negocio
{
    public static class CN_Recursos
    {
        #region GESTION DE CONTRASEÑAS
        /// <summary>
        /// Método que me permitirá encriptar las claves
        /// de los usuarios del sistema.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string EncriptarClavesSha256(string text)
        {
            StringBuilder sb = new StringBuilder();
            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(text));

                foreach (byte b in result)
                    sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// Me permitirá generar una clave aleatoria
        /// para el usuario.
        /// </summary>
        /// <returns></returns>
        public static string GenerarClaveAutomatica()
        {
            return Guid.NewGuid().ToString("N").Substring(0,6);//-->Clave maximo d 6
        }
        #endregion

        /// <summary>
        /// Me permitirá enviar un correo al usuario
        /// mediante GMAIL.
        /// </summary>
        /// <param name="destinatario"></param>
        /// <param name="asunto"></param>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public static bool EnviarCorreo(string destinatario,string asunto,string mensaje)
        {
            bool pudoEnviar = false;

            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(destinatario);//-->A quien esta dirigido 
                mail.From = new MailAddress("rocibessio@gmail.com");//-->Quien envia el mail
                mail.Subject = asunto;//-->Asunto del correo.
                mail.Body = mensaje;
                mail.IsBodyHtml = true;//-->Formato HTML.

                //-->Servidor que envia el mensaje y lo configuro
                var smtp = new SmtpClient()
                {
                    Credentials = new NetworkCredential("testdecodigo003@gmail.com", "sszsebecdojsgvjw"),
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                };

                smtp.Send(mail);
                pudoEnviar = true;//-->Si lo envio cambio a true
            }
            catch(Exception e)
            {
                pudoEnviar = false;//-->Si no pudo enviarlo 
            }
            return pudoEnviar;
        }
    }
}
