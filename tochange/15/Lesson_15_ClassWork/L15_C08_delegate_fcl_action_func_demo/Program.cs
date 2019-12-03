using System;

namespace L15_C08_delegate_fcl_action_func_demo
{
	class Program
	{ 
		static void Main(string[] args)
		{
			int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 100 };

			int sum = 0;
			foreach (int number in numbers)
			{
				sum += number;
			}

			Console.WriteLine($"The sum is {sum}");
		}
	}
}
