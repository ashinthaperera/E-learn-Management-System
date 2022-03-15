using ResultAndExam;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Home : Form
    {
        private Form currentChildForm;

        public Home()
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

        private void btnUser_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUserSubMenu);
        }

        private void btnAccountSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new Page());
            btnHome.Visible = true;
            hideSubMenu();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubjectsSubMenu);
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            openChildForm(new Page());
            btnHome.Visible = true;
            hideSubMenu();
        }

        private void btnMaths_Click(object sender, EventArgs e)
        {
            openChildForm(new Page());
            btnHome.Visible = true;
            hideSubMenu();
        }

        private void btnScience_Click(object sender, EventArgs e)
        {
            openChildForm(new Page());
            btnHome.Visible = true;
            hideSubMenu();
        }

        private void btnICT_Click(object sender, EventArgs e)
        {
            openChildForm(new Page());
            btnHome.Visible = true;
            hideSubMenu();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            openChildForm(new Page());
            btnHome.Visible = true;
            hideSubMenu();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            showSubMenu(panelServicesSubMenu);
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            openChildForm(new Page());
            btnHome.Visible = true;
            hideSubMenu();
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Student?", "Message", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                openChildForm(new StudentExam());
            }
            else
            {
                openChildForm(new LecturerExam());
            }
            btnHome.Visible = true;
            hideSubMenu();
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Student?", "Message", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                openChildForm(new StudentResults());
            }
            else
            {
                openChildForm(new LecturerResults());
            }
            btnHome.Visible = true;
            hideSubMenu();
        }

        private void btnForum_Click(object sender, EventArgs e)
        {
            openChildForm(new Page());
            btnHome.Visible = true;
            hideSubMenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure, you want to logout?", "Message", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                Application.Exit();
            }

            hideSubMenu();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                btnHome.Visible = false;
                lblPage.Text = "Home";
            }
        }

        private void openChildForm(Form childForm)
        {
            if (currentChildForm!=null)
                currentChildForm.Close();
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblPage.Text = childForm.Text;
        }
  
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Student?", "Message", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                openChildForm(new StudentExam());
            }
            else
            {
                openChildForm(new LecturerExam());
            }
            btnHome.Visible = true;
        }

        private void picEnglish_Click(object sender, EventArgs e)
        {
            openChildForm(new Page());
            btnHome.Visible = true;
        }

        private void picMaths_Click(object sender, EventArgs e)
        {
            openChildForm(new Page());
            btnHome.Visible = true;
        }

        private void picScience_Click(object sender, EventArgs e)
        {
            openChildForm(new Page());
            btnHome.Visible = true;
        }

        private void picICT_Click(object sender, EventArgs e)
        {
            openChildForm(new Page());
            btnHome.Visible = true;
        }

        private void picHistory_Click(object sender, EventArgs e)
        {
            openChildForm(new Page());
            btnHome.Visible = true;
        }

        private void picCalendar_Click(object sender, EventArgs e)
        {
            openChildForm(new Page());
            btnHome.Visible = true;
        }

        private void picResults_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Student?", "Message", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                openChildForm(new StudentResults());
            }
            else
            {
                openChildForm(new LecturerResults());
            }
            btnHome.Visible = true;
        }

        private void picForum_Click(object sender, EventArgs e)
        {
            openChildForm(new Page());
            btnHome.Visible = true;
        }

        private void btnElearn_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                btnHome.Visible = false;
                lblPage.Text = "Home";
            }
        }
    }
}
