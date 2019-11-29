using System;

namespace L14_C06_static_members_in_regular_classes_demo
{
	class Program
	{
		static void Main(string[] args)
		{
			StaticMembersContainer.StaticProperty = 10;

			var regularInstance = 
				new StaticMembersContainer();
			regularInstance.RegularProperty = 20;

			Console.WriteLine(
				regularInstance.RegularMethod());

			StaticMembersContainer.StaticMethod(15);

			Console.WriteLine(
				regularInstance.RegularMethod());
		}
	}
}
