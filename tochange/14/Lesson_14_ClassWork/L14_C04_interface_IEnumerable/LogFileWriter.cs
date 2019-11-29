using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace L14_C04_interface_IEnumerable
{
	public class LogFileWriter: IDisposable, IEnumerable<Tuple<DateTimeOffset, string>>
	{
		private string _logFileName;
		private StreamWriter _logFileWriter;
		private List<Tuple<DateTimeOffset, string>> _logHistory;

		public string LogFileName
		{
			get { return _logFileName;  }
		}

		public LogFileWriter(string fileName = "log.txt")
		{
			// initialize a new list
			_logHistory = new List<Tuple<DateTimeOffset, string>>();

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

		public void WriteToLog(string logMessage)
		{
			var logRecord = new Tuple<DateTimeOffset, string>(
				DateTimeOffset.UtcNow,
				logMessage);

			_logFileWriter.WriteLine(
				"{0:yyyy:MM:ddThh:mm:ss}+00:00\t{1}",
				logRecord.Item1,
				logRecord.Item2);
			_logFileWriter.Flush();

			_logHistory.Add(logRecord);
		}

		public void Dispose()
		{
			if (_logHistory != null)
			{
				_logHistory.Clear();
				_logHistory = null;
			}

			if (_logFileWriter != null)
				_logFileWriter.Dispose();
		}

		public IEnumerator<Tuple<DateTimeOffset, string>> GetEnumerator()
		{
			return _logHistory.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)_logHistory).GetEnumerator();
		}
	}
}
