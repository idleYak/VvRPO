
namespace Oformlenie_biletov
{
    partial class Form2_writer_bron
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4_Click = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ticketSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oformlenie_biletov_DataSet = new Oformlenie_biletov.Oformlenie_biletov_DataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.trainSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainSetTableAdapter = new Oformlenie_biletov.Oformlenie_biletov_DataSetTableAdapters.TrainSetTableAdapter();
            this.ticketSetTableAdapter = new Oformlenie_biletov.Oformlenie_biletov_DataSetTableAdapters.TicketSetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ticketSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oformlenie_biletov_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(621, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 50);
            this.button1.TabIndex = 80;
            this.button1.Text = "Забронировать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(260, 285);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(264, 22);
            this.textBox5.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGreen;
            this.label5.Location = new System.Drawing.Point(42, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 73;
            this.label5.Text = "Место прибытия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGreen;
            this.label6.Location = new System.Drawing.Point(42, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 72;
            this.label6.Text = "Место отправления";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(260, 235);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(264, 22);
            this.textBox4.TabIndex = 71;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(260, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 22);
            this.textBox2.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGreen;
            this.label2.Location = new System.Drawing.Point(42, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Тип поезда";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(42, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "ФИО";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 22);
            this.textBox1.TabIndex = 65;
            // 
            // button4_Click
            // 
            this.button4_Click.BackColor = System.Drawing.SystemColors.Info;
            this.button4_Click.Location = new System.Drawing.Point(621, 257);
            this.button4_Click.Name = "button4_Click";
            this.button4_Click.Size = new System.Drawing.Size(138, 50);
            this.button4_Click.TabIndex = 64;
            this.button4_Click.Text = "Вернуться";
            this.button4_Click.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.ticketSetBindingSource;
            this.comboBox1.DisplayMember = "Carrige_type";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(259, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(264, 24);
            this.comboBox1.TabIndex = 82;
            // 
            // ticketSetBindingSource
            // 
            this.ticketSetBindingSource.DataMember = "TicketSet";
            this.ticketSetBindingSource.DataSource = this.oformlenie_biletov_DataSet;
            // 
            // oformlenie_biletov_DataSet
            // 
            this.oformlenie_biletov_DataSet.DataSetName = "Oformlenie_biletov_DataSet";
            this.oformlenie_biletov_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGreen;
            this.label3.Location = new System.Drawing.Point(42, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 81;
            this.label3.Text = "Тип вагона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGreen;
            this.label4.Location = new System.Drawing.Point(42, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 84;
            this.label4.Text = "Электронная почта";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(260, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(264, 22);
            this.textBox3.TabIndex = 83;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(259, 389);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(264, 22);
            this.textBox7.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGreen;
            this.label7.Location = new System.Drawing.Point(41, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 87;
            this.label7.Text = "Время прибытия";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(260, 342);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(264, 22);
            this.textBox6.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightGreen;
            this.label8.Location = new System.Drawing.Point(42, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 17);
            this.label8.TabIndex = 85;
            this.label8.Text = "Время отправления";
            // 
            // trainSetBindingSource
            // 
            this.trainSetBindingSource.DataMember = "TrainSet";
            this.trainSetBindingSource.DataSource = this.oformlenie_biletov_DataSet;
            // 
            // trainSetTableAdapter
            // 
            this.trainSetTableAdapter.ClearBeforeFill = true;
            // 
            // ticketSetTableAdapter
            // 
            this.ticketSetTableAdapter.ClearBeforeFill = true;
            // 
            // Form2_writer_bron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4_Click);
            this.Name = "Form2_writer_bron";
            this.Text = "Form2_writer_bron";
            this.Load += new System.EventHandler(this.Form2_writer_bron_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oformlenie_biletov_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4_Click;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private Oformlenie_biletov_DataSet oformlenie_biletov_DataSet;
        private System.Windows.Forms.BindingSource trainSetBindingSource;
        private Oformlenie_biletov_DataSetTableAdapters.TrainSetTableAdapter trainSetTableAdapter;
        private System.Windows.Forms.BindingSource ticketSetBindingSource;
        private Oformlenie_biletov_DataSetTableAdapters.TicketSetTableAdapter ticketSetTableAdapter;
    }
}