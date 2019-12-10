using System;
using System.Diagnostics;

namespace L15_C06_delegate_demo
{
	class Program
	{
		delegate int PerformCalculation(int x, int y);

		static void Main(string[] args)
		{
			var calc = new SimpleCalculator();
			PerformCalculation performCalculation;
			int result;

			performCalculation = calc.Sum;
			result = performCalculation(10, 5);
			Console.WriteLine(result);

			performCalculation = calc.Multiply;
			result = performCalculation(10, 5);
			Console.WriteLine(result);
		}
	}
}
