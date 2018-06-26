namespace WindowsFormsApp3
{
    partial class Form4
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
            this.партнерыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.партнерыTableAdapter = new WindowsFormsApp3.Database1DataSetTableAdapters.ПартнерыTableAdapter();
            this.счетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.счетTableAdapter = new WindowsFormsApp3.Database1DataSetTableAdapters.СчетTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new WindowsFormsApp3.Database1DataSetTableAdapters.ЗаказыTableAdapter();
            this.contractIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositPayedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractTotalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractTotalPriceinclVATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionProcessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.партнерыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // счетBindingSource
            // 
            this.счетBindingSource.DataMember = "Счет";
            this.счетBindingSource.DataSource = this.database1DataSet;
            // 
            // счетTableAdapter
            // 
            this.счетTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contractIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.depositPayedDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.contractTotalPriceDataGridViewTextBoxColumn,
            this.contractTotalPriceinclVATDataGridViewTextBoxColumn,
            this.productionProcessDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заказыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 509);
            this.dataGridView1.TabIndex = 0;
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
            // contractIDDataGridViewTextBoxColumn
            // 
            this.contractIDDataGridViewTextBoxColumn.DataPropertyName = "Contract_ID";
            this.contractIDDataGridViewTextBoxColumn.HeaderText = "Contract_ID";
            this.contractIDDataGridViewTextBoxColumn.Name = "contractIDDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // depositPayedDataGridViewTextBoxColumn
            // 
            this.depositPayedDataGridViewTextBoxColumn.DataPropertyName = "DepositPayed";
            this.depositPayedDataGridViewTextBoxColumn.HeaderText = "DepositPayed";
            this.depositPayedDataGridViewTextBoxColumn.Name = "depositPayedDataGridViewTextBoxColumn";
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // contractTotalPriceDataGridViewTextBoxColumn
            // 
            this.contractTotalPriceDataGridViewTextBoxColumn.DataPropertyName = "ContractTotalPrice";
            this.contractTotalPriceDataGridViewTextBoxColumn.HeaderText = "ContractTotalPrice";
            this.contractTotalPriceDataGridViewTextBoxColumn.Name = "contractTotalPriceDataGridViewTextBoxColumn";
            // 
            // contractTotalPriceinclVATDataGridViewTextBoxColumn
            // 
            this.contractTotalPriceinclVATDataGridViewTextBoxColumn.DataPropertyName = "ContractTotalPrice_inclVAT";
            this.contractTotalPriceinclVATDataGridViewTextBoxColumn.HeaderText = "ContractTotalPrice_inclVAT";
            this.contractTotalPriceinclVATDataGridViewTextBoxColumn.Name = "contractTotalPriceinclVATDataGridViewTextBoxColumn";
            // 
            // productionProcessDataGridViewTextBoxColumn
            // 
            this.productionProcessDataGridViewTextBoxColumn.DataPropertyName = "ProductionProcess";
            this.productionProcessDataGridViewTextBoxColumn.HeaderText = "ProductionProcess";
            this.productionProcessDataGridViewTextBoxColumn.Name = "productionProcessDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 611);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.партнерыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource партнерыBindingSource;
        private Database1DataSetTableAdapters.ПартнерыTableAdapter партнерыTableAdapter;
        private System.Windows.Forms.BindingSource счетBindingSource;
        private Database1DataSetTableAdapters.СчетTableAdapter счетTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private Database1DataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositPayedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractTotalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractTotalPriceinclVATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionProcessDataGridViewTextBoxColumn;
    }
}