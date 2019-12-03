using System;

namespace L15_C02_generic_methods_final
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = -1;
			int b = 100;
			Console.WriteLine($"a = {a}, b = {b}");
			Swapper.Swap<int>(ref a, ref b);
			Console.WriteLine($"a = {a}, b = {b}");

			float c = MathF.PI;
			float d = MathF.E;
			Console.WriteLine($"c = {c}, d = {d}");
			Swapper.Swap<float>(ref c, ref d);
			Console.WriteLine($"c = {c}, d = {d}");

			string e = "Hello";
			string f = "World";
			Console.WriteLine($"e = {e}, f = {f}");
			Swapper.Swap<string>(ref e, ref f);
			Console.WriteLine($"e = {e}, f = {f}");

			int[] arr1 = { 1, 2, 3 };
			int[] arr2 = { };
			Console.WriteLine($"arr1.Length = {arr1.Length}, arr2.Length = {arr2.Length}");
			Swapper.Swap<int[]>(ref arr1, ref arr2);
			Console.WriteLine($"arr1.Length = {arr1.Length}, arr2.Length = {arr2.Length}");

		}
	}
}
