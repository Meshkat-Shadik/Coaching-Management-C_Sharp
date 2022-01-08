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
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
        }

        private void Button_email_teacher_Click(object sender, EventArgs e)
        {
            email_to_tecahers obj = new email_to_tecahers();
            obj.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            email_to_students form = new email_to_students();
            form.Show();
            this.Hide();
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            admin form = new admin();
            form.Show();
            this.Hide();
        }
    }
}
