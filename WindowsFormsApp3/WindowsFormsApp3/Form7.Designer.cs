namespace WindowsFormsApp3
{
    partial class Form7
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
            this.лодкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.лодкиTableAdapter = new WindowsFormsApp3.Database1DataSetTableAdapters.ЛодкиTableAdapter();
            this.boatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boatTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfRowersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.woodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лодкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boatIDDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.boatTypeDataGridViewTextBoxColumn,
            this.numberOfRowersDataGridViewTextBoxColumn,
            this.mastDataGridViewTextBoxColumn,
            this.colourDataGridViewTextBoxColumn,
            this.woodDataGridViewTextBoxColumn,
            this.basePriceDataGridViewTextBoxColumn,
            this.vATDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.лодкиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 525);
            this.dataGridView1.TabIndex = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // boatIDDataGridViewTextBoxColumn
            // 
            this.boatIDDataGridViewTextBoxColumn.DataPropertyName = "Boat_ID";
            this.boatIDDataGridViewTextBoxColumn.HeaderText = "Boat_ID";
            this.boatIDDataGridViewTextBoxColumn.Name = "boatIDDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // boatTypeDataGridViewTextBoxColumn
            // 
            this.boatTypeDataGridViewTextBoxColumn.DataPropertyName = "BoatType";
            this.boatTypeDataGridViewTextBoxColumn.HeaderText = "BoatType";
            this.boatTypeDataGridViewTextBoxColumn.Name = "boatTypeDataGridViewTextBoxColumn";
            // 
            // numberOfRowersDataGridViewTextBoxColumn
            // 
            this.numberOfRowersDataGridViewTextBoxColumn.DataPropertyName = "NumberOfRowers";
            this.numberOfRowersDataGridViewTextBoxColumn.HeaderText = "NumberOfRowers";
            this.numberOfRowersDataGridViewTextBoxColumn.Name = "numberOfRowersDataGridViewTextBoxColumn";
            // 
            // mastDataGridViewTextBoxColumn
            // 
            this.mastDataGridViewTextBoxColumn.DataPropertyName = "Mast";
            this.mastDataGridViewTextBoxColumn.HeaderText = "Mast";
            this.mastDataGridViewTextBoxColumn.Name = "mastDataGridViewTextBoxColumn";
            // 
            // colourDataGridViewTextBoxColumn
            // 
            this.colourDataGridViewTextBoxColumn.DataPropertyName = "Colour";
            this.colourDataGridViewTextBoxColumn.HeaderText = "Colour";
            this.colourDataGridViewTextBoxColumn.Name = "colourDataGridViewTextBoxColumn";
            // 
            // woodDataGridViewTextBoxColumn
            // 
            this.woodDataGridViewTextBoxColumn.DataPropertyName = "Wood";
            this.woodDataGridViewTextBoxColumn.HeaderText = "Wood";
            this.woodDataGridViewTextBoxColumn.Name = "woodDataGridViewTextBoxColumn";
            // 
            // basePriceDataGridViewTextBoxColumn
            // 
            this.basePriceDataGridViewTextBoxColumn.DataPropertyName = "BasePrice";
            this.basePriceDataGridViewTextBoxColumn.HeaderText = "BasePrice";
            this.basePriceDataGridViewTextBoxColumn.Name = "basePriceDataGridViewTextBoxColumn";
            // 
            // vATDataGridViewTextBoxColumn
            // 
            this.vATDataGridViewTextBoxColumn.DataPropertyName = "VAT";
            this.vATDataGridViewTextBoxColumn.HeaderText = "VAT";
            this.vATDataGridViewTextBoxColumn.Name = "vATDataGridViewTextBoxColumn";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 625);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лодкиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource лодкиBindingSource;
        private Database1DataSetTableAdapters.ЛодкиTableAdapter лодкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn boatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boatTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfRowersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn woodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATDataGridViewTextBoxColumn;
    }
}