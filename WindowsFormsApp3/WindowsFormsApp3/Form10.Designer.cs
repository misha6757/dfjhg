namespace WindowsFormsApp3
{
    partial class Form10
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new WindowsFormsApp3.Database1DataSet();
            this.счетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.счетTableAdapter = new WindowsFormsApp3.Database1DataSetTableAdapters.СчетTableAdapter();
            this.invoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumInclVATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceIDDataGridViewTextBoxColumn,
            this.contractIDDataGridViewTextBoxColumn,
            this.settledDataGridViewTextBoxColumn,
            this.sumDataGridViewTextBoxColumn,
            this.sumInclVATDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.счетBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 509);
            this.dataGridView1.TabIndex = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // счетBindingSource
            // 
            this.счетBindingSource.DataMember = "Счет";
            this.счетBindingSource.DataSource = this.database1DataSet;
            // 
            // счетTableAdapter
            // 
            this.счетTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceIDDataGridViewTextBoxColumn
            // 
            this.invoiceIDDataGridViewTextBoxColumn.DataPropertyName = "Invoice_ID";
            this.invoiceIDDataGridViewTextBoxColumn.HeaderText = "Invoice_ID";
            this.invoiceIDDataGridViewTextBoxColumn.Name = "invoiceIDDataGridViewTextBoxColumn";
            // 
            // contractIDDataGridViewTextBoxColumn
            // 
            this.contractIDDataGridViewTextBoxColumn.DataPropertyName = "Contract_ID";
            this.contractIDDataGridViewTextBoxColumn.HeaderText = "Contract_ID";
            this.contractIDDataGridViewTextBoxColumn.Name = "contractIDDataGridViewTextBoxColumn";
            // 
            // settledDataGridViewTextBoxColumn
            // 
            this.settledDataGridViewTextBoxColumn.DataPropertyName = "Settled";
            this.settledDataGridViewTextBoxColumn.HeaderText = "Settled";
            this.settledDataGridViewTextBoxColumn.Name = "settledDataGridViewTextBoxColumn";
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "Sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "Sum";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            // 
            // sumInclVATDataGridViewTextBoxColumn
            // 
            this.sumInclVATDataGridViewTextBoxColumn.DataPropertyName = "Sum_InclVAT";
            this.sumInclVATDataGridViewTextBoxColumn.HeaderText = "Sum_InclVAT";
            this.sumInclVATDataGridViewTextBoxColumn.Name = "sumInclVATDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 647);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource счетBindingSource;
        private Database1DataSetTableAdapters.СчетTableAdapter счетTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn settledDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumInclVATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}