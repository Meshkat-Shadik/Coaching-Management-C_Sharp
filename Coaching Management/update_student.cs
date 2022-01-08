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
    public partial class update_student : Form
    {
        String a;
        string conn = "datasource=localhost;username=root;password=;database=coaching_management";
        MySqlDataReader myReader;
        public update_student(String x, string y)
        {
            InitializeComponent();
            a = x;
            label1.Text = "Student Update For " + y;
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            student_admin obj = new student_admin();
            obj.Show();
            this.Hide();
        }

        private void Button_update_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox_name.Text == "" || textBox_email.Text == "" || textBox_name_of_institution.Text == "" || textBox_adress.Text == "" || textBox_contact_no.Text == "" || textBox_gurdian_contact_no.Text == "" || textBox_password.Text == "")
                {
                    MessageBox.Show("Fields can not be empty");
                    return;
                }

                MySqlConnection conn2 = new MySqlConnection(conn);
                //string query2 = "INSERT INTO  `coaching_management`.`student_registration`(`Name`,`Email`, `Name_of_institution`, `Address`, `Contact_no`, `Guardian_contact_no`, `Password`)  VALUES ('" + textBox_name.Text + "','" + textBox_email.Text + "','" + textBox_name_of_institution.Text + "','" + textBox_adress.Text + "','" + textBox_contact_no.Text + "','" + textBox_gurdian_contact_no.Text + "','" + textBox_password.Text + "')";

                //   string Query = "update datas set name='" + this.namebox.Text + "',email='" + this.emailbox.Text + "',bloodgroup='" + this.bgbox.Text + "',mobile='" + this.mobilebox.Text + "',category='" + this.catbox.Text + "' where mobile='" + this.label1.Text + "';";
                // string query = 'UPDATE student_registration SET Name=' + this.textBox_name.Text.ToString() + ',Email=' + this.textBox_email.Text.ToString() + ',Name_of_institution=' + this.textBox_name_of_institution.Text + ',Address=' + this.textBox_adress.Text + ',Contact_no=' + this.textBox_contact_no.Text + ',Guardian_contact_no=' + this.textBox_gurdian_contact_no.Text + ',Password=' + this.textBox_password.Text + ' WHERE Id = ' + this.a + '';

                string query = "update student_registration  set Name='" + this.textBox_name.Text + "',Email='" + this.textBox_email.Text + "',Name_of_institution='" + this.textBox_name_of_institution.Text + "',Address='" + this.textBox_adress.Text + "',Contact_no='" + this.textBox_contact_no.Text + "',Guardian_contact_no='" + this.textBox_gurdian_contact_no.Text + "',Password='" + this.textBox_password.Text + "' where Id='" + a + "';";
                MySqlCommand command = new MySqlCommand(query, conn2);
                conn2.Open();
                myReader = command.ExecuteReader();
                MessageBox.Show("Update Completed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
