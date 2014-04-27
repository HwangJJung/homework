using System;

namespace Week6Lab1
{
	class MainClass
	{
		public static void Main (string[] args)
		{   Intro ();
			String name = SetName();
			int[] numbers = GetRandomNumbers ();
			ResultView (name,numbers);
		}



		private static void Intro()
		{
			Console.WriteLine ("**********************************");
			Console.WriteLine ("******** Lottery Numbers *********"); 
			Console.WriteLine ("**********************************");
		}


		private static string SetName()
		{
			string name;
			Console.Write ("Enter your name: ");
			name = Console.ReadLine ();
			return name;
		}

		private static int[] GetRandomNumbers()
		{
			int[] numbers = new int[6];
			int index = 0;
			Random random = new Random ();
			do {
				int randomNumber = random.Next (1, 46);
				for (int loop = 0; loop <= index; loop++) {
					if (numbers [index] == randomNumber) {
						break;
					} 
				}
				if (numbers [index] != randomNumber) {
					numbers [index] = randomNumber;
					index++;
				}
			} while (index < numbers.Length);

			return numbers;
		}

		private static void ResultView(string name, int[] numbers) {

			Console.Write ("Name : {0}, Numbers : [", name); 
			foreach(int number in numbers)
			{
				Console.Write ("{0} ", number);
			}
			Console.WriteLine ("]");
		}


	}
}