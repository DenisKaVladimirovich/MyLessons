using System;

namespace L14_C06_static_members_in_regular_classes
{
	public class LogWriter
	{
		private readonly string _logRecordFormat = "{0:yyyy-MM-ddThh:mm:ss}+0000\t{1}";

		public void LogRecord(string message)
		{
			Console.WriteLine(GetLogRecord(message));
		}

		private string GetLogRecord(string message)
		{
			return string.Format(
				_logRecordFormat,
				DateTime.UtcNow,
				message);
		}
	}
}
