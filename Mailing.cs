using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Oformlenie_biletov
{
    class Mailing
    {
        public void mailpost(string mail, string textmail, string topicmail)
        {
            MailAddress fromAdress = new MailAddress("idleyak@gmail.com", "Поступили билетики");
            MailAddress toAdress = new MailAddress(mail);
            MailMessage mailMessage = new MailMessage(fromAdress, toAdress);
            mailMessage.Body = textmail;
            mailMessage.Subject = topicmail;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(fromAdress.Address, "секрет");

            smtpClient.Send(mailMessage);

        }
    }
}
