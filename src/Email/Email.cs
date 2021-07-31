using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net.Mime;
using MailKit.Net.Smtp;

namespace Asset_and_Maintenance_Management_System.src.Email
{
    class Email
    {
        private string email = "cial.amms@gmail.com";
        private string password = "7Gf5%2uum%7hxy^&t$U8$##2CC9j&8@2R5&6**5tufCaVwoc@V";
        private NetworkCredential login;
        System.Net.Mail.SmtpClient client;
        public void sendEmail(string sender, string subject, string message)
        {

            try
            {
                MailMessage mess = new MailMessage();
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();

                mess.From = new MailAddress(email);
                mess.To.Add(new MailAddress(sender));
                mess.Subject = subject;
                mess.Body = message;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(email, password);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(mess);
            }
            catch(Exception ex)
            {
                TextWriter.writeContent("logs.txt", ex.ToString());
            }
        }
    }
}
