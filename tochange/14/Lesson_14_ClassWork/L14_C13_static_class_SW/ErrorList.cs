using System;
using System.Collections.Generic;

namespace L14_C13_static_class_SW
{
	public static class ErrorList
	{
		private static List<string> _errors;

		public static string Category { get; set; }

		public static string OutputPrefixFormat { get; set; }

		private static string _outputPrefix
		{
			get
			{
				return DateTime.Now.ToString(OutputPrefixFormat);
			}
		}

		static ErrorList()
		{
			OutputPrefixFormat = "MMMM d, yyyy (hh:mm tt)";
			Category = "Default";
			_errors = new List<string>();
		}

		public static void Add(string errorMessage)
		{
			_errors.Add(errorMessage);
		}

		public static void WriteToConsole()
		{
			foreach (string error in _errors)
			{
				Console.WriteLine(string.Format(
					"{0}{1} {2}",
					_outputPrefix,
					Category,
					error));
			}
		}

		public static IEnumerator<string> GetEnumerator()
		{
			return _errors.GetEnumerator();
		}
	}
}
