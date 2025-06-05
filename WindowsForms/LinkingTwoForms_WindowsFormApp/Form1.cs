using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nme = name.Text;
            string pass = password.Text;
            this.Close();
            //Form2 form = new Form2(nme,pass);
            //check this mohsoo
            Form2 form = new Form2();
            form.textBox1.Text = nme;
            form.textBox2.Text = pass;
            form.Show();
            //MessageBox.Show("Name: " + nme);
            //MessageBox.Show("Password: " + pass);
            
        }
    }
}
