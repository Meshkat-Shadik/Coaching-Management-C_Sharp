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
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text.Equals("sumon") && textBox_password.Text.Equals("1234"))
            {

                admin obj = new admin();
                obj.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Admin name or password is wrong");
            }
        }

        private void Button1_back_Click(object sender, EventArgs e)
        {

            home_page obj = new home_page();
            obj.Show();
            this.Hide();
        }
    }
}
