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
    public partial class Salary : UserControl
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
            if (salary_employeeID.Text == ""
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
                    salary_employeeID.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    );
                if (check == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {

                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "update employees set salary = @salary, update_date = @updateDate" +
                                " where employee_id = @employeeID; " +
                                "update Bonus set bonus=@bonus where employee_id=@employeeID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
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
                        catch (Exception ex)
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
                        MessageBoxButtons.OK, MessageBoxIcon.Warning
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
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row != null)
                {
                    salary_employeeID.Text = row.Cells[0].Value?.ToString();
                    salary_name.Text = row.Cells[1].Value?.ToString();
                    salary_position.Text = row.Cells[4].Value?.ToString();
                    salary_salary.Text = row.Cells[5].Value?.ToString();
                }

                // Select bonus
                string query = "SELECT bonus FROM Bonus WHERE employee_id = @employeeID;";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@employeeID", salary_employeeID.Text.Trim());

                    connect.Open();
                    object result = cmd.ExecuteScalar();
                    connect.Close();

                    // Display 0 if no bonus, else show actual bonus
                    salary_bonus.Text = (result != null && result != DBNull.Value) ? result.ToString() : "0";
                }
            }

        

            //end selecting bonus

        }
        

        private void salary_clearBtn_Click(object sender, EventArgs e)
        {
            this.clearFields();
        }

        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void bonus_deleteBtn_Click(object sender, EventArgs e)
        {
            //for delete purpose
            if (salary_employeeID.Text == ""
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
                DialogResult check = MessageBox.Show("Are you sure you want to Remove Bonus for ID: " +
                    salary_employeeID.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    );
                if (check == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {

                        try
                        {

                            connect.Open();
                            DateTime today = DateTime.Today;

                            // Step 1: Set bonus = 0
                            string updateBonusQuery = @"
                                                        UPDATE Bonus 
                                                        SET bonus = 0 
                                                        WHERE employee_id = @employeeID;";

                            using (SqlCommand cmdBonus = new SqlCommand(updateBonusQuery, connect))
                            {
                                cmdBonus.Parameters.AddWithValue("@employeeID", salary_employeeID.Text.Trim());
                                cmdBonus.ExecuteNonQuery();
                            }

                            // Step 2: Get total_salary safely, handle NULLs
                            string selectQuery = @"
                                                SELECT ISNULL(CAST(total_salary AS INT), 0) 
                                                FROM Bonus 
                                                WHERE employee_id = @employeeID;";

                            int totalSalary = 0;

                            using (SqlCommand cmdSelect = new SqlCommand(selectQuery, connect))
                            {
                                cmdSelect.Parameters.AddWithValue("@employeeID", salary_employeeID.Text.Trim());

                                using (SqlDataReader reader = cmdSelect.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        totalSalary = reader.GetInt32(0);  // Will now be 0 only if both bonus & basic_salary are NULL
                                    }
                                }
                            }

                            // Step 3: Update employee's salary
                            string updateEmpQuery = @"
                                                    UPDATE Employees 
                                                    SET salary = @salary, update_date = @updateDate 
                                                    WHERE employee_id = @employeeID;";

                            using (SqlCommand cmdEmp = new SqlCommand(updateEmpQuery, connect))
                            {
                                cmdEmp.Parameters.AddWithValue("@salary", totalSalary);
                                cmdEmp.Parameters.AddWithValue("@updateDate", today);
                                cmdEmp.Parameters.AddWithValue("@employeeID", salary_employeeID.Text.Trim());
                                cmdEmp.ExecuteNonQuery();
                            }

                            this.displayEmployees();
                            MessageBox.Show("Bonus deleted and salary updated successfully!", "Information Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.clearFields();





                        }
                        catch (Exception ex)
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
                        MessageBoxButtons.OK, MessageBoxIcon.Warning
                        );
                }
            }
        }
    }
}