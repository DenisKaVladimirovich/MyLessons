using System;
namespace L14_HW1_solution
{
	class Program
	{
		static void Main(string[] args)
		{
            //var consoleLogger = new ConsoleLogWriter();
            //var fileLogger = new FileLogWriter();
            //
			//MultipleLogWriter.LogWriters.Add(consoleLogger);
			//MultipleLogWriter.LogWriters.Add(fileLogger);
            //
			//using (var logger = MultipleLogWriter.GetInstance())
			//{
			//	logger.LogInfo("Test information message");
			//	logger.LogWarning("Test warning message");
            //
			//	MultipleLogWriter.LogWriters.Remove(consoleLogger);
            //
			//	logger.LogError("Test error message");
			//}



            LWF _factory = LWF.GetInstance();

            var flw = (FileLogWriter)_factory.GetWriter<FileLogWriter>();
            var clw = (ConsoleLogWriter)_factory.GetWriter<ConsoleLogWriter>();
            using (var logger = (MultipleLogWriter)_factory.GetWriter<MultipleLogWriter>(clw, flw))
            {
                logger.LogInfo("Test information message");
                logger.LogWarning("Test warning message");

                MultipleLogWriter.LogWriters.Remove(flw);

                logger.LogError("Test error message");
            }


            Console.ReadLine();
        }
	}
}
