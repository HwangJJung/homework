using System;

namespace Week5Lab5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		Console.WriteLine ("Sausage Bun     Ketchup Mustard Onions  ");
			int i1, i2, i3, i4, i5 = 0;
			for (i1 = 0; i1 < 2; i1++) {
				i2 = 0;
				i3 = 0;
				i4 = 0;
				i5 = 0;
				for (i2 = 0; i2 < 2; i2++) {
					i3 = 0;
					i4 = 0;
					i5 = 0;
					for (i3 = 0; i3 < 2; i3++) {
						i4 = 0;
						i5 = 0;	
						for (i4 = 0; i4 < 2; i4++) {
							i5 = 0;
							for (i5 = 0; i5 < 2; i5++) {
								Console.Write ("{0}\t", i1);
								Console.Write ("{0}\t", i2);
								Console.Write ("{0}\t", i3);
								Console.Write ("{0}\t", i4);
								Console.Write ("{0}\t", i5);
								Console.WriteLine ("");
							}
						}
					}
				}
			}
		}
	}
}
