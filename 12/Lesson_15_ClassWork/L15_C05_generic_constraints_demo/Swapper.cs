namespace L15_C05_generic_constraints_demo
{
	public static class Swapper<T> where T: struct
	{
		public static void Swap(ref T a, ref T b)
		{
			T temp = a;
			a = b;
			b = temp;
		}
	}
}
