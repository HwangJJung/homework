using System;

namespace Lab3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string greeting = "Hello, ";
			string name = "황정민";
			string result = greeting + name;

			Console.WriteLine ("{0} - 글자수: {1}", result, result.Length);
		}
	}
}
