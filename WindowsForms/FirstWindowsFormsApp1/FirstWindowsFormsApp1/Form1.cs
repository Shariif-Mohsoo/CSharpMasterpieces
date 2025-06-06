using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsFormsApp1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = textBox1.Text;
            if(text == "")
            {
                MessageBox.Show("Hi Enter SomeThing In Input Box And Then Press Button.");
            }
            else
            {
                MessageBox.Show(text);
            }
        }
    }
}
