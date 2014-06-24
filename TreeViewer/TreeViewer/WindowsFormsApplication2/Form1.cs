using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private Point MouseDownLocation;
        private int currentRecover = 0;
        List<Panel> pnList = new List<Panel>();
         
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Stream ws = new FileStream("students.dat", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();

            List<Student> list = new List<Student>();

            list.Add(new Student("조영호", 1, 2, 5));
            list.Add(new Student("변지민", 3, 8, 1));
            list.Add(new Student("하태호", 1, 2, 2));
            list.Add(new Student("임정민", 2, 3, 3));
            list.Add(new Student("윤영선", 2, 3, 4));
            list.Add(new Student("최연규", 2, 3, 5));
            list.Add(new Student("전다영글", 2, 3, 6));
            list.Add(new Student("김영하", 2, 3, 7));
            list.Add(new Student("김민주", 2, 3, 8));
            list.Add(new Student("류선", 2, 3, 9));
            list.Add(new Student("권다예", 2, 3, 10));
            list.Add(new Student("심보희", 2, 3, 11));
            list.Add(new Student("진유림", 2, 4,1));
            list.Add(new Student("채종운", 2, 4,2));
            list.Add(new Student("정희수", 2, 4,3));
            list.Add(new Student("김혜원", 2, 4, 4));
            list.Add(new Student("김승환", 2, 4, 5));
            list.Add(new Student("황정민", 2, 4, 11));
            list.Add(new Student("서동유", 2, 4, 12));
            list.Add(new Student("하채영", 2, 4, 13));
            list.Add(new Student("김희재", 2, 4,14));
            list.Add(new Student("양현석", 2, 4,15));
            list.Add(new Student("정서경", 2, 4,16));
            list.Add(new Student("서동규", 2, 4,17));
          
           
           
         
            list.Add(new Student("박찬진", 2, 5,0));
            list.Add(new Student("정덕현", 2, 5,1));
            list.Add(new Student("이재봉", 2, 5,2));
            list.Add(new Student("손명준", 2, 5,3));
            list.Add(new Student("이도형", 2, 5,4));
            list.Add(new Student("신윤서", 2, 5,5));
            list.Add(new Student("고예슬", 2, 5,6));
            
            serializer.Serialize(ws, list);
            ws.Close();
           /*  초기화 코드

                Stream ws2 = new FileStream("recovers.dat", FileMode.Create);
                BinaryFormatter serializer2 = new BinaryFormatter();


                Recover[] recoverArray = new Recover[6] 
                { 
                new Recover(11),new Recover(12), new Recover(23),
                new Recover(24),new Recover(25),new Recover(26) 
                };
            
                foreach (Recover r in  recoverArray)
                {
                    r.initialize();
                }

                serializer2.Serialize(ws2, recoverArray);
                ws2.Close();
             
            */

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //이름 중복 가능성 고려안함.
        private void Search_Btn_Click(object sender, EventArgs e)
        {
            listView1.Clear();

            string input = Search_Text.Text;

            Stream rs = new FileStream("students.dat", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();


            List<Student> list2 = new List<Student>();
            list2 = (List<Student>)deserializer.Deserialize(rs);
            rs.Close();



            //리커버에 대한 검색
            if (Regex.IsMatch(input, @"\d\-\d|\d\-\d+ *"))
            {
                string[] inputs = input.Split('-');
                int vilnum = int.Parse(inputs[0]);
                int recnum = int.Parse(inputs[1]);

                var result = from student in list2
                             where student.villageNumber == vilnum
                             select student
                             ;

                try
                {
                    Student[] results = result.ToArray<Student>();

                    for (int i = 0; i < results.Length; i++)
                    {
                        if (recnum == results[i].recoverNumber)
                        { listView1.Items.Add(results[i].name); }
                    }
                }

                catch
                {
                    resultBox.Text = "정규식, 이상한 값을 넣으셨네요. 누군가의 이름이나 \'2-4\'와 같이 리커버로 검색해 보세요.";
                }
            }
            // 사람에 대한 검색
            else
            {

                var result = from student in list2
                             where student.name == input
                             select student;
                try
                {
                    Student[] results = result.ToArray<Student>();
                    resultBox.Text = results[0].name + " 님은 " + results[0].villageNumber +
                            "-" + results[0].recoverNumber + " 리커버에 거주 중입니다. \n";
                    string vilrec = results[0].villageNumber.ToString() + results[0].recoverNumber.ToString();
                    switch (int.Parse(vilrec))
                    {
                        case 24:
                            {
                                vil2_panel.Enabled = true;
                                vil2_panel.Visible = true;
                                RecoverBuilder(2, 4);
                                break;
                            }
                    }

                    for ( int i = 0; i < pnList.Count; i++)
                    {
                        if (pnList[i].Controls[0].Text == results[0].name)
                        {
                            pnList[i].BorderStyle = BorderStyle.Fixed3D;
                           
                            break;
                        }
                    }

                }
                catch
                {
                    resultBox.Text = "이상한 값을 넣으셨네요. 누군가의 이름이나 \'2-4\'와 같이 리커버로 검색해 보세요.";
                }

            }
        }
        private void RecoverBuilder(int v, int r)
        {
            rec24_map.Enabled = true;
            rec24_map.Visible = true;
            int vilrecNumber = int.Parse(v.ToString() + r.ToString());
            currentRecover = vilrecNumber;

            Stream rs = new FileStream("recovers.dat", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            Recover[] recoverarr = new Recover[6];
            recoverarr = (Recover[])deserializer.Deserialize(rs);
            rs.Close();
            DeskAdd1to18();
            Recover thisRecover = new Recover(0);
            switch(vilrecNumber)
            {
                case 24:
                    {                 
                        rec24_map.Top = 0;
                        rec24_map.Left = 0;
                        thisRecover = recoverarr[3];
                        pnList.Add(Desk19_panel);
                        pnList.Add(Desk20_panel);
                        pnList.Add(Desk21_panel);
                        pnList.Add(Desk22_panel);
                        break;
                    }
            }

            //resultBox.Text = thisRecover.leftDeskNum.ToString() + "자리 남아있습니다.";

            for (int i = 0; i < pnList.Count; i++)
            {
                pnList[i].Visible = true;

                pnList[i].Location = thisRecover.deskList[i].location;
                pnList[i].Size = thisRecover.deskList[i].desksize;
                pnList[i].Controls[0].Text = thisRecover.deskList[i].studentName;
                pnList[i].Controls[0].Height = pnList[i].Size.Height - 20;
                pnList[i].Controls[0].Width = pnList[i].Size.Width - 30;

                if (thisRecover.deskList[i].deskVertical == true)
                {
                    pnList[i].BackgroundImage = Properties.Resources.SeroDesk;
                }
                else
                {
                    pnList[i].BackgroundImage = Properties.Resources.GaroDesk;
                }
            }

        }
        private void DeskAdd1to18()
        {
            pnList.Clear();
            pnList.Add(desk1_panel);
            pnList.Add(desk2_panel);
            pnList.Add(desk3_panel);
            pnList.Add(desk4_panel);
            pnList.Add(Desk5_panel);
            pnList.Add(Desk6_panel);
            pnList.Add(Desk7_panel);
            pnList.Add(Desk8_panel);
            pnList.Add(Desk9_panel);
            pnList.Add(Desk10_panel);
            pnList.Add(Desk11_panel);
            pnList.Add(Desk12_panel);
            pnList.Add(Desk13_panel);
            pnList.Add(Desk14_panel);
            pnList.Add(Desk15_panel);
            pnList.Add(Desk16_panel);
            pnList.Add(Desk17_panel);
            pnList.Add(Desk18_panel);
        }

        private void rec24_panel_Click(object sender, EventArgs e)
        {
            RecoverBuilder(2, 4);
          
        }

        private void rec24_panel_MouseDown(object sender, MouseEventArgs e)
        {
            rec24_panel.BackColor = Color.LightGray;
        }

        private void rec24_panel_MouseUp(object sender, MouseEventArgs e)
        {
            rec24_panel.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            timer1.Start();
            pnList.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while (rec24_map.Top > -600)
            { rec24_map.Top = rec24_map.Top - 100; }
            timer1.Stop();

        }

        private void village2_Click(object sender, EventArgs e)
        {
            vil2_panel.Enabled = true;
            vil2_panel.Visible = true;
        }
        //이름 중복 가능성 고려안함.
        private void edit_btn_Click(object sender, EventArgs e)
        {

            Stream rs = new FileStream("recovers.dat", FileMode.Open);
            BinaryFormatter Deserializer = new BinaryFormatter();
            Recover[] Recoverarray = new Recover[6];
            Recoverarray = (Recover[])Deserializer.Deserialize(rs);
            rs.Close();

            Recover a;

            for (int i = 0; i <= Recoverarray.Length; i++)
            {
                if (Recoverarray[i].name == currentRecover)
                {
                    a = Recoverarray[i];
                    for (int j = 0; j < pnList.Count; j++)
                    {
                        a.deskList[j].location = pnList[j].Location;
                        a.deskList[j].studentName = pnList[j].Controls[0].Text;
                    }
                    Recoverarray[i] = a;
                    break;
                }
            }
            Stream ws = new FileStream("recovers.dat", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(ws, Recoverarray);
            ws.Close();
        }

        private void 도회전하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void DragMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left) // 왼쪽 버튼만 드래그 가능
            {
                MouseDownLocation = e.Location;
            }
        }
        private void DragMouseMove(Panel pn, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pn.Left = e.X + pn.Left - MouseDownLocation.X;
                pn.Top = e.Y + pn.Top - MouseDownLocation.Y;
            }
        }

        private void desk1_panel_MouseMove(object sender, MouseEventArgs e)
        {       
               DragMouseMove(desk1_panel, e);      
        }
      

        private void desk2_panel_MouseMove(object sender, MouseEventArgs e)
        {
            DragMouseMove(desk2_panel, e);
        }

        private void desk3_panel_MouseMove(object sender, MouseEventArgs e)
        {
            DragMouseMove(desk3_panel, e);
        }

        private void desk4_panel_MouseMove(object sender, MouseEventArgs e)
        {
            DragMouseMove(desk4_panel, e);
        }

        private void Desk5_panel_MouseMove(object sender, MouseEventArgs e)
        {
            DragMouseMove(Desk5_panel, e);
        }

        private void Desk6_panel_MouseMove(object sender, MouseEventArgs e)
        {
            DragMouseMove(Desk6_panel, e);
        }

        private void Desk7_panel_MouseMove(object sender, MouseEventArgs e)
        {
            DragMouseMove(Desk7_panel, e);
        }

        private void Desk8_panel_MouseMove(object sender, MouseEventArgs e)
        {
            DragMouseMove(Desk8_panel, e);
        }

        private void Desk9_panel_MouseMove(object sender, MouseEventArgs e)
        {
            DragMouseMove(Desk9_panel, e);
        }
        private void Desk10_panel_MouseMove(object sender, MouseEventArgs e)
        {
            DragMouseMove(Desk10_panel, e);
        }
     
        private void Desk11_panel_MouseMove(object sender, MouseEventArgs e)
        {
            DragMouseMove(Desk11_panel, e);
        }

        private void Desk12_panel_MouseMove(object sender, MouseEventArgs e)
        {
            DragMouseMove(Desk12_panel, e);
        }

        private void Desk13_panel_MouseMove(object sender, MouseEventArgs e)
        {
            DragMouseMove(Desk13_panel, e);
        }

        private void Desk14_panel_MouseMove(object sender, MouseEventArgs e)
        {
            DragMouseMove(Desk14_panel, e);
        }

        private void Desk15_panel_MouseMove(object sender, MouseEventArgs e)
        {
            DragMouseMove(Desk15_panel, e);
        }

        private void Desk16_panel_MouseMove(object sender, MouseEventArgs e)
        {
            DragMouseMove(Desk16_panel, e);
        }

        private void Desk17_panel_MouseMove(object sender, MouseEventArgs e)
        {
            DragMouseMove(Desk17_panel, e);
        }

        private void Desk18_panel_MouseMove(object sender, MouseEventArgs e)
        {
            DragMouseMove(Desk18_panel, e);
        }

        private void Desk19_panel_MouseMove(object sender, MouseEventArgs e)
        {
            DragMouseMove(Desk19_panel, e);
        }

        private void Desk20_panel_MouseMove(object sender, MouseEventArgs e)
        {
            DragMouseMove(Desk20_panel, e);
        }

        private void Desk21_panel_MouseMove(object sender, MouseEventArgs e)
        {
            DragMouseMove(Desk21_panel, e);
        }

        private void Desk22_panel_MouseMove(object sender, MouseEventArgs e)
        {
            DragMouseMove(Desk22_panel, e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TextBox[] tbBoxes = new TextBox[22]
            {
                desk1_text,
                desk2_text,
                desk3_text,
                textBox1,
                textBox2,
                textBox3,
                textBox4,
                textBox5,
                textBox6,
                textBox7,
                textBox8,
                textBox9,
                textBox10,
                textBox11,
                textBox12,
                textBox13,
                textBox14,
                textBox15,
                textBox16,
                textBox17,
                textBox18,
                textBox19
            };
            if (desk1_text.Enabled == false)
            {
                foreach (TextBox t in tbBoxes)
                {
                    t.Enabled = true;
                    
                    
                
                }
            }
            else
            {
                foreach (TextBox t in tbBoxes)
                {
                   
                    t.Enabled = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vil2_panel.Enabled = false;
            vil2_panel.Visible = false;
            rec24_map.Enabled = false;
            rec24_map.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rec24_map.Enabled = false;
            rec24_map.Visible = false;
        }

        private void rec24_map_VisibleChanged(object sender, EventArgs e)
        {
            if (rec24_map.Visible == true)
            {
                name_btn.Enabled = true;
                save_btn.Enabled = true;
                button5.Enabled = true;
            }
            else
            {
                name_btn.Enabled = false;
                save_btn.Enabled = false;
                button5.Enabled = false;
            }
        }

    
     

    }
}
