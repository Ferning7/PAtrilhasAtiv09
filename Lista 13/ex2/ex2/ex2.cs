
using System;
using System.Collections.Generic;

namespace ex2
{
	
	public class Banco
	{
		private List<Conta> contas;
		private Random rand;
		public Banco(){
			contas = new List<Conta>();
			rand = new Random();
		}
		
		
		public void AbrirConta(string titular){
			string numeroConta = GerarNumeroConta();
			Conta novaConta = new Conta(numeroConta, titular);
			contas.Add(novaConta);
			
			Console.WriteLine("Conta criada!\nNúmero da conta: {0}", numeroConta);
		}
		
		private string GerarNumeroConta(){
			return rand.Next(1000, 9999).ToString();
		}
		
		public void FecharConta(string numeroConta){
			Conta conta = contas.Find(c => c.Numero == numeroConta);
			
			if (conta.Saldo > 0) {
				Console.WriteLine("Erro: esta conta possui saldo");
			}
			contas.Remove(conta);
			Console.WriteLine("Conta {0} fechada com sucesso!", numeroConta);
		}
		
		public void Depositar(string numeroConta, double valor){
			Conta conta = contas.Find(c => c.Numero == numeroConta);
			
			if (conta == null) {
				Console.WriteLine("Conta não encontrada");
			}
			
			if (valor <= 0) {
				Console.WriteLine("O valor do depósito deve ser maior que zero");
			}
			conta.Depositar(valor);
			Console.WriteLine("Depósito de {0} realizado na conta {1}", valor, numeroConta);
		}
		
		
		public class Conta {
			
			public string Numero { get; private set;}
			public string Titular{get; private set;}
			public double Saldo {get; private set;}
			
			public Conta(string numero, string titular){
				Numero = numero;
				Titular = titular;
				Saldo = 0;
			}
			
			public void Depositar(double valor){
				Saldo += valor;
			}
			
			public void Sacar(double valor){
				if (Saldo >= valor) {
					Saldo -= valor;
				}
			}
			
		}
	}
	
	
	class ex2
	{
		public static void Main(string[] args)
		{
			Banco banco = new Banco();
			
			
			Console.WriteLine("Selecione uma operação: ");
			int sair = 1;
			
			while (sair == 1) {
				Console.Clear();
				Console.WriteLine("Digite 0 para fechar\n");
				Console.Write("1)Abrir Conta\n2)Sacar \n3)Depositar\n4)Fechar Conta\nOpção: ");
				int escolha = int.Parse(Console.ReadLine());
				
				
				switch (escolha) {
					case 1:
						
						Console.WriteLine();
						Console.WriteLine("Digite seu nome: ");
						string nomePessoa = Console.ReadLine();
						
						banco.AbrirConta(nomePessoa);
						Console.ReadKey(true);
						break;
						
					case 2:
						
						break;
						
					case 0:
						sair = 0;
						
						break;
				}
			}

			
		}
	}
}