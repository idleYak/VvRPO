using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace Oformlenie_biletov
{
    public partial class Form2_admin_ticket : Form
    {
        public Form2_admin_ticket()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2_admin form_admin2 = new Form2_admin();
            form_admin2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=ALEXIUS;Database=Oformlenie_biletov;Trusted_Connection=True;TrustServerCertificate=True;";
            string sqlExpression = "SELECT Ticket_number, Carrige_type, Carrige_number, Place_number FROM TicketSet WHERE Ticket_number = '" + textBox1.Text + "' AND Carrige_type = '" + comboBox1.Text + "' AND Carrige_number = '" + textBox3.Text + "' AND  Place_number = '" + textBox4.Text + "';";
            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    MessageBox.Show("Информация о билете найдена");
                else
                    MessageBox.Show("Информация о билете не найдена");

            }
            /*
            String ticket_number = textBox1.Text;
            String carrige_type = comboBox1.Text;
            String carrige_number = textBox3.Text;
            String place_number = textBox4.Text;



            int check = (ticket_number, carrige_type, carrige_number, place_number);


            if (check > 0)
                MessageBox.Show("Data was found.");
            else
                MessageBox.Show("Data wasn't found.");
        }*/
        }

        private void Form2_admin_ticket_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oformlenie_biletov_DataSet.TicketSet". При необходимости она может быть перемещена или удалена.
            this.ticketSetTableAdapter.Fill(this.oformlenie_biletov_DataSet.TicketSet);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
