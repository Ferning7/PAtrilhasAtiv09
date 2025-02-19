
using System;
using System.Collections.Generic;

namespace exE
{
	class Program
	{
		public static void Main(string[] args)
		{
			List<int> numeros = new List<int>{12, 15, 20, 25, 30, 18};
			
			double media = 0.0;
			int soma = 0;
			
			Console.Write("Números da lista: ");
			foreach (int i in numeros) {
				Console.Write("{0} ", i);
				soma += i;
				media = soma / numeros.Count;
				
			}
			Console.WriteLine("\nA média será: {0}", media);
			Console.ReadKey(true);
		}
	}
}