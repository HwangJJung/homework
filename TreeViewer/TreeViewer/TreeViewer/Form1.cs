using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TreeViewer
{
    public partial class Form1 : Form
    {
        private int cell = 0;
        bool first = true;
        List<Student> Students = new List<Student>();
        private Bitmap node = Properties.Resources.node_small_2;
        private Bitmap movingchiyo = Properties.Resources.longnode_01;
        Student s = new Student(0, new Point(1000, 1000));
        public Form1()
        {
            InitializeComponent();
            InitializeStudent();
            
        }
     


        private void InitializeStudent()
        {
   
            Students.Add(s);
        }
      
        private void tree_panel_Paint(object sender, PaintEventArgs e)
        {
           
         
        }

        private void TreeViewer_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_normal_MouseEnter(object sender, EventArgs e)
        {
            btn_add_hover.Visible = true;
        }

        private void btn_add_normal_MouseLeave(object sender, EventArgs e)
        {
            btn_add_hover.Visible = false;
        }

        private void btn_add_normal_MouseDown(object sender, MouseEventArgs e)
        {
            btn_add_clicked.Visible = true;
        }

        private void btn_add_normal_MouseUp(object sender, MouseEventArgs e)
        {
            btn_add_clicked.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_normal_Click(object sender, EventArgs e)
        {
            same_error_label.Visible = false;
            int id = (int)numericUpDown1.Value;

            if ( id == 2212)
            {
                Long_Animate_Timer.Start();
            }
            else if (id == 7324)
            {
                Long_Animate_Timer.Stop();
            }
            if (first == true)
            {
                s = new Student(id);
                first = false;
            }
            else
            {
                s.Add(new Student(id));
            }
            numericUpDown1.Value = 0;

        }
 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Long_Animate_Timer_Tick(object sender, EventArgs e)
        {
            cell++;
            switch (cell)
            {
                case 1:
                    movingchiyo = Properties.Resources.longnode_01;
                    break;
                case 2:
                    movingchiyo = Properties.Resources.longnode_02;
                    break;
                case 3:
                    movingchiyo = Properties.Resources.longnode_03;
                    break;
                case 4:
                    movingchiyo = Properties.Resources.longnode_04;
                    break;
                case 5:
                    movingchiyo = Properties.Resources.longnode_03;
                    break;
                case 6:
                    movingchiyo = Properties.Resources.longnode_02;
                    break;
          
                default:
                    movingchiyo = Properties.Resources.longnode_01;
                    cell = 0;
                    break;
            }
            Invalidate();
          
        }

        private void tree_panel_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Students.Clear();
            PrintSubtree(s,0,0);
            
            foreach (Student student in Students)
            {
                e.Graphics.DrawImage(node, student.Location.X, student.Location.Y, node.Width, node.Height);
                e.Graphics.DrawString(student.id.ToString(),
                  new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)))
                , Brushes.Black, student.Location.X + 10, student.Location.Y + 40);
            
          
                //e.Graphics.FillEllipse(Brushes.White, star.Location.X, star.Location.Y, star.Speed, star.Speed);
            }
             
               e.Graphics.DrawImage(movingchiyo, 700, 510, movingchiyo.Width, movingchiyo.Height);

          
        }
        
        private void PrintSubtree(Student s,int level, int row)
        {
            int x = 600 - (row*60);
            int y = 20;
           
            if (s.left != null)
            {
            PrintSubtree(s.left,level+1,row);
            }
            
            for(int i = 0; i < level; i++)
            {             
               y +=  100;
               x += 50;
            }
         
            Students.Add(new Student(s.id, new Point(x, y)));
            row++;
           if (s.right != null)
            {
               PrintSubtree(s.right, level + 1,row);
            }
           
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btn_del_normal_MouseEnter(object sender, EventArgs e)
        {
            btn_del_hover.Visible = true;
        }

        private void btn_del_normal_MouseDown(object sender, MouseEventArgs e)
        {
            btn_del_clicked.Visible = true;
        }

        private void btn_del_normal_MouseLeave(object sender, EventArgs e)
        {
            btn_del_hover.Visible = false;
        }

        private void btn_del_normal_MouseUp(object sender, MouseEventArgs e)
        {
            btn_del_clicked.Visible = false;
        }

        private void btn_del_normal_Click(object sender, EventArgs e)
        {
            int id = (int)numericUpDown1.Value;
            s.Remove(id);
        }


       
       

    }
}
