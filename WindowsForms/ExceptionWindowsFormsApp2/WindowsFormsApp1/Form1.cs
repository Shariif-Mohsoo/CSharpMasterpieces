using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    // creating the exception class
    public class validateInput : Exception
    {
        public validateInput(string error) : base(error) { }
    }
    public partial class Form1 : Form
    {
        public void userInputValidate()
        {
            if(maskedTextBox1.Text == ""  || maskedTextBox2.Text=="")
            {
                throw new validateInput("Please fill all fields");
            }
            else
            {
                MessageBox.Show("Okaz good work");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.userInputValidate();
            }
            catch(validateInput ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Jul Daffa Hoo");
                Application.Exit();
            }
        }
    }
}
