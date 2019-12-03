namespace L15_C01_generic_methods
{
	public static class Swapper
	{
		public static void Swap(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		}
	}
}
