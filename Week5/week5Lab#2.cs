using System;

namespace dan
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int left = 1; left < 10; left++) {
				Console.WriteLine ("[{0} times table]", left);
				for (int right=1; right<10; right++){
					Console.WriteLine("{0} * {1} = {2}",left,right,left*right);
				}
				Console.Write("\n");
			}
		}
	}
}
