using System;

namespace L14_C14_singleton_demo
{
	class Program
	{
		static void Main(string[] args)
		{
			SingletonDemo singleton =
				SingletonDemo.GetInstance();

			SingletonDemo singleton2 =
				SingletonDemo.GetInstance();

			Console.WriteLine(
				singleton2.Equals(singleton));

			// True
		}
	}
}
