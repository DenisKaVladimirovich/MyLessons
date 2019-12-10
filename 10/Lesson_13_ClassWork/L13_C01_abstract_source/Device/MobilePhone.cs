using System;

namespace L13_C01_abstract_source.Device
{
	public class MobilePhone
	{
		private readonly ConsoleWriter _writer;

		public string MusicSource { get; set; }

		public MobilePhone(ConsoleWriter writer)
		{
			_writer = writer;
			_writer.WriteLineWithCyan("Starting work with Mobile Phone");
		}

		public void PlayMusic()
		{
			if (string.IsNullOrEmpty(MusicSource))
			{
				_writer.WriteLineWithYellow("It is nothing to play. Set the music source and try again.");
				return;
			}

			_writer.WriteLineWithYellow($"Playing music from {MusicSource}");
		}

		public void Call(string phoneNumber)
		{
			_writer.WriteLine($"Calling {phoneNumber}...");
		}

		public void Restart()
		{
			_writer.WriteLineWithCyan("Restarting Mobile Phone... Displaing splash screen while loading.");
		}
	}
}
