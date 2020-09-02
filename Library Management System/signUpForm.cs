using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class signUpForm : Form
    {
        private string conString = "Data Source=MARSAD\\HAMLET;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

        public signUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string id = idText.Text;
            string name = nameText.Text;
            string email = emailText.Text;
            string address = addressText.Text;
            string type = typeText.Text;
            string phone = phoneText.Text;
            string password = passwordText.Text;

            string query1 = "insert into LibraryStaff values(@id,@name,@address,@type,@phone)";

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand command1 = new SqlCommand(query1, conn);
            command1.Parameters.AddWithValue("@id", id);
            command1.Parameters.AddWithValue("@name", name);
            command1.Parameters.AddWithValue("@address", address);
            command1.Parameters.AddWithValue("@type", type);
            command1.Parameters.AddWithValue("@phone", phone);
            command1.ExecuteNonQuery();

            string query2 = "insert into Librarian values(@registration,@email,@password)";
            SqlCommand command2 = new SqlCommand(query2,conn);
            command2.Parameters.AddWithValue("@registration", id);
            command2.Parameters.AddWithValue("@email", email);
            command2.Parameters.AddWithValue("@password", password);
            command2.ExecuteNonQuery();

            MessageBox.Show("Regesterd successfully!");
            new controller().Show();
            this.Hide();
        }

    }
}
