using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10Lab_1
{
    public partial class Form1 : Form
    {
        private static int result = 0;
        private static Stack<int> leftNumber = new Stack<int>();
        private static Stack<int> rightNumber = new Stack<int>();
        private static bool operationClicked = false; 
        public Form1()
        {
            InitializeComponent();
        }

        private void SetNumber(string num)
        {
            if (operationClicked == false)
            {
                leftNumber.Push(int.Parse(num));
            }
            else
            {
                rightNumber.Push(int.Parse(num));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetNumber(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetNumber(button2.Text);
        
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SetNumber(button10.Text);
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetNumber(button10.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetNumber(button4.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
