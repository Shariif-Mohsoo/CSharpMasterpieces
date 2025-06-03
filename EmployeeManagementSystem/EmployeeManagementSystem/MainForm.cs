using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?",
                "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );
            if (check == DialogResult.Yes) { 
                    Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            //opening the current form and hidding the others
            dashboard1.Visible = true;
            addEmployee1.Visible = false;
            salary1.Visible = false;

            // Attempt to cast 'dashboard1' to a 'Dashboard' type and assign it to 'dashForm'
            Dashboard dashForm = dashboard1 as Dashboard;

            // Check if the cast was successful (i.e., dashboard1 is indeed a Dashboard)
            if (dashForm != null)
            {
                // If successful, call the Refresh method to update the dashboard UI
                dashForm.RefreshData();
            }

        }

        private void addEmployee_btn_Click(object sender, EventArgs e)
        {
            //opening the current form and hidding the others
            dashboard1.Visible = false;
            addEmployee1.Visible = true;
            salary1.Visible = false;

            // Try to convert 'addEmployee1' to type 'addEmployee' and save it in 'addEmpForm'
            addEmployee addEmpForm = addEmployee1 as addEmployee;

            // Check if the conversion worked (it is not null)
            if (addEmpForm != null)
            {
                // If it worked, call the RefreshData() method to update the data
                addEmpForm.RefreshData();
            }

        }

        private void salary_btn_Click(object sender, EventArgs e)
        {
            //opening the current form and hidding the others
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            salary1.Visible = true;

            // Try to convert 'salary1' to type 'Salary' and store it in 'salaryForm'
            Salary salaryForm = salary1 as Salary;

            // Check if the conversion worked (not null)
            if (salaryForm != null)
            {
                // If yes, call RefreshData() to update the salary form
                salaryForm.RefreshData();
            }

        }
    }
}
