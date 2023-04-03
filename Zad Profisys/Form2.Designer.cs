namespace Zad_Profisys
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.Columns = new System.Windows.Forms.GroupBox();
            this.sortDesc = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.orderBy = new System.Windows.Forms.ComboBox();
            this.IdColumn = new System.Windows.Forms.CheckBox();
            this.DocumentColumn = new System.Windows.Forms.CheckBox();
            this.TaxColumn = new System.Windows.Forms.CheckBox();
            this.QualityColumn = new System.Windows.Forms.CheckBox();
            this.ProductColumn = new System.Windows.Forms.CheckBox();
            this.PriceColumn = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.Columns.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(600, 426);
            this.dataGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(629, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Final price:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.price.Location = new System.Drawing.Point(629, 377);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(30, 31);
            this.price.TabIndex = 3;
            this.price.Text = "0";
            // 
            // Columns
            // 
            this.Columns.Controls.Add(this.sortDesc);
            this.Columns.Controls.Add(this.label6);
            this.Columns.Controls.Add(this.orderBy);
            this.Columns.Controls.Add(this.IdColumn);
            this.Columns.Controls.Add(this.DocumentColumn);
            this.Columns.Controls.Add(this.TaxColumn);
            this.Columns.Controls.Add(this.QualityColumn);
            this.Columns.Controls.Add(this.ProductColumn);
            this.Columns.Controls.Add(this.PriceColumn);
            this.Columns.Location = new System.Drawing.Point(618, 12);
            this.Columns.Name = "Columns";
            this.Columns.Size = new System.Drawing.Size(209, 166);
            this.Columns.TabIndex = 21;
            this.Columns.TabStop = false;
            this.Columns.Text = "Columns";
            // 
            // sortDesc
            // 
            this.sortDesc.AutoSize = true;
            this.sortDesc.Location = new System.Drawing.Point(98, 115);
            this.sortDesc.Name = "sortDesc";
            this.sortDesc.Size = new System.Drawing.Size(105, 17);
            this.sortDesc.TabIndex = 22;
            this.sortDesc.Text = "Sort Descending";
            this.sortDesc.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Order By";
            // 
            // orderBy
            // 
            this.orderBy.FormattingEnabled = true;
            this.orderBy.Items.AddRange(new object[] {
            "Id",
            "Document Number",
            "Product Name",
            "Quality",
            "Price",
            "Tax Rate"});
            this.orderBy.Location = new System.Drawing.Point(98, 88);
            this.orderBy.Name = "orderBy";
            this.orderBy.Size = new System.Drawing.Size(91, 21);
            this.orderBy.TabIndex = 21;
            this.orderBy.Text = "Id";
            // 
            // IdColumn
            // 
            this.IdColumn.AutoSize = true;
            this.IdColumn.Checked = true;
            this.IdColumn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IdColumn.Location = new System.Drawing.Point(11, 19);
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Size = new System.Drawing.Size(35, 17);
            this.IdColumn.TabIndex = 13;
            this.IdColumn.Text = "Id";
            this.IdColumn.UseVisualStyleBackColor = true;
            // 
            // DocumentColumn
            // 
            this.DocumentColumn.AutoSize = true;
            this.DocumentColumn.Checked = true;
            this.DocumentColumn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DocumentColumn.Location = new System.Drawing.Point(11, 42);
            this.DocumentColumn.Name = "DocumentColumn";
            this.DocumentColumn.Size = new System.Drawing.Size(115, 17);
            this.DocumentColumn.TabIndex = 14;
            this.DocumentColumn.Text = "Document Number";
            this.DocumentColumn.UseVisualStyleBackColor = true;
            // 
            // TaxColumn
            // 
            this.TaxColumn.AutoSize = true;
            this.TaxColumn.Checked = true;
            this.TaxColumn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TaxColumn.Location = new System.Drawing.Point(11, 134);
            this.TaxColumn.Name = "TaxColumn";
            this.TaxColumn.Size = new System.Drawing.Size(70, 17);
            this.TaxColumn.TabIndex = 18;
            this.TaxColumn.Text = "Tax Rate";
            this.TaxColumn.UseVisualStyleBackColor = true;
            // 
            // QualityColumn
            // 
            this.QualityColumn.AutoSize = true;
            this.QualityColumn.Checked = true;
            this.QualityColumn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.QualityColumn.Location = new System.Drawing.Point(11, 88);
            this.QualityColumn.Name = "QualityColumn";
            this.QualityColumn.Size = new System.Drawing.Size(58, 17);
            this.QualityColumn.TabIndex = 15;
            this.QualityColumn.Text = "Quality";
            this.QualityColumn.UseVisualStyleBackColor = true;
            // 
            // ProductColumn
            // 
            this.ProductColumn.AutoSize = true;
            this.ProductColumn.Checked = true;
            this.ProductColumn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ProductColumn.Location = new System.Drawing.Point(11, 65);
            this.ProductColumn.Name = "ProductColumn";
            this.ProductColumn.Size = new System.Drawing.Size(94, 17);
            this.ProductColumn.TabIndex = 17;
            this.ProductColumn.Text = "Product Name";
            this.ProductColumn.UseVisualStyleBackColor = true;
            // 
            // PriceColumn
            // 
            this.PriceColumn.AutoSize = true;
            this.PriceColumn.Checked = true;
            this.PriceColumn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PriceColumn.Location = new System.Drawing.Point(11, 111);
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.Size = new System.Drawing.Size(50, 17);
            this.PriceColumn.TabIndex = 16;
            this.PriceColumn.Text = "Price";
            this.PriceColumn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(629, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "Date:";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.date.Location = new System.Drawing.Point(634, 283);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(30, 31);
            this.date.TabIndex = 23;
            this.date.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Columns);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.Columns.ResumeLayout(false);
            this.Columns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label price;
        private System.Windows.Forms.GroupBox Columns;
        private System.Windows.Forms.CheckBox sortDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox orderBy;
        private System.Windows.Forms.CheckBox IdColumn;
        private System.Windows.Forms.CheckBox DocumentColumn;
        private System.Windows.Forms.CheckBox TaxColumn;
        private System.Windows.Forms.CheckBox QualityColumn;
        private System.Windows.Forms.CheckBox ProductColumn;
        private System.Windows.Forms.CheckBox PriceColumn;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label date;
    }
}