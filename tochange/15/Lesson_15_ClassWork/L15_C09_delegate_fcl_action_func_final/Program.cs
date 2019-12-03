using System;

namespace L15_C09_delegate_fcl_action_func_final
{
	class Program
	{
		static void DoCalcAndWriteOutput(
			int[] numbers,
			Func<int[], int> doCalc,
			Action<string> writeOutput)
		{
			int result = doCalc(numbers);
			writeOutput($"The result of calculation is {result}");
		}

		static void WriteToConsole(string message)
		{
			Console.WriteLine(message);
		}

		static int Sum(int[] numbers)
		{
			int sum = 0;
			foreach (int number in numbers)
			{
				sum += number;
			}

			return sum;
		}

		static int Avg(int[] numbers)
		{
			return Sum(numbers) / numbers.Length;
		}

		static void Main(string[] args)
		{
			int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 100 };

			Console.WriteLine($"Getting sum of {string.Join(", ", numbers)}");
			DoCalcAndWriteOutput(
				numbers,
				Sum,
				WriteToConsole);

			Console.WriteLine("\n***\n");

			Console.WriteLine($"Getting average value of {string.Join(", ", numbers)}");
			DoCalcAndWriteOutput(
				numbers,
				Avg,
				WriteToConsole);
		}
	}
}
