using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace GUIRectangle
{
    public partial class Form1 : Form
    {
        private Rectangle CreateRectangle()
        {
            Random random = new Random();
            int left = random.Next(1, 100);
            int top = random.Next(1, 100);
            int right = random.Next(300, 350);
            int bottom = random.Next(200, 300);

            return new Rectangle(left, top, right, bottom);
        }

        private Rectangle[] rectangles = new Rectangle[] 
         { 

         new Rectangle(10, 10, 100, 100), 

         new Square(200, 100, 70, Brushes.Silver), 

         new Rectangle(150, 300, 120, 120), 

         new Square(100, 100, 20, Brushes.Black) 

         }; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                foreach (Rectangle rectangle in rectangles)
                {
                   rectangle.Show(g);
                }
            }
        }
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
           Rectangle rectangle = CreateRectangle();
           Rectangle temp = new Rectangle();
           List<Rectangle> newList = new List<Rectangle>();
           foreach (Rectangle i in rectangles)
            {
                newList.Add(i);
            }
            
            newList.Add(rectangle);
            rectangles = newList.ToArray();
           
            OnPaint(null);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
