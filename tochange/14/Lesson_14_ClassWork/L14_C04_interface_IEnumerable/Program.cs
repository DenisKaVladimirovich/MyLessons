using System;
using System.IO;

namespace L14_C04_interface_IEnumerable
{
	public static class Program
	{
		public static void Main()
		{
			HistoryList list = new HistoryList();
			list.Add("New history record");
			list.Add("New history record 2");

			foreach (var item in list)
			{
				Console.WriteLine(item);
			}

			//using (var logger = new LogFileWriter())
			//{
			//	logger.WriteToLog("Program has stated.");
			//	logger.WriteToLog("Somewhere in the middle.");
			//	logger.WriteToLog("Finish");

			//	foreach(Tuple<DateTimeOffset, string> logRecord in logger)
			//	{
			//		Console.WriteLine(
			//			"{0:yyyy:MM:ddThh:mm:ss}+00:00\t{1}",
			//				logRecord.Item1,
			//				logRecord.Item2);
			//	}
			//}
		}
	}
}
