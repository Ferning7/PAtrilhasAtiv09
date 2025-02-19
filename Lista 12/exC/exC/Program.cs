
using System;
using System.Collections.Generic;

namespace exC
{
	class Program
	{
		public static void Main(string[] args)
		{
			List<int> inteiros = new List<int>{10, 15, 20, 25, 30, 35};
			
			int maior = 0;
			foreach (int i in inteiros) {
				Console.Write("{0} ", i);
				if (i > maior) {
					maior = i;
					
				}
			}
			
			Console.Write("\nO maior é: {0} ", maior);
			Console.ReadKey(true);
		}
	}
}