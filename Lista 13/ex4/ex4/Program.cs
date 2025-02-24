
using System;
using System.Collections.Generic;

namespace ex4
{
	class Aluno{
		
		public string Nome {get; set;}
		public List<double> notas {get; set;}
		
		public Aluno(){
			notas = new List<double>();
		}
		
		public double CalcularMedia(){
			double soma = 0;
			foreach (var nota in notas) {
				soma += nota;
			}
			return soma / notas.Count;
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			Console.ReadKey(true);
		}
	}
}