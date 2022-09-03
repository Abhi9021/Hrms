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
    public partial class Project_Management : Form
    {
        public Project_Management()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter ad;
        DataSet ds;
        int m = 0;
        public void Project_Management_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Desktop\HRMS.accdb");
            con.Open();
            database();

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (txtprleader.Text == "" && txtprname.Text == "" && member1.Text == "" && member2.Text == "" && member3.Text == "" && member4.Text == "" && member5.Text == "")
            {
                MessageBox.Show("please enter all the details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmd = new OleDbCommand("insert into project(ProjectName,ProjectLeader,Member1,Member2,Member3,Member4,Member5) values('" + txtprname.Text + "','" + txtprleader.Text + "','" + member1.Text + "','" + member2.Text + "','" + member3.Text + "','" + member4.Text + "','" + member5.Text + "')", con);
                m = cmd.ExecuteNonQuery();
                if (m > 0)
                {
                    MessageBox.Show("Record insert succesfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    database();
                    
                }
                else
                {
                    MessageBox.Show("Record insertion  failed", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                }
            }
        }
        public void clear()
        {
            txtprname.Clear();
            txtprleader.Clear();
            member1.Clear();
            member2.Clear();
            member3.Clear();
            member4.Clear();
            member5.Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtprleader.Text == "" && txtprname.Text == "" && member1.Text == "" && member2.Text == "" && member3.Text == "" && member4.Text == "" && member5.Text == "")
            {
                MessageBox.Show("please enter all the details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmd = new OleDbCommand("update project set ProjectName='" + txtprname.Text + "',ProjectLeader='" + txtprleader.Text + "',Member1='" + member1.Text + "', Member2='" + member2.Text + "',Member3='" + member3.Text + "',Member4='" + member3.Text + "',Member5='" + member5.Text + "' where ProjectName='" + txtprname.Text + "'", con);
                m = cmd.ExecuteNonQuery();
                if (m > 0)
                {
                    MessageBox.Show("Record Updated succesfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    database();
                }
                else
                {
                    MessageBox.Show("Record Updation  failed", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                }

            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                MessageBox.Show("please Enter correct Project Name", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ad = new OleDbDataAdapter("select * from project where ProjectName='" + txtsearch.Text + "'", con);
                ds = new DataSet();
                ad.Fill(ds, "name");
                Projectinfo.DataSource = ds.Tables[0];
            }
           
        }
        public  void database()
        {
            ds = new DataSet();
            ad = new OleDbDataAdapter("select *from Project", con);
            ad.Fill(ds, "Project");
            Projectinfo.DataSource = ds.Tables[0];
        }

    

        
       
    }
}
