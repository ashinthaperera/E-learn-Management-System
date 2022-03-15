using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace Profile_page
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UG9EF74\SQLEXPRESS;Initial Catalog=cmblogin;Integrated Security=True");
            con.Open();

            if (textBox1.Text != "")
            {
                SqlCommand cmd = new SqlCommand("select s_name,s_username,s_class,s_contactno from adminlogin where staffid=@staffid", con);
                cmd.Parameters.AddWithValue("@staffid", int.Parse(textBox1.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    textBox6.Text = da.GetValue(0).ToString();
                    textBox5.Text = da.GetValue(1).ToString();
                    textBox4.Text = da.GetValue(2).ToString();
                    textBox2.Text = da.GetValue(3).ToString();



                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    image1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UG9EF74\SQLEXPRESS;Initial Catalog=cmblogin;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Insert into login(image)values(@image)");
            MemoryStream stream = new MemoryStream();
            image1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] pic = stream.ToArray();
            cmd.Parameters.AddWithValue("@image", image1);
            con.Open();
            MessageBox.Show("Image Saved");

        }
    }
    
}
