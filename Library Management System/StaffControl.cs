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
    public partial class StaffControl : UserControl
    {
        private string conString = "Data Source=MARSAD\\HAMLET;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
        public StaffControl()
        {
            InitializeComponent();
            populate();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string Id = idText.Text;
            string type = authorText.Text;
            string Name = nameText.Text;
            string Price = priceText.Text;
            string Status = statusText.Text;

            string q = "insert into LibraryStaff values(@id,@author,@name,@price,@status)";

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand command = new SqlCommand(q, conn);
            command.Parameters.AddWithValue("@id", Id);
            command.Parameters.AddWithValue("@author", type);
            command.Parameters.AddWithValue("@name", Name);
            command.Parameters.AddWithValue("@price", Price);
            command.Parameters.AddWithValue("@status", Status);

            command.ExecuteNonQuery();

            MessageBox.Show("New Staff added successfully!");
            populate();
        }

        private void populate()
        {

            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            SqlCommand selectCommand = new SqlCommand("Select * from LibraryStaff", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);

            DataSet ds = new DataSet();
            adapter.Fill(ds);


            dataGridViewStaff.DataSource = null;
            dataGridViewStaff.Rows.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                String id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                String author = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                String name = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                String price = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                String status = ds.Tables[0].Rows[i].ItemArray[4].ToString();

                DataGridViewRow data = new DataGridViewRow();
                data.CreateCells(dataGridViewStaff);
                data.Cells[0].Value = id;
                data.Cells[1].Value = author;
                data.Cells[2].Value = name;
                data.Cells[3].Value = price;
                data.Cells[4].Value = status;
                dataGridViewStaff.Rows.Add(data);
            }
        }

        private void DataGridViewStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex + 1 == dataGridViewStaff.Rows.Count)
            {
                return;
            }
            else
            {
                DataGridViewRow dataGridViewRow = dataGridViewStaff.Rows[e.RowIndex];
                idText.Text = dataGridViewRow.Cells[0].Value.ToString();
                authorText.Text = dataGridViewRow.Cells[1].Value.ToString();
                nameText.Text = dataGridViewRow.Cells[2].Value.ToString();
                priceText.Text = dataGridViewRow.Cells[3].Value.ToString();
                statusText.Text = dataGridViewRow.Cells[4].Value.ToString();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string Id = idText.Text;
            string type = authorText.Text;
            string Name = nameText.Text;
            string Price = priceText.Text;
            string Status = statusText.Text;

            string q = "update LibraryStaff set LibraryStaff.lsName = @author , LibraryStaff.lsAddress = @name , " +
                "LibraryStaff.lsType  = @price , LibraryStaff.lsPhone = @status where LibraryStaff.lsId = @id";

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand command = new SqlCommand(q, conn);
            command.Parameters.AddWithValue("@id", Id);
            command.Parameters.AddWithValue("@author", type);
            command.Parameters.AddWithValue("@name", Name);
            command.Parameters.AddWithValue("@price", Price);
            command.Parameters.AddWithValue("@status", Status);

            command.ExecuteNonQuery();

            MessageBox.Show("Staff updated successfully!");
            populate();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string Id = idText.Text;

            string q = "delete from LibraryStaff where LibraryStaff.lsId = @id";

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand command = new SqlCommand(q, conn);
            command.Parameters.AddWithValue("@id", Id);
            command.ExecuteNonQuery();
            MessageBox.Show("Staff Deleted successfully!");
            populate();
        }

        private void StatusText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceText_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AuthorText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void IdText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
