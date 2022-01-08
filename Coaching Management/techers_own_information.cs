using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Coaching_Management
{
    public partial class techers_own_information : Form
    {
        string conn = "datasource=localhost;username=root;password=; database=coaching_management";
        string id;
        public techers_own_information(string x)
        {
            id = x;
            InitializeComponent();
            textBox_name.ReadOnly = true;
            textBox_id.ReadOnly = true;
            textBox_subject.ReadOnly = true;
            textBox_qualification.ReadOnly = true;
            textBox_address.ReadOnly = true;
            textBox_password.ReadOnly = true;
        }
        public techers_own_information()
        {
            // TODO: Complete member initialization
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            add_result_by_teacher obj = new add_result_by_teacher();
            obj.Show();
            this.Hide();
        }

        private void Techers_own_information_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conn);
            con.Open();
            string str = "select * from teacher_registration where Id =" + teacher__login.teacher_id + "";
            //  MySqlCommand com = new MySqlCommand(str, con);
            MySqlDataAdapter sda = new MySqlDataAdapter(str, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                textBox_name.Text = dt.Rows[0][1].ToString();
                textBox_id.Text = dt.Rows[0][0].ToString();
                textBox_subject.Text = dt.Rows[0][2].ToString();
                textBox_qualification.Text = dt.Rows[0][3].ToString();
                textBox_address.Text = dt.Rows[0][5].ToString();
                textBox_password.Text = dt.Rows[0][6].ToString();
            }
            else
            {
                MessageBox.Show("Problem in database");
            }
            con.Close();
        }

        private void Button_logout_Click(object sender, EventArgs e)
        {
            teacher__login obj = new teacher__login();
            obj.Show();
            this.Hide();
        }
    }
}
