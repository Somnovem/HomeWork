using System;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using System.Drawing;

namespace Homework2_1Films
{
    internal class MailSender
    {
        private static string smtpServer = "smtp.meta.ua";
        private static int smtpPort = 25;

        public delegate void SendingResultDelegate(string message);
        public static event SendingResultDelegate SendingResult;
        public static void SendMessage(string fromMail, string toMail, string fromPassword, string theme, string body) 
        {
            Task.Run(() =>
            {
                SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(fromMail, fromPassword);

                try
                {
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(fromMail);
                    message.To.Add(new MailAddress(toMail));
                    message.Subject = theme;
                    message.Body = body;
                    smtpClient.Send(message);
                    SendingResult?.Invoke("Email sent successfully!");
                }
                catch (Exception ex)
                {
                    SendingResult?.Invoke("Error encountered when sending email: " + ex.Message);
                }
            });
        }
    }
}
