using System;

namespace L14_C13_static_class_SW
{
	class Program
	{
		static void Main(string[] args)
		{
			ErrorList.Category = "Program Errors";
			ErrorList.Add("I/O error");
			ErrorList.Add("Some unknown error");
			ErrorList.WriteToConsole();
			
			// manual work with enumerator
			var errorsEnumerator = ErrorList.GetEnumerator();
			errorsEnumerator.Reset();
			while (errorsEnumerator.MoveNext())
			{
				Console.WriteLine(
					ErrorList.Category + " " + errorsEnumerator.Current);
			}
			
		}
	}
}
