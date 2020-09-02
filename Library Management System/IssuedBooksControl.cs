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
    public partial class IssuedBooksControl : UserControl
    {
        private string conString = "Data Source=MARSAD\\HAMLET;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

        public IssuedBooksControl()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string id = memberIdText.Text;
            populate(id);

        }

        private void populate(string id)
        {

            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            SqlCommand selectCommand = new SqlCommand("Select * from Transction where Transction.memberId = " + "'" + id + "'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);

            DataSet ds = new DataSet();
            adapter.Fill(ds);


            issuedDataGridView.DataSource = null;
            issuedDataGridView.Rows.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                String issueId = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                String memberId = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                String bookId = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                String issueDate = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                String returnDate = ds.Tables[0].Rows[i].ItemArray[4].ToString();

                DataGridViewRow data = new DataGridViewRow();
                data.CreateCells(issuedDataGridView);
                data.Cells[0].Value = issueId;
                data.Cells[1].Value = memberId;
                data.Cells[2].Value = bookId;
                data.Cells[3].Value = issueDate;
                data.Cells[4].Value = returnDate;
                issuedDataGridView.Rows.Add(data);
            }
        }

    }
}
