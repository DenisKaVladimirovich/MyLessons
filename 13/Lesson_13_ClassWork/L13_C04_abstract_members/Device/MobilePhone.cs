using System;

namespace L13_C04_abstract_members.Device
{
	public class MobilePhone: AbstractMusicPlayer
	{
		public MobilePhone(ConsoleWriter writer): base(writer)
		{
			_writer.WriteLineWithCyan("Starting work with Mobile Phone");
		}

		public void Call(string phoneNumber)
		{
			_writer.WriteLine($"Calling {phoneNumber}...");
		}

		public override void Restart()
		{
			_writer.WriteLineWithCyan("Restarting Mobile Phone... Displaing splash screen while loading.");
		}
	}
}
