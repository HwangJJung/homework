using System;

namespace Week4Lab3
{
	class MainClass
	{
		public static void Main (string[] args)
		{	int i = 0;
			int j = 0;
			while (i < 5) {
				j = 0;
				do {
					Console.Write ("*");
					j++;
				} while(j < i);
				Console.Write ("\n");
				i++;
			}
		}
	}
}
