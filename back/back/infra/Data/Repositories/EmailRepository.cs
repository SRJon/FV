using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using back.data.http;
using back.domain.Repositories;

namespace back.infra.Data.Repositories
{
    public static class EmailRepository
    {
        public static bool SendEmail(string message, string destinatario, string sender = "EMAIL", string password = "SENHA")
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp-mail.outlook.com");

                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                System.Net.NetworkCredential credential = new System.Net.NetworkCredential(sender, password);
                client.EnableSsl = true;
                client.Credentials = credential;

                MailMessage emailMessage = new MailMessage(sender, destinatario);
                emailMessage.Subject = "Teste";
                emailMessage.Body = message;
                emailMessage.IsBodyHtml = true;
                client.Send(emailMessage);
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }
    }
}