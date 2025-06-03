using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// for using the db
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class Form1: Form
    {
        SqlConnection connect = new
       SqlConnection("Data Source=DESKTOP-9CRTH2N\\SQLEXPRESS;Initial Catalog=employees;Integrated Security=True;");


        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(login_username.Text == "" || login_showPass.Text == "")
            {
                MessageBox.Show("Please fill all the fields"
                    , "Error Message" , MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
            }
            else
            {
                // Check if the database connection is closed
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        // Open the database connection
                        connect.Open();

                        // Create a SQL query to select user where username and password match
                        string selectData = "Select * from users where username = @username" +
                            " AND password = @password";

                        // Create a SqlCommand object to run the query
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            // Add values from the input fields to the query
                            cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());

                            // Create an adapter to fetch data from the database
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd); // here: pass cmd inside

                            // Create an empty table to store the result
                            DataTable table = new DataTable();

                            // Fill the table with the result of the query
                            adapter.Fill(table);

                            // Check if any row exists (means login successful)
                            if (table.Rows.Count >= 1)
                            {
                                // Show success message
                                MessageBox.Show("Login Successfully!",
                                    "Information Message", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );
                                MainForm mForm = new MainForm();
                                mForm.Show(); 
                                this.Hide();
                            }
                            else
                            {
                                // Show error if no user found
                                MessageBox.Show("Incorrect Username/Password", "Error Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error
                                );
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // If any error happens, show the error message
                        MessageBox.Show("Error: " + ex,
                            "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error
                        );
                    }
                    finally
                    {
                        // Always close the database connection
                        connect.Close();
                    }

                }
            }
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }
    }
}
