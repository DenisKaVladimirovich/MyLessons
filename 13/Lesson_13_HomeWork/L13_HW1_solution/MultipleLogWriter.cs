using System;
using System.Collections.Generic;

namespace L13_HW1_solution
{
	public class MultipleLogWriter : AbstractLogWriter, ILogWriter, IDisposable
	{
		private IEnumerable<ILogWriter> _logWriters;

		public MultipleLogWriter(params ILogWriter[] writers)
		{
			_logWriters = writers;
		}

		protected override void LogRecord(string message, LogRecordType logRecordType)
		{
			string logRecord = base.GetLogRecord(message, logRecordType);

			foreach (var writer in _logWriters)
			{
				switch (logRecordType)
				{
					case LogRecordType.Info:
						writer.LogInfo(message);
						break;
					case LogRecordType.Warning:
						writer.LogWarning(message);
						break;
					case LogRecordType.Error:
						writer.LogError(message);
						break;
				}
			}
		}

		public void Dispose()
		{
			foreach (var writer in _logWriters)
			{
				if (writer is IDisposable && writer != null)
				{
					((IDisposable)writer).Dispose();
				}
			}
		}
	}
}
