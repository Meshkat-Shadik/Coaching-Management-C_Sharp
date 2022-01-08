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
    public partial class student_login : Form
    {
        string conn = "datasource=localhost;username=root;password=";
        string roboIp;
        public student_login()
        {
            InitializeComponent();
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox_name.Text == "" || textBox_password.Text == "")
                {
                    MessageBox.Show("Fields can not be empty");
                    return;
                }

                MySqlConnection conn2 = new MySqlConnection(conn);
                string query = "select * from `coaching_management`.`student_registration` where Name = '" + textBox_name.Text + "' and Password = '" + textBox_password.Text + "'  ";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, conn2);

                MySqlCommand cmd = new MySqlCommand(query, conn2);
                cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn2);
                conn2.Open();
                // MySqlDataReader dr = cmd.ExecuteReader();
                var dr = cmd.ExecuteReader();
                // Now check if any rows returned.
                if (dr.HasRows)
                {
                    dr.Read();// Get first record.
                    roboIp = dr.GetString(0);// Get value of first column as string.
                }
                dr.Close();



                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Matched!");
                   // MessageBox.Show(roboIp);
                    students_details obj = new students_details(roboIp);
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Did not match");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
