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

namespace Oformlenie_biletov
{
    public partial class Form2_admin_trains : Form
    {
        public Form2_admin_trains()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string connectionString = "Server=ALEXIUS;Database=Oformlenie_biletov;Trusted_Connection=True;TrustServerCertificate=True;";
                string sqlExpression = "INSERT INTO TrainSet(Train_number, Train_type, Passenger_seats, Point_departure, Point_destination, Time_departure, Time_destination) values('" + textBox1.Text + "' ,'" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "') ;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string connectionString = "Server=ALEXIUS;Database=Oformlenie_biletov;Trusted_Connection=True;TrustServerCertificate=True;";
                string sqlExpression = "DELETE FROM TrainSet WHERE Train_number = '" + textBox1.Text + "' AND Train_type = '" + textBox2.Text + "' AND Passenger_seats = '" + textBox3.Text + "' AND Point_departure = '" + textBox4.Text + "' AND Point_destination = '" + textBox5.Text + "' AND Time_departure = '" + textBox6.Text + "' AND Time_destination = '" + textBox7.Text + "';";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                }
            }
        }

        private void button4_Click_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2_admin form_admin2 = new Form2_admin();
            form_admin2.Show();
        }
    }
}
