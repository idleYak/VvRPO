
namespace Oformlenie_biletov
{
    partial class Form_user_train
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
            this.oformlenie_biletov_DataSet = new Oformlenie_biletov.Oformlenie_biletov_DataSet();
            this.oformleniebiletovDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainSetTableAdapter = new Oformlenie_biletov.Oformlenie_biletov_DataSetTableAdapters.TrainSetTableAdapter();
            this.trainSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trainSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trainnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traintypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengerseatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointdepartureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointdestinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timedepartureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timedestinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainSetBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oformlenie_biletov_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oformleniebiletovDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainSetBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Info;
            this.button5.Location = new System.Drawing.Point(559, 374);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 50);
            this.button5.TabIndex = 17;
            this.button5.Text = "Вернуться";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // oformlenie_biletov_DataSet
            // 
            this.oformlenie_biletov_DataSet.DataSetName = "Oformlenie_biletov_DataSet";
            this.oformlenie_biletov_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oformleniebiletovDataSetBindingSource
            // 
            this.oformleniebiletovDataSetBindingSource.DataSource = this.oformlenie_biletov_DataSet;
            this.oformleniebiletovDataSetBindingSource.Position = 0;
            // 
            // trainSetBindingSource
            // 
            this.trainSetBindingSource.DataMember = "TrainSet";
            this.trainSetBindingSource.DataSource = this.oformleniebiletovDataSetBindingSource;
            // 
            // trainSetTableAdapter
            // 
            this.trainSetTableAdapter.ClearBeforeFill = true;
            // 
            // trainSetBindingSource1
            // 
            this.trainSetBindingSource1.DataMember = "TrainSet";
            this.trainSetBindingSource1.DataSource = this.oformleniebiletovDataSetBindingSource;
            // 
            // trainSetBindingSource2
            // 
            this.trainSetBindingSource2.DataMember = "TrainSet";
            this.trainSetBindingSource2.DataSource = this.oformleniebiletovDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainnumberDataGridViewTextBoxColumn,
            this.traintypeDataGridViewTextBoxColumn,
            this.passengerseatsDataGridViewTextBoxColumn,
            this.pointdepartureDataGridViewTextBoxColumn,
            this.pointdestinationDataGridViewTextBoxColumn,
            this.timedepartureDataGridViewTextBoxColumn,
            this.timedestinationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.trainSetBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(28, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1171, 186);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // trainnumberDataGridViewTextBoxColumn
            // 
            this.trainnumberDataGridViewTextBoxColumn.DataPropertyName = "Train_number";
            this.trainnumberDataGridViewTextBoxColumn.HeaderText = "Train_number";
            this.trainnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trainnumberDataGridViewTextBoxColumn.Name = "trainnumberDataGridViewTextBoxColumn";
            this.trainnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // traintypeDataGridViewTextBoxColumn
            // 
            this.traintypeDataGridViewTextBoxColumn.DataPropertyName = "Train_type";
            this.traintypeDataGridViewTextBoxColumn.HeaderText = "Train_type";
            this.traintypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.traintypeDataGridViewTextBoxColumn.Name = "traintypeDataGridViewTextBoxColumn";
            this.traintypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // passengerseatsDataGridViewTextBoxColumn
            // 
            this.passengerseatsDataGridViewTextBoxColumn.DataPropertyName = "Passenger_seats";
            this.passengerseatsDataGridViewTextBoxColumn.HeaderText = "Passenger_seats";
            this.passengerseatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passengerseatsDataGridViewTextBoxColumn.Name = "passengerseatsDataGridViewTextBoxColumn";
            this.passengerseatsDataGridViewTextBoxColumn.Width = 125;
            // 
            // pointdepartureDataGridViewTextBoxColumn
            // 
            this.pointdepartureDataGridViewTextBoxColumn.DataPropertyName = "Point_departure";
            this.pointdepartureDataGridViewTextBoxColumn.HeaderText = "Point_departure";
            this.pointdepartureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pointdepartureDataGridViewTextBoxColumn.Name = "pointdepartureDataGridViewTextBoxColumn";
            this.pointdepartureDataGridViewTextBoxColumn.Width = 125;
            // 
            // pointdestinationDataGridViewTextBoxColumn
            // 
            this.pointdestinationDataGridViewTextBoxColumn.DataPropertyName = "Point_destination";
            this.pointdestinationDataGridViewTextBoxColumn.HeaderText = "Point_destination";
            this.pointdestinationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pointdestinationDataGridViewTextBoxColumn.Name = "pointdestinationDataGridViewTextBoxColumn";
            this.pointdestinationDataGridViewTextBoxColumn.Width = 125;
            // 
            // timedepartureDataGridViewTextBoxColumn
            // 
            this.timedepartureDataGridViewTextBoxColumn.DataPropertyName = "Time_departure";
            this.timedepartureDataGridViewTextBoxColumn.HeaderText = "Time_departure";
            this.timedepartureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timedepartureDataGridViewTextBoxColumn.Name = "timedepartureDataGridViewTextBoxColumn";
            this.timedepartureDataGridViewTextBoxColumn.Width = 125;
            // 
            // timedestinationDataGridViewTextBoxColumn
            // 
            this.timedestinationDataGridViewTextBoxColumn.DataPropertyName = "Time_destination";
            this.timedestinationDataGridViewTextBoxColumn.HeaderText = "Time_destination";
            this.timedestinationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timedestinationDataGridViewTextBoxColumn.Name = "timedestinationDataGridViewTextBoxColumn";
            this.timedestinationDataGridViewTextBoxColumn.Width = 125;
            // 
            // trainSetBindingSource3
            // 
            this.trainSetBindingSource3.DataMember = "TrainSet";
            this.trainSetBindingSource3.DataSource = this.oformleniebiletovDataSetBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(454, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Информационная поездо-панель";
            // 
            // Form_user_train
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Name = "Form_user_train";
            this.Text = "Form_user_train";
            this.Load += new System.EventHandler(this.Form_user_train_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oformlenie_biletov_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oformleniebiletovDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainSetBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource oformleniebiletovDataSetBindingSource;
        private Oformlenie_biletov_DataSet oformlenie_biletov_DataSet;
        private System.Windows.Forms.BindingSource trainSetBindingSource;
        private Oformlenie_biletov_DataSetTableAdapters.TrainSetTableAdapter trainSetTableAdapter;
        private System.Windows.Forms.BindingSource trainSetBindingSource1;
        private System.Windows.Forms.BindingSource trainSetBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traintypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengerseatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointdepartureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointdestinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timedepartureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timedestinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource trainSetBindingSource3;
        private System.Windows.Forms.Label label1;
    }
}