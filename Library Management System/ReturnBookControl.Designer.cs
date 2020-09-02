namespace Library_Management_System
{
    partial class ReturnBookControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transactionIdText = new System.Windows.Forms.TextBox();
            this.dateTimePickerReturned = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewReturndBooks = new System.Windows.Forms.DataGridView();
            this.transactionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnedBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementSystemDataSet5 = new Library_Management_System.LibraryManagementSystemDataSet5();
            this.returnedBooksTableAdapter = new Library_Management_System.LibraryManagementSystemDataSet5TableAdapters.returnedBooksTableAdapter();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.differenceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturndBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnedBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementSystemDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Return date";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // transactionIdText
            // 
            this.transactionIdText.Location = new System.Drawing.Point(154, 38);
            this.transactionIdText.Name = "transactionIdText";
            this.transactionIdText.Size = new System.Drawing.Size(137, 20);
            this.transactionIdText.TabIndex = 2;
            // 
            // dateTimePickerReturned
            // 
            this.dateTimePickerReturned.Location = new System.Drawing.Point(470, 38);
            this.dateTimePickerReturned.Name = "dateTimePickerReturned";
            this.dateTimePickerReturned.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReturned.TabIndex = 3;
            // 
            // dataGridViewReturndBooks
            // 
            this.dataGridViewReturndBooks.AutoGenerateColumns = false;
            this.dataGridViewReturndBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturndBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIdDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn});
            this.dataGridViewReturndBooks.DataSource = this.returnedBooksBindingSource;
            this.dataGridViewReturndBooks.Location = new System.Drawing.Point(487, 120);
            this.dataGridViewReturndBooks.Name = "dataGridViewReturndBooks";
            this.dataGridViewReturndBooks.Size = new System.Drawing.Size(216, 333);
            this.dataGridViewReturndBooks.TabIndex = 5;
            this.dataGridViewReturndBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewReturndBooks_CellContentClick);
            // 
            // transactionIdDataGridViewTextBoxColumn
            // 
            this.transactionIdDataGridViewTextBoxColumn.DataPropertyName = "transactionId";
            this.transactionIdDataGridViewTextBoxColumn.HeaderText = "transactionId";
            this.transactionIdDataGridViewTextBoxColumn.Name = "transactionIdDataGridViewTextBoxColumn";
            this.transactionIdDataGridViewTextBoxColumn.Width = 70;
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "returnDate";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "returnDate";
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            // 
            // returnedBooksBindingSource
            // 
            this.returnedBooksBindingSource.DataMember = "returnedBooks";
            this.returnedBooksBindingSource.DataSource = this.libraryManagementSystemDataSet5;
            // 
            // libraryManagementSystemDataSet5
            // 
            this.libraryManagementSystemDataSet5.DataSetName = "LibraryManagementSystemDataSet5";
            this.libraryManagementSystemDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // returnedBooksTableAdapter
            // 
            this.returnedBooksTableAdapter.ClearBeforeFill = true;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(295, 180);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 23;
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
            this.updateButton.Location = new System.Drawing.Point(201, 180);
            this.updateButton.Margin = new System.Windows.Forms.Padding(16, 3, 16, 16);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 22;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.Color.Blue;
            this.insertButton.FlatAppearance.BorderSize = 0;
            this.insertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertButton.ForeColor = System.Drawing.Color.White;
            this.insertButton.Location = new System.Drawing.Point(107, 180);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 21;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // differenceLabel
            // 
            this.differenceLabel.AutoSize = true;
            this.differenceLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.differenceLabel.Location = new System.Drawing.Point(53, 87);
            this.differenceLabel.Name = "differenceLabel";
            this.differenceLabel.Size = new System.Drawing.Size(91, 16);
            this.differenceLabel.TabIndex = 24;
            this.differenceLabel.Text = "Difference is ";
            // 
            // ReturnBookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.differenceLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.dataGridViewReturndBooks);
            this.Controls.Add(this.dateTimePickerReturned);
            this.Controls.Add(this.transactionIdText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReturnBookControl";
            this.Size = new System.Drawing.Size(758, 473);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturndBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnedBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementSystemDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox transactionIdText;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturned;
        private System.Windows.Forms.DataGridView dataGridViewReturndBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource returnedBooksBindingSource;
        private LibraryManagementSystemDataSet5 libraryManagementSystemDataSet5;
        private LibraryManagementSystemDataSet5TableAdapters.returnedBooksTableAdapter returnedBooksTableAdapter;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label differenceLabel;
    }
}
