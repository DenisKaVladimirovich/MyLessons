using System;

namespace L13_HW1_solution
{
	public class ConsoleLogWriter : AbstractLogWriter, ILogWriter
	{
		protected override void LogRecord(string message, LogRecordType logRecordType)
		{
			Console.WriteLine(base.GetLogRecord(message, logRecordType));
		}
	}
}
