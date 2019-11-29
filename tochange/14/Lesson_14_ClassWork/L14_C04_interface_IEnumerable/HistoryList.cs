using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace L14_C04_interface_IEnumerable
{
	public class HistoryList: IEnumerable<string>
	{
		private List<string> _historyList = new List<string>();

		private IEnumerator<string> enumerator;

		public void Add(string historyItem)
		{
			_historyList.Add(historyItem);
		}

		public IEnumerator<string> GetEnumerator()
		{
			return _historyList.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _historyList.GetEnumerator();
		}
	}
}
