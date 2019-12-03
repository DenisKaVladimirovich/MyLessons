using System;

namespace L14_HW1_solution
{
	public class ConsoleLogWriter : AbstractLogWriter
	{
		private static ConsoleLogWriter _instance;

		private ConsoleLogWriter() { }

		protected override void LogRecord(string message, LogRecordType logRecordType)
		{
			Console.WriteLine(base.GetLogRecord(message, logRecordType));
		}

		public static ConsoleLogWriter GetInstance()
		{
			if (_instance == null)
				_instance = new ConsoleLogWriter();

			return _instance;
		}
	}
}
