 
using System;
using System.Collections.Generic;

namespace ex3
{
	
	class Produto
	{
		// Propriedades da classe Produto
		public string Nome { get; set; }
		public double PrecoUnitario { get; set; }
		public int Quantidade { get; set; }

		// Método para calcular o valor total
		public double CalcularValorTotal()
		{
			return PrecoUnitario * Quantidade;
		}
	}

	class Program
	{
		public static void Main()
		{
			
			List<Produto> produtos = new List<Produto>();

			
			Console.WriteLine("Cadastro de Produtos");
			Console.WriteLine("Digite quantos cadastros deseja fazer");
			int quantCad = int.Parse(Console.ReadLine());
			
			Console.WriteLine();
			for (int i = 1; i <= quantCad; i++) {
				Produto produto = new Produto();
				
				Console.WriteLine("\n{0}° Produto", i);
				
				Console.Write("\nNome do produto: ");
				produto.Nome = Console.ReadLine();
				
				Console.Write("Preço unid: R$");
				produto.PrecoUnitario = double.Parse(Console.ReadLine());
				
				Console.Write("Quantidade: ");
				produto.Quantidade = int.Parse(Console.ReadLine());
				
				produtos.Add(produto);
			}
			
			Console.ReadKey(true);
			Console.Clear();
			Console.WriteLine("\nProdutos Cadastrados: ");
			
			foreach (var produto in produtos) {
				double valorTotal = produto.CalcularValorTotal();
				Console.WriteLine("\nNome: {0}\nQuantidade {1}\nValor total: {2}\n", produto.Nome, produto.PrecoUnitario, valorTotal);
			}
			
			
			
			
			
			
			Console.ReadKey(true);
		}
	}
	
}