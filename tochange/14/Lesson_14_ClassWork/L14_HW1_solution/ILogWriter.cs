﻿namespace L14_HW1_solution
{
	public interface ILogWriter
	{
		void LogInfo(string message);

		void LogWarning(string message);

		void LogError(string message);
	}
}
