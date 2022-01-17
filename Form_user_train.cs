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
    public partial class Form_user_train : Form
    {
        public Form_user_train()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2_user form_user = new Form2_user();
            form_user.Show();
        }

        private void Form_user_train_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oformlenie_biletov_DataSet.TrainSet". При необходимости она может быть перемещена или удалена.
            this.trainSetTableAdapter.Fill(this.oformlenie_biletov_DataSet.TrainSet);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
