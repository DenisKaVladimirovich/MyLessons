namespace L13_C02_abstract_class.Device
{
	public class VideoPlayer : AbstractMusicPlayer
	{
		public string VideoSource { get; set; }

		public VideoPlayer(ConsoleWriter writer) : base(writer)
		{
			Writer.WriteLineWithCyan("Starting work with Video Player");
		}

		public void PlayVideo()
		{
			if (string.IsNullOrEmpty(VideoSource))
			{
				Writer.WriteLine("It is nothing to play. Set the video source and try again.");
				return;
			}

			Writer.WriteLine($"Playing video from {VideoSource}");
		}

		public void Restart()
		{
			Writer.WriteLineWithCyan("Restarting Video Player... Please wait about 10 seconds.");
		}
	}
}
