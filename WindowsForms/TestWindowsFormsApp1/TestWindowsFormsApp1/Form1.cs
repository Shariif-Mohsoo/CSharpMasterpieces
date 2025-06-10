using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;
using System.Data;
using System.Linq.Expressions;

namespace TestWindowsFormsApp1
{
    public partial class Form1: Form
    {
        string connection = "Data Source=DESKTOP-9CRTH2N\\SQLEXPRESS;Initial Catalog=register;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //logic for fetching data
            string name = textBox1.Text;
            string password = textBox2.Text;
            string email = textBox3.Text;
            string role = comboBox1.Text;
            string question = comboBox2.Text;
            string answer = textBox6.Text;

            try
            {

                using (SqlConnection con = new SqlConnection(connection))
                {
                    string query = "\r\ninsert into registerUser(name,password,email,role,question,answer)" +
                        " values(@name,@password,@email,@role,@question,@answer)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@question", question);
                        cmd.Parameters.AddWithValue("@answer", answer);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        
                    }
                }
                MessageBox.Show("Added Succesfully");
            }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
        }
    }
}
