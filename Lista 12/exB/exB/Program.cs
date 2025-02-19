
using System;
using System.Collections.Generic;

namespace exB
{
	class Program
	{
		public static void Main(string[] args)
		{
			List<string> strings = new List<string>{"Vai", "Robá", "viado", "?"};
			
			foreach (string palavras in strings) {
				Console.Write("{0} ", palavras);
			}
			Console.ReadKey(true);
		}
	}
}