using System;

namespace Week5Lab4
{
	class MainClass
	{	
		public static void NumberRead(ref int x ,ref int y) {
			Console.Write ("Enter the first number : ");
			x = int.Parse(Console.ReadLine());
			Console.Write ("Enter the second number : ");
			y = int.Parse(Console.ReadLine());
		}



		public static void Main (string[] args)
		{
			Boolean retry = true;
			int first = 0;
			int second = 0;
			while (retry == true) {
				Console.Write("Enter the operation[+,-,*,/](If you want to quit, enter 'q'): ");
				String input = Console.ReadLine();
				if (input == "q") {
					retry = false;
				} else {
					switch (input) {
					case "+":
						NumberRead (ref first, ref second);
						Console.WriteLine ("Result : {0}", first + second);
						break;
					case "-":
						NumberRead (ref first, ref second);
						Console.WriteLine ("Result : {0}", first - second);
						break;
					case "*":
						NumberRead (ref first, ref second);
						Console.WriteLine ("Result : {0}", first * second);
						break;
					case "/":
						NumberRead (ref first, ref second);
						Console.WriteLine ("Result : {0}", first / second);
						break;
					default :
						Console.WriteLine ("You entered wrong operation. Only +,-,*,/,q are allowed!");
						break;
					}
					Console.WriteLine ("");
				}
			}
			Console.WriteLine ("Bye!");
		}
	}
}
