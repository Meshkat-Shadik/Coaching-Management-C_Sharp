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
    public partial class teacher__login : Form
    {
        string conn = "datasource=localhost;username=root;password=";
        public static int teacher_id = 0;
        public teacher__login()
        {
            InitializeComponent();
        }

        private void Button_login_teacher_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox_name.Text == "" || textBox_password.Text == "")
                {
                    MessageBox.Show("Fields can not be empty");
                    return;
                }

                MySqlConnection conn2 = new MySqlConnection(conn);
                string query = "select * from `coaching_management`.`teacher_registration` where Name = '" + textBox_name.Text + "' and Password = '" + textBox_password.Text + "'  ";
                //  MessageBox.Show(query);
                MySqlDataAdapter sda = new MySqlDataAdapter(query, conn2);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Matched!");
                    string id = dt.Rows[0][0].ToString();
                    teacher_id = Convert.ToInt32(dt.Rows[0][0].ToString());


                    /*
                    add_result_by_teacher obj = new add_result_by_teacher();
                    obj.Show();
                    this.Hide();*/

                    /*techers_own_information obj = new techers_own_information();
                    obj.Show();
                    this.Hide();*/
                    techers_own_information obj = new techers_own_information(id);
                    this.Hide();
                    obj.ShowDialog();
                    Close();


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
