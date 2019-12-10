using System;

namespace L15_C10_delegate_SW
{
	public sealed class Circle
	{
		private double _radius;

		public Circle(double radius)
		{
			_radius = radius;
		}

		public double Calculate(Func<double, double> operation)
		{
			return operation(_radius);
		}
	}
}
