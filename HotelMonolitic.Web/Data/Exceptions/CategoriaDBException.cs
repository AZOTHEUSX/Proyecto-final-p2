using System;
using System.Diagnostics;
using System.Net.Mail;

namespace HotelMonolitic.Web.Data.Exceptions
{
    public class CategoriaDBException : ArgumentNullException
    {
        public CategoriaDBException(string message) : base(message)
        {
            LogError(message);
            SendError(message);
        }

        private void LogError(string message)
        {
            try
            {
                // Usar EventLog para registrar el error (verificar que EventLog esté configurado correctamente en el sistema)
                if (!EventLog.SourceExists("HotelMonolitic"))
                {
                    EventLog.CreateEventSource("HotelMonolitic", "Application");
                }
                EventLog.WriteEntry("HotelMonolitic", message, EventLogEntryType.Error);
            }
            catch (Exception ex)
            {
                // Manejar cualquier problema con el mecanismo de registro
                Console.WriteLine("El registro falló: " + ex.Message);
            }
        }

        private void SendError(string message)
        {
            try
            {
                var fromAddress = new MailAddress("tu-correo@example.com", "Tu Nombre");
                var toAddress = new MailAddress("destinatario@example.com", "Nombre del Destinatario");
                const string fromPassword = "tu-contraseña-de-correo";
                const string subject = "Error de Base de Datos en HotelMonolitic";
                string body = $"Ocurrió un error en la operación de la base de datos: {message}";

                var smtp = new SmtpClient
                {
                    Host = "smtp.example.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var emailMessage = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(emailMessage);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier problema con el mecanismo de envío de correo
                Console.WriteLine("El envío de correo falló: " + ex.Message);
            }
        }
    }
}
