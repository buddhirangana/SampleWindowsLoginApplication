using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleLoginWindowsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show(this, "Please Enter UserName and Password");
                return;
            }
            else if (textBox1.Text == "User" & textBox2.Text == "Password")
            {
                MessageBox.Show(this, "Login Successful!");
                this.Hide();
                Form2 fm = new Form2();
                fm.Show();
            }
            else
            {
                MessageBox.Show(this, "Login Failed!");
            }
        }
    }
}
