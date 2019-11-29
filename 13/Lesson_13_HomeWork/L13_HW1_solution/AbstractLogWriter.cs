using System;

namespace L13_HW1_solution
{
	public abstract class AbstractLogWriter : ILogWriter
	{
		private readonly string _logRecordFormat = "{0:yyyy-MM-ddThh:mm:ss}+0000\t{1}\t{2}";

		public void LogError(string message)
		{
			LogRecord(message, LogRecordType.Error);
		}

		public void LogInfo(string message)
		{
			LogRecord(message, LogRecordType.Info);
		}

		public void LogWarning(string message)
		{
			LogRecord(message, LogRecordType.Warning);
		}

		protected string GetLogRecord(string message, LogRecordType logRecordType)
		{
			return string.Format(
				_logRecordFormat,
				DateTime.UtcNow,
				logRecordType,
				message);
		}

		protected abstract void LogRecord(string message, LogRecordType logRecordType);
	}
}
