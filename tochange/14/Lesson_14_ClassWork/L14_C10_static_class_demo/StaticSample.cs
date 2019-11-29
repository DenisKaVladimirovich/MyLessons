using System;

namespace L14_C10_static_class_demo
{
	public static class StaticSample
	{
		public static string StaticPropertySample { get; set; }

		static StaticSample()
		{
			StaticPropertySample = "Test String";
		}

		public static void StaticMethod()
		{
			InternalStaticMethod();
		}

		public static void InternalStaticMethod()
		{
			Console.WriteLine(StaticPropertySample);
		}
	}
}
