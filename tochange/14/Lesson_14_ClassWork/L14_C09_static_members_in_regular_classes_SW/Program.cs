using System;

namespace L14_C09_static_members_in_regular_classes_SW
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var errorList = new ErrorList("Program Errors"))
			{
				errorList.Add("I/O error");
				errorList.Add("Some unknown error");

				errorList.WriteToConsole();
			}
		}
	}
}
