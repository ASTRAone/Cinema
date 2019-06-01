namespace WindowsFormsApp17
{
    partial class Form5
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
            this.button1 = new System.Windows.Forms.Button();
            this.кинотеатрDataSet = new WindowsFormsApp17.КинотеатрDataSet();
            this.кинотеатрDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кинотеатрDataSet1 = new WindowsFormsApp17.КинотеатрDataSet1();
            this.продуктыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продуктыTableAdapter = new WindowsFormsApp17.КинотеатрDataSet1TableAdapters.ПродуктыTableAdapter();
            this.idпродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиепродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценапродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idпродуктаDataGridViewTextBoxColumn,
            this.названиепродуктаDataGridViewTextBoxColumn,
            this.ценапродуктаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.продуктыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // кинотеатрDataSet
            // 
            this.кинотеатрDataSet.DataSetName = "КинотеатрDataSet";
            this.кинотеатрDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // кинотеатрDataSetBindingSource
            // 
            this.кинотеатрDataSetBindingSource.DataSource = this.кинотеатрDataSet;
            this.кинотеатрDataSetBindingSource.Position = 0;
            // 
            // кинотеатрDataSet1
            // 
            this.кинотеатрDataSet1.DataSetName = "КинотеатрDataSet1";
            this.кинотеатрDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // продуктыBindingSource
            // 
            this.продуктыBindingSource.DataMember = "Продукты";
            this.продуктыBindingSource.DataSource = this.кинотеатрDataSet1;
            // 
            // продуктыTableAdapter
            // 
            this.продуктыTableAdapter.ClearBeforeFill = true;
            // 
            // idпродуктаDataGridViewTextBoxColumn
            // 
            this.idпродуктаDataGridViewTextBoxColumn.DataPropertyName = "Id_продукта";
            this.idпродуктаDataGridViewTextBoxColumn.HeaderText = "Id_продукта";
            this.idпродуктаDataGridViewTextBoxColumn.Name = "idпродуктаDataGridViewTextBoxColumn";
            // 
            // названиепродуктаDataGridViewTextBoxColumn
            // 
            this.названиепродуктаDataGridViewTextBoxColumn.DataPropertyName = "Название_продукта";
            this.названиепродуктаDataGridViewTextBoxColumn.HeaderText = "Название_продукта";
            this.названиепродуктаDataGridViewTextBoxColumn.Name = "названиепродуктаDataGridViewTextBoxColumn";
            // 
            // ценапродуктаDataGridViewTextBoxColumn
            // 
            this.ценапродуктаDataGridViewTextBoxColumn.DataPropertyName = "Цена_продукта";
            this.ценапродуктаDataGridViewTextBoxColumn.HeaderText = "Цена_продукта";
            this.ценапродуктаDataGridViewTextBoxColumn.Name = "ценапродуктаDataGridViewTextBoxColumn";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource кинотеатрDataSetBindingSource;
        private КинотеатрDataSet кинотеатрDataSet;
        private System.Windows.Forms.Button button1;
        private КинотеатрDataSet1 кинотеатрDataSet1;
        private System.Windows.Forms.BindingSource продуктыBindingSource;
        private КинотеатрDataSet1TableAdapters.ПродуктыTableAdapter продуктыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idпродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиепродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценапродуктаDataGridViewTextBoxColumn;
    }
}