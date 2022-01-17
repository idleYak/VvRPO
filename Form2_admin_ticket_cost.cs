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
    public partial class Form2_admin_ticket_cost : Form
    {
        public Form2_admin_ticket_cost()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2_admin form_admin = new Form2_admin();
            form_admin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string connectionString = "Server=ALEXIUS;Database=Oformlenie_biletov;Trusted_Connection=True;TrustServerCertificate=True;";
                string sqlExpression = "INSERT INTO Ticket_costSet(Cost, Status) values('" + textBox1.Text + "' ,'" + textBox2.Text + "') ;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                string connectionString = "Server=ALEXIUS;Database=Oformlenie_biletov;Trusted_Connection=True;TrustServerCertificate=True;";
                string sqlExpression = "DELETE FROM Ticket_costSet WHERE Cost = '" + textBox1.Text + "' AND Status = '" + textBox2.Text + "';";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                }
            }
        }
    }
}
