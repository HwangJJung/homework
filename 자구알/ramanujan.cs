using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{       
	class MainClass
	{
		//세제곱 시키는 함수 
		
		private static int Cube(int i)
		{
			i = i*i*i;
			return i;
		}

		public static void Main (string[] args)
		{
			int[] cube = new int[100];
			List<int> resultList = new List<int> ();

			for (int i =1; i<=100; i++){
				cube.SetValue (Cube(i), i-1);
			}
			for ( int i=0; i<100; i++ ) {
				for ( int j = i+1; j < 100; j++) {
					resultList.Add (cube[i] + cube[j]);
				}
			}
			resultList.Sort ();
			for ( int i=0; i < 500; i++) {
				if (resultList[i] == resultList[i+1]) {
					Console.WriteLine( resultList[i]);
				}
			}
            Console.ReadLine();
		}
		
	}
}