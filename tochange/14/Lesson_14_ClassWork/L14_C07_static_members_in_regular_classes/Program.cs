namespace L14_C06_static_members_in_regular_classes
{
	class Program
	{
		static void Main(string[] args)
		{
			var logWriter = new LogWriter();
			logWriter.LogRecord("Event for test logging to console");
		}
	}
}
