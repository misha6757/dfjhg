namespace WindowsFormsApp3
{
    partial class Form9
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
            this.database1DataSet = new WindowsFormsApp3.Database1DataSet();
            this.менеджерыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.менеджерыTableAdapter = new WindowsFormsApp3.Database1DataSetTableAdapters.МенеджерыTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.партнерыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.партнерыTableAdapter = new WindowsFormsApp3.Database1DataSetTableAdapters.ПартнерыTableAdapter();
            this.partnerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.партнерыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // менеджерыBindingSource
            // 
            this.менеджерыBindingSource.DataMember = "Менеджеры";
            this.менеджерыBindingSource.DataSource = this.database1DataSet;
            // 
            // менеджерыTableAdapter
            // 
            this.менеджерыTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partnerIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.партнерыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 544);
            this.dataGridView1.TabIndex = 0;
            // 
            // партнерыBindingSource
            // 
            this.партнерыBindingSource.DataMember = "Партнеры";
            this.партнерыBindingSource.DataSource = this.database1DataSet;
            // 
            // партнерыTableAdapter
            // 
            this.партнерыTableAdapter.ClearBeforeFill = true;
            // 
            // partnerIDDataGridViewTextBoxColumn
            // 
            this.partnerIDDataGridViewTextBoxColumn.DataPropertyName = "Partner_ID";
            this.partnerIDDataGridViewTextBoxColumn.HeaderText = "Partner_ID";
            this.partnerIDDataGridViewTextBoxColumn.Name = "partnerIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 625);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.партнерыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource менеджерыBindingSource;
        private Database1DataSetTableAdapters.МенеджерыTableAdapter менеджерыTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource партнерыBindingSource;
        private Database1DataSetTableAdapters.ПартнерыTableAdapter партнерыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
    }
}