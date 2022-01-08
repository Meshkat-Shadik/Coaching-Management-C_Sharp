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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void Button_stu_admin_Click(object sender, EventArgs e)
        {
            student_admin obj = new student_admin();
            obj.Show();
            this.Hide();
        }

        private void Button_teac_admin_Click(object sender, EventArgs e)
        {
            teacher_admin obj = new teacher_admin();
            obj.Show();
            this.Hide();
        }

        private void Button_fee_admin_Click(object sender, EventArgs e)
        {
            student_payment_show_admin obj = new student_payment_show_admin();
            obj.Show();
            this.Hide();
        }

        private void Button_email_Click(object sender, EventArgs e)
        {
            Mail obj = new Mail();
            obj.Show();
            this.Hide();
        }

        private void Button_logout_admin_Click(object sender, EventArgs e)
        {
            home_page obj = new home_page();
            obj.Show();
            this.Hide();
        }
    }
}
