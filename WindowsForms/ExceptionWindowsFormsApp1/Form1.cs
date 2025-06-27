using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionWindowsFormsApp2
{

    public class passwordException:Exception
    {
       public passwordException(string message):base(message) { }
    }

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void check_data()
        {
            string usr = textBox1.Text;
            int pass ;
            if (int.TryParse(textBox2.Text, out pass))
            {
                MessageBox.Show("Valid Input");
            } else
            {
                throw new passwordException(textBox2.Text + "should be number");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.check_data();
            }
            catch(passwordException ex)
            {
                MessageBox.Show("Error Catched: "  + ex.Message);
            }
            finally
            {
                MessageBox.Show("Done");
            }
            
        }
    }
}
