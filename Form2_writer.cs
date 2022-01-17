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
    public partial class Form2_writer : Form
    {
        public Form2_writer()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form_start = new Form1();
            form_start.Show();
        }

        private void Form2_writer_Load(object sender, EventArgs e)
        {

        }
    }
}
