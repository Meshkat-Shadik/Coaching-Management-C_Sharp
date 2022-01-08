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
    public partial class student_payment_show_admin : Form
    {
        public student_payment_show_admin()
        {
            InitializeComponent();
        }

        private void Button_back_Click(object sender, EventArgs e)
        {

            admin form = new admin();
            form.Show();
            this.Hide();
        }

        private void Student_payment_show_admin_Load(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=; database=coaching_management");//connection name

                con.Open();

                MySqlCommand cmd = new MySqlCommand("select * from payment", con);

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
    }
}
