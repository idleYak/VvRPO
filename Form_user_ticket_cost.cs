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
    public partial class Form_user_ticket_cost : Form
    {
        public Form_user_ticket_cost()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2_user form_user = new Form2_user();
            form_user.Show();
        }

        private void Form_user_ticket_cost_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oformlenie_biletov_DataSet.TicketSet". При необходимости она может быть перемещена или удалена.
            this.ticketSetTableAdapter.Fill(this.oformlenie_biletov_DataSet.TicketSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oformlenie_biletov_DataSet.Ticket_costSet". При необходимости она может быть перемещена или удалена.
            this.ticket_costSetTableAdapter.Fill(this.oformlenie_biletov_DataSet.Ticket_costSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oformlenie_biletov_DataSet.PaymentSet". При необходимости она может быть перемещена или удалена.
            this.paymentSetTableAdapter.Fill(this.oformlenie_biletov_DataSet.PaymentSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oformlenie_biletov_DataSet.Ticket_costSet". При необходимости она может быть перемещена или удалена.
            this.ticket_costSetTableAdapter.Fill(this.oformlenie_biletov_DataSet.Ticket_costSet);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticket_costSetTableAdapter.FillBy(this.oformlenie_biletov_DataSet.Ticket_costSet);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticket_costSetTableAdapter.Fill(this.oformlenie_biletov_DataSet.Ticket_costSet);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
