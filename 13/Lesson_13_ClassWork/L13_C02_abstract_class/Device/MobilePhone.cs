using System;

namespace L13_C02_abstract_class.Device
{
	public class MobilePhone: AbstractMusicPlayer
	{
		public MobilePhone(ConsoleWriter writer): base(writer)
		{
			Writer.WriteLineWithCyan("Starting work with Mobile Phone");
		}

		public void Call(string phoneNumber)
		{
			Writer.WriteLine($"Calling {phoneNumber}...");
		}

		public void Restart()
		{
			Writer.WriteLineWithCyan("Restarting Mobile Phone... Displaing splash screen while loading.");
		}
	}
}
