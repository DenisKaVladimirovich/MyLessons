namespace L14_C11_static_class
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
