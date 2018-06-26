namespace WindowsFormsApp3
{
    partial class Form3
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
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter = new WindowsFormsApp3.Database1DataSetTableAdapters.КлиентыTableAdapter();
            this.лодкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.лодкиTableAdapter = new WindowsFormsApp3.Database1DataSetTableAdapters.ЛодкиTableAdapter();
            this.менеджерыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.менеджерыTableAdapter = new WindowsFormsApp3.Database1DataSetTableAdapters.МенеджерыTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.доставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доставкаTableAdapter = new WindowsFormsApp3.Database1DataSetTableAdapters.ДоставкаTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesrersonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лодкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // лодкиBindingSource
            // 
            this.лодкиBindingSource.DataMember = "Лодки";
            this.лодкиBindingSource.DataSource = this.database1DataSet;
            // 
            // лодкиTableAdapter
            // 
            this.лодкиTableAdapter.ClearBeforeFill = true;
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
            this.кодDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.salesrersonIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.boatIDDataGridViewTextBoxColumn,
            this.deliveryAddressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.доставкаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(48, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 479);
            this.dataGridView1.TabIndex = 0;
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
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // salesrersonIDDataGridViewTextBoxColumn
            // 
            this.salesrersonIDDataGridViewTextBoxColumn.DataPropertyName = "Salesrerson_ID";
            this.salesrersonIDDataGridViewTextBoxColumn.HeaderText = "Salesrerson_ID";
            this.salesrersonIDDataGridViewTextBoxColumn.Name = "salesrersonIDDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // boatIDDataGridViewTextBoxColumn
            // 
            this.boatIDDataGridViewTextBoxColumn.DataPropertyName = "Boat_ID";
            this.boatIDDataGridViewTextBoxColumn.HeaderText = "Boat_ID";
            this.boatIDDataGridViewTextBoxColumn.Name = "boatIDDataGridViewTextBoxColumn";
            // 
            // deliveryAddressDataGridViewTextBoxColumn
            // 
            this.deliveryAddressDataGridViewTextBoxColumn.DataPropertyName = "DeliveryAddress";
            this.deliveryAddressDataGridViewTextBoxColumn.HeaderText = "DeliveryAddress";
            this.deliveryAddressDataGridViewTextBoxColumn.Name = "deliveryAddressDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 652);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лодкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private Database1DataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.BindingSource лодкиBindingSource;
        private Database1DataSetTableAdapters.ЛодкиTableAdapter лодкиTableAdapter;
        private System.Windows.Forms.BindingSource менеджерыBindingSource;
        private Database1DataSetTableAdapters.МенеджерыTableAdapter менеджерыTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource доставкаBindingSource;
        private Database1DataSetTableAdapters.ДоставкаTableAdapter доставкаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesrersonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
    }
}