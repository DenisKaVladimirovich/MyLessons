using System;

namespace L15_C07_delegate_multiple_demo
{
	class Program
	{
		delegate int DoCalculation(int x, int y);

		static void Main(string[] args)
		{
			DoCalculation doCalculation1 = SimpleCalculator.Sum;
			DoCalculation doCalculation2 = SimpleCalculator.Multiply;

			// operator +=
			doCalculation1 += doCalculation2;

			// static method Delegate.Combine
			doCalculation1 = (DoCalculation)Delegate.Combine(
				doCalculation1, doCalculation2);

			var multipleResult = doCalculation1(10, 5);
			Console.WriteLine($"{nameof(multipleResult)} = {multipleResult}");

			Console.WriteLine("\n***\n");

			// operator -=
			doCalculation1 -= doCalculation2;

			// method Remove()
			doCalculation1 = (DoCalculation)Delegate.Remove(
				doCalculation1, doCalculation2);

			multipleResult = doCalculation1(10, 5);
			Console.WriteLine($"{nameof(multipleResult)} = {multipleResult}");
		}
	}
}
