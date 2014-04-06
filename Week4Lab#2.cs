using System;

namespace Week4Lab2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int i = 5; i > 0; i--) {
				for (int j = 0; j < i; j++) {
					Console.Write ("*");
				}
				Console.Write ("\n");
			}

		}
	}
}
