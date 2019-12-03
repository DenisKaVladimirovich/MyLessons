using System;

namespace L15_C05_generic_constraints_demo
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = -1;
			int b = 100;
			Console.WriteLine($"a = {a}, b = {b}");
			Swapper<int>.Swap(ref a, ref b);
			Console.WriteLine($"a = {a}, b = {b}");

			float c = MathF.PI;
			float d = MathF.E;
			Console.WriteLine($"c = {c}, d = {d}");
			Swapper<float>.Swap(ref c, ref d);
			Console.WriteLine($"c = {c}, d = {d}");

			// this will not work
			//string e = "Hello";
			//string f = "World";
			//Console.WriteLine($"e = {e}, f = {f}");
			//Swapper<string>.Swap(ref e, ref f);
			//Console.WriteLine($"e = {e}, f = {f}");

			// this will not work!
			//int[] arr1 = { 1, 2, 3 };
			//int[] arr2 = { };
			//Console.WriteLine($"arr1.Length = {arr1.Length}, arr2.Length = {arr2.Length}");
			//Swapper<int[]>.Swap(ref arr1, ref arr2);
			//Console.WriteLine($"arr1.Length = {arr1.Length}, arr2.Length = {arr2.Length}");
		}
	}
}
