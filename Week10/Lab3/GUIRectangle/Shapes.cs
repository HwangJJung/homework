using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using System.Collections;

namespace GUIRectangle
{ 
    class Rectangle
    {
        protected Point LeftTop;
        protected Point RightBottom;

        public Rectangle() : this(0, 0)
        {
        }
        public Rectangle(int Left, int Top) : this(Left, Top, Left + 100, Top + 100)
        {
        }
        public Rectangle(int Left, int Top, int Right, int Bottom)
        {
            this.LeftTop = new Point(Left, Top);
            this.RightBottom = new Point(Right, Bottom);
        }

       

        public virtual void Show(Graphics g)
        {
            g.FillRectangle(Brushes.SkyBlue,

              LeftTop.X, LeftTop.Y,

              RightBottom.X - LeftTop.X, RightBottom.Y - LeftTop.Y);

            g.DrawRectangle(Pens.Black,

            LeftTop.X, LeftTop.Y,

            RightBottom.X - LeftTop.X, RightBottom.Y - LeftTop.Y); 

        }
        
     }

     class Square : Rectangle
     {
        private Brush Color;

        public Square(int Left, int Top, int Width , Brush Color) : base(Left, Top, Left + Width, Top + Width)
        {
            this.Color = Color;
        }

        public override void Show(Graphics g)
        {
            g.FillRectangle(Color,

              LeftTop.X, LeftTop.Y,

              RightBottom.X - LeftTop.X, RightBottom.Y - LeftTop.Y);

            g.DrawRectangle(Pens.Black,

            LeftTop.X, LeftTop.Y,

            RightBottom.X - LeftTop.X, RightBottom.Y - LeftTop.Y); 

        }
     }
    class Ellipse : Rectangle
    {
        protected Brush Color;
        public Ellipse() : this (0,0)
        {}
        public Ellipse(int Left, int Top) : this(Left, Top, Left + 100, Top + 100)
        {}
        public Ellipse(int Left, int Top, int Right, int Bottom)
        {
            this.LeftTop = new Point(Left, Top);
            this.RightBottom = new Point(Right, Bottom);
        }
        public override void Show(Graphics g)
        {
            g.FillEllipse(Brushes.DarkMagenta, LeftTop.X, LeftTop.Y,

             RightBottom.X - LeftTop.X, RightBottom.Y - LeftTop.Y);

            g.DrawEllipse(Pens.Black,

         LeftTop.X, LeftTop.Y,

         RightBottom.X - LeftTop.X, RightBottom.Y - LeftTop.Y);

        }
    }
    class Circle : Ellipse
    {
        public Circle(int Left, int Top, int Width, Brush Color)
            : base(Left, Top, Left + Width, Top + Width)
        {
            this.Color = Color;
        }
        public override void Show(Graphics g)
        {
            g.FillEllipse(Color,

              LeftTop.X, LeftTop.Y,

              RightBottom.X - LeftTop.X, RightBottom.Y - LeftTop.Y);

            g.DrawEllipse(Pens.Black,

            LeftTop.X, LeftTop.Y,

            RightBottom.X - LeftTop.X, RightBottom.Y - LeftTop.Y);
          
        }
    }
    class Triangle : Rectangle
    {
        private Point LeftBottom;
        Point[] points = new Point[3];
        public Triangle (int Left,int Top,int Right,int Bottom)
        {
            this.LeftTop = new Point(Left, Top);
            this.RightBottom = new Point(Right, Bottom);
            this.LeftBottom = new Point(Left, Bottom);
            points[0] = LeftTop;
            points[1] = RightBottom;
            points[2] = LeftBottom;
          }

        
        public override void Show(Graphics g)
        {   
            g.FillPolygon(Brushes.ForestGreen,points);

            g.DrawPolygon(Pens.Black, points);
        }
    }
}
