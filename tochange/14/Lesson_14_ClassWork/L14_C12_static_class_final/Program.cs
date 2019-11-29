namespace L14_C12_static_class_final
{
	class Program
	{
		static void Main(string[] args)
		{
			LogWriter.LogRecord("Below we will play around with the output format of the logs");
			LogWriter.LogRecord("Actual log format is: \"" + LogWriter.LogRecordFormat + "\"");

			LogWriter.LogRecordFormat = ">>> {0:yy-MM-ddThh:mm:ss}\t{1}";
			LogWriter.LogRecord("Now log format is: \"" + LogWriter.LogRecordFormat + "\"");
		}
	}
}
