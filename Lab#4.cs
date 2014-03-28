using System;

namespace Lab4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Type the first num: ");
			string value1 = Console.ReadLine ();
			Console.WriteLine ("Type the second num: ");
			string value2 = Console.ReadLine ();
			int result = int.Parse(value1) + int.Parse(value2);
			Console.WriteLine ("num1: {0}, num2: {1}, sum: {2}", value1, value2, result);
		}
	}
}
