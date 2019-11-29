using L13_C06_interface.Interface;

namespace L13_C06_interface.Device
{
	public class MobilePhone: AbstractMusicPlayer, ICaller, IMusicPlayer, IRestartable
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
