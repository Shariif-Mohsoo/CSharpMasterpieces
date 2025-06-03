using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//for the database
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class RegisterForm: Form
    {
        //performing the connection
        //SqlConnection connect = new
        //  SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shariif-Rajpoot\OneDrive\문서\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");


        //SqlConnection connect = new
        // SqlConnection("Data Source=localhost\\SQLEXPRESS;Integrated Security=True;Trust Server Certificate=True");

      SqlConnection connect = new
       SqlConnection("Data Source=DESKTOP-9CRTH2N\\SQLEXPRESS;Initial Catalog=employees;Integrated Security=True;");
       
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showPass.Checked ? '\0' : '*';
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signin_loginBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (signup_username.Text == "" || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error message",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open) {
                    try {
                        connect.Open();
                        string selectUsername = "select count(id) from users where username = @user";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", signup_username.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();
                            if (count >= 1)
                            {
                                MessageBox.Show(signup_username.Text.Trim() + " is already taken"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error
                                    );  
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "insert into users"
                                    + "(username,password,date_register)"
                                    + "values(@username,@password,@dateReg)";
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);
                                    
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Register Successfully", "Information Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information
                                        );
                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }

                            }  
                        }

                       
                        
                    }
                    catch(Exception ex) {
                        MessageBox.Show("Error: " + ex, "Error message",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally {
                        connect.Close();                    
                    }
                }
            }

        }
    }
}
