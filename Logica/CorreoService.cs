using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Logica
{
    public class CorreoService
    {
        private MailMessage email;
        private SmtpClient smtp;
        public CorreoService()
        {
            smtp = new SmtpClient();
        }
        private void ConfigurarSmt()
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("djosedonado@unicesar.edu.co",                                                                                                                                                                          "donado1234");
        }

        private void ConfigurarEmail(Deportista deportista)
        {
            email = new MailMessage();
            email.To.Add(deportista.Correo);
            email.From = new MailAddress("djosedonado@unicesar.edu.co");
            email.Subject = "SUSTENTATCION DE DANILO JOSE DONADO SANDOVAL";
            email.Body = $"<b>Sr {deportista.Nombre} {deportista.Apellidó}</b> <br " +
                $" > HOLA QUE HACE";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;

        }
        public string EnviarEmail(Deportista deportista)
        {

            try
            {
                ConfigurarSmt();
                ConfigurarEmail(deportista);
                smtp.Send(email);
                return ("Correo enviado Satifactoriamente");
            }
            catch (Exception e)
            {

                return ("error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }

        }
    }
}
