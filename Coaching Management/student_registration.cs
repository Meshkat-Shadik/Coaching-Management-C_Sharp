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
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;

namespace Coaching_Management
{
    public partial class student_registration : Form
    {
        int c;
        string conn = "datasource=localhost;username=root;password=";
        MySqlDataReader myReader;
        public student_registration()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox_name.Text == "" || comboBox_class.Text == "" || comboBox_session.Text == "" || textBox_email.Text == "" || textBox_name_of_institution.Text == "" || textBox_adress.Text == "" || textBox_contact_no.Text == "" || textBox_gurdian_contact_no.Text == "" || textBox_password.Text == "")
                {
                    MessageBox.Show("Fields can not be empty");
                    return;
                }

                MySqlConnection conn2 = new MySqlConnection(conn);
                string query = "INSERT INTO  `coaching_management`.`student_registration`(`Name`,`Class`,`Course_session`,`Email`, `Name_of_institution`, `Address`, `Contact_no`, `Guardian_contact_no`, `Password`)  VALUES ('" + textBox_name.Text + "','" + comboBox_class.Text + "','" + comboBox_session.Text + "','" + textBox_email.Text + "','" + textBox_name_of_institution.Text + "','" + textBox_adress.Text + "','" + textBox_contact_no.Text + "','" + textBox_gurdian_contact_no.Text + "','" + textBox_password.Text + "')";
                MySqlCommand command = new MySqlCommand(query, conn2);
                conn2.Open();
                myReader = command.ExecuteReader();

                mailsend(textBox_email.Text);
                MessageBox.Show("Registration Completed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int studentid(String email)
        {

            MySqlConnection con = new MySqlConnection(conn);
            con.Open();
            string str = "select Id from coaching_management.student_registration where Email ='" + textBox_email.Text + "'";
            MySqlCommand com = new MySqlCommand(str, con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            c = Convert.ToInt32(reader["Id"].ToString());
            return c;
        }

        void mailsend(String mail)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("sumooncse@gmail.com", "01790054409@outlook.com");
                MailMessage msg = new MailMessage();
                msg.To.Add(mail);
                msg.From = new MailAddress("sumooncse@gmail.com");
                msg.Subject = "Transaction Id";
                msg.Body = "Dear " + textBox_name.Text + ", your Registration in " + comboBox_class.Text + " is successful, and your student  id is " + studentid(mail) + "";
                //   Attachment data = new Attachment(textBox_file.Text);
                //    msg.Attachments.Add(data);

                client.Send(msg);
                MessageBox.Show("send successfully");

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
