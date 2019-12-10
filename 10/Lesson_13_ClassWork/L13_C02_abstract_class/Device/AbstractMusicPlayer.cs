namespace L13_C02_abstract_class.Device
{
	public abstract class AbstractMusicPlayer
	{
		protected readonly ConsoleWriter Writer;

		public string MusicSource { get; set; }

		public AbstractMusicPlayer(ConsoleWriter writer)
		{
			Writer = writer;
		}

		public void PlayMusic()
		{
			if (string.IsNullOrEmpty(MusicSource))
			{
				Writer.WriteLineWithYellow("It is nothing to play. Set the music source and try again.");
				return;
			}

			Writer.WriteLineWithYellow($"Playing music from {MusicSource}");
		}
	}
}
