using System;
using System.Collections.Generic;
using System.Text;

namespace L15_C10_delegate_SW
{
	static class CircleOperation
	{
		public static double CalculatePerimeter(double radius)
		{
			return 2 * Math.PI * radius;
		}

		public static double CalculateSquare(double radius)
		{
			return Math.PI * Math.Pow(radius, 2);
		}
	}
}
