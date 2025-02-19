
using System;

namespace exA
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] array = {10, 15, 20, 25, 30, 35, 40};
			
			foreach (int numeros in array) {
				Console.Write("{0} ",numeros);
			}
			
		
			Console.ReadKey(true);
		}
	}
}