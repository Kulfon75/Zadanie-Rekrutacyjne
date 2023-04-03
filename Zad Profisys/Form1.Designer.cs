namespace Zad_Profisys
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selectFile = new System.Windows.Forms.Button();
            this.docs = new System.Windows.Forms.RadioButton();
            this.positions = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.userText = new System.Windows.Forms.TextBox();
            this.dataSourceTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.connStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.closeConnection = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.IdColumn = new System.Windows.Forms.CheckBox();
            this.TypeColumn = new System.Windows.Forms.CheckBox();
            this.FirstNameColumn = new System.Windows.Forms.CheckBox();
            this.LastNameColumn = new System.Windows.Forms.CheckBox();
            this.DateColumn = new System.Windows.Forms.CheckBox();
            this.CityColumn = new System.Windows.Forms.CheckBox();
            this.RefreshTable = new System.Windows.Forms.Button();
            this.Columns = new System.Windows.Forms.GroupBox();
            this.sortDesc = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.orderBy = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.Columns.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // selectFile
            // 
            this.selectFile.Location = new System.Drawing.Point(12, 12);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(107, 23);
            this.selectFile.TabIndex = 0;
            this.selectFile.Text = "Select File";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // docs
            // 
            this.docs.AutoSize = true;
            this.docs.Checked = true;
            this.docs.Location = new System.Drawing.Point(6, 25);
            this.docs.Name = "docs";
            this.docs.Size = new System.Drawing.Size(79, 17);
            this.docs.TabIndex = 1;
            this.docs.TabStop = true;
            this.docs.Text = "Documents";
            this.docs.UseVisualStyleBackColor = true;
            // 
            // positions
            // 
            this.positions.AutoSize = true;
            this.positions.Location = new System.Drawing.Point(91, 25);
            this.positions.Name = "positions";
            this.positions.Size = new System.Drawing.Size(67, 17);
            this.positions.TabIndex = 2;
            this.positions.Text = "Positions";
            this.positions.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.filePath);
            this.groupBox1.Controls.Add(this.docs);
            this.groupBox1.Controls.Add(this.positions);
            this.groupBox1.Location = new System.Drawing.Point(138, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 59);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Filepath:";
            // 
            // filePath
            // 
            this.filePath.Enabled = false;
            this.filePath.Location = new System.Drawing.Point(217, 22);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(207, 20);
            this.filePath.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Connect to database";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(81, 22);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(158, 20);
            this.userTextBox.TabIndex = 5;
            this.userTextBox.Text = "sys";
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(81, 50);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(158, 20);
            this.passTextBox.TabIndex = 6;
            this.passTextBox.Text = "password";
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(290, 28);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(100, 20);
            this.userText.TabIndex = 5;
            // 
            // dataSourceTextBox
            // 
            this.dataSourceTextBox.Location = new System.Drawing.Point(81, 82);
            this.dataSourceTextBox.Name = "dataSourceTextBox";
            this.dataSourceTextBox.Size = new System.Drawing.Size(158, 20);
            this.dataSourceTextBox.TabIndex = 7;
            this.dataSourceTextBox.Text = "localhost:1521/orcl";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.connStatus);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.closeConnection);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.userTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dataSourceTextBox);
            this.groupBox2.Controls.Add(this.passTextBox);
            this.groupBox2.Location = new System.Drawing.Point(626, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 157);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection Data";
            // 
            // connStatus
            // 
            this.connStatus.AutoSize = true;
            this.connStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.connStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connStatus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.connStatus.Location = new System.Drawing.Point(198, 114);
            this.connStatus.Name = "connStatus";
            this.connStatus.Size = new System.Drawing.Size(155, 25);
            this.connStatus.TabIndex = 16;
            this.connStatus.Text = "Disconnected";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(28, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Connection status:";
            // 
            // closeConnection
            // 
            this.closeConnection.Location = new System.Drawing.Point(258, 65);
            this.closeConnection.Name = "closeConnection";
            this.closeConnection.Size = new System.Drawing.Size(107, 37);
            this.closeConnection.TabIndex = 12;
            this.closeConnection.Text = "Close Connection";
            this.closeConnection.UseVisualStyleBackColor = true;
            this.closeConnection.Click += new System.EventHandler(this.closeConnection_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 97);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(566, 418);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add file to database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            // TypeColumn
            // 
            this.TypeColumn.AutoSize = true;
            this.TypeColumn.Checked = true;
            this.TypeColumn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TypeColumn.Location = new System.Drawing.Point(11, 42);
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.Size = new System.Drawing.Size(79, 17);
            this.TypeColumn.TabIndex = 14;
            this.TypeColumn.Text = "Order Type";
            this.TypeColumn.UseVisualStyleBackColor = true;
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.AutoSize = true;
            this.FirstNameColumn.Checked = true;
            this.FirstNameColumn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FirstNameColumn.Location = new System.Drawing.Point(11, 88);
            this.FirstNameColumn.Name = "FirstNameColumn";
            this.FirstNameColumn.Size = new System.Drawing.Size(76, 17);
            this.FirstNameColumn.TabIndex = 15;
            this.FirstNameColumn.Text = "First Name";
            this.FirstNameColumn.UseVisualStyleBackColor = true;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.AutoSize = true;
            this.LastNameColumn.Checked = true;
            this.LastNameColumn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LastNameColumn.Location = new System.Drawing.Point(11, 111);
            this.LastNameColumn.Name = "LastNameColumn";
            this.LastNameColumn.Size = new System.Drawing.Size(77, 17);
            this.LastNameColumn.TabIndex = 16;
            this.LastNameColumn.Text = "Last Name";
            this.LastNameColumn.UseVisualStyleBackColor = true;
            // 
            // DateColumn
            // 
            this.DateColumn.AutoSize = true;
            this.DateColumn.Checked = true;
            this.DateColumn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DateColumn.Location = new System.Drawing.Point(11, 65);
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.Size = new System.Drawing.Size(49, 17);
            this.DateColumn.TabIndex = 17;
            this.DateColumn.Text = "Date";
            this.DateColumn.UseVisualStyleBackColor = true;
            // 
            // CityColumn
            // 
            this.CityColumn.AutoSize = true;
            this.CityColumn.Checked = true;
            this.CityColumn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CityColumn.Location = new System.Drawing.Point(11, 134);
            this.CityColumn.Name = "CityColumn";
            this.CityColumn.Size = new System.Drawing.Size(43, 17);
            this.CityColumn.TabIndex = 18;
            this.CityColumn.Text = "City";
            this.CityColumn.UseVisualStyleBackColor = true;
            // 
            // RefreshTable
            // 
            this.RefreshTable.Location = new System.Drawing.Point(626, 440);
            this.RefreshTable.Name = "RefreshTable";
            this.RefreshTable.Size = new System.Drawing.Size(118, 75);
            this.RefreshTable.TabIndex = 19;
            this.RefreshTable.Text = "Reftesh Table";
            this.RefreshTable.UseVisualStyleBackColor = true;
            this.RefreshTable.Click += new System.EventHandler(this.RefreshTable_Click);
            // 
            // Columns
            // 
            this.Columns.Controls.Add(this.sortDesc);
            this.Columns.Controls.Add(this.label6);
            this.Columns.Controls.Add(this.orderBy);
            this.Columns.Controls.Add(this.IdColumn);
            this.Columns.Controls.Add(this.TypeColumn);
            this.Columns.Controls.Add(this.CityColumn);
            this.Columns.Controls.Add(this.FirstNameColumn);
            this.Columns.Controls.Add(this.DateColumn);
            this.Columns.Controls.Add(this.LastNameColumn);
            this.Columns.Location = new System.Drawing.Point(626, 205);
            this.Columns.Name = "Columns";
            this.Columns.Size = new System.Drawing.Size(218, 166);
            this.Columns.TabIndex = 20;
            this.Columns.TabStop = false;
            this.Columns.Text = "Columns";
            // 
            // sortDesc
            // 
            this.sortDesc.AutoSize = true;
            this.sortDesc.Location = new System.Drawing.Point(107, 65);
            this.sortDesc.Name = "sortDesc";
            this.sortDesc.Size = new System.Drawing.Size(105, 17);
            this.sortDesc.TabIndex = 22;
            this.sortDesc.Text = "Sort Descending";
            this.sortDesc.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 16);
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
            "Order Type",
            "Date",
            "First Name",
            "Last Name",
            "City"});
            this.orderBy.Location = new System.Drawing.Point(107, 38);
            this.orderBy.Name = "orderBy";
            this.orderBy.Size = new System.Drawing.Size(91, 21);
            this.orderBy.TabIndex = 21;
            this.orderBy.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 537);
            this.Controls.Add(this.Columns);
            this.Controls.Add(this.RefreshTable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.selectFile);
            this.Name = "Form1";
            this.Text = "Application";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.Columns.ResumeLayout(false);
            this.Columns.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.RadioButton docs;
        private System.Windows.Forms.RadioButton positions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.TextBox dataSourceTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeConnection;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label connStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox IdColumn;
        private System.Windows.Forms.CheckBox TypeColumn;
        private System.Windows.Forms.CheckBox FirstNameColumn;
        private System.Windows.Forms.CheckBox LastNameColumn;
        private System.Windows.Forms.CheckBox DateColumn;
        private System.Windows.Forms.CheckBox CityColumn;
        private System.Windows.Forms.Button RefreshTable;
        private System.Windows.Forms.GroupBox Columns;
        private System.Windows.Forms.ComboBox orderBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox sortDesc;
    }
}

