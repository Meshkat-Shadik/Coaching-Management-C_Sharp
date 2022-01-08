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
    public partial class students_details : Form
    {
        string conn = "datasource=localhost;username=root;password=; database=coaching_management";
        string id;
        public students_details(string x)
        {
            id = x;
            InitializeComponent();
            //MessageBox.Show(id.ToString());
            showdata();
            //MessageBox.Show("2");
            showresult();
            //MessageBox.Show("3");
        }
        void showdata()
        {
            MySqlConnection con = new MySqlConnection(conn);
            con.Open();
            string str = "select * from student_registration where Id =" + id + "";
            MySqlCommand com = new MySqlCommand(str, con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            label11.Text = reader["Name"].ToString();
            reader.Read();
            label14.Text = reader["Id"].ToString();
            reader.Read();
            label12.Text = reader["Email"].ToString();
            label17.Text = reader["Name_of_institution"].ToString();
            label13.Text = reader["Address"].ToString();
            label16.Text = reader["Contact_no"].ToString();
            label15.Text = reader["Guardian_contact_no"].ToString();

            reader.Close();
            con.Close();
        }

        void showresult()
        {
            MySqlConnection con = new MySqlConnection(conn);
            con.Open();
            string str = "select * from result where Id =" + id + "";
            // MessageBox.Show(str);
            MySqlCommand com = new MySqlCommand(str, con);
            MySqlDataReader reader = com.ExecuteReader();
            //reader.Read();
            if (reader.Read())
            {
                textBox_name.Text = reader["Name"].ToString();
                //reader.Read();
                textBox_id.Text = reader["Id"].ToString();
                //reader.Read();
                textBox_bangla.Text = reader["Bangla"].ToString();
                textBox_english.Text = reader["English"].ToString();
                textBox_math.Text = reader["Math"].ToString();
            }

            reader.Close();
            con.Close();
        }

        private void Button_own_details_Click(object sender, EventArgs e)
        {
            panel_my_details.Visible = false;
            panel_result.Visible = true;
        }

        private void Button_result_Click(object sender, EventArgs e)
        {
            panel_my_details.Visible = true;
            panel_result.Visible = false;
        }

        private void Button_logout_Click(object sender, EventArgs e)
        {
            student_login obj = new student_login();
            obj.Show();
            this.Hide();
        }
    }
}
