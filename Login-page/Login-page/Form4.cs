using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_page
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();//Student Dashboard here
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UG9EF74\SQLEXPRESS;Initial Catalog=cmblogin;Integrated Security=True");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from adminlogin where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {

                MessageBox.Show("Login Successful");
                Form2 f = new Form2();//Admin Dashboard here
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error Login");
            }
        }
    }
}
