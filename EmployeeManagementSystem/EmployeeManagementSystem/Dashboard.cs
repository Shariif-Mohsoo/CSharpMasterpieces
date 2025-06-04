using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class Dashboard: UserControl
    {
        // SQL Server connection string to connect with the 'employees' database
        SqlConnection connect = new SqlConnection(
            "Data Source=DESKTOP-9CRTH2N\\SQLEXPRESS;Initial Catalog=employees;Integrated Security=True;"
        );
        public Dashboard()
        {
            InitializeComponent();
            //to display Total Employees 
            this.displayTE();
            // to display Active Employees
            this.displayAE();
            // to display In_Active Employees.
            this.displayIE();
        }

        public void RefreshData()
        {
            // Check: Are we on the wrong thread? (Not the UI thread)
            if (InvokeRequired)
            {
                // If yes, run this method again, but on the correct (UI) thread
                Invoke((MethodInvoker)RefreshData);
                return; // Stop this one (wrong thread)
            }
            this.displayTE();
            this.displayAE();
            this.displayIE();
            // If we are already on the correct thread, we can safely update the screen (UI)
            // Example: label1.Text = "Updated!"; (You can add your UI update code here)
        }


        //function to check totaly number of employees working.
        public void displayTE()
        {
            if (connect.State != ConnectionState.Open)
            {
                try {
                    connect.Open();
                    //writing the query
                    //string selectData = "select count(id) from employees where delete_date is null";
                    string selectData = "select count(employee_id) from employees where delete_date is null";

                    using (SqlCommand cmd = new SqlCommand(selectData,connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if(reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_TE.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex ) {
                    MessageBox.Show("Error: " + ex, "Error Message", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { 
                    connect.Close();
                }
            }
        }

        //function to check total number of active employees.

        public void displayAE()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    //writing the query
                    //string selectData = "select count(id) from employees where " +
                    //    "status = @status and " +
                    //    "delete_date is null";
                    string selectData = "select count(employee_id) from employees where " +
                        "status = @status and " +
                        "delete_date is null";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Active");
                        
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_AE.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        //function to check total number of in_active employees.

        public void displayIE()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    //writing the query
                    //string selectData = "select count(id) from employees where " +
                    //    "status = @status and " +
                    //    "delete_date is null";
                    string selectData = "select count(employee_id) from employees where " +
                        "status = @status and " +
                        "delete_date is null";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Inactive");
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_IE.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
