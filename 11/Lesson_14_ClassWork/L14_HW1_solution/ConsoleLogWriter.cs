using System;

namespace L14_HW1_solution
{
	public class ConsoleLogWriter : AbstractLogWriter
	{
        public ConsoleLogWriter() { }

		protected override void LogRecord(string message, LogRecordType logRecordType)
		{
			Console.WriteLine(base.GetLogRecord(message, logRecordType));
		}
	}
}
