using System;
using System.IO;

namespace L14_HW1_solution
{
	public class FileLogWriter : AbstractLogWriter, IDisposable
	{
		private static FileLogWriter _instance;

		private StreamWriter _logFileWriter;

		private FileLogWriter(string fileName)
		{
			_logFileWriter = new StreamWriter(
				File.Open(
					fileName,
					FileMode.OpenOrCreate,
					FileAccess.ReadWrite,
					FileShare.Read));

			_logFileWriter.BaseStream.Seek(0, SeekOrigin.End);
		}

		public static string LogFileName { get { return "log.txt"; } }

		protected override void LogRecord(string message, LogRecordType logRecordType)
		{
			string logRecord = base.GetLogRecord(message, logRecordType);
			_logFileWriter.WriteLine(logRecord);
			_logFileWriter.Flush();
		}

		public static FileLogWriter GetInstance()
		{
			if (_instance == null)
				_instance = new FileLogWriter(LogFileName);

			return _instance;
		}

		public void Dispose()
		{

			if (_logFileWriter != null)
				_logFileWriter.Dispose();
		}
	}
}
