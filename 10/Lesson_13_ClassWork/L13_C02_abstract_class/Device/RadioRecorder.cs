using System;

namespace L13_C02_abstract_class.Device
{
	public class RadioRecorder : AbstractMusicPlayer
	{
		public RadioRecorder(ConsoleWriter writer) : base(writer)
		{
			Writer.WriteLineWithCyan("Starting work with Radio Recorder");
		}

		public string RecordingDestination { get; set; }

		public void RecordMusic(TimeSpan duration)
		{
			if (string.IsNullOrEmpty(RecordingDestination))
			{
				Writer.WriteLine(
					"The destination is empty. Set the recording destination and try again.");
				return;
			}

			if (string.IsNullOrEmpty(MusicSource))
			{
				Writer.WriteLine(
					"It is nothing to play. Set the music source and try again.");
				return;
			}

			Writer.WriteLine(
				$"Recording {duration.TotalSeconds} seconds from {MusicSource} to {RecordingDestination}");
		}

		public void Restart()
		{
			Writer.WriteLineWithCyan("Restarting Radio Recorder... Power Off > Power On.");
		}
	}
}
