using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_material_page
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            lblPage.Text = "Home";
        }

        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
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
            
        }

        private void picEnglish_Click(object sender, EventArgs e)
        {
            English eng = new English();
            eng.Show();
            this.Hide();
        }

        private void picMaths_Click(object sender, EventArgs e)
        {
            Maths mat = new Maths();
            mat.Show();
            this.Hide();
        }

        private void picScience_Click(object sender, EventArgs e)
        {
            Science sci = new Science();
            sci.Show();
            this.Hide();
        }

        private void picICT_Click(object sender, EventArgs e)
        {
            ICT ict = new ICT();
            ict.Show();
            this.Hide();
        }

        private void picHistory_Click(object sender, EventArgs e)
        {
            History his = new History();
            his.Show();
            this.Hide();
        }

        private void picCalendar_Click(object sender, EventArgs e)
        {
            
        }

        private void picResults_Click(object sender, EventArgs e)
        {
            
        }

        private void picForum_Click(object sender, EventArgs e)
        {
            
        }
    }
}

