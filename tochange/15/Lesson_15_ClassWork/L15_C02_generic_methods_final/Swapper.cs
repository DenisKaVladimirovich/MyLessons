namespace L15_C02_generic_methods_final
{
public static class Swapper
{
	public static void Swap<T>(ref T a, ref T b)
	{
		T temp = a;
		a = b;
		b = temp;
	}
}
}
