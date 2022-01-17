using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oformlenie_biletov;

namespace Oformlenie_biletov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2_user form_user = new Form2_user();
            form_user.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2_writer_bron form_writer_bron = new Form2_writer_bron();
            form_writer_bron.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2_admin form_admin = new Form2_admin();
            form_admin.Show();
        }
    }
}
