using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//for database
using System.Data.SqlClient;
using System.Data;

namespace EmployeeManagementSystem
{
    // This class represents an employee and handles retrieving employee data from the database
    class EmployeeData
    {
        // Properties representing fields in the 'employees' database table
        //public int Id { get; set; }                  // Primary key (auto-incremented ID) 0
        public string EmployeeId { get; set; }       // Employee's unique ID 1
        public string Name { get; set; }             // Full name of the employee 2
        public string Gender { get; set; }           // Gender of the employee 3
        public string Contact { get; set; }          // Contact number 4
        public string Position { set; get; }         // Position or job title 5
        public string Image { set; get; }            // File path of the employee's image 6
        public int Salary { set; get; }              // Salary amount 7
        public string Status { set; get; }           // Employment status (e.g., Active, Inactive) 8

        // SQL Server connection string to connect with the 'employees' database
        SqlConnection connect = new SqlConnection(
            "Data Source=DESKTOP-9CRTH2N\\SQLEXPRESS;Initial Catalog=employees;Integrated Security=True;"
        );

        // Method to fetch a list of employees from the database
        public List<EmployeeData> employeeListData()
        {
            // List to store employee records fetched from the database
            List<EmployeeData> listdata = new List<EmployeeData>();

            // Check if connection is not already open
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open(); // Open database connection

                    // SQL query to select all employees where delete_date is null (not deleted)
                    string selectData = "select * from employees where delete_date is null";

                    // Execute the query using SqlCommand
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader(); // Read the result

                        // Loop through each row in the result
                        while (reader.Read())
                        {
                            // Create a new employee object and populate it from the reader
                            EmployeeData ed = new EmployeeData();
                            //ed.Id = (int)reader["id"];
                            ed.EmployeeId = reader["employee_id"].ToString();
                            ed.Name = reader["full_name"].ToString();
                            ed.Gender = reader["gender"].ToString();
                            ed.Contact = reader["contact_number"].ToString();
                            ed.Position = reader["position"].ToString();
                            ed.Salary = (int)reader["salary"];
                            ed.Image = reader["image"].ToString();
                            ed.Status = reader["status"].ToString();

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

        // Method to fetch a list of employees from the database
        public List<EmployeeData> salaryEmployeeListData()
        {
            // List to store employee records fetched from the database
            List<EmployeeData> listdata = new List<EmployeeData>();

            // Check if connection is not already open
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open(); // Open database connection

                    // SQL query to select all employees where delete_date is null (not deleted)
                    string selectData = "select * from employees where delete_date is null";

                    // Execute the query using SqlCommand
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader(); // Read the result

                        // Loop through each row in the result
                        while (reader.Read())
                        {
                            // Create a new employee object and populate it from the reader
                            EmployeeData ed = new EmployeeData();
                            ed.EmployeeId = reader["employee_id"].ToString();
                            ed.Name = reader["full_name"].ToString();
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
