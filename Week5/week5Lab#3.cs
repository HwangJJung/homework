using System;

namespace Week5Lab3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Random rNum = new Random ();
			int computer = rNum.Next (1, 99);
			int input;
			int count = 0;
			Console.WriteLine ("수를 맞춰보세요! 1 ~ 99 ");

			while(count < 6){
				input = int.Parse(Console.ReadLine() );
				if (input >= 1 && input <= 99) {
					if (input > computer) {
						Console.WriteLine ("Too High !!");
					} else if (input < computer) {
						Console.WriteLine ("Too Low !!");
					} else {
						Console.WriteLine ("축하합니다!! 컴퓨터의 숫자는 '{0}' 이었습니다!! \n {1} 번만에 맞추셨네요 !",input,count+1);
						break;
					}
					count++;
					if (count == 6) {
						Console.WriteLine ("6번이 다 끝났네요. 답은 '{0}' 이었습니다.", computer);
						Console.WriteLine ("다음번엔 꼭 성공하세요.");
						break;
					}
					Console.WriteLine ("{0}번 남았습니다. 흐흐", (6 - count));
					Console.WriteLine ("다른 수를 입력해보세요 !");
				} else {
					Console.WriteLine (" 1~99사이의 숫자로 다시 입력해주세요 !! ");
				}
			}


		}
	}
}
