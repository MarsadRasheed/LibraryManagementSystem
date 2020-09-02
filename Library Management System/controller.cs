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
    public partial class controller : Form
    {
        public controller()
        {
            InitializeComponent();
            bookControl1.BringToFront();
            bill.Visible = false;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            bookControl1.BringToFront();
            bill.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            memberControl1.BringToFront();
            bill.Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            issueBookControl1.BringToFront();
            bill.Visible = false;
        }


        private void Button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            returnBookControl1.BringToFront();
            bill.Visible = true;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top;
            issuedBooksControl1.BringToFront();
            bill.Visible = false;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button8.Height;
            SidePanel.Top = button8.Top;
            billControl1.BringToFront();
            bill.Visible = false;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button9.Height;
            SidePanel.Top = button9.Top;
            MessageBox.Show("User logged out successfully!");
            new logInForm().Show();
            this.Hide();
            bill.Visible = false;
        }

        private void BookControl1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            staffControl1.BringToFront();
            bill.Visible = false;
        }

        private void Bill_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button8.Height;
            SidePanel.Top = button8.Top;
            billControl1.BringToFront();
        }
    }
}