namespace WindowsFormsApp3
{
    partial class Form2
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
            this.аксессуарыЛодочныеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.аксессуары_лодочныеTableAdapter = new WindowsFormsApp3.Database1DataSetTableAdapters.Аксессуары_лодочныеTableAdapter();
            this.fitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.аксессуарыЛодочныеBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.доставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доставкаTableAdapter = new WindowsFormsApp3.Database1DataSetTableAdapters.ДоставкаTableAdapter();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new WindowsFormsApp3.Database1DataSetTableAdapters.ЗаказыTableAdapter();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter = new WindowsFormsApp3.Database1DataSetTableAdapters.КлиентыTableAdapter();
            this.критерииДоставкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.критерии_доставкиTableAdapter = new WindowsFormsApp3.Database1DataSetTableAdapters.Критерии_доставкиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аксессуарыЛодочныеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аксессуарыЛодочныеBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.критерииДоставкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fitIDDataGridViewTextBoxColumn,
            this.accessoryIDDataGridViewTextBoxColumn,
            this.boatIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.аксессуарыЛодочныеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 484);
            this.dataGridView1.TabIndex = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // аксессуарыЛодочныеBindingSource
            // 
            this.аксессуарыЛодочныеBindingSource.DataMember = "Аксессуары лодочные";
            this.аксессуарыЛодочныеBindingSource.DataSource = this.database1DataSet;
            // 
            // аксессуары_лодочныеTableAdapter
            // 
            this.аксессуары_лодочныеTableAdapter.ClearBeforeFill = true;
            // 
            // fitIDDataGridViewTextBoxColumn
            // 
            this.fitIDDataGridViewTextBoxColumn.DataPropertyName = "Fit_ID";
            this.fitIDDataGridViewTextBoxColumn.HeaderText = "Fit_ID";
            this.fitIDDataGridViewTextBoxColumn.Name = "fitIDDataGridViewTextBoxColumn";
            // 
            // accessoryIDDataGridViewTextBoxColumn
            // 
            this.accessoryIDDataGridViewTextBoxColumn.DataPropertyName = "Accessory_ID";
            this.accessoryIDDataGridViewTextBoxColumn.HeaderText = "Accessory_ID";
            this.accessoryIDDataGridViewTextBoxColumn.Name = "accessoryIDDataGridViewTextBoxColumn";
            // 
            // boatIDDataGridViewTextBoxColumn
            // 
            this.boatIDDataGridViewTextBoxColumn.DataPropertyName = "Boat_ID";
            this.boatIDDataGridViewTextBoxColumn.HeaderText = "Boat_ID";
            this.boatIDDataGridViewTextBoxColumn.Name = "boatIDDataGridViewTextBoxColumn";
            // 
            // аксессуарыЛодочныеBindingSource1
            // 
            this.аксессуарыЛодочныеBindingSource1.DataMember = "Аксессуары лодочные";
            this.аксессуарыЛодочныеBindingSource1.DataSource = this.database1DataSet;
            // 
            // доставкаBindingSource
            // 
            this.доставкаBindingSource.DataMember = "Доставка";
            this.доставкаBindingSource.DataSource = this.database1DataSet;
            // 
            // доставкаTableAdapter
            // 
            this.доставкаTableAdapter.ClearBeforeFill = true;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.database1DataSet;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.database1DataSet;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 620);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аксессуарыЛодочныеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аксессуарыЛодочныеBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.критерииДоставкиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource аксессуарыЛодочныеBindingSource;
        private Database1DataSetTableAdapters.Аксессуары_лодочныеTableAdapter аксессуары_лодочныеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource аксессуарыЛодочныеBindingSource1;
        private System.Windows.Forms.BindingSource доставкаBindingSource;
        private Database1DataSetTableAdapters.ДоставкаTableAdapter доставкаTableAdapter;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private Database1DataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private Database1DataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.BindingSource критерииДоставкиBindingSource;
        private Database1DataSetTableAdapters.Критерии_доставкиTableAdapter критерии_доставкиTableAdapter;
    }
}