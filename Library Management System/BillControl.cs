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
    public partial class BillControl : UserControl
    {
        private string conString = "Data Source=MARSAD\\HAMLET;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

        public BillControl()
        {
            InitializeComponent();
            populate();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string billId = billIdTextBox.Text;
            string billNo = noTextBox.Text;
            string memberId = memberIdtextBox.Text;
            string billAmount = amounttextBox.Text;

      
            string q = "insert into Bill values(@billId,@billNo,@memberId,@billAmount)";

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand command = new SqlCommand(q, conn);
            command.Parameters.AddWithValue("@billId", billId);
            command.Parameters.AddWithValue("@billNo", billNo);
            command.Parameters.AddWithValue("@memberId", memberId);
            command.Parameters.AddWithValue("@billAmount", billAmount);
            command.ExecuteNonQuery();

            MessageBox.Show("New Bill added successfully!");
            populate();
        }

        private void populate()
        {

            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            SqlCommand selectCommand = new SqlCommand("Select * from Bill ", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);

            DataSet ds = new DataSet();
            adapter.Fill(ds);


            billDataGridView.DataSource = null;
            billDataGridView.Rows.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                String billId = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                String billNo = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                String memberId = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                String amount = ds.Tables[0].Rows[i].ItemArray[3].ToString();

                DataGridViewRow data = new DataGridViewRow();
                data.CreateCells(billDataGridView);
                data.Cells[0].Value = billId;
                data.Cells[1].Value = billNo;
                data.Cells[2].Value = memberId;
                data.Cells[3].Value = amount;

                billDataGridView.Rows.Add(data);
            }
        }

        private void BillDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex + 1 == billDataGridView.Rows.Count)
            {
                return;
            }
            else
            {
                DataGridViewRow dataGridViewRow = billDataGridView.Rows[e.RowIndex];
                noTextBox.Text = dataGridViewRow.Cells[0].Value.ToString();
                billIdTextBox.Text = dataGridViewRow.Cells[1].Value.ToString();
                memberIdtextBox.Text = dataGridViewRow.Cells[2].Value.ToString();
                amounttextBox.Text = dataGridViewRow.Cells[3].Value.ToString();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string billId = billIdTextBox.Text;
            
            string q = "delete from Bill where Bill.billId = @billId";

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand command = new SqlCommand(q, conn);
            command.Parameters.AddWithValue("@billId", billId);
            command.ExecuteNonQuery();

            MessageBox.Show("Bill deleted successfully!");
            populate();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string billId = billIdTextBox.Text;
            string billNo = noTextBox.Text;
            string memberId = memberIdtextBox.Text;
            string billAmount = amounttextBox.Text;

            string q = "update Bill set Bill.billNumber = @billNo , Bill.memberId = @memberId , Bill.billAmount = @billAmount where Bill.billId = @billId";

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand command = new SqlCommand(q, conn);
            command.Parameters.AddWithValue("@billId", billId);
            command.Parameters.AddWithValue("@billNo", billNo);
            command.Parameters.AddWithValue("@memberId", memberId);
            command.Parameters.AddWithValue("@billAmount", billAmount);
            command.ExecuteNonQuery();

            MessageBox.Show("Bill updated successfully!");
            populate();
        }
    }
}
