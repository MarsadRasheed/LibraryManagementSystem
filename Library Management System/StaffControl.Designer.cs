namespace Library_Management_System
{
    partial class StaffControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.authorText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.lsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lsAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lsTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lsPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementSystemDataSet6 = new Library_Management_System.LibraryManagementSystemDataSet6();
            this.libraryStaffTableAdapter = new Library_Management_System.LibraryManagementSystemDataSet6TableAdapters.LibraryStaffTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryStaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementSystemDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // statusText
            // 
            this.statusText.AccessibleDescription = "";
            this.statusText.Location = new System.Drawing.Point(570, 78);
            this.statusText.Margin = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(137, 20);
            this.statusText.TabIndex = 24;
            this.statusText.TextChanged += new System.EventHandler(this.StatusText_TextChanged);
            // 
            // priceText
            // 
            this.priceText.AccessibleDescription = "";
            this.priceText.Location = new System.Drawing.Point(570, 31);
            this.priceText.Margin = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(137, 20);
            this.priceText.TabIndex = 23;
            this.priceText.TextChanged += new System.EventHandler(this.PriceText_TextChanged);
            // 
            // nameText
            // 
            this.nameText.AccessibleDescription = "";
            this.nameText.Location = new System.Drawing.Point(125, 129);
            this.nameText.Margin = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(137, 20);
            this.nameText.TabIndex = 22;
            this.nameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // authorText
            // 
            this.authorText.AccessibleDescription = "";
            this.authorText.Location = new System.Drawing.Point(125, 82);
            this.authorText.Margin = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(137, 20);
            this.authorText.TabIndex = 21;
            this.authorText.TextChanged += new System.EventHandler(this.AuthorText_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(466, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Phone";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(466, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Type";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(34, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Id";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // idText
            // 
            this.idText.AccessibleDescription = "";
            this.idText.Location = new System.Drawing.Point(125, 35);
            this.idText.Margin = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(137, 20);
            this.idText.TabIndex = 14;
            this.idText.TextChanged += new System.EventHandler(this.IdText_TextChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(632, 126);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Green;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(538, 125);
            this.updateButton.Margin = new System.Windows.Forms.Padding(16, 3, 16, 3);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 26;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(444, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.AutoGenerateColumns = false;
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lsIdDataGridViewTextBoxColumn,
            this.lsNameDataGridViewTextBoxColumn,
            this.lsAddressDataGridViewTextBoxColumn,
            this.lsTypeDataGridViewTextBoxColumn,
            this.lsPhoneDataGridViewTextBoxColumn});
            this.dataGridViewStaff.DataSource = this.libraryStaffBindingSource;
            this.dataGridViewStaff.Location = new System.Drawing.Point(98, 191);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.Size = new System.Drawing.Size(549, 263);
            this.dataGridViewStaff.TabIndex = 28;
            this.dataGridViewStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewStaff_CellContentClick);
            // 
            // lsIdDataGridViewTextBoxColumn
            // 
            this.lsIdDataGridViewTextBoxColumn.DataPropertyName = "lsId";
            this.lsIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.lsIdDataGridViewTextBoxColumn.Name = "lsIdDataGridViewTextBoxColumn";
            // 
            // lsNameDataGridViewTextBoxColumn
            // 
            this.lsNameDataGridViewTextBoxColumn.DataPropertyName = "lsName";
            this.lsNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.lsNameDataGridViewTextBoxColumn.Name = "lsNameDataGridViewTextBoxColumn";
            // 
            // lsAddressDataGridViewTextBoxColumn
            // 
            this.lsAddressDataGridViewTextBoxColumn.DataPropertyName = "lsAddress";
            this.lsAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.lsAddressDataGridViewTextBoxColumn.Name = "lsAddressDataGridViewTextBoxColumn";
            // 
            // lsTypeDataGridViewTextBoxColumn
            // 
            this.lsTypeDataGridViewTextBoxColumn.DataPropertyName = "lsType";
            this.lsTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.lsTypeDataGridViewTextBoxColumn.Name = "lsTypeDataGridViewTextBoxColumn";
            // 
            // lsPhoneDataGridViewTextBoxColumn
            // 
            this.lsPhoneDataGridViewTextBoxColumn.DataPropertyName = "lsPhone";
            this.lsPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.lsPhoneDataGridViewTextBoxColumn.Name = "lsPhoneDataGridViewTextBoxColumn";
            // 
            // libraryStaffBindingSource
            // 
            this.libraryStaffBindingSource.DataMember = "LibraryStaff";
            this.libraryStaffBindingSource.DataSource = this.libraryManagementSystemDataSet6;
            // 
            // libraryManagementSystemDataSet6
            // 
            this.libraryManagementSystemDataSet6.DataSetName = "LibraryManagementSystemDataSet6";
            this.libraryManagementSystemDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryStaffTableAdapter
            // 
            this.libraryStaffTableAdapter.ClearBeforeFill = true;
            // 
            // StaffControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewStaff);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idText);
            this.Name = "StaffControl";
            this.Size = new System.Drawing.Size(758, 473);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryStaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementSystemDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox statusText;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox authorText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn lsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lsAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lsTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lsPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource libraryStaffBindingSource;
        private LibraryManagementSystemDataSet6 libraryManagementSystemDataSet6;
        private LibraryManagementSystemDataSet6TableAdapters.LibraryStaffTableAdapter libraryStaffTableAdapter;
    }
}
