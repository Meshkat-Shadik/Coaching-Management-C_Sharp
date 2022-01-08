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
    public partial class teacher_admin : Form
    {
        string conn = "datasource=localhost;username=root;password=; database=coaching_management";
        MySqlDataReader myReader;
        public teacher_admin()
        {
            InitializeComponent();
            load();
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            admin obj = new admin();
            obj.Show();
            this.Hide();
        }

        private void Button_update_Click(object sender, EventArgs e)
        {

            try
            {
                // string selected_mobile = dataGridView1.SelectedRows[0].Cells["Mobile"].Value.ToString();
                string selected_name = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
                // this.Hide();
                update_teacher f = new update_teacher(selected_name, name);
                f.ShowDialog();
                load();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();

                MySqlConnection conn2 = new MySqlConnection(conn);
                string query = "DELETE FROM `teacher_registration` WHERE Id='" + id + "';";
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

      /*  public void load()
        {
            try
            {

                MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=; database=coaching_management");//connection name

                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT `Name`, `Subject`, `Qualification`, `Teachers_id`, `Email`, `Address` FROM `teacher_registration`", con);

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
      */
      public void load()
        {
            try
            {
                string MyConnection2 = "datasource = localhost; username = root; password=; database = coaching_management";
                string Query = "SELECT `Name`, `Subject`, `Qualification`, `Id`, `Email`, `Address` FROM `teacher_registration`";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                MyConn2.Close();
                dataGridView1.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Record Found"+ex.ToString());
            }
        }
    }
}
