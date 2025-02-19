
using System;
using System.Collections.Generic;

namespace exD
{
	class Program
	{
		public static void Main(string[] args)
		{
			List<string> nomes = new List<string>{"Matheus", "Robert", "Flavio", "Henrique"};
			
			int qntLetras = 0;
			string maiorPalavra = "";
			
			foreach (string palavra in nomes) {
				Console.WriteLine("{0} ", palavra);
				
				if (palavra.Length > qntLetras ) {
					qntLetras = palavra.Length;
					maiorPalavra = palavra;
				}
			}
			
			Console.WriteLine("A maior palavra é: {0} com {1} letras", maiorPalavra, qntLetras);
			Console.ReadKey(true);
		}
	}
}