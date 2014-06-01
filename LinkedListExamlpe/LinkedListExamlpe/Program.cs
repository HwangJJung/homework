using System;
using System.Collections;
using System.Collections.Generic;


namespace ListExample {

	class MainClass {
		class Term{
			public double coef;
			public int exp;
			public Term next;
			public Term prev;
		}

		class Polynomial{
			public Term first;
			public Polynomial (){
				first = null;
			}
			
			public void AddTerm(double coef, int exp) {
				Term t = new Term();
				t.coef = coef;
				t.exp = exp;
				if (first == null) {
					first = t;
					t.next = null;
				} else {
					t.next = first;
					first = t;
				}
			}
			public void DeleteTerm(Term t) {
				t.coef = 0;
			}

			public void PrintPoly(){
				for (Term t = first; t != null; t = t.next) {
					Console.Write ("+");
					Console.Write("({0} x^{1})", t.coef, t.exp);

				}
				Console.WriteLine ();
			}
			public Polynomial Simplify() {
				Polynomial res = new Polynomial ();
				for ( Term t = first; t != null; t=t.next){
			
					int exp= t.exp;
					double coef = t.coef;

					for (Term s = t.next; s != null; s=s.next) {
						if (s.exp == exp) {
							coef += s.coef;
							DeleteTerm (s);
						}
					}
					res.AddTerm (coef, exp);
				}
				return res;
			}
		static void Main() {
				Polynomial p = new Polynomial ();
				p.AddTerm (1, 2);
				p.AddTerm (-1, 1);
				p.AddTerm (-1, 1);
				p.AddTerm (1, 0);

				p.PrintPoly ();
				Polynomial s = p.Simplify ();
				s.PrintPoly ();
			}
		}
	}
}