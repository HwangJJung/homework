using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        private Ellipse CreateEllipse()
        {
            Random random = new Random();
            int left = random.Next(50, 100);
            int top = random.Next(175, 225);
            int right = random.Next(400, 450);
            int bottom = random.Next(300, 350);

            return new Ellipse(left, top, right, bottom);
        }
        private Circle CreateCircle()
        {
            Random random = new Random();
            int left = random.Next(100, 200);
            int top = random.Next(100, 200);
            int right = random.Next(300, 350);
            int bottom = random.Next(250, 300);

            return new Circle(left, top,top-bottom,Brushes.GhostWhite);

        }
        private Square CreateSquare()
        {
            Random random = new Random();
            int left = random.Next(100, 200);
            int top = random.Next(100, 200);
            int right = random.Next(300, 350);
            int bottom = random.Next(250, 300);

            return new Square(left, top,bottom-top, Brushes.Silver);
        }
        private Triangle CreateTriangle()
        {
            Random random = new Random();
            int left = random.Next(100, 200);
            int top = random.Next(50, 100);
            int right = random.Next(400, 450);
            int bottom = random.Next(150, 200);

            return new Triangle(left,top,right,bottom);
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
        {}
        private void button1_Click(object sender, EventArgs e)
        {
            int switchExpression = comboBox1.SelectedIndex;
            Rectangle shape = new Rectangle();
            switch(switchExpression)
            {
                case 0:
                   shape = CreateRectangle();
                    break;
                case 1:
                   shape = CreateSquare();
                    break;
                case 2:
                    shape = CreateEllipse();
                    break;
                case 3:
                   shape = CreateCircle();
                    break;
                case 4:
                    shape = CreateTriangle();
                    break;
            }

           List<Rectangle> newList = new List<Rectangle>();
           foreach (Rectangle i in rectangles)
            {
                newList.Add(i);
            }
            newList.Add(shape);
            rectangles = newList.ToArray<Rectangle>();
            using (Graphics g = this.CreateGraphics())
            {
                rectangles[rectangles.Length-1].Show(g);
            }
            
 
        }
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { }

    }
}
