using System;

namespace Loop
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int i=0; i<5; i++) {
				for (int j = 0; j <= i; j++) {
					Console.Write ("*");
				}
				Console.Write ("\n");
			}
		}
	}
}
