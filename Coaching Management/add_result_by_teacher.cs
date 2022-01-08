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
    public partial class add_result_by_teacher : Form
    {
        string conn = "datasource=localhost;username=root;password=";
        MySqlDataReader myReader;
        string query1;
        public add_result_by_teacher()
        {
            InitializeComponent();
        }

        private void Button_add_result_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox_name.Text == "" || textBox_id.Text == "" || comboBox_subject.Text == "" || comboBox_class.Text == "" || textBox_obtai_mark.Text == "")
                {
                    MessageBox.Show("Fields can not be empty");
                    return;
                }


                MySqlConnection conn2 = new MySqlConnection(conn);
                string query = "select * from coaching_management.result where Name = '" + textBox_name.Text + "' and Id = '" + textBox_id.Text + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, conn2);

                MySqlCommand cmd = new MySqlCommand(query, conn2);
                cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn2);
                conn2.Open();
                // MySqlDataReader dr = cmd.ExecuteReader();
                var dr = cmd.ExecuteReader();
                // MessageBox.Show("seleceted");
                // Now check if any rows returned.
                if (dr.HasRows)
                {
                    dr.Read();// Get first record.
                }
                dr.Close();



                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {

                    //MessageBox.Show("matched");
                    try
                    {

                        if (textBox_name.Text == "" || textBox_id.Text == "" || comboBox_subject.Text == "" || textBox_obtai_mark.Text == "")
                        {
                            MessageBox.Show("Fields can not be empty");
                            return;
                        }

                        //  MySqlConnection conn2 = new MySqlConnection(conn);
                        if (this.comboBox_subject.Text == "Bangla")
                        {
                            query1 = "update coaching_management.result  set Bangla='" + this.textBox_obtai_mark.Text + "' where Id='" + this.textBox_id.Text + "';";
                        }
                        else if (this.comboBox_subject.Text == "English")
                        {
                            query1 = "update coaching_management.result  set English='" + this.textBox_obtai_mark.Text + "' where Id='" + this.textBox_id.Text + "';";
                        }
                        else if (this.comboBox_subject.Text == "Math")
                        {
                            query1 = "update coaching_management.result  set Math='" + this.textBox_obtai_mark.Text + "' where Id='" + this.textBox_id.Text + "';";
                        }
                        MySqlCommand command2 = new MySqlCommand(query1, conn2);
                        // conn2.Open();
                        myReader = command2.ExecuteReader();
                        MessageBox.Show("Result Uploaded!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
                else
                {
                    //MessageBox.Show("Did not match");
                    try
                    {

                        if (textBox_name.Text == "" || textBox_id.Text == "" || textBox_obtai_mark.Text == "")
                        {
                            MessageBox.Show("Fields can not be empty");
                            return;
                        }

                        //  MySqlConnection conn2 = new MySqlConnection(conn);
                        if (this.comboBox_subject.Text == "Bangla")
                        {
                            query = "INSERT INTO `coaching_management`.`result`( Name ,Id,Class, Bangla)  VALUES ('" + textBox_name.Text + "','" + textBox_id.Text + "','" + comboBox_class.Text + "','" + textBox_obtai_mark.Text + "')";
                        }
                        else if (this.comboBox_subject.Text == "English")
                        {
                            query = "INSERT INTO  `coaching_management`.`result`(Name,Id,Class, English)  VALUES ('" + textBox_name.Text + "','" + textBox_id.Text + "','" + comboBox_class.Text + "','" + textBox_obtai_mark.Text + "')";
                        }
                        else if (this.comboBox_subject.Text == "Math")
                        {
                            query = "INSERT INTO  `coaching_management`.`result`(Name,Id,Class,Math)  VALUES ('" + textBox_name.Text + "','" + textBox_id.Text + "','" + comboBox_class.Text + "','" + textBox_obtai_mark.Text + "')";
                        }
                        MySqlCommand command = new MySqlCommand(query, conn2);
                        // conn2.Open();
                        myReader = command.ExecuteReader();
                        MessageBox.Show("Result Uploaded!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_logout_Click(object sender, EventArgs e)
        {
            teacher__login obj = new teacher__login();
            obj.Show();
            this.Hide();
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            techers_own_information form = new techers_own_information();
            this.Hide();
            form.ShowDialog();
            Close();
        }
    }
}
