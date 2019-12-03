namespace L14_HW1_solution
{
	class Program
	{
		static void Main(string[] args)
		{
			var consoleLogger = ConsoleLogWriter.GetInstance();
			var fileLogger = FileLogWriter.GetInstance();

			MultipleLogWriter.LogWriters.Add(consoleLogger);
			MultipleLogWriter.LogWriters.Add(fileLogger);

			using (var logger = MultipleLogWriter.GetInstance())
			{
				logger.LogInfo("Test information message");
				logger.LogWarning("Test warning message");

				MultipleLogWriter.LogWriters.Remove(consoleLogger);

				logger.LogError("Test error message");
			}
		}
	}
}
