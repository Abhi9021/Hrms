namespace HRMS
{
    partial class homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Administration = new System.Windows.Forms.Button();
            this.emp_info = new System.Windows.Forms.Button();
            this.project_management = new System.Windows.Forms.Button();
            this.Attendance = new System.Windows.Forms.Button();
            this.paayment = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.report = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1320, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Administration
            // 
            this.Administration.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administration.Location = new System.Drawing.Point(43, 49);
            this.Administration.Name = "Administration";
            this.Administration.Size = new System.Drawing.Size(289, 43);
            this.Administration.TabIndex = 1;
            this.Administration.Text = "Administration";
            this.Administration.UseVisualStyleBackColor = true;
            this.Administration.Click += new System.EventHandler(this.Administration_Click);
            // 
            // emp_info
            // 
            this.emp_info.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_info.Location = new System.Drawing.Point(43, 132);
            this.emp_info.Name = "emp_info";
            this.emp_info.Size = new System.Drawing.Size(289, 46);
            this.emp_info.TabIndex = 2;
            this.emp_info.Text = "Employee_info";
            this.emp_info.UseVisualStyleBackColor = true;
            this.emp_info.Click += new System.EventHandler(this.emp_info_Click);
            // 
            // project_management
            // 
            this.project_management.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_management.Location = new System.Drawing.Point(43, 212);
            this.project_management.Name = "project_management";
            this.project_management.Size = new System.Drawing.Size(378, 68);
            this.project_management.TabIndex = 3;
            this.project_management.Text = "Project Management";
            this.project_management.UseVisualStyleBackColor = true;
            this.project_management.Click += new System.EventHandler(this.project_management_Click);
            // 
            // Attendance
            // 
            this.Attendance.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendance.Location = new System.Drawing.Point(43, 300);
            this.Attendance.Name = "Attendance";
            this.Attendance.Size = new System.Drawing.Size(289, 50);
            this.Attendance.TabIndex = 4;
            this.Attendance.Text = "Attendance Mangement";
            this.Attendance.UseVisualStyleBackColor = true;
            this.Attendance.Click += new System.EventHandler(this.Attendance_Click);
            // 
            // paayment
            // 
            this.paayment.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paayment.Location = new System.Drawing.Point(43, 370);
            this.paayment.Name = "paayment";
            this.paayment.Size = new System.Drawing.Size(289, 48);
            this.paayment.TabIndex = 5;
            this.paayment.Text = "Payment";
            this.paayment.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.report);
            this.panel1.Controls.Add(this.paayment);
            this.panel1.Controls.Add(this.Administration);
            this.panel1.Controls.Add(this.emp_info);
            this.panel1.Controls.Add(this.project_management);
            this.panel1.Controls.Add(this.Attendance);
            this.panel1.Location = new System.Drawing.Point(21, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 514);
            this.panel1.TabIndex = 6;
            // 
            // report
            // 
            this.report.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.Location = new System.Drawing.Point(43, 450);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(289, 48);
            this.report.TabIndex = 6;
            this.report.Text = "Report";
            this.report.UseVisualStyleBackColor = true;
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 693);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "homepage";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.homepage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button Administration;
        private System.Windows.Forms.Button emp_info;
        private System.Windows.Forms.Button project_management;
        private System.Windows.Forms.Button Attendance;
        private System.Windows.Forms.Button paayment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button report;
    }
}