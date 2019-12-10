using System;

namespace L15_C10_delegate_SW
{
	class Program
	{
		static void Main(string[] args)
		{
			const double circleRadius = 1.5;
			var circle = new Circle(circleRadius);

			var circlePerimeter =
				circle.Calculate(CircleOperation.CalculatePerimeter);

			var circleSquare =
				circle.Calculate(CircleOperation.CalculateSquare);

			Console.WriteLine(
				$"For the circle with radius {circleRadius}\n" +
				$"\tPerimeter is\t{circlePerimeter}\n" +
				$"\tSquare is\t{circleSquare}");
		}
	}
}
