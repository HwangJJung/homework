using System;

namespace Drawing
{
	class MainClass
	{
		private static void PrintTriangle(int floor,int unit, char word)
		{
			for (int outer = 1; outer <= floor; outer++) {
				for (int inner = 1; inner <= outer * unit; inner++) {
					Console.Write ("{0}",word);
				}
				Console.WriteLine ();
			}
			Console.WriteLine ();

		}
		public static void Main (string[] args)
		{
			PrintTriangle (3,1,'*');
			PrintTriangle (4,2,'#');
			PrintTriangle (8,4,'*');
		}
	}
}
