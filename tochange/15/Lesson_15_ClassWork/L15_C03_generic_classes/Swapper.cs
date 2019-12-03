namespace L15_C03_generic_classes
{
	public static class Swapper<T>
	{
		public static void Swap(ref T a, ref T b)
		{
			T temp = a;
			a = b;
			b = temp;
		}
	}
}
