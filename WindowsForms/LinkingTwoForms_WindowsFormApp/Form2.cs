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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string nme,string pass)
        {
            InitializeComponent();
            //textBox1.Text = nme;
            //textBox2.Text = pass;
        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
