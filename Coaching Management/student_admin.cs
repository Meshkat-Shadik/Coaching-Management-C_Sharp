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
    public partial class student_admin : Form
    {
        string conn = "datasource=localhost;username=root;password=; database=coaching_management";
        MySqlDataReader myReader;
        public student_admin()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            try
            {

                MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=; database=coaching_management");//connection name

                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT `Name`, `Class`, `Course_session`, `Id`, `Email`, `Name_of_institution`, `Address`, `Contact_no`, `Guardian_contact_no` FROM `student_registration` ", con);


                cmd.CommandType = CommandType.Text;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "ss");

                dataGridView1.DataSource = ds.Tables["ss"]; ;

                // dataGridView1.DataBind();

            }

            catch
            {

                MessageBox.Show("No Record Found");

            }
        }

        private void Button_update_Click(object sender, EventArgs e)
        {
            try
            {
                // string selected_mobile = dataGridView1.SelectedRows[0].Cells["Mobile"].Value.ToString();
                string selected_name = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
                // this.Hide();
                update_student f = new update_student(selected_name, name);
                f.ShowDialog();
                load();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_del_admin_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();

                MySqlConnection conn2 = new MySqlConnection(conn);
                string query = "DELETE FROM `student_registration` WHERE Id='" + id + "';";
                MySqlCommand command = new MySqlCommand(query, conn2);
                conn2.Open();
                myReader = command.ExecuteReader();
                MessageBox.Show("Deleted!");
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            admin obj = new admin();
            obj.Show();
            this.Hide();
        }
    }
}
