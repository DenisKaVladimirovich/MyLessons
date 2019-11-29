using System;
using System.Collections;
using System.Collections.Generic;

namespace L14_C09_static_members_in_regular_classes_SW
{
	public class ErrorList : IDisposable, IEnumerable<string>
	{
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
		}

		private readonly string _category;
		private List<string> _errors;

		public string Category
		{
			get { return _category; }
		}

		public void Add(string errorMessage)
		{
			_errors.Add(errorMessage);
		}

		public ErrorList(string category)
		{
			_errors = new List<string>();
			_category = category;
		}

		public void WriteToConsole()
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

		public void Dispose()
		{
			if (_errors != null)
			{
				_errors.Clear();
				_errors = null;
			}
		}

		public IEnumerator<string> GetEnumerator()
		{
			return _errors.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _errors.GetEnumerator();
		}
	}
}
