using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text.RegularExpressions;


namespace ConsoleApplication1
{
    [Serializable]
    class Student 
    {
        public string name; //{get;set;}
        public int a; //{get;set;}
        public int b;// { get; set;}

        public Student(string name, int a, int b)
        {
            this.name = name;
            this.a = a;
            this.b = b;
        }

 
    }



    class Program
    {

        static void Main(string[] args)
        {
            Stream ws = new FileStream("students.dat", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();

            List<Student> list = new List<Student>();


            list.Add(new Student("임정민", 2, 3));
            list.Add(new Student("윤영선", 2, 3));
            list.Add(new Student("최연규", 2, 3));
            list.Add(new Student("전다영글", 2, 3));
            list.Add(new Student("김영하", 2, 3));
            list.Add(new Student("김민주", 2, 3));
            list.Add(new Student("류선", 2, 3));
            list.Add(new Student("권다예", 2, 3));
            list.Add(new Student("심보희", 2, 3));
            list.Add(new Student("진유림", 2, 4));
            list.Add(new Student("황정민", 2, 4));
            list.Add(new Student("서동유", 2, 4));
            list.Add(new Student("하채영", 2, 4));
            list.Add(new Student("채종운", 2, 4));
            list.Add(new Student("정희수", 2, 4));
            list.Add(new Student("김희재", 2, 4));
            list.Add(new Student("양현석", 2, 4));
            list.Add(new Student("김혜원", 2, 4));
            list.Add(new Student("정서경", 2, 4));
            list.Add(new Student("서동규", 2, 4));
            list.Add(new Student("박찬진", 2, 5));
            list.Add(new Student("정덕현", 2, 5));
            list.Add(new Student("이재봉", 2, 5));
            list.Add(new Student("손명준", 2, 5));
            list.Add(new Student("이도형", 2, 5));
            list.Add(new Student("신윤서", 2, 5));
            list.Add(new Student("고예슬", 2, 5));

            serializer.Serialize(ws, list);
            ws.Close();

            string input = Console.ReadLine();

            Stream rs = new FileStream("students.dat", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();


            List<Student> list2 = new List<Student>();
            list2 = (List<Student>)deserializer.Deserialize(rs);
            rs.Close();



            if (Regex.IsMatch(input, @"\d\-\d"))
            {
                string[] inputs = input.Split('-');
                int vilnum = int.Parse(inputs[0]);
                int recnum = int.Parse(inputs[0]);

                var result = from student in list2
                             where student.a == vilnum
                             orderby student.name descending
                             select student
                             ;

                Student[] results = result.ToArray<Student>();
                foreach (Student student in result)
                {
                    Console.WriteLine(student.name);
                }

                //     try
                //     {
                //var[] results = result.ToArray<Student>();
                //  foreach(var student in results)
                //  {
                //     resultBox.Text =student.name+ "님이"+student.villageNumber+ 
                //          "-" + student.recoverNumber + "리버커에 거주 중입니다. \n";
                //     listView1.Items.Add(student.name);
                //  }
                //      }
                //   catch
                //    {   
                //  resultBox.Text ="정규식, 이상한 값을 넣으셨네요. 누군가의 이름이나 \'2-4\'와 같이 리커버로 검색해 보세요.";
                //    }
            }
            else
            {
                var result = from student in list2
                             where student.name == input
                             select student
                             ;
                //    try
                //      {

                Student[] results = result.ToArray<Student>();

                Console.WriteLine(results[0].a);
                //  }                           
            }
            Console.Read();
        }

    }
}
