using System;

namespace Week4
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.Write("plz type the first number: ");
			int first = int.Parse(Console.ReadLine());
			Console.Write("plz type the second number: ");
			int second = int.Parse(Console.ReadLine());

			Console.Write("plz type operation +,-,*,/,%: ");
			string operation = Console.ReadLine ();

			switch (operation) {
			case "+":	
				Console.WriteLine (" {0} + {1} = {2}", first, second, first + second);
				break;
			case "-":	
				Console.WriteLine (" {0} - {1} = {2}", first, second, first - second);
				break;
			case "*":	
				Console.WriteLine (" {0} * {1} = {2}", first, second, first * second);
				break;
			case "/":	
				Console.WriteLine (" {0} / {1} = {2}", first, second, first / second);
				break;
			case "%":	
				Console.WriteLine (" {0} % {1} = {2}", first, second, first % second);
				break;
			default:
				Console.WriteLine (" plz type +,-,*,/,% !! ");
				break;
			}
		}
	}
}
