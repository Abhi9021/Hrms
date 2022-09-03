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
    public partial class employeemanagement : Form
    {

        OleDbConnection con;
        OleDbCommand cmd;
        int n = 0;
        public employeemanagement()
        {
            InitializeComponent();
        }
        private void Administration_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Desktop\HRMS.accdb");
            con.Open();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtperaddress.Text = txtaddress.Text;

        }

        private void update_Click(object sender, EventArgs e)
        {
            String qry = "update employee set  Name='" + txtname.Text + "',mob=" + txtmob.Text + ",Email='" + txtemail.Text + "',dob='" + txtdob.Text + "',gender='" + txtgender.Text + "',bloodgroup='" + txtbloodgroup.Text + "',currentaddress='" + txtaddress.Text + "',permenantaddress='" + txtperaddress.Text + "',sscper=" + txtsscper.Text + ",hscper=" + txthscper.Text + ",stream='" + txtugstream.Text + "',UG=" + txtugper.Text + ",PG_stream='" + txtpgstream.Text + "',PG=" + txtpgper.Text + ",Skill='" + txtskill.Text + "',Experience=" + txtexperience.Text + " where Name='" + txtname.Text + "'";
            cmd = new OleDbCommand(qry, con);
            n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Record update succesfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            else
            {
                MessageBox.Show("Record updation  failed", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            String qry = "insert into employee(Name,mob,Email,dob,gender,bloodgroup,currentaddress,permenantaddress,sscper,hscper,stream,UG,PG_stream,PG,Skill,Experience) values('" + txtname.Text + "'," + txtmob.Text + ",'" + txtemail.Text + "','" + txtdob.Text + "','" + txtgender.Text + "','" + txtbloodgroup.Text + "','" + txtaddress.Text + "','" + txtperaddress.Text + "'," + txtsscper.Text + "," + txthscper.Text + ",'" + txtugstream.Text + "'," + txtugper.Text + ",'" + txtpgstream.Text + "'," + txtpgper.Text + ",'" + txtskill.Text + "'," + txtexperience.Text + ")";
            cmd = new OleDbCommand(qry, con);
            n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Record inserted", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            else
            {
                MessageBox.Show("Record insertion failed", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            String qry = "delete * from employee where Name='" + txtname.Text + "'";
            cmd = new OleDbCommand(qry, con);
            n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Record Deleted", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            else
            {
                MessageBox.Show("Record not deleted", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }
        }
        public void clear()
        {
            txtname.Clear();
            txtmob.Clear();
            txtemail.Clear();
            txtdob.Dispose();
            txtgender.Text = "";
            txtbloodgroup.Text = "";
            txtaddress.Clear();
            txtperaddress.Clear();
            txtsscper.Clear();
            txthscper.Clear();
            txtugstream.Clear();
            txtugper.Clear();
            txtpgstream.Clear();
            txtpgper.Clear();
            txtskill.Clear();
            txtexperience.Clear();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

    }
}


