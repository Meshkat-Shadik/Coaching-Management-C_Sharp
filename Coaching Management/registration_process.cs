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
    public partial class registration_process : Form
    {
        string conn = "datasource=localhost;username=root;password=";
        public registration_process()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBox1.Text == "" || textBox_trn_id.Text == "")
                {
                    MessageBox.Show("Fields can not be empty");
                    return;
                }

                MySqlConnection conn2 = new MySqlConnection(conn);
                string query = "select * from `coaching_management`.`payment` where Number = '" + comboBox1.Text + "' and Transaction_id = '" + textBox_trn_id.Text + "'  ";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, conn2);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Matched!");


                    student_registration obj = new student_registration();
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
