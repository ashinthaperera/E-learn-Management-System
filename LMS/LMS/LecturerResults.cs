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

namespace ResultAndExam
{
    public partial class LecturerResults : Form
    {
        //add your new connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rajitha\source\repos\ResultAndExam\ResultsDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public LecturerResults()
        {
            InitializeComponent();
            display();
            labelSubject.Text = "Select Subject";
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            labelSubject.Text = "English";
            
        }

        private void btnMaths_Click(object sender, EventArgs e)
        {
            labelSubject.Text = "Maths";
        }

        private void btnScience_Click(object sender, EventArgs e)
        {
            labelSubject.Text = "Science";

        }

        private void btnICT_Click(object sender, EventArgs e)
        {
            labelSubject.Text = "ICT";

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            labelSubject.Text = "History";

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //english
            if(labelSubject.Text == "English")
            {
                try
                {
                    int id = int.Parse(textBoxStudentId.Text);
                    float exam = float.Parse(textBoxExam.Text);
                    float classTest = float.Parse(textBoxClassTest.Text); ;
                    float HomeWork = float.Parse(textBoxHomeWork.Text); ;
                    string query = "INSERT INTO dbo.Results (StudentId, EnglishExam, EnglishClassTest, EnglishHomeWork) VAlUES (" + id + ", " + exam + ", " + classTest + ", " + HomeWork + ")";
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
                    display();
                    empty();
                }
            }

            //maths
            if (labelSubject.Text == "Maths")
            {
                try
                {
                    int id = int.Parse(textBoxStudentId.Text);
                    float exam = float.Parse(textBoxExam.Text);
                    float classTest = float.Parse(textBoxClassTest.Text); ;
                    float HomeWork = float.Parse(textBoxHomeWork.Text); ;
                    string query = "INSERT INTO dbo.Results (StudentId, MathsExam, MathsClassTest, MathsHomeWork) VAlUES (" + id + ", " + exam + ", " + classTest + ", " + HomeWork + ")";
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
                    display();
                    empty();
                }
            }

            //science
            if (labelSubject.Text == "Science")
            {
                try
                {
                    int id = int.Parse(textBoxStudentId.Text);
                    float exam = float.Parse(textBoxExam.Text);
                    float classTest = float.Parse(textBoxClassTest.Text); ;
                    float HomeWork = float.Parse(textBoxHomeWork.Text); ;
                    string query = "INSERT INTO dbo.Results (StudentId, ScienceExam, ScienceClassTest, ScienceHomeWork) VAlUES (" + id + ", " + exam + ", " + classTest + ", " + HomeWork + ")";
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
                    display();
                    empty();
                }
            }

            //ict
            if (labelSubject.Text == "ICT")
            {
                try
                {
                    int id = int.Parse(textBoxStudentId.Text);
                    float exam = float.Parse(textBoxExam.Text);
                    float classTest = float.Parse(textBoxClassTest.Text); ;
                    float HomeWork = float.Parse(textBoxHomeWork.Text); ;
                    string query = "INSERT INTO dbo.Results (StudentId, ICTExam, ICTClassTest, ICTHomeWork) VAlUES (" + id + ", " + exam + ", " + classTest + ", " + HomeWork + ")";
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
                    display();
                    empty();
                }
            }

            //history
            if (labelSubject.Text == "History")
            {
                try
                {
                    int id = int.Parse(textBoxStudentId.Text);
                    float exam = float.Parse(textBoxExam.Text);
                    float classTest = float.Parse(textBoxClassTest.Text); ;
                    float HomeWork = float.Parse(textBoxHomeWork.Text); ;
                    string query = "INSERT INTO dbo.Results (StudentId, HistoryExam, HistoryClassTest, HistoryHomeWork) VAlUES (" + id + ", " + exam + ", " + classTest + ", " + HomeWork + ")";
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
                    display();
                    empty();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //english
            if (labelSubject.Text == "English")
            {
                try
                {
                    int id = int.Parse(textBoxStudentId.Text);
                    float exam = float.Parse(textBoxExam.Text);
                    float classTest = float.Parse(textBoxClassTest.Text); ;
                    float HomeWork = float.Parse(textBoxHomeWork.Text); ;
                    string query = "UPDATE dbo.Results SET EnglishExam = " + exam + ", EnglishClassTest = " + classTest + ", EnglishHomeWork = " + HomeWork + " WHERE StudentId = " + id + "";
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
                    display();
                    empty();
                }
            }

            //maths
            if (labelSubject.Text == "Maths")
            {
                try
                {
                    int id = int.Parse(textBoxStudentId.Text);
                    float exam = float.Parse(textBoxExam.Text);
                    float classTest = float.Parse(textBoxClassTest.Text); ;
                    float HomeWork = float.Parse(textBoxHomeWork.Text); ;
                    string query = "UPDATE dbo.Results SET MathsExam = " + exam + ", MathsClassTest = " + classTest + ", MathsHomeWork = " + HomeWork + " WHERE StudentId = " + id + "";
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
                    display();
                    empty();
                }
            }

            //science
            if (labelSubject.Text == "Science")
            {
                try
                {
                    int id = int.Parse(textBoxStudentId.Text);
                    float exam = float.Parse(textBoxExam.Text);
                    float classTest = float.Parse(textBoxClassTest.Text); ;
                    float HomeWork = float.Parse(textBoxHomeWork.Text); ;
                    string query = "UPDATE dbo.Results SET ScienceExam = " + exam + ", ScienceClassTest = " + classTest + ", ScienceHomeWork = " + HomeWork + " WHERE StudentId = " + id + "";
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
                    display();
                    empty();
                }
            }

            //ict
            if (labelSubject.Text == "ICT")
            {
                try
                {
                    int id = int.Parse(textBoxStudentId.Text);
                    float exam = float.Parse(textBoxExam.Text);
                    float classTest = float.Parse(textBoxClassTest.Text); ;
                    float HomeWork = float.Parse(textBoxHomeWork.Text); ;
                    string query = "UPDATE dbo.Results SET ICTExam = " + exam + ", ICTClassTest = " + classTest + ", ICTHomeWork = " + HomeWork + " WHERE StudentId = " + id + "";
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
                    display();
                    empty();
                }
            }

            //history
            if (labelSubject.Text == "History")
            {
                try
                {
                    int id = int.Parse(textBoxStudentId.Text);
                    float exam = float.Parse(textBoxExam.Text);
                    float classTest = float.Parse(textBoxClassTest.Text); ;
                    float HomeWork = float.Parse(textBoxHomeWork.Text); ;
                    string query = "UPDATE dbo.Results SET HistoryExam = " + exam + ", HistoryClassTest = " + classTest + ", HistoryHomeWork = " + HomeWork + " WHERE StudentId = " + id + "";
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
                    display();
                    empty();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //english
            if (labelSubject.Text == "English")
            {
                try
                {
                    int id = int.Parse(textBoxStudentId.Text);
                    //float exam = float.Parse(textBoxExam.Text);
                    //float classTest = float.Parse(textBoxClassTest.Text); ;
                    //float HomeWork = float.Parse(textBoxHomeWork.Text);
                    string query = "DELETE FROM dbo.Results WHERE StudentId = " + id + "";
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
                    display();
                    empty();
                }
            }

            //maths
            if (labelSubject.Text == "Maths")
            {
                try
                {
                    int id = int.Parse(textBoxStudentId.Text);
                    //float exam = float.Parse(textBoxExam.Text);
                    //float classTest = float.Parse(textBoxClassTest.Text); ;
                    //float HomeWork = float.Parse(textBoxHomeWork.Text);
                    string query = "DELETE FROM dbo.Results WHERE StudentId = " + id + "";
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
                    display();
                    empty();
                }
            }

            //science
            if (labelSubject.Text == "Science")
            {
                try
                {
                    int id = int.Parse(textBoxStudentId.Text);
                    //float exam = float.Parse(textBoxExam.Text);
                    //float classTest = float.Parse(textBoxClassTest.Text); ;
                    //float HomeWork = float.Parse(textBoxHomeWork.Text);
                    string query = "DELETE FROM dbo.Results WHERE StudentId = " + id + "";
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
                    display();
                    empty();
                }
            }

            //ict
            if (labelSubject.Text == "ICT")
            {
                try
                {
                    int id = int.Parse(textBoxStudentId.Text);
                    //float exam = float.Parse(textBoxExam.Text);
                    //float classTest = float.Parse(textBoxClassTest.Text); ;
                    //float HomeWork = float.Parse(textBoxHomeWork.Text);
                    string query = "DELETE FROM dbo.Results WHERE StudentId = " + id + "";
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
                    display();
                    empty();
                }
            }

            //history
            if (labelSubject.Text == "History")
            {
                try
                {
                    int id = int.Parse(textBoxStudentId.Text);
                    //float exam = float.Parse(textBoxExam.Text);
                    //float classTest = float.Parse(textBoxClassTest.Text); ;
                    //float HomeWork = float.Parse(textBoxHomeWork.Text);
                    string query = "DELETE FROM dbo.Results WHERE StudentId = " + id + "";
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
                    display();
                    empty();
                }
            }
        }

        public void display()
        {
            string qry = "SELECT * FROM dbo.Results";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "dbo.Results");
            dataGridViewLec.DataSource = ds.Tables["dbo.Results"].DefaultView;
        }

        public void empty()
        {
            textBoxStudentId.Text = "";
            textBoxExam.Text = "";
            textBoxClassTest.Text = "";
            textBoxHomeWork.Text = "";
        }

        public void keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(sender, e);
        }

        private void textBoxExam_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(sender, e);
        }

        private void textBoxClassTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(sender, e);
        }

        private void textBoxHomeWork_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(sender, e);
        }
    }
}
