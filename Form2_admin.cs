using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oformlenie_biletov
{
    public partial class Form2_admin : Form
    {
        public Form2_admin()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form_admin = new Form1();
            form_admin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2_admin_trains form_admin_trains = new Form2_admin_trains();
            form_admin_trains.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2_admin_station form_admin_station = new Form2_admin_station();
            form_admin_station.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2_admin_ticket_cost form_admin_ticket_cost = new Form2_admin_ticket_cost();
            form_admin_ticket_cost.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2_admin_ticket form_admin_ticket = new Form2_admin_ticket();
            form_admin_ticket.Show();
        }
    }
}
