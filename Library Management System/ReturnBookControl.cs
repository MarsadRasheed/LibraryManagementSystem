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
    public partial class ReturnBookControl : UserControl
    {
        private string conString = "Data Source=MARSAD\\HAMLET;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
        public ReturnBookControl()
        {
            InitializeComponent();
            populate();
            differenceLabel.Text = "";
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            string id = transactionIdText.Text;
            string date = dateTimePickerReturned.Value.ToString("yyyy-MM-dd");

            string q = "insert into returnedBooks values(@id,@date)";

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand command = new SqlCommand(q, conn);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@date", date);

            command.ExecuteNonQuery();
            MessageBox.Show("Book returned successfully!");
            populate();
            setLabel(id,DateTime.Parse(date));
        
        }

        private void populate()
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            SqlCommand selectCommand = new SqlCommand("Select * from returnedBooks ", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridViewReturndBooks.DataSource = null;
            dataGridViewReturndBooks.Rows.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                String id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                String date = ds.Tables[0].Rows[i].ItemArray[1].ToString();
            
                DataGridViewRow data = new DataGridViewRow();
                data.CreateCells(dataGridViewReturndBooks);
                data.Cells[0].Value = id;
                data.Cells[1].Value = date;
                dataGridViewReturndBooks.Rows.Add(data);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string id = transactionIdText.Text;
            
            string q = "delete from returnedBooks where returnedBooks.transactionId = @id";

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand command = new SqlCommand(q, conn);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Book deleted successfully!");
            populate();
            differenceLabel.Text = "";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string id = transactionIdText.Text;
            string date = dateTimePickerReturned.Value.ToString("yyyy-MM-dd");

            string q = "update returnedBooks set returnedBooks.returnDate = @date where returnedBooks.transactionId = @id";

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand command = new SqlCommand(q, conn);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@date", date);

            command.ExecuteNonQuery();
            MessageBox.Show("Book updated successfully!");
            populate();
            setLabel(id,dateTimePickerReturned.Value);
        }

        private void DataGridViewReturndBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex + 1 == dataGridViewReturndBooks.Rows.Count)
            {
                return;
            }
            else
            {
                string id = transactionIdText.Text;
                string date = dateTimePickerReturned.Value.ToString("yyyy-MM-dd");

                DataGridViewRow dataGridViewRow = dataGridViewReturndBooks.Rows[e.RowIndex];
                transactionIdText.Text = dataGridViewRow.Cells[0].Value.ToString();
                DateTime returnDate = DateTime.Parse(dataGridViewRow.Cells[1].Value.ToString());
                dateTimePickerReturned.Value = returnDate;
            }
        }

        private DateTime getDueDate(String id)
        {
            string q = "select Transction.dueDate from Transction where Transction.transactionId = '"  + id + "'";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            SqlCommand selectCommand = new SqlCommand(q, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return DateTime.Parse(ds.Tables[0].Rows[0]["dueDate"].ToString());
        }

        private void setLabel(String id,DateTime returnDate)
        {
            DateTime dueDate = getDueDate(id);
            TimeSpan t = returnDate - dueDate;
            double NrOfDays = t.TotalDays;
            if (NrOfDays >= 1)
            {
                differenceLabel.Text = "Difference between return date " + returnDate.ToString() + " and due date " + dueDate.ToString() + " is : " + NrOfDays.ToString() + " days\n" +
                    "Add bill " + NrOfDays * 10 + " to member";
            }
        }

    }
}
