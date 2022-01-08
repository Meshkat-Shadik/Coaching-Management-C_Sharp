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
    public partial class payment : Form
    {
        int c;
        string conn = "datasource=localhost;username=root;password=";
        int selectedCourseFee;
        MySqlDataReader myReader;
        public payment()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (comboBox.Text.ToString().Contains("Bangla=3000"))
                {
                    selectedCourseFee = 3000;
                }
                else if (comboBox.Text.ToString().Contains("English=4000"))
                {
                    selectedCourseFee = 4000;
                }

                else if (comboBox.Text.ToString().Contains("Math=5000"))
                {
                    selectedCourseFee = 5000;
                }
                else if (comboBox.Text.ToString().Contains("Bangla+English=6000"))
                {
                    selectedCourseFee = 6000;
                }
                else if (comboBox.Text.ToString().Contains("Bangla+Math=7000"))
                {
                    selectedCourseFee = 7000;
                }
                else if (comboBox.Text.ToString().Contains("English+Math=8000"))
                {
                    selectedCourseFee = 8000;
                }
                else if (comboBox.Text.ToString().Contains("Bangla + English + Math = 11000"))
                {
                    selectedCourseFee = 11000;
                }

                if (comboBox.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || textBox_email.Text == "")
                {
                    MessageBox.Show("Fields can not be empty");
                    return;
                }
                int transactionId = new Random().Next(0, 99999999);
                MySqlConnection conn2 = new MySqlConnection(conn);
                string query = "INSERT INTO  `coaching_management`.`payment`(`Transaction_id`, `Name`, `Course`, `Number`, `Amount`, `Email`) VALUES ('" + transactionId + "','" + textBox_name.Text + "','" + comboBox.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox_email.Text + "')";
                //MessageBox.Show(query);
                MySqlCommand command = new MySqlCommand(query, conn2);
                conn2.Open();
                myReader = command.ExecuteReader();

               
                if(int.Parse(comboBox2.Text.Trim()) == selectedCourseFee)
                {
                    mailsend(textBox_email.Text);
                    MessageBox.Show("Payment Completed!");
                }
                else
                {
                    MessageBox.Show("Please pay the full amount");
                }


                // transactionid(textBox_email.Text);
              
                //  MessageBox.Show(" "+transactionid(textBox_email.Text));
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        int transactionid(String email)
        {

            MySqlConnection con = new MySqlConnection(conn);
            con.Open();
            string str = "select Transaction_id from coaching_management.payment where Email ='" + textBox_email.Text + "'";
            MySqlCommand com = new MySqlCommand(str, con);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            c = Convert.ToInt32(reader["Transaction_id"].ToString());
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
                msg.Body = "Dear " + textBox_name.Text + ", your payment " + comboBox2.Text + " is successful, and your transaction id is " + transactionid(mail) + "";
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

        private void Button_back_Click(object sender, EventArgs e)
        {
            home_page obj = new home_page();
            obj.Show();
            this.Hide();
        }
    }
}
