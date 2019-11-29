namespace L13_C07_interface_SW
{
	public interface IFlyingObject
	{
		int MaxHeight { get; }

		int CurrentHeight { get; }

		void TakeUpper(int delta);

		void TakeLower(int delta);
	}
}
