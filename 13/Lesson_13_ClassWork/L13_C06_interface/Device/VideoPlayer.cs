using L13_C06_interface.Interface;

namespace L13_C06_interface.Device
{
	public class VideoPlayer : AbstractMusicPlayer, IVideoPlayer, IMusicPlayer, IRestartable
	{
		public string VideoSource { get; set; }

		public VideoPlayer(ConsoleWriter writer) : base(writer)
		{
			_writer.WriteLineWithCyan("Starting work with Video Player");
		}

		public void PlayVideo()
		{
			if (string.IsNullOrEmpty(VideoSource))
			{
				_writer.WriteLine("It is nothing to play. Set the video source and try again.");
				return;
			}

			_writer.WriteLine($"Playing video from {VideoSource}");
		}

		public override void Restart()
		{
			_writer.WriteLineWithCyan("Restarting Video Player... Please wait about 10 seconds.");
		}
	}
}
