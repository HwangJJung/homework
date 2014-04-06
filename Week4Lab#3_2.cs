using System;

namespace Week4Lab3_2
{
	class MainClass
	{
		public static void Main (string[] args)
		{	int i = 5;
			int j = 0;
			while (i > 0) {
				j = 0;
				do {
					Console.Write("*");
					j++;
				} while(j < i);
				Console.Write ("\n");
				i--;
			}
		}
	}
}
