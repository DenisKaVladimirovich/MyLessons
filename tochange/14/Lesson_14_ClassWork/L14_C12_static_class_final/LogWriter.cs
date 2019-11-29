using System;

namespace L14_C12_static_class_final
{
	public static class LogWriter
	{
		public static string LogRecordFormat { get; set; }

		static LogWriter()
		{
			LogRecordFormat = "{0:yyyy-MM-ddThh:mm:ss}+0000\t{1}";
		}

		public static void LogRecord(string message)
		{
			Console.WriteLine(GetLogRecord(message));
		}

		private static string GetLogRecord(string message)
		{
			return string.Format(
				LogRecordFormat,
				DateTime.UtcNow,
				message);
		}
	}
}
