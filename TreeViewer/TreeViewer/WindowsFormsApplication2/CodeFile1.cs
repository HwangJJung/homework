using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;


namespace WindowsFormsApplication2
{
    [Serializable]
    class Dragable
    {
        public Point location;

        public void Drag(Point location)
        {
            //  pictureBox1.Left = e.X + pictureBox1.Left - MouseDownLocation.X;
            // pictureBox1.Top = e.Y + pictureBox1.Top - MouseDownLocation.Y;

        }
    }

    [Serializable]
    class Student
    {
        public int  id;
        public string name;
        public int villageNumber; 
        public int recoverNumber;
 
        public Student (string name, int villageNumber, int recoverNumber, int id)
        {
            this.name = name;
            this.villageNumber = villageNumber;
            this.recoverNumber = recoverNumber;
            this.id = id;
        }

        public void ChangeSeat(int villageNumber, int recoverNumber)
        {
            this.villageNumber = villageNumber;
            this.recoverNumber = recoverNumber;
            
        }
    }
    [Serializable]
    class Desk 
    {

        public int id;
        public bool deskVertical; // false면 가로, true면 세로
        
        public Point location;
        public string studentName;
        public Size desksize;

        public Desk (int id , Point location, bool deskVertical, bool occupied )
        {
            this.id = id;
            this.location = location;
            this.deskVertical = deskVertical;
           
            if ( deskVertical == true)
            {             
                desksize = new System.Drawing.Size(55, 88);
            }
            else
            {           
                desksize = new System.Drawing.Size(88, 55);
            }
            this.studentName = " ";
        }
        public Desk(int id, int x,int y, bool deskVertical)
        {
            this.id = id;
            this.location.X = x;
            this.location.Y = y;
            this.deskVertical = deskVertical;
          
            if (deskVertical == true)
            {  
                desksize = new System.Drawing.Size(55, 88);
            }
            else
            {  
                desksize = new System.Drawing.Size(88, 55);
            }

            this.studentName = " ";
        }
        public Desk(int id, bool deskVertical)
        {
            this.id = id;
            this.location.X = 200;
            this.location.Y = 200;
            this.deskVertical = deskVertical;

            if (deskVertical == true)
            {
                desksize = new System.Drawing.Size(55, 88);
            }
            else
            {
                desksize = new System.Drawing.Size(88, 55);
            }

            this.studentName = " ";
        }
    }


    [Serializable]
    class Recover : Dragable
    {
        public int allDeskNum=0;
        public int leftDeskNum=0;
        public int name;
        public List<Desk> deskList = new List<Desk>();
        public List<Student> studentList = new List<Student>();

        public Recover(int name)
        {
            this.name = name;

        }

        public List<Student> PushStudentData(int v, int r)
        {
            Stream rs = new FileStream("students.dat", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            List<Student> list2 = new List<Student>();
                          list2 = (List<Student>)deserializer.Deserialize(rs);
                           rs.Close();

                       var  result = from student in list2
                                     where student.villageNumber == v
                                     where student.recoverNumber == r
                                     select student
                                     ;
                       List<Student> results = result.ToList<Student>();
                        return results;
        }

        public void initialize()
        {
            switch (name)
            {
                case 24:
                    {
                        allDeskNum = 22;
                        //   int deskWidth = 55;
                        //    int deskHeight = 88;

                        deskList.Add(new Desk(1, 100, 100, true));
                        deskList.Add(new Desk(2, true));
                        deskList.Add(new Desk(3, true));
                        deskList.Add(new Desk(4, true));
                        deskList.Add(new Desk(5, true));
                        deskList.Add(new Desk(6, true));
                        deskList.Add(new Desk(7, true));
                        deskList.Add(new Desk(8, true));
                        deskList.Add(new Desk(9, true));
                        deskList.Add(new Desk(10, true));
                        deskList.Add(new Desk(11, false));
                        deskList.Add(new Desk(12, false));
                        deskList.Add(new Desk(13, false));
                        deskList.Add(new Desk(14, false));
                        deskList.Add(new Desk(15, false));
                        deskList.Add(new Desk(16, false));
                        deskList.Add(new Desk(17, false));
                        deskList.Add(new Desk(18, false));
                        deskList.Add(new Desk(19, false));
                        deskList.Add(new Desk(20, false));
                        deskList.Add(new Desk(21, true));
                        deskList.Add(new Desk(22, true));

                        studentList = PushStudentData(2, 4);
                        leftDeskNum = allDeskNum - studentList.Count;
                        foreach (Desk d in deskList)
                        {
                            foreach (Student s in studentList)
                            {
                                if (d.id == s.id)
                                {

                                    d.studentName = s.name;
                                    break;
                                }
                            }
                        }
                        break;
                    }
                default:
                    { break; }
            }
        }
    }

    
}