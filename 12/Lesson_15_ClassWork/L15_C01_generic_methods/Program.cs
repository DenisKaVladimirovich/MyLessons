using System;

namespace L15_C01_generic_methods
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = -1;
			int b = 100;

			Console.WriteLine($"a = {a}, b = {b}");

			Swapper.Swap(ref a, ref b);

			Console.WriteLine($"a = {a}, b = {b}");
		}
	}
}
