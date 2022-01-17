using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Oformlenie_biletov
{
    public partial class Form2_writer_bron : Form
    {
        public Form2_writer_bron()
        {
            InitializeComponent();
        }

        class Mailing
        {/*
            public void mailpost(string mail, string textmail, string topicmail)
            {
                MailAddress fromAdress = new MailAddress("idleyak@gmail.com");
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
                smtpClient.Credentials = new NetworkCredential(fromAdress.Address, "_");

                smtpClient.Send(mailMessage);

            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gmail mailing = new Gmail();
            mailing.mailpost($"{textBox3.Text}", $"Здравствуйте, {textBox1.Text}. Вы успешно забронировали билет, в вагоне типа - {comboBox1.Text} в поезде типа - {textBox2.Text}. " +
                $"Ваш билет действителен от {textBox4.Text} и до {textBox5.Text}. С временем отправления в: {textBox6.Text} и временем прибытия в {textBox7.Text}", "Бронь билета");
            MessageBox.Show("Вы успешно забронировали билет на поезд.");
        }

        private void Form2_writer_bron_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oformlenie_biletov_DataSet.TicketSet". При необходимости она может быть перемещена или удалена.
            this.ticketSetTableAdapter.Fill(this.oformlenie_biletov_DataSet.TicketSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oformlenie_biletov_DataSet.TrainSet". При необходимости она может быть перемещена или удалена.
            this.trainSetTableAdapter.Fill(this.oformlenie_biletov_DataSet.TrainSet);

        }
    }

    public class Gmail
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
            smtpClient.Credentials = new NetworkCredential(fromAdress.Address, "null");

            smtpClient.Send(mailMessage);

        }
    }
}
