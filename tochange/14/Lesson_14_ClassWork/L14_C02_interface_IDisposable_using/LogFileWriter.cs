using System;
using System.IO;

namespace L14_C02_interface_IDisposable_using
{
	public class LogFileWriter: IDisposable
	{
		private string _logFileName;
		private StreamWriter _logFileWriter;

		public string LogFileName
		{
			get { return _logFileName;  }
		}

		public LogFileWriter(string fileName = "log.txt")
		{
			// save file name to not lose it in future
			_logFileName = fileName;

			// create the stream writer and open it for writing
			_logFileWriter = new StreamWriter(
				File.Open(
					_logFileName,
					FileMode.OpenOrCreate,
					FileAccess.ReadWrite,
					FileShare.Read));

			// move internal pointer to the end of file
			_logFileWriter.BaseStream.Seek(0, SeekOrigin.End);
		}

		public void WriteToLog(string logRecord)
		{
			_logFileWriter.WriteLine(
				"{0:yyyy:MM:ddThh:mm:ss}+00:00\t{1}",
				DateTime.UtcNow,
				logRecord);
			_logFileWriter.Flush();
		}

		public void Dispose()
		{
			if (_logFileWriter != null)
				_logFileWriter.Dispose();
		}
	}
}
