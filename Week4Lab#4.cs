using System;

namespace Week4Lab4
{
	class MainClass
	{
		public static void Main (string[] args)
		{	
			int input;
			do{
				Console.Write("반복횟수를 입력하세요 : ");
				input = int.Parse(Console.ReadLine() );
					if (input >0) {
						break;
					}
					else{
						Console.WriteLine ("0보다 작거나 같은 수는 입력할 수 없습니다.");
					}
				}while(true);

			for (int i = 0; i < input; i++) {
				for (int j = 0; j <= i; j++) {
					Console.Write ("*");
				}
				Console.Write ("\n");
			}

		}
	}
}
