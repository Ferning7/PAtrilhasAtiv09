
using System;

namespace ex1
{
	class ex1
	{
		class Calculadora{
			
			public double Somar(double num1, double num2){
				return num1 + num2;
			}
			
			public double Subtrair(double num1, double num2){
				return num1 - num2;
			}
			
			public double Multiplicar(double num1, double num2){
				return num1 * num2;
			}
			
			public double Dividir(double num1, double num2){
				return num1 / num2;
			}
		}
		
		public static void Main(string[] args)
		{
			Calculadora calculadora = new Calculadora();
			
			Console.WriteLine("Digite dois números: ");
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			
			int sair = 1;
			
			while (sair == 1) {
				Console.Clear();
				
				Console.WriteLine("Escolha uma ação(digite 0 para sair): ");
				Console.Write("1) Somar\n2) Subtrair\n3) Multiplicar\n4) Dividir\n:: ");
				int escolha = int.Parse(Console.ReadLine());
				
				switch(escolha){
					case 1:
						Console.Clear();
						Console.WriteLine("A soma de {0} + {1} é igual a: {2}", num1, num2, calculadora.Somar(num1, num2));
						Console.WriteLine("Enter para continuar...");
						
						Console.ReadKey(true);
						break;
						
					case 2:
						Console.Clear();
						Console.WriteLine("A subtração de {0} - {1} é igual a: {2}", num1, num2, calculadora.Subtrair(num1, num2));
						
						Console.WriteLine("Enter para continuar...");
						Console.ReadKey(true);
						
						break;
						
					case 3:
						Console.Clear();
						Console.WriteLine("A multiplicação de {0} x {1} é igual a: {2}", num1, num2, calculadora.Multiplicar(num1, num2));
						
						Console.WriteLine("Enter para continuar...");
						Console.ReadKey(true);
						break;
						
					case 4:
						Console.Clear();
						Console.WriteLine("A divisão de {0} / {1} é igual a: {2}", num1, num2, calculadora.Dividir(num1, num2));
						
						Console.WriteLine("Enter para continuar...");
						Console.ReadKey(true);
						
						break;
					case 0:
						sair = 0;
						break;
				}
				
			}
			Console.ReadKey(true);
		}
	}
}