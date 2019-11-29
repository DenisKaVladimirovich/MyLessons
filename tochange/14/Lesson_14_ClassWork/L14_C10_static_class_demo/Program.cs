using System;

namespace L14_C10_static_class_demo
{
	class Program
	{
		static void Main(string[] args)
		{
			StaticSample.StaticMethod();

			StaticSample.StaticPropertySample = "New String!";
			StaticSample.StaticMethod();
		}
	}
}
