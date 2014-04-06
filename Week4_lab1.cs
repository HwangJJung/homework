using System;

namespace week4Lab1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int i = 0; i < 5; i++) {
				for (int j = 0; i >= j; j++) {
					Console.Write ("*");
				}
				Console.Write ("\n");
			}
		}
	}
}
