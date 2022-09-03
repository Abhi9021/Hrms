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
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void homepage_Load(object sender, EventArgs e)
        {

        }

        private void Administration_Click(object sender, EventArgs e)
        {
            employeemanagement  f = new employeemanagement();
            f.Show();
        }

        private void emp_info_Click(object sender, EventArgs e)
        {
            Employee_Info i = new Employee_Info();
            i.Show();
        }

        private void project_management_Click(object sender, EventArgs e)
        {
            Project_Management p = new Project_Management();
            p.Show();
        }

        private void Attendance_Click(object sender, EventArgs e)
        {

        }

   
    }
}
