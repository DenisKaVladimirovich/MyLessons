using System;
using System.IO;

namespace L14_C03_interface_IDisposable_using_SW
{
	public static class Program
	{
		public static void Main()
		{
			using (var errorList = new ErrorList("Program Errors"))
			{
				errorList.Errors.Add("I/O error");
				errorList.Errors.Add("Some unknown error");

				foreach(string error in errorList.Errors)
				{
					Console.WriteLine(errorList.Category + ": " + error);
				}
			}
		}
	}
}
