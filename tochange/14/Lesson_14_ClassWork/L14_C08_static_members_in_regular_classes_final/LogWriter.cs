using System;

namespace L14_C08_static_members_in_regular_classes_final
{
	public class LogWriter
	{
		public static string LogRecordFormat { get; set; }

		static LogWriter()
		{
			LogRecordFormat = "{0:yyyy-MM-ddThh:mm:ss}+0000\t{1}";
		}

		public void LogRecord(string message)
		{
			Console.WriteLine(GetLogRecord(message));
		}

		private string GetLogRecord(string message)
		{
			return string.Format(
				LogRecordFormat,
				DateTime.UtcNow,
				message);
		}
	}
}
