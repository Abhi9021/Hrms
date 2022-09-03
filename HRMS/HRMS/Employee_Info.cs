using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HRMS
{
    public partial class Employee_Info : Form
    {
        public Employee_Info()
        {
            InitializeComponent();
        }
        OleDbDataAdapter ad;
        DataSet ds;
        OleDbConnection con;
        private void Employee_Info_Load(object sender, EventArgs e)
        {
             con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Desktop\HRMS.accdb");
            con.Open();
            ad=new OleDbDataAdapter("select * from employee",con);
            ds = new DataSet();
            ad.Fill(ds,"demo");
            dataGridView1.DataSource=ds.Tables[0];
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                MessageBox.Show("please Enter correct Employee Name", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ad = new OleDbDataAdapter("select * from employee where Name='" + txtsearch.Text + "'", con);
                ds = new DataSet();
                ad.Fill(ds, "name");
                dataGridView1.DataSource = ds.Tables[0];
            }
           
        }
    }
}
