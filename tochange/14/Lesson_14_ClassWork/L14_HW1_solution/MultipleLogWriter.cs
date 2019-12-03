using System;
using System.Collections.Generic;

namespace L14_HW1_solution
{
	public class MultipleLogWriter : AbstractLogWriter, IDisposable
	{
		private static MultipleLogWriter _instance;

		public static IList<ILogWriter> LogWriters { get; private set; }

		static MultipleLogWriter()
		{
			LogWriters = new List<ILogWriter>();
		}

		private MultipleLogWriter() { }

		protected override void LogRecord(string message, LogRecordType logRecordType)
		{
			string logRecord = base.GetLogRecord(message, logRecordType);

			foreach (var writer in LogWriters)
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

		public static MultipleLogWriter GetInstance()
		{
			if (_instance == null)
				_instance = new MultipleLogWriter();

			return _instance;
		}


		public void Dispose()
		{
			foreach (var writer in LogWriters)
			{
				if (writer is IDisposable && writer != null)
				{
					((IDisposable)writer).Dispose();
				}
			}
		}
	}
}
