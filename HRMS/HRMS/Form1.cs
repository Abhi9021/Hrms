using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "Admin" && txtpassword.Text == "9021")
            {
                homepage h2 = new homepage();
                h2.Show();
            }
            else
            {
                MessageBox.Show("please Enter valid details", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
