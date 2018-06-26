namespace WindowsFormsApp3
{
    partial class Form6
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
            this.критерииДоставкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.критерии_доставкиTableAdapter = new WindowsFormsApp3.Database1DataSetTableAdapters.Критерии_доставкиTableAdapter();
            this.detailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acessoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.критерииДоставкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detailIDDataGridViewTextBoxColumn,
            this.acessoryIDDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.критерииДоставкиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 526);
            this.dataGridView1.TabIndex = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // критерииДоставкиBindingSource
            // 
            this.критерииДоставкиBindingSource.DataMember = "Критерии доставки";
            this.критерииДоставкиBindingSource.DataSource = this.database1DataSet;
            // 
            // критерии_доставкиTableAdapter
            // 
            this.критерии_доставкиTableAdapter.ClearBeforeFill = true;
            // 
            // detailIDDataGridViewTextBoxColumn
            // 
            this.detailIDDataGridViewTextBoxColumn.DataPropertyName = "Detail_ID";
            this.detailIDDataGridViewTextBoxColumn.HeaderText = "Detail_ID";
            this.detailIDDataGridViewTextBoxColumn.Name = "detailIDDataGridViewTextBoxColumn";
            // 
            // acessoryIDDataGridViewTextBoxColumn
            // 
            this.acessoryIDDataGridViewTextBoxColumn.DataPropertyName = "Acessory_ID";
            this.acessoryIDDataGridViewTextBoxColumn.HeaderText = "Acessory_ID";
            this.acessoryIDDataGridViewTextBoxColumn.Name = "acessoryIDDataGridViewTextBoxColumn";
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 629);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.критерииДоставкиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource критерииДоставкиBindingSource;
        private Database1DataSetTableAdapters.Критерии_доставкиTableAdapter критерии_доставкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acessoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
    }
}