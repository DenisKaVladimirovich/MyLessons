using System;
using System.Collections.Generic;
using System.Text;

namespace L14_C14_singleton_demo
{
	public class SingletonDemo
	{
		private static SingletonDemo instance;

		private SingletonDemo()
		{ }

		public static SingletonDemo GetInstance()
		{
			if (instance == null)
				instance = new SingletonDemo();
			return instance;
		}
	}
}
