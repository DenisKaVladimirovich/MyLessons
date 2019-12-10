using System;
using System.IO;

namespace L13_HW1_solution
{
	public class FileLogWriter : AbstractLogWriter, ILogWriter, IDisposable
	{
		private StreamWriter _logFileWriter;

		public FileLogWriter(string fileName = "log.txt")
		{
			_logFileWriter = new StreamWriter(
				File.Open(
					fileName,
					FileMode.OpenOrCreate,
					FileAccess.ReadWrite,
					FileShare.Read));

			_logFileWriter.BaseStream.Seek(0, SeekOrigin.End);
		}

		protected override void LogRecord(string message, LogRecordType logRecordType)
		{
			string logRecord = base.GetLogRecord(message, logRecordType);
			_logFileWriter.WriteLine(logRecord);
			_logFileWriter.Flush();
		}

		public void Dispose()
		{

			if (_logFileWriter != null)
				_logFileWriter.Dispose();
		}
	}
}
