using L13_C06_interface.Device;
using L13_C06_interface.Interface;
using System;

namespace L13_C06_interface
{
	class Program
	{
		static void Main(string[] args)
		{
			var consoleWriter = new ConsoleWriter();

			var mobilePhone = new MobilePhone(consoleWriter);
			mobilePhone.MusicSource = "Music in a Social Network";

			var radioRecorder = new RadioRecorder(consoleWriter);
			radioRecorder.MusicSource = "FM Radio Channel";
			radioRecorder.RecordingDestination = "Flash Drive";

			var videoPlayer = new VideoPlayer(consoleWriter);
			videoPlayer.VideoSource = "YouTube";
			videoPlayer.MusicSource = "Podcast Server";

			consoleWriter.WriteLine("\n");

			var devices = new AbstractMusicPlayer[]
			{
				mobilePhone,
				radioRecorder,
				videoPlayer
			};

			// each device will do all the actions it can do according to implemented interfaces
			foreach (object device in devices)
			{
				consoleWriter.WriteLineWithGreen($"\n{device.GetType().Name}");

				if (device is IMusicPlayer && device != null)
				{
					if (!string.IsNullOrEmpty((device as IMusicPlayer).MusicSource))
						(device as IMusicPlayer).PlayMusic();
				}

				if (device is IVideoPlayer && device != null)
				{
					if (!string.IsNullOrEmpty((device as IVideoPlayer).VideoSource))
						(device as IVideoPlayer).PlayVideo();
				}

				if (device is IMusicRecorder && device != null)
				{
					if (!string.IsNullOrEmpty((device as IMusicRecorder).RecordingDestination))
						(device as IMusicRecorder).RecordMusic(TimeSpan.FromMinutes(20));
				}

				if (device is ICaller && device != null)
				{
					(device as ICaller).Call("+7916291XXXX");
				}

				if (device is IRestartable && device != null)
				{
					(device as IRestartable).Restart();
				}
			}
		}
	}
}
