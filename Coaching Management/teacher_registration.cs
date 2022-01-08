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
    public partial class teacher_registration : Form
    {
        string conn = "datasource=localhost;username=root;password=";
        MySqlDataReader myReader;
        public teacher_registration()
        {
            InitializeComponent();
        }

        private void Teacher_regi_submit_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox_name.Text == "" || comboBox.Text == "" || textBox_qualification.Text == "" || textBox_email.Text == "" || textBox_address.Text == "" || textBox_password.Text == "")
                {
                    MessageBox.Show("Fields can not be empty");
                    return;
                }

                MySqlConnection conn2 = new MySqlConnection(conn);
                string query = "INSERT INTO  `coaching_management`.`teacher_registration`(`Name`, `Subject`, `Qualification`, `Email`,  `Address`, `Password`)  VALUES ('" + textBox_name.Text + "','" + comboBox.Text + "','" + textBox_qualification.Text + "','" + textBox_email.Text + "','" + textBox_address.Text + "','" + textBox_password.Text + "')";
                MySqlCommand command = new MySqlCommand(query, conn2);
                conn2.Open();
                myReader = command.ExecuteReader();
                MessageBox.Show("Regitration Completed!");
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
