namespace Library_Management_System
{
    partial class IssuedBooksControl
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
            this.memberIdText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.issuedDataGridView = new System.Windows.Forms.DataGridView();
            this.transactionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfIssueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transctionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementSystemDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementSystemDataSet3 = new Library_Management_System.LibraryManagementSystemDataSet3();
            this.transctionTableAdapter = new Library_Management_System.LibraryManagementSystemDataSet3TableAdapters.TransctionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.issuedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transctionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementSystemDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementSystemDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Id";
            // 
            // memberIdText
            // 
            this.memberIdText.Location = new System.Drawing.Point(241, 44);
            this.memberIdText.Name = "memberIdText";
            this.memberIdText.Size = new System.Drawing.Size(150, 20);
            this.memberIdText.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(524, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // issuedDataGridView
            // 
            this.issuedDataGridView.AutoGenerateColumns = false;
            this.issuedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issuedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIdDataGridViewTextBoxColumn,
            this.memberIdDataGridViewTextBoxColumn,
            this.bookIdDataGridViewTextBoxColumn,
            this.dateOfIssueDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn});
            this.issuedDataGridView.DataSource = this.transctionBindingSource;
            this.issuedDataGridView.Location = new System.Drawing.Point(87, 113);
            this.issuedDataGridView.Name = "issuedDataGridView";
            this.issuedDataGridView.Size = new System.Drawing.Size(566, 306);
            this.issuedDataGridView.TabIndex = 3;
            // 
            // transactionIdDataGridViewTextBoxColumn
            // 
            this.transactionIdDataGridViewTextBoxColumn.DataPropertyName = "transactionId";
            this.transactionIdDataGridViewTextBoxColumn.HeaderText = "Issue Id";
            this.transactionIdDataGridViewTextBoxColumn.Name = "transactionIdDataGridViewTextBoxColumn";
            // 
            // memberIdDataGridViewTextBoxColumn
            // 
            this.memberIdDataGridViewTextBoxColumn.DataPropertyName = "memberId";
            this.memberIdDataGridViewTextBoxColumn.HeaderText = "memberId";
            this.memberIdDataGridViewTextBoxColumn.Name = "memberIdDataGridViewTextBoxColumn";
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "bookId";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "bookId";
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            // 
            // dateOfIssueDataGridViewTextBoxColumn
            // 
            this.dateOfIssueDataGridViewTextBoxColumn.DataPropertyName = "dateOfIssue";
            this.dateOfIssueDataGridViewTextBoxColumn.HeaderText = "dateOfIssue";
            this.dateOfIssueDataGridViewTextBoxColumn.Name = "dateOfIssueDataGridViewTextBoxColumn";
            this.dateOfIssueDataGridViewTextBoxColumn.Width = 110;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "dueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "dueDate";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.Width = 110;
            // 
            // transctionBindingSource
            // 
            this.transctionBindingSource.DataMember = "Transction";
            this.transctionBindingSource.DataSource = this.libraryManagementSystemDataSet3BindingSource;
            // 
            // libraryManagementSystemDataSet3BindingSource
            // 
            this.libraryManagementSystemDataSet3BindingSource.DataSource = this.libraryManagementSystemDataSet3;
            this.libraryManagementSystemDataSet3BindingSource.Position = 0;
            // 
            // libraryManagementSystemDataSet3
            // 
            this.libraryManagementSystemDataSet3.DataSetName = "LibraryManagementSystemDataSet3";
            this.libraryManagementSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transctionTableAdapter
            // 
            this.transctionTableAdapter.ClearBeforeFill = true;
            // 
            // IssuedBooksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.issuedDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.memberIdText);
            this.Controls.Add(this.label1);
            this.Name = "IssuedBooksControl";
            this.Size = new System.Drawing.Size(758, 473);
            ((System.ComponentModel.ISupportInitialize)(this.issuedDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transctionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementSystemDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementSystemDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox memberIdText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView issuedDataGridView;
        private System.Windows.Forms.BindingSource transctionBindingSource;
        private System.Windows.Forms.BindingSource libraryManagementSystemDataSet3BindingSource;
        private LibraryManagementSystemDataSet3 libraryManagementSystemDataSet3;
        private LibraryManagementSystemDataSet3TableAdapters.TransctionTableAdapter transctionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfIssueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
    }
}
