using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10_Lab1
{
    public partial class Form1 : Form
    {
        private static int leftNumber = 0;
        private static int rightNumber = 0;
        private void SetNumber(string num)
        {
                if (textBox1.Text=="+")
                {
                    textBox1.Text = "";
                }
                
                textBox1.Text = textBox1.Text + num; 
                
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            leftNumber = 0;
            rightNumber = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetNumber(button1.Text); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetNumber(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetNumber(button3.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+")
            { }
            else
            {
                leftNumber = int.Parse(textBox1.Text);
                textBox1.Text = button5.Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            rightNumber = int.Parse(textBox1.Text);
            int result = leftNumber + rightNumber;
            textBox1.Text = result.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SetNumber(button9.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SetNumber(button8.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SetNumber(button7.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SetNumber(button12.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SetNumber(button11.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SetNumber(button10.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SetNumber(button13.Text);
        }
    }
}
