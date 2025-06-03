using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class SalaryData
    {
        // Properties representing fields in the 'employees' database table
        public string EmployeeId { get; set; }       // Employee's unique ID 0
        public string Name { get; set; }             // Full name of the employee 1
        public string Gender { set; get; }           // Gender of the employee 2
        public string Contact { set; get; }          // Contact of the employee 3
        public string Position { set; get; }         // Position or job title 4
        public int Salary { set; get; }              // Salary amount 5

        // SQL Server connection string to connect with the 'employees' database
        SqlConnection connect = new SqlConnection(
            "Data Source=DESKTOP-9CRTH2N\\SQLEXPRESS;Initial Catalog=employees;Integrated Security=True;"
        );

        // Method to fetch a list of employees from the database
        public List<SalaryData> salaryEmployeeListData()
        {
            // List to store employee records fetched from the database
            List<SalaryData> listdata = new List<SalaryData>();

            // Check if connection is not already open
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open(); // Open database connection

                    // SQL query to select all employees where delete_date is null (not deleted)
                    string selectData = "select * from employees where status = 'Active' and" +
                        " delete_date is null";

                    // Execute the query using SqlCommand
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader(); // Read the result

                        // Loop through each row in the result
                        while (reader.Read())
                        {
                            // Create a new employee object and populate it from the reader
                            SalaryData ed = new SalaryData();
                            ed.EmployeeId = reader["employee_id"].ToString();
                            ed.Name = reader["full_name"].ToString();
                            ed.Gender = reader["gender"].ToString();
                            ed.Contact = reader["contact_number"].ToString();
                            ed.Position = reader["position"].ToString();
                            ed.Salary = (int)reader["salary"];

                            // Add the employee to the list
                            listdata.Add(ed);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Print error if something goes wrong
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    // Always close the connection after use
                    connect.Close();
                }
            }

            // Return the final list of employee data
            return listdata;
        }
    }
}
