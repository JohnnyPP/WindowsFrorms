using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String test, test2;
            //MessageBox.Show("Hello World");
            test=textBox1.Text;
            test2 = test;
            textBox2.Text = test2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //double dTest;
            textBox4.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) + 4);
           
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
