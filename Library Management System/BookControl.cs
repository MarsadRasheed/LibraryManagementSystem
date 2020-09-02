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
    public partial class BookControl : UserControl
    {

        private string conString = "Data Source=MARSAD\\HAMLET;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
        public BookControl()
        {
            InitializeComponent();
            populate();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string bookId = idText.Text;
            string bookAuthor = authorText.Text;
            string bookName = nameText.Text;
            string bookPrice = priceText.Text;
            string bookStatus = statusText.Text;
            string bookEditor = editorText.Text;
            string date = dateTimePicker.Value.ToString("yyyy-MM-dd");

            string q = "insert into Book values(@id,@author,@name,@price,@status,@editor,@date)";

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand command = new SqlCommand(q, conn);
            command.Parameters.AddWithValue("@id", bookId);
            command.Parameters.AddWithValue("@author", bookAuthor);
            command.Parameters.AddWithValue("@name", bookName);
            command.Parameters.AddWithValue("@price", bookPrice);
            command.Parameters.AddWithValue("@status", bookStatus);
            command.Parameters.AddWithValue("@editor", bookEditor);
            command.Parameters.AddWithValue("@date", date);

            command.ExecuteNonQuery();

            MessageBox.Show("New Book added successfully!");
            populate();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void populate()
        {

            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            SqlCommand selectCommand = new SqlCommand("Select * from Book ", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);

            DataSet ds = new DataSet();
            adapter.Fill(ds);


            booksDataGridView.DataSource = null;
            booksDataGridView.Rows.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                String id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                String author = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                String name = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                String price = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                String status = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                String editor = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                String dop = ds.Tables[0].Rows[i].ItemArray[6].ToString();

                DataGridViewRow data = new DataGridViewRow();
                data.CreateCells(booksDataGridView);
                data.Cells[0].Value = id;
                data.Cells[1].Value = author;
                data.Cells[2].Value = name;
                data.Cells[3].Value = price;
                data.Cells[4].Value = status;
                data.Cells[5].Value = editor;
                data.Cells[6].Value = dop;
                booksDataGridView.Rows.Add(data);

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string bookId = idText.Text;

            string q = "delete from Book where Book.bookId = @bookId";
            
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand command = new SqlCommand(q, conn);
            command.Parameters.AddWithValue("@bookId", bookId);

            command.ExecuteNonQuery();
            MessageBox.Show("Book deleted successfully!");
            populate();
        }

        private void BooksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex + 1 == booksDataGridView.Rows.Count)
            {
                return;
            }
            else
            {
                DataGridViewRow dataGridViewRow = booksDataGridView.Rows[e.RowIndex];
                idText.Text = dataGridViewRow.Cells[0].Value.ToString();
                authorText.Text = dataGridViewRow.Cells[1].Value.ToString();
                nameText.Text = dataGridViewRow.Cells[2].Value.ToString();
                priceText.Text = dataGridViewRow.Cells[3].Value.ToString();
                statusText.Text = dataGridViewRow.Cells[4].Value.ToString();
                editorText.Text = dataGridViewRow.Cells[5].Value.ToString();
                dateTimePicker.Value = DateTime.Parse(dataGridViewRow.Cells[6].Value.ToString());
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string bookId = idText.Text;
            string bookAuthor = authorText.Text;
            string bookName = nameText.Text;
            string bookPrice = priceText.Text;
            string bookStatus = statusText.Text;
            string bookEditor = editorText.Text;
            string date = dateTimePicker.Value.ToString("yyyy-MM-dd");

            string q = "update Book set bookAuthor = @bookAuthor , bookName = @bookName , " +
                "bookPrice = @bookPrice , bookStatus = @bookStatus , bookEditor = @bookEditor , bookDateOfPurchase = @date" +
                " where bookId = @bookId " ;

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand command = new SqlCommand(q, conn);
            command.Parameters.AddWithValue("@bookId", bookId);
            command.Parameters.AddWithValue("@bookAuthor", bookAuthor);
            command.Parameters.AddWithValue("@bookName", bookName);
            command.Parameters.AddWithValue("@bookPrice", bookPrice);
            command.Parameters.AddWithValue("@bookStatus", bookStatus);
            command.Parameters.AddWithValue("@bookEditor", bookEditor);
            command.Parameters.AddWithValue("@date", date);

            command.ExecuteNonQuery();

            MessageBox.Show("Book updated successfully!");
            populate();
        }
    }
}
