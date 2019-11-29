using System;

namespace L14_C05_interface_IEnumerable_SW
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var errorList = new ErrorList("Program Errors"))
			{
				errorList.Add("I/O error");
				errorList.Add("Some unknown error");

				foreach (string error in errorList)
				{
					Console.WriteLine(errorList.Category + " " + error);
				}
			}
		}
	}
}
