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
    public partial class logInForm : Form
    {
        public string conString = "Data Source=MARSAD\\HAMLET;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

        public logInForm()
        {
            InitializeComponent();
            
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string userName = userNameBox.Text;
            string password = passwordBox.Text;

            if (checkResult(userName, password))
            {
                MessageBox.Show("User Logged In Successfully!");
                this.Hide();
                new controller().Show();
            }
            else {
               MessageBox.Show("Logged in failed.\nPlease, check your email or password");
            }

        }

        private bool checkResult(string name, string password) {
            
            string q = "Select * from Librarian where Librarian.librarianName = @email and Librarian.librarianPassword = @password";

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();

            SqlCommand command = new SqlCommand(q, conn);
            command.Parameters.AddWithValue("@email",name);
            command.Parameters.AddWithValue("@password",password);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count == 1) {
                return true;
            }
            return false;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new signUpForm().Show();
            this.Hide();
        }

    }
}
