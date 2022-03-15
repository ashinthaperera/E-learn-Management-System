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
using System.IO;

namespace ResultAndExam
{
    public partial class LecturerExam : Form
    {
        //add new connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rajitha\source\repos\ResultAndExam\ResultsDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public LecturerExam()
        {
            InitializeComponent();
            this.dataGridViewLecExam.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewLecExam_DataError);
            this.dataGridViewStudentSubmissions.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewStudentSubmissions_DataError);
            displayExam();
            displayStudentSubmission();
        }

        private void buttonUploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            string filePath = "";
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                filePath = choofdlog.FileName;
                string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true
            }

            labelFilePath.Text = filePath;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //upload TimeLimit and ExamFile by FileId to Exam table

            try
            {
                 string filePath = labelFilePath.Text;

                 FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                 BinaryReader reader = new BinaryReader(stream);
                 byte[] file = reader.ReadBytes((int)stream.Length);
                 reader.Close();
                 stream.Close();

                 int id = int.Parse(textBoxFileId.Text);
                 int time = int.Parse(textBoxTimeLimit.Text);

                 string query = "INSERT INTO dbo.Exam (FileId, TimeLimit, ExamFile) VAlUES ("+id+", "+time+", @File)";
                 SqlCommand cmd = new SqlCommand(query, con);
                 cmd.Parameters.Add("@File", SqlDbType.Binary, file.Length).Value = file;

                 con.Open();
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("success");
             }
             catch (SqlException sql)
             {
                 MessageBox.Show("Error" + sql.ToString());
             }
             catch (Exception prs)
             {
                 MessageBox.Show(prs.Message);
             }
             finally
             {
                 con.Close();
                 displayExam();
                 empty();
             }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //update TimeLimit and ExamFile by FileId to Exam table
            try
            {
                string filePath = labelFilePath.Text;

                FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(stream);
                byte[] file = reader.ReadBytes((int)stream.Length);
                reader.Close();
                stream.Close();

                int id = int.Parse(textBoxFileId.Text);
                int time = int.Parse(textBoxTimeLimit.Text);

                string query = "UPDATE dbo.Exam SET TimeLimit = " + time + ", ExamFile = @File WHERE FileId = " + id + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@File", SqlDbType.Binary, file.Length).Value = file;

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("success");
            }
            catch (SqlException sql)
            {
                MessageBox.Show("Error" + sql.ToString());
            }
            catch (Exception prs)
            {
                MessageBox.Show(prs.Message);
            }
            finally
            {
                con.Close();
                displayExam();
                empty();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //delete TimeLimit and ExamFile by FileId from Exam table
            try
            {
                int id = int.Parse(textBoxFileId.Text);
                string query = "DELETE FROM dbo.Exam WHERE FileId = " + id + "";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("success");
            }
            catch (SqlException sql)
            {
                MessageBox.Show("Error" + sql.ToString());
            }
            catch (Exception prs)
            {
                MessageBox.Show(prs.Message);
            }
            finally
            {
                con.Close();
                displayExam();
                empty();
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            //download StudentFile from StudentExam table
            try
            {
                int id = int.Parse(textBoxStudentId.Text);
                string query =
                "SELECT StudentFile FROM dbo.StudentExam WHERE StudentIdExam = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                con.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var name = "file";
                    var data = (byte[])reader["StudentFile"];
                    var extn = ".txt";

                    var newFileName = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss"));


                    File.WriteAllBytes(extn, data);
                    System.Diagnostics.Process.Start(newFileName);
                }
            }
            catch(SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception prs)
            {
                MessageBox.Show(prs.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void displayExam()
        {
            string qry = "SELECT * FROM dbo.Exam";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "dbo.Exam");
            dataGridViewLecExam.DataSource = ds.Tables["dbo.Exam"].DefaultView;
        }

        public void displayStudentSubmission()
        {
            string qry = "SELECT * FROM dbo.StudentExam";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "dbo.StudentExam");
            dataGridViewStudentSubmissions.DataSource = ds.Tables["dbo.StudentExam"].DefaultView;
        }

        public void empty()
        {
            textBoxFileId.Text = "";
            textBoxTimeLimit.Text = "";
        }

        private void dataGridViewLecExam_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dataGridViewStudentSubmissions_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
