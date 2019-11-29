using System;

namespace L13_C05_abstract_members_SW
{
	public class Helicopter : FlyingObject
	{
		public byte BladesCount { get; private set; }

		public Helicopter(int maxHeight, byte bladesCount) : base(maxHeight)
		{
			BladesCount = bladesCount;
			Console.WriteLine("It’s a helicopter, welcome aboard!");
		}

		public void WriteAllProperties()
		{
			Console.WriteLine(
				$"Properties of {GetType().Name}:" +
				$"\n\t{nameof(BladesCount)}:\t{BladesCount}" +
				$"\n\t{nameof(MaxHeight)}:\t{MaxHeight}" +
				$"\n\t{nameof(CurrentHeight)}:\t{CurrentHeight}\n");
		}
	}
}
