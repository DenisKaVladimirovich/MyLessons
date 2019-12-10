using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
	private static void Main()
	{
		// prepare test data
		var testData = new Dictionary<string, bool>
		{
			//{ "()", true },
			{ "[]()", true },
			//{ "[[]()]", true },
			//{ "([([])])()[]", true },
			//{ "(", false },
			//{ "[][)", false },
			//{ "[(])", false },
			//{ "(()[]]", false }
		};

		// run the tests and write results
		foreach (var test in testData)
		{
			bool expected = test.Value;
			bool actual = AreBracketsCorrect(test.Key);
			Console.WriteLine(
				"Test of string \"{0}\" {1} (expected: {2}, actual: {3})",
				test.Key,
				expected == actual ? "PASSED" : "FAILED",
				expected,
				actual);
		}

		Console.WriteLine("Press any key to close...");
		Console.ReadKey();
	}

	private static bool AreBracketsCorrect(string stringToCheck)
	{
		var brackets = new[] { '[', ']', '(', ')' };
		var stack = new Stack<char>();

		// Finding brackets in string
		foreach (char symbol in stringToCheck)
		{
			if (!brackets.Contains(symbol))
				continue;

			// If opening bracket found, put it on top of stack
			if ((symbol == '(') || (symbol == '['))
			{
				stack.Push(symbol);
				continue;
			}

			// If round closing bracket found, check 
			if (stack.Count > 0 &&
				((symbol == ')' && stack.Pop() != '(')
				 || (symbol == ']' && stack.Pop() != '[')))
			{
				return false;
			}
		}

		// If opening brackets without pair left
		return stack.Count == 0;
	}
}