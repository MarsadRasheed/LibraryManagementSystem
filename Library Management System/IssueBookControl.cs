using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class IssueBookControl : UserControl
    {
        private string conString = "Data Source=MARSAD\\HAMLET;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

        public IssueBookControl()
        {
            InitializeComponent();
            populate();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string issueId = issueIdText.Text;
            string bookId = bookIdText.Text;
            string memberId = memberIdText.Text;
            string issueDate = dateTimePickerIssue.Value.ToString("yyyy-MM-dd");
            string returnDate = dateTimePickerReturn.Value.ToString("yyyy-MM-dd");

            string q = "insert into Transction values(@issueId,@memberId,@bookId,@issueDate,@returnDate)";

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand command = new SqlCommand(q, conn);
            command.Parameters.AddWithValue("@issueId", issueId);
            command.Parameters.AddWithValue("@memberId", memberId);
            command.Parameters.AddWithValue("@bookId", bookId);
            command.Parameters.AddWithValue("@issueDate", issueDate);
            command.Parameters.AddWithValue("@returnDate", returnDate);

            command.ExecuteNonQuery();

            MessageBox.Show("New Transaction added successfully!");
            populate();
        }

        private void populate()
        {

            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            SqlCommand selectCommand = new SqlCommand("Select * from Transction ", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);

            DataSet ds = new DataSet();
            adapter.Fill(ds);


            transactionDataGridView.DataSource = null;
            transactionDataGridView.Rows.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                String issueId = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                String memberId = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                String bookId = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                String issueDate = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                String returnDate = ds.Tables[0].Rows[i].ItemArray[4].ToString();

                DataGridViewRow data = new DataGridViewRow();
                data.CreateCells(transactionDataGridView);
                data.Cells[0].Value = issueId;
                data.Cells[1].Value = memberId;
                data.Cells[2].Value = bookId;
                data.Cells[3].Value = issueDate;
                data.Cells[4].Value = returnDate;
                transactionDataGridView.Rows.Add(data);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string issueId = issueIdText.Text;
            string bookId = bookIdText.Text;
            string memberId = memberIdText.Text;
            string issueDate = dateTimePickerIssue.Value.ToString("yyyy-MM-dd");
            string returnDate = dateTimePickerReturn.Value.ToString("yyyy-MM-dd");

            string q = "update Transction set " +
                " Transction.dateOfIssue = @issueDate , Transction.dueDate = @returnDate " +
                " where Transction.transactionId = @issueId";

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand command = new SqlCommand(q, conn);
            command.Parameters.AddWithValue("@issueId", issueId);
            command.Parameters.AddWithValue("@memberId", memberId);
            command.Parameters.AddWithValue("@bookId", bookId);
            command.Parameters.AddWithValue("@issueDate", issueDate);
            command.Parameters.AddWithValue("@returnDate", returnDate);

            command.ExecuteNonQuery();

            MessageBox.Show("Transaction updated successfully!");
            populate();
        }

        private void TransactionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex + 1 == transactionDataGridView.Rows.Count)
            {
                return;
            }
            else
            {
                DataGridViewRow dataGridViewRow = transactionDataGridView.Rows[e.RowIndex];
                issueIdText.Text = dataGridViewRow.Cells[0].Value.ToString();
                bookIdText.Text = dataGridViewRow.Cells[1].Value.ToString();
                memberIdText.Text = dataGridViewRow.Cells[2].Value.ToString();
                dateTimePickerIssue.Value = DateTime.Parse(dataGridViewRow.Cells[3].Value.ToString());
                dateTimePickerReturn.Value = DateTime.Parse(dataGridViewRow.Cells[4].Value.ToString());
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string issueId = issueIdText.Text;

            string q = "delete from Transction where transactionId = @issueId ";
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand command = new SqlCommand(q, conn);
            command.Parameters.AddWithValue("@issueId", issueId);

            command.ExecuteNonQuery();

            MessageBox.Show("Transaction deleted successfully!");
            populate();
        }
    }
}
