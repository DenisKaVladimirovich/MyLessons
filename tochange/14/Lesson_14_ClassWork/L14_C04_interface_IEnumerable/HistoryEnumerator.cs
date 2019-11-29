using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace L14_C04_interface_IEnumerable
{
	public class HistoryEnumerator : IEnumerator<string>
	{
		private Random _rnd = new Random();

		private string _current;

		public string Current => throw new NotImplementedException();

		object IEnumerator.Current => throw new NotImplementedException();

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public bool MoveNext()
		{
			_current = _rnd.Next().ToString();
			return true;
		}

		public void Reset()
		{
			throw new NotImplementedException();
		}
	}
}
