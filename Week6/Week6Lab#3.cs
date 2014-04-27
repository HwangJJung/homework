using System;

namespace Week6
{
	class MainClass
	{	
		static string input;
		private static bool OddChecker(){
			int a = input.Length;
			if (a%2 == 0) {
				return false;
			}else{
				return true;
			}
		}
		private static bool ReachHalfIndex(int n) {
			int a = (input.Length)/2;
			if (a == n) {
				return true;
			} else {
				return false;
			}
		}
		private static bool IsSameIndex(int n, int m) {
			if (n == m) {
				return true;
			} else {
				return false;
			}
		}

		private static bool IsSameChar(int n, int m)
		{
			if (input [n] == input [m]) {
				return true;
			} else {
				return false;
			}
		}

		private static bool PalindromeChecker(int n, int m) {
			if ( OddChecker()) {
				return OddPalindromeChecker (n, m);
			}else{
				return EvenPalindromeChecker (n, m);
			}
		}



		private static bool OddPalindromeChecker(int n, int m) {
			if (IsSameIndex (n, m)) {
				return true;
			} else {
				if (IsSameChar (n, m)) {
					return OddPalindromeChecker (n + 1, m - 1);
				} else {
					return false;
				}
			}
		}

		private static bool EvenPalindromeChecker(int n, int m) {
		
			if (ReachHalfIndex(n)) {
				return true;
			} else {
				if (IsSameChar (n, m)) {
					return EvenPalindromeChecker (n + 1, m - 1);
				} else {
					return false;
				}
			}
		}


		public static void Main (string[] args)
		{
			Console.Write (" Enter a word: ");
			input = Console.ReadLine ();

			int firstIndex = 0;
			int LastIndex = input.Length - 1;
			if (input.Length == 1) {
				Console.WriteLine ("'{0}' has only one alphabet. Plz Enter more than 2.", input);
			}else if (PalindromeChecker (firstIndex, LastIndex)) {
				Console.WriteLine ("'{0}' is Palidrome.", input);
			} else {
				Console.WriteLine ("'{0}' is not Palidrome.", input);
			}
		}



			}
}
