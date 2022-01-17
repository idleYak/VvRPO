
namespace Oformlenie_biletov
{
    partial class Form_user_ticket_cost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ticketcostSetBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.oformleniebiletovDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oformlenie_biletov_DataSet = new Oformlenie_biletov.Oformlenie_biletov_DataSet();
            this.ticketcostSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ticketcostSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticket_costSetTableAdapter = new Oformlenie_biletov.Oformlenie_biletov_DataSetTableAdapters.Ticket_costSetTableAdapter();
            this.fKPaymentTicketcostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentSetTableAdapter = new Oformlenie_biletov.Oformlenie_biletov_DataSetTableAdapters.PaymentSetTableAdapter();
            this.ticketcostSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKTicketTicketcostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketSetTableAdapter = new Oformlenie_biletov.Oformlenie_biletov_DataSetTableAdapters.TicketSetTableAdapter();
            this.idticketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrigetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrigenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengerIdpassengerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainIdtrainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketcostIdticketcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketcostSetBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oformleniebiletovDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oformlenie_biletov_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketcostSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketcostSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPaymentTicketcostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketcostSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTicketTicketcostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Info;
            this.button5.Location = new System.Drawing.Point(487, 348);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 50);
            this.button5.TabIndex = 18;
            this.button5.Text = "Вернуться";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idticketDataGridViewTextBoxColumn,
            this.ticketnumberDataGridViewTextBoxColumn,
            this.carrigetypeDataGridViewTextBoxColumn,
            this.carrigenumberDataGridViewTextBoxColumn,
            this.placenumberDataGridViewTextBoxColumn,
            this.passengerIdpassengerDataGridViewTextBoxColumn,
            this.trainIdtrainDataGridViewTextBoxColumn,
            this.ticketcostIdticketcostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ticketSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(709, 150);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ticketcostSetBindingSource3
            // 
            this.ticketcostSetBindingSource3.DataMember = "Ticket_costSet";
            this.ticketcostSetBindingSource3.DataSource = this.oformleniebiletovDataSetBindingSource;
            // 
            // oformleniebiletovDataSetBindingSource
            // 
            this.oformleniebiletovDataSetBindingSource.DataSource = this.oformlenie_biletov_DataSet;
            this.oformleniebiletovDataSetBindingSource.Position = 0;
            // 
            // oformlenie_biletov_DataSet
            // 
            this.oformlenie_biletov_DataSet.DataSetName = "Oformlenie_biletov_DataSet";
            this.oformlenie_biletov_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketcostSetBindingSource1
            // 
            this.ticketcostSetBindingSource1.DataMember = "Ticket_costSet";
            this.ticketcostSetBindingSource1.DataSource = this.oformleniebiletovDataSetBindingSource;
            // 
            // ticketcostSetBindingSource
            // 
            this.ticketcostSetBindingSource.DataMember = "Ticket_costSet";
            this.ticketcostSetBindingSource.DataSource = this.oformleniebiletovDataSetBindingSource;
            // 
            // ticket_costSetTableAdapter
            // 
            this.ticket_costSetTableAdapter.ClearBeforeFill = true;
            // 
            // fKPaymentTicketcostBindingSource
            // 
            this.fKPaymentTicketcostBindingSource.DataMember = "FK_Payment_Ticket_cost";
            this.fKPaymentTicketcostBindingSource.DataSource = this.ticketcostSetBindingSource;
            // 
            // paymentSetTableAdapter
            // 
            this.paymentSetTableAdapter.ClearBeforeFill = true;
            // 
            // ticketcostSetBindingSource2
            // 
            this.ticketcostSetBindingSource2.DataMember = "Ticket_costSet";
            this.ticketcostSetBindingSource2.DataSource = this.oformleniebiletovDataSetBindingSource;
            // 
            // fKTicketTicketcostBindingSource
            // 
            this.fKTicketTicketcostBindingSource.DataMember = "FK_Ticket_Ticket_cost";
            this.fKTicketTicketcostBindingSource.DataSource = this.ticketcostSetBindingSource3;
            // 
            // ticketSetTableAdapter
            // 
            this.ticketSetTableAdapter.ClearBeforeFill = true;
            // 
            // idticketDataGridViewTextBoxColumn
            // 
            this.idticketDataGridViewTextBoxColumn.DataPropertyName = "Id_ticket";
            this.idticketDataGridViewTextBoxColumn.HeaderText = "Id_ticket";
            this.idticketDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idticketDataGridViewTextBoxColumn.Name = "idticketDataGridViewTextBoxColumn";
            this.idticketDataGridViewTextBoxColumn.ReadOnly = true;
            this.idticketDataGridViewTextBoxColumn.Width = 125;
            // 
            // ticketnumberDataGridViewTextBoxColumn
            // 
            this.ticketnumberDataGridViewTextBoxColumn.DataPropertyName = "Ticket_number";
            this.ticketnumberDataGridViewTextBoxColumn.HeaderText = "Ticket_number";
            this.ticketnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ticketnumberDataGridViewTextBoxColumn.Name = "ticketnumberDataGridViewTextBoxColumn";
            this.ticketnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // carrigetypeDataGridViewTextBoxColumn
            // 
            this.carrigetypeDataGridViewTextBoxColumn.DataPropertyName = "Carrige_type";
            this.carrigetypeDataGridViewTextBoxColumn.HeaderText = "Carrige_type";
            this.carrigetypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carrigetypeDataGridViewTextBoxColumn.Name = "carrigetypeDataGridViewTextBoxColumn";
            this.carrigetypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // carrigenumberDataGridViewTextBoxColumn
            // 
            this.carrigenumberDataGridViewTextBoxColumn.DataPropertyName = "Carrige_number";
            this.carrigenumberDataGridViewTextBoxColumn.HeaderText = "Carrige_number";
            this.carrigenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carrigenumberDataGridViewTextBoxColumn.Name = "carrigenumberDataGridViewTextBoxColumn";
            this.carrigenumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // placenumberDataGridViewTextBoxColumn
            // 
            this.placenumberDataGridViewTextBoxColumn.DataPropertyName = "Place_number";
            this.placenumberDataGridViewTextBoxColumn.HeaderText = "Place_number";
            this.placenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.placenumberDataGridViewTextBoxColumn.Name = "placenumberDataGridViewTextBoxColumn";
            this.placenumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // passengerIdpassengerDataGridViewTextBoxColumn
            // 
            this.passengerIdpassengerDataGridViewTextBoxColumn.DataPropertyName = "PassengerId_passenger";
            this.passengerIdpassengerDataGridViewTextBoxColumn.HeaderText = "PassengerId_passenger";
            this.passengerIdpassengerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passengerIdpassengerDataGridViewTextBoxColumn.Name = "passengerIdpassengerDataGridViewTextBoxColumn";
            this.passengerIdpassengerDataGridViewTextBoxColumn.Width = 125;
            // 
            // trainIdtrainDataGridViewTextBoxColumn
            // 
            this.trainIdtrainDataGridViewTextBoxColumn.DataPropertyName = "Train_Id_train";
            this.trainIdtrainDataGridViewTextBoxColumn.HeaderText = "Train_Id_train";
            this.trainIdtrainDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trainIdtrainDataGridViewTextBoxColumn.Name = "trainIdtrainDataGridViewTextBoxColumn";
            this.trainIdtrainDataGridViewTextBoxColumn.Width = 125;
            // 
            // ticketcostIdticketcostDataGridViewTextBoxColumn
            // 
            this.ticketcostIdticketcostDataGridViewTextBoxColumn.DataPropertyName = "Ticket_cost_Id_ticket_cost";
            this.ticketcostIdticketcostDataGridViewTextBoxColumn.HeaderText = "Ticket_cost_Id_ticket_cost";
            this.ticketcostIdticketcostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ticketcostIdticketcostDataGridViewTextBoxColumn.Name = "ticketcostIdticketcostDataGridViewTextBoxColumn";
            this.ticketcostIdticketcostDataGridViewTextBoxColumn.Width = 125;
            // 
            // ticketSetBindingSource
            // 
            this.ticketSetBindingSource.DataMember = "TicketSet";
            this.ticketSetBindingSource.DataSource = this.oformleniebiletovDataSetBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(233, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Информационная билето-панель";
            // 
            // Form_user_ticket_cost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Name = "Form_user_ticket_cost";
            this.Text = "Form_user_ticket_cost";
            this.Load += new System.EventHandler(this.Form_user_ticket_cost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketcostSetBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oformleniebiletovDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oformlenie_biletov_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketcostSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketcostSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPaymentTicketcostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketcostSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTicketTicketcostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource oformleniebiletovDataSetBindingSource;
        private Oformlenie_biletov_DataSet oformlenie_biletov_DataSet;
        private System.Windows.Forms.BindingSource ticketcostSetBindingSource;
        private Oformlenie_biletov_DataSetTableAdapters.Ticket_costSetTableAdapter ticket_costSetTableAdapter;
        private System.Windows.Forms.BindingSource fKPaymentTicketcostBindingSource;
        private Oformlenie_biletov_DataSetTableAdapters.PaymentSetTableAdapter paymentSetTableAdapter;
        private System.Windows.Forms.BindingSource ticketcostSetBindingSource1;
        private System.Windows.Forms.BindingSource ticketcostSetBindingSource3;
        private System.Windows.Forms.BindingSource ticketcostSetBindingSource2;
        private System.Windows.Forms.BindingSource fKTicketTicketcostBindingSource;
        private Oformlenie_biletov_DataSetTableAdapters.TicketSetTableAdapter ticketSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idticketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrigetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrigenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengerIdpassengerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainIdtrainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketcostIdticketcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ticketSetBindingSource;
        private System.Windows.Forms.Label label1;
    }
}