using System;
using System.IO;

namespace L14_HW1_solution
{
    public class FileLogWriter : AbstractLogWriter, IDisposable
	{

		private StreamWriter _logFileWriter;

		public void Init(string fileName="log.txt")
		{
			_logFileWriter = new StreamWriter(
				File.Open(
					fileName,
					FileMode.OpenOrCreate,
					FileAccess.ReadWrite,
					FileShare.Read));

			_logFileWriter.BaseStream.Seek(0, SeekOrigin.End);
		}


        public FileLogWriter()
        {
            Init();
        }

        public static string LogFileName { get { return "log.txt"; } }

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
