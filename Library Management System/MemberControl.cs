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
    public partial class MemberControl : UserControl
    {
        string member;
        private string conString = "Data Source=MARSAD\\HAMLET;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

        public MemberControl()
        {
            InitializeComponent();
            populate();
        }

        private void MaleButton_CheckedChanged(object sender, EventArgs e)
        {
            member = "student";
        }

        private void FemaleButton_CheckedChanged(object sender, EventArgs e)
        {
            member = "teacher";
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            string id = idText.Text;
            string address = addressText.Text;
            string phone = phoneText.Text;
            string booksIssued = booksIssuedText.Text;
            string date = memberDateTimePicker.Value.ToString("yyyy-MM-dd");

            string q = "insert into Member values(@id,@type,@membership,@issued,@address,@phone)";

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand command = new SqlCommand(q, conn);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@type", member);
            command.Parameters.AddWithValue("@membership", date);
            command.Parameters.AddWithValue("@issued", booksIssued);
            command.Parameters.AddWithValue("@phone", phone);

            command.ExecuteNonQuery();
            MessageBox.Show("New Member added successfully!");
            populate();
        }

        private void populate()
        {

            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            SqlCommand selectCommand = new SqlCommand("Select * from Member ", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);

            DataSet ds = new DataSet();
            adapter.Fill(ds);


            memberDataGridView.DataSource = null;
            memberDataGridView.Rows.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                String id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                String type = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                String date = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                String books = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                String address = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                String phone = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                
                DataGridViewRow data = new DataGridViewRow();
                data.CreateCells(memberDataGridView);
                data.Cells[0].Value = id;
                data.Cells[1].Value = type;
                data.Cells[2].Value = date;
                data.Cells[3].Value = books;
                data.Cells[4].Value = address;
                data.Cells[5].Value = phone;
                memberDataGridView.Rows.Add(data);
            }
        }

        private void MemberDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex + 1 == memberDataGridView.Rows.Count)
            {
                return;
            }
            else
            {
                string id = idText.Text;
                string address = addressText.Text;
                string phone = phoneText.Text;
                string booksIssued = booksIssuedText.Text;
                string date = memberDateTimePicker.Value.ToString("yyyy-MM-dd");

                DataGridViewRow dataGridViewRow = memberDataGridView.Rows[e.RowIndex];
                idText.Text = dataGridViewRow.Cells[0].Value.ToString();
                member = dataGridViewRow.Cells[1].Value.ToString();
                if (member.Equals("student"))
                {
                    maleButton.Checked = true;
                }
                else
                {
                    femaleButton.Checked = true;
                }
                memberDateTimePicker.Value = DateTime.Parse(dataGridViewRow.Cells[2].Value.ToString());
                booksIssuedText.Text = dataGridViewRow.Cells[3].Value.ToString();
                addressText.Text = dataGridViewRow.Cells[4].Value.ToString();
                phoneText.Text = dataGridViewRow.Cells[5].Value.ToString();
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string id = idText.Text;
            string address = addressText.Text;
            string phone = phoneText.Text;
            string booksIssued = booksIssuedText.Text;
            string date = memberDateTimePicker.Value.ToString("yyyy-MM-dd");

            string q = "delete from Member where Member.memberId=@id";

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand command = new SqlCommand(q, conn);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
            MessageBox.Show("Member deleted successfully!");
            populate();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string id = idText.Text;
            string address = addressText.Text;
            string phone = phoneText.Text;
            string booksIssued = booksIssuedText.Text;
            string date = memberDateTimePicker.Value.ToString("yyyy-MM-dd");

            string q = "Update Member set Member.memberType=@type , Member.dateOfMembership = @membership , " +
                " Member.noOfBooksIssued = @issued , Member.memberAddress = @address , Member.memberPhone = @phone where " +
                "Member.memberId=@id ";

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand command = new SqlCommand(q, conn);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@type", member);
            command.Parameters.AddWithValue("@membership", date);
            command.Parameters.AddWithValue("@issued", booksIssued);
            command.Parameters.AddWithValue("@phone", phone);

            command.ExecuteNonQuery();
            MessageBox.Show("Member updated successfully!");
            populate();
        }
    }
}
