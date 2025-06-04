using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class Salary: UserControl
    {

        // SQL Server connection string to connect with the 'employees' database
        SqlConnection connect = new SqlConnection(
            "Data Source=DESKTOP-9CRTH2N\\SQLEXPRESS;Initial Catalog=employees;Integrated Security=True;"
        );

        public Salary()
        {
            InitializeComponent();
            this.displayEmployees();
            this.disableFields();
        }

        public void RefreshData()
        {
            // Check: Are we on the wrong thread? (not the main UI thread)
            if (InvokeRequired)
            {
                // If yes, run this method again on the correct UI thread
                Invoke((MethodInvoker)RefreshData);
                return; // Stop this (wrong thread) call
            }

            // Now we are on the correct UI thread
            // So we can safely update the screen

            this.displayEmployees();  // Show employee data on the form
            this.disableFields();     // Disable some form fields (like textboxes,
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void displayEmployees()
        {
            SalaryData ed = new SalaryData();
            List<SalaryData> listData = ed.salaryEmployeeListData();
            //filling the gridView with list of employees data.
            dataGridView1.DataSource = listData;

        }
        private void salary_updateBtn_Click(object sender, EventArgs e)
        {
            if(salary_employeeID.Text == ""
               || salary_name.Text == ""
               || salary_position.Text == ""
               || salary_salary.Text == ""
                )
            {
                MessageBox.Show("Please make sure to fill all blank fields",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE ID: " + 
                    salary_employeeID.Text.Trim() + "?","Confirmation Message" ,MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    );
                if (check == DialogResult.Yes)
                {
                    if(connect.State == ConnectionState.Closed)
                    {

                        try {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "update employees set salary = @salary, update_date = @updateDate" +
                                " where employee_id = @employeeID; " +
                                "update Bonus set bonus=@bonus where employee_id=@employeeID";

                            using (SqlCommand cmd = new SqlCommand(updateData,connect)) {
                                int bonus = Convert.ToInt32(salary_bonus.Text.Trim());
                                int basicSalary = Convert.ToInt32(salary_salary.Text.Trim());
                                int totalSalary = basicSalary + bonus;
                                cmd.Parameters.AddWithValue("@salary", totalSalary);
                                cmd.Parameters.AddWithValue("@updateDate", today);
                                cmd.Parameters.AddWithValue("@employeeID", salary_employeeID.Text.Trim());
                                //new one for salary table
                                cmd.Parameters.AddWithValue("@basicSalary", basicSalary);
                                cmd.Parameters.AddWithValue("@bonus", bonus);

                                cmd.ExecuteNonQuery();
                                this.displayEmployees();
                                MessageBox.Show("Updated Successfully!", "Information Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.clearFields();
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled", "Information Message",
                        MessageBoxButtons.OK,MessageBoxIcon.Warning
                        );
                }
            }
        }
        public void clearFields()
        {
            salary_employeeID.Text = "";
            salary_name.Text = "";
            salary_position.Text = "";
            salary_salary.Text = "";
            salary_bonus.Text = "";
        }
        public void disableFields()
        {
            //to make the desire fields just read only
            salary_employeeID.Enabled = false;
            salary_name.Enabled = false;
            salary_position.Enabled = false;
            //add new one for salary
            salary_salary.Enabled = false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //row shouldn't be out of the boundry
            if(e.RowIndex != -1)
            {
                //select the clicked row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                //storing the desire data to the input fields of salary form.
                if (row != null)
                {
                    salary_employeeID.Text = row.Cells[0].Value.ToString();
                    salary_name.Text = row.Cells[1].Value.ToString();
                    salary_position.Text = row.Cells[4].Value.ToString();
                    salary_salary.Text = row.Cells[5].Value.ToString();
                }

            }
        }

        private void salary_clearBtn_Click(object sender, EventArgs e)
        {
            this.clearFields();
        }

        private void Salary_Load(object sender, EventArgs e)
        {

        }
    }
}
