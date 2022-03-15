using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Lecture_material_page
{
    public partial class Maths : Form
    {
        public Maths()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelUserSubMenu.Visible = false;
            panelSubjectsSubMenu.Visible = false;
            panelServicesSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelUserSubMenu.Visible == true)
            {
                panelUserSubMenu.Visible = false;
            }
            if (panelSubjectsSubMenu.Visible == true)
            {
                panelSubjectsSubMenu.Visible = false;
            }
            if (panelServicesSubMenu.Visible == true)
            {
                panelServicesSubMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home ho = new Home();
            ho.Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUserSubMenu);
        }

        private void btnAccountSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubjectsSubMenu);
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            English en = new English();
            en.Show();
            this.Hide();
        }

        private void btnMaths_Click(object sender, EventArgs e)
        {
            Maths ma = new Maths();
            ma.Show();
            this.Hide();
        }

        private void btnScience_Click(object sender, EventArgs e)
        {
            Science sc = new Science();
            sc.Show();
            this.Hide();
        }

        private void btnICT_Click(object sender, EventArgs e)
        {
            ICT ic = new ICT();
            ic.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History his = new History();
            his.Show();
            this.Hide();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            showSubMenu(panelServicesSubMenu);
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {

        }

        private void btnExam_Click(object sender, EventArgs e)
        {

        }

        private void btnResults_Click(object sender, EventArgs e)
        {

        }

        private void btnForum_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure, you want to logout?", "Message", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                Application.Exit();
            }

            hideSubMenu();
        }

        private void Maths_Load(object sender, EventArgs e)
        {

        }

        private void buttonmabr_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            txtFilePath.Text = dlg.FileName;
        }

        private void buttonmaup_Click(object sender, EventArgs e)
        {
            SaveFile(txtFilePath.Text);
            MessageBox.Show("Saved");
        }

        private void SaveFile(string filePath)
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                var fi = new FileInfo(filePath);
                string extn = fi.Extension;
                string name = fi.Name;

                string query = "INSERT INTO Maths(FIleName,Data,Extension)VALUES(@name,@data,@extn)";

                using (SqlConnection cn = GetSqlConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                    cmd.Parameters.Add("@extn", SqlDbType.Char).Value = extn;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private SqlConnection GetSqlConnection()
        {
            return new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My data.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void LoadData()
        {
            using (SqlConnection cn = GetSqlConnection())
            {
                string query = "SELECT ID,FileName,Extension FROM Maths";
                SqlDataAdapter adp = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgvDocuments.DataSource = dt;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvDocuments.SelectedRows;
            foreach (var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                OpenFile(id);
            }
        }

        private void OpenFile(int id)
        {
            using (SqlConnection cn = GetSqlConnection())
            {
                string query = "SELECT Data,FileName,Extension FROM Maths WHERE ID=@id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var name = reader["FileName"].ToString();
                    var data = (byte[])reader["data"];
                    var extn = reader["Extension"].ToString();
                    var newFileName = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn;
                    File.WriteAllBytes(newFileName, data);
                    System.Diagnostics.Process.Start(newFileName);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My data.mdf;Integrated Security=True;Connect Timeout=30";
            string Query = "SELECT * FROM Maths";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Constring);
            DataSet set = new DataSet();
            adapter.Fill(set, "Maths");

            set.Tables["Maths"].Rows[1].Delete();

            dgvDocuments.DataSource = set.Tables["Maths"];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            textBox1.Text = dlg.FileName;
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            SaveFile1(textBox1.Text);
            MessageBox.Show("Saved");
        }

        private void SaveFile1(string filePath1)
        {
            using (Stream stream = File.OpenRead(filePath1))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                var fi = new FileInfo(filePath1);
                string extn = fi.Extension;
                string name = fi.Name;

                string query = "INSERT INTO MaRecording(FIleName,Data,Extension)VALUES(@name,@data,@extn)";

                using (SqlConnection cn = GetSqlConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                    cmd.Parameters.Add("@extn", SqlDbType.Char).Value = extn;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void LoadData1()
        {
            using (SqlConnection cn = GetSqlConnection())
            {
                string query = "SELECT ID,FileName,Extension FROM MaRecording";
                SqlDataAdapter adp1 = new SqlDataAdapter(query, cn);
                DataTable dt1 = new DataTable();
                adp1.Fill(dt1);

                if (dt1.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt1;
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            LoadData1();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows;
            foreach (var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                OpenFile1(id);
            }
        }

        private void OpenFile1(int id)
        {
            using (SqlConnection cn = GetSqlConnection())
            {
                string query = "SELECT Data,FileName,Extension FROM MaRecording WHERE ID=@id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var name = reader["FileName"].ToString();
                    var data = (byte[])reader["data"];
                    var extn = reader["Extension"].ToString();
                    var newFileName = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn;
                    File.WriteAllBytes(newFileName, data);
                    System.Diagnostics.Process.Start(newFileName);
                }
            }
        }

        private void LoadData2()
        {
            using (SqlConnection cn = GetSqlConnection())
            {
                string query = "SELECT ID,FileName,Extension FROM Homeworkma";
                SqlDataAdapter adp2 = new SqlDataAdapter(query, cn);
                DataTable dt2 = new DataTable();
                adp2.Fill(dt2);

                if (dt2.Rows.Count > 0)
                {
                    dataGridView2.DataSource = dt2;
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            LoadData2();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView2.SelectedRows;
            foreach (var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                OpenFile2(id);
            }
        }

        private void OpenFile2(int id)
        {
            using (SqlConnection cn = GetSqlConnection())
            {
                string query = "SELECT Data,FileName,Extension FROM Homeworkma WHERE ID=@id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var name = reader["FileName"].ToString();
                    var data = (byte[])reader["data"];
                    var extn = reader["Extension"].ToString();
                    var newFileName = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn;
                    File.WriteAllBytes(newFileName, data);
                    System.Diagnostics.Process.Start(newFileName);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            textBox2.Text = dlg.FileName;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SaveFile2(textBox2.Text);
            MessageBox.Show("Saved");
        }

        private void SaveFile2(string filePath1)
        {
            using (Stream stream = File.OpenRead(filePath1))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                var fi = new FileInfo(filePath1);
                string extn = fi.Extension;
                string name = fi.Name;

                string query = "INSERT INTO Homeworkma(FIleName,Data,Extension)VALUES(@name,@data,@extn)";

                using (SqlConnection cn = GetSqlConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                    cmd.Parameters.Add("@extn", SqlDbType.Char).Value = extn;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Science sc = new Science();
            sc.Show();
            this.Hide();
        }
    }
}
