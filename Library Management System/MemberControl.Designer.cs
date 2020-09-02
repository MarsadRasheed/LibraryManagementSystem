namespace Library_Management_System
{
    partial class MemberControl
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
            this.idText = new System.Windows.Forms.TextBox();
            this.booksIssuedText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.memberDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.insertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.memberDataGridView = new System.Windows.Forms.DataGridView();
            this.libraryManagementSystemDataSet2 = new Library_Management_System.LibraryManagementSystemDataSet2();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new Library_Management_System.LibraryManagementSystemDataSet2TableAdapters.MemberTableAdapter();
            this.memberIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfMembershipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfBooksIssuedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(160, 39);
            this.idText.Margin = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(137, 20);
            this.idText.TabIndex = 0;
            // 
            // booksIssuedText
            // 
            this.booksIssuedText.Location = new System.Drawing.Point(540, 39);
            this.booksIssuedText.Margin = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.booksIssuedText.Name = "booksIssuedText";
            this.booksIssuedText.Size = new System.Drawing.Size(137, 20);
            this.booksIssuedText.TabIndex = 3;
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(540, 86);
            this.addressText.Margin = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(137, 20);
            this.addressText.TabIndex = 4;
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(540, 133);
            this.phoneText.Margin = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(137, 20);
            this.phoneText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Member Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Member Type";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date of Membership";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "No of books issued";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(421, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Member Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(421, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Member Phone";
            // 
            // maleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.Location = new System.Drawing.Point(160, 86);
            this.maleButton.Margin = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(62, 17);
            this.maleButton.TabIndex = 12;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "Student";
            this.maleButton.UseVisualStyleBackColor = true;
            this.maleButton.CheckedChanged += new System.EventHandler(this.MaleButton_CheckedChanged);
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Location = new System.Drawing.Point(238, 86);
            this.femaleButton.Margin = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(65, 17);
            this.femaleButton.TabIndex = 13;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "Teacher";
            this.femaleButton.UseVisualStyleBackColor = true;
            this.femaleButton.CheckedChanged += new System.EventHandler(this.FemaleButton_CheckedChanged);
            // 
            // memberDateTimePicker
            // 
            this.memberDateTimePicker.Location = new System.Drawing.Point(160, 130);
            this.memberDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.memberDateTimePicker.Name = "memberDateTimePicker";
            this.memberDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.memberDateTimePicker.TabIndex = 14;
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.Color.Blue;
            this.insertButton.FlatAppearance.BorderSize = 0;
            this.insertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertButton.ForeColor = System.Drawing.Color.White;
            this.insertButton.Location = new System.Drawing.Point(252, 175);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 18;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Green;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(346, 175);
            this.updateButton.Margin = new System.Windows.Forms.Padding(16, 3, 16, 16);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 19;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(440, 175);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // memberDataGridView
            // 
            this.memberDataGridView.AutoGenerateColumns = false;
            this.memberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberIdDataGridViewTextBoxColumn,
            this.memberTypeDataGridViewTextBoxColumn,
            this.dateOfMembershipDataGridViewTextBoxColumn,
            this.noOfBooksIssuedDataGridViewTextBoxColumn,
            this.memberAddressDataGridViewTextBoxColumn,
            this.memberPhoneDataGridViewTextBoxColumn});
            this.memberDataGridView.DataSource = this.memberBindingSource;
            this.memberDataGridView.Location = new System.Drawing.Point(55, 217);
            this.memberDataGridView.Name = "memberDataGridView";
            this.memberDataGridView.Size = new System.Drawing.Size(644, 253);
            this.memberDataGridView.TabIndex = 22;
            this.memberDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemberDataGridView_CellContentClick);
            // 
            // libraryManagementSystemDataSet2
            // 
            this.libraryManagementSystemDataSet2.DataSetName = "LibraryManagementSystemDataSet2";
            this.libraryManagementSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.libraryManagementSystemDataSet2;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // memberIdDataGridViewTextBoxColumn
            // 
            this.memberIdDataGridViewTextBoxColumn.DataPropertyName = "memberId";
            this.memberIdDataGridViewTextBoxColumn.HeaderText = "memberId";
            this.memberIdDataGridViewTextBoxColumn.Name = "memberIdDataGridViewTextBoxColumn";
            // 
            // memberTypeDataGridViewTextBoxColumn
            // 
            this.memberTypeDataGridViewTextBoxColumn.DataPropertyName = "memberType";
            this.memberTypeDataGridViewTextBoxColumn.HeaderText = "memberType";
            this.memberTypeDataGridViewTextBoxColumn.Name = "memberTypeDataGridViewTextBoxColumn";
            // 
            // dateOfMembershipDataGridViewTextBoxColumn
            // 
            this.dateOfMembershipDataGridViewTextBoxColumn.DataPropertyName = "dateOfMembership";
            this.dateOfMembershipDataGridViewTextBoxColumn.HeaderText = "dateOfMembership";
            this.dateOfMembershipDataGridViewTextBoxColumn.Name = "dateOfMembershipDataGridViewTextBoxColumn";
            // 
            // noOfBooksIssuedDataGridViewTextBoxColumn
            // 
            this.noOfBooksIssuedDataGridViewTextBoxColumn.DataPropertyName = "noOfBooksIssued";
            this.noOfBooksIssuedDataGridViewTextBoxColumn.HeaderText = "noOfBooksIssued";
            this.noOfBooksIssuedDataGridViewTextBoxColumn.Name = "noOfBooksIssuedDataGridViewTextBoxColumn";
            // 
            // memberAddressDataGridViewTextBoxColumn
            // 
            this.memberAddressDataGridViewTextBoxColumn.DataPropertyName = "memberAddress";
            this.memberAddressDataGridViewTextBoxColumn.HeaderText = "memberAddress";
            this.memberAddressDataGridViewTextBoxColumn.Name = "memberAddressDataGridViewTextBoxColumn";
            // 
            // memberPhoneDataGridViewTextBoxColumn
            // 
            this.memberPhoneDataGridViewTextBoxColumn.DataPropertyName = "memberPhone";
            this.memberPhoneDataGridViewTextBoxColumn.HeaderText = "memberPhone";
            this.memberPhoneDataGridViewTextBoxColumn.Name = "memberPhoneDataGridViewTextBoxColumn";
            // 
            // MemberControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.memberDataGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.memberDateTimePicker);
            this.Controls.Add(this.femaleButton);
            this.Controls.Add(this.maleButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.booksIssuedText);
            this.Controls.Add(this.idText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MemberControl";
            this.Size = new System.Drawing.Size(758, 473);
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox booksIssuedText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.DateTimePicker memberDateTimePicker;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView memberDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfMembershipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfBooksIssuedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private LibraryManagementSystemDataSet2 libraryManagementSystemDataSet2;
        private LibraryManagementSystemDataSet2TableAdapters.MemberTableAdapter memberTableAdapter;
    }
}
