using System;
using System.Collections;
using System.Collections.Generic;

namespace L14_C05_interface_IEnumerable_SW
{
	public class ErrorList: IDisposable, IEnumerable<string>
	{
		private readonly string _category;
		private List<string> _errors;

		public string Category
		{
			get { return _category; }
		}

		public void Add(string errorMessage)
		{
			_errors.Add(errorMessage);
		}

		public ErrorList(string category)
		{
			_errors = new List<string>();
			_category = category;
		}

		public void Dispose()
		{
			if (_errors != null)
			{
				_errors.Clear();
				_errors = null;
			}
		}

		public IEnumerator<string> GetEnumerator()
		{
			return _errors.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _errors.GetEnumerator();
		}
	}
}
