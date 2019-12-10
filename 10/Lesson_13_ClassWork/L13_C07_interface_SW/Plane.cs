using System;

namespace L13_C07_interface_SW
{
	public class Plane : FlyingObject
	{
		public byte EnginesCount { get; private set; }

		public Plane(int maxHeight, byte enginesCount) : base(maxHeight)
		{
			EnginesCount = enginesCount;
			Console.WriteLine("It’s a plane, welcome aboard!");
		}

		public override void WriteAllProperties()
		{
			Console.WriteLine(
				$"Properties of {this.GetType().Name}:" +
				$"\n\t{nameof(EnginesCount)}:\t{EnginesCount}" +
				$"\n\t{nameof(MaxHeight)}:\t{MaxHeight}" +
				$"\n\t{nameof(CurrentHeight)}:\t{CurrentHeight}\n");
		}

		public override void WriteAllProperties2()
		{
			Console.Write(
				$"Properties of {this.GetType().Name}:" +
				$"\n\t{nameof(EnginesCount)}:\t{EnginesCount}");

			base.WriteAllProperties2();
		}
	}
}
