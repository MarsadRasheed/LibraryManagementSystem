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
    public partial class Form1 : Form
    {
        public string conString = "Data Source=MARSAD\\HAMLET;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            /*
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into Librarian values('L1','ali@gmail.com','123456')";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Date inserted!");
            }
            */
            new logInForm().Show();
//            new controller().Show();
            this.Hide();
        }
    }
}
