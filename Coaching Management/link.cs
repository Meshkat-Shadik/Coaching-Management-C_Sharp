using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace Coaching_Management
{
    public partial class link : Form
    {
        public link()
        {
            InitializeComponent();
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            admin form = new admin();
            form.Show();
            this.Hide();
        }

        private void LinkLabe1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.w3school.com");
        }

        private void LinkLabel_10mintschool_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.10minutesschool.com");
        }

        private void LinkLabel_ssc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.educationboardresults.govt.bd");
        }

        private void LinkLabel_hsc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.educationboardresults.govt.bd");
        }
    }
}
