using L13_C06_interface.Interface;

namespace L13_C06_interface.Device
{
	public abstract class AbstractMusicPlayer: IMusicPlayer, IRestartable
	{
		protected readonly ConsoleWriter _writer;

		public string MusicSource { get; set; }

		public AbstractMusicPlayer(ConsoleWriter writer)
		{
			_writer = writer;
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

		public abstract void Restart();
	}
}
