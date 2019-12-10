using System;

namespace L15_C07_delegate_multiple_demo
{
	public static class SimpleCalculator
	{
		public static int Sum(int x, int y)
		{
			Console.WriteLine($"{nameof(Sum)} called (result {x + y})");
			return x + y;
		}

		public static int Multiply(int x, int y)
		{
			Console.WriteLine($"{nameof(Multiply)} called (result {x * y})");
			return x * y;
		}
	}
}
