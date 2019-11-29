namespace L14_C08_static_members_in_regular_classes_final
{
	class Program
	{
		static void Main(string[] args)
		{
			var logWriter = new LogWriter();

			logWriter.LogRecord("Below we will play around with the output format of the logs");
			logWriter.LogRecord("Actual log format is: \"" + LogWriter.LogRecordFormat + "\"");

			LogWriter.LogRecordFormat = ">>> {0:yy-MM-ddThh:mm:ss}\t{1}";
			logWriter.LogRecord("Now log format is: \"" + LogWriter.LogRecordFormat + "\"");
		}
	}
}
