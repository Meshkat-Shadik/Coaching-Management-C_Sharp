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
using System.Collections;

namespace Coaching_Management
{
    public partial class email_to_students : Form
    {
        string conn = "datasource=localhost;username=root;password=";
        MySqlDataReader myReader;
        public email_to_students()
        {
            InitializeComponent();
        }

        private void Button_send_Click(object sender, EventArgs e)
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
                msg.From = new MailAddress("sumooncse@gmail.com");
                msg.Subject = textBox_subject.Text;
                msg.Body = textBox_body.Text;
                // Attachment data = new Attachment(textBox_file.Text);
                // msg.Attachments.Add(data);

                MySqlConnection conn2 = new MySqlConnection(conn);
                string query = "select Email from coaching_management.student_registration ";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, conn2);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    msg.To.Clear();
                    //MessageBox.Show(item[0].ToString());
                    msg.To.Add(item[0].ToString());
                    client.Send(msg);
                }
                MessageBox.Show("send successfully");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
