using System;

namespace L13_C01_abstract_source.Device
{
	public class VideoPlayer
	{
		private readonly ConsoleWriter _writer;

		public string MusicSource { get; set; }

		public string VideoSource { get; set; }

		public VideoPlayer(ConsoleWriter writer)
		{
			_writer = writer;
			_writer.WriteLineWithCyan("Starting work with Video Player");
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

		public void PlayVideo()
		{
			if (string.IsNullOrEmpty(VideoSource))
			{
				_writer.WriteLine("It is nothing to play. Set the video source and try again.");
				return;
			}

			_writer.WriteLine($"Playing video from {VideoSource}");
		}

		public void Restart()
		{
			_writer.WriteLineWithCyan("Restarting Video Player... Please wait about 10 seconds.");
		}
	}
}
