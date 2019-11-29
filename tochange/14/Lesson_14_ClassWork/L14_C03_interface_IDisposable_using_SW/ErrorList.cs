using System;
using System.Collections.Generic;

namespace L14_C03_interface_IDisposable_using_SW
{
	public class ErrorList: IDisposable
	{
		public string Category { get; private set; }

		public List<string> Errors { get; private set; }

		public ErrorList(string category)
		{
			Errors = new List<string>();
			Category = category;
		}

		public void Dispose()
		{
			if (Errors != null)
			{
				Errors.Clear();
				Errors = null;
			}
		}
	}
}
