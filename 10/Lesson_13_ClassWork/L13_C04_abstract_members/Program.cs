using L13_C04_abstract_members.Device;
using System;
using System.Collections.Generic;

namespace L13_C04_abstract_members
{
	class Program
	{
		static void Main(string[] args)
		{
			var  consoleWriter = new ConsoleWriter();

			consoleWriter.WriteLineWithGreen("Class MobilePhone\n");

			MobilePhone mobilePhone = new MobilePhone(consoleWriter);
			mobilePhone.Call("+7916291XXXX");
			mobilePhone.MusicSource = "Music in a Social Network";
			mobilePhone.PlayMusic();

			consoleWriter.WriteLineWithGreen("\nClass RadioRecorder\n");

			var radioRecorder = new RadioRecorder(consoleWriter);
			radioRecorder.MusicSource = "FM Radio Channel";
			radioRecorder.PlayMusic();
			radioRecorder.RecordingDestination = "Flash Drive";
			radioRecorder.RecordMusic(TimeSpan.FromSeconds(15));

			consoleWriter.WriteLineWithGreen("\nClass VideoPlayer\n");

			var videoPlayer = new VideoPlayer(consoleWriter);
			videoPlayer.VideoSource = "YouTube";
			videoPlayer.PlayVideo();
			videoPlayer.PlayMusic();
			videoPlayer.MusicSource = "Podcast Server";
			videoPlayer.PlayMusic();

			consoleWriter.WriteLine("\n\n");

			var players = new List<AbstractMusicPlayer>
			{
				mobilePhone,
				videoPlayer,
				radioRecorder
			};

			foreach(AbstractMusicPlayer player in players)
			{
				player.Restart();
			}
		}
	}
}
