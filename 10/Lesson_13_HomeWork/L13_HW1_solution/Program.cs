namespace L13_HW1_solution
{
	class Program
	{
		static void Main(string[] args)
		{
			var consoleLogger = new ConsoleLogWriter();
			var fileLogger = new FileLogWriter();

			using (var logger = new MultipleLogWriter(consoleLogger, fileLogger))
			{
				logger.LogInfo("Test information message");
				logger.LogWarning("Test warning message");
				logger.LogError("Test error message");
			}
		}
	}
}
