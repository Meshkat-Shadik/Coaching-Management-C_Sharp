using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coaching_Management
{
    public partial class home_page : Form
    {
        public home_page()
        {
            InitializeComponent();
        }

        private void StudentRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registration_process form = new registration_process();
            form.Show();
            this.Hide();
        }

        private void TeacherRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teacher_registration form = new teacher_registration();
            form.Show();
            this.Hide();
        }

        private void StudentLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student_login form = new student_login();
            form.Show();
            this.Hide();
        }

        private void TeacherLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teacher__login form = new teacher__login();
            form.Show();
            this.Hide();
        }

        private void FeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            payment obj = new payment();
            obj.Show();
            this.Hide();
        }

        private void AdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_login form = new admin_login();
            form.Show();
            this.Hide();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            link obj = new link();
            obj.Show();
            this.Hide();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            developer obj = new developer();
            obj.Show();
            this.Hide();
        }
    }
}
