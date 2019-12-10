using System;
using System.Collections.Generic;
using System.Text;

internal class Program
{
	private static void Main()
	{
		var testData = new Dictionary<string, bool>
		{
			{ "()", true },
			{ "[]()", true },
			{ "[[]()]", true },
			{ "([([])])()[]", true },
			{ "(", false },
			{ "[][)", false },
			{ "[(])", false },
			{ "(()[]]", false }
		};

		foreach (KeyValuePair<string, bool> pair in testData)
		{
			// get next pair for test
			string testLine = pair.Key;
			bool expectedResult = pair.Value;

			// starting the test
			while (true)
			{
				// remove paired brackets
				var line = testLine
					.Replace("[]", string.Empty)
					.Replace("()", string.Empty);

				// stop cleaning if there were not changes
				if (line == testLine)
					break;

				// update line for the next iteration
				testLine = line;
			}

			// string is valid if after the cleaning up it is empty
			var actualResult = testLine == string.Empty;

			var result = new StringBuilder();
			result.Append("Test ");
			result.Append(actualResult == expectedResult ? "PASSED" : "FAILED");
			result.Append($": Line \"{pair.Key}\" looks ");
			result.Append(actualResult ? "valid" : "invalid");

			Console.WriteLine(result.ToString());
		}

		Console.WriteLine("Press any key to close...");
		Console.ReadKey();
	}
}