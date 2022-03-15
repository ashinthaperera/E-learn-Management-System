using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Login_page

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UG9EF74\SQLEXPRESS;Initial Catalog=cmblogin;Integrated Security=True");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from login where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
               
                MessageBox.Show("Login Successful");               
                Form2 f = new Form2();//Student Dashboard here
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error Login");
            }
        }               

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Form3 f = new Form3();//Student Dashboard here
            f.Show();
            this.Hide();
        }
    }

}