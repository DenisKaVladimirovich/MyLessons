using System.Collections.Generic;

namespace L13_C07_interface_SW
{
	class Program
	{
		static void Main(string[] args)
		{
			var plane = new Plane(100, 4);
			plane.TakeUpper(120);
			plane.TakeLower(100);
			plane.WriteAllProperties();
			//plane.WriteAllProperties2();

			var helicopter = new Helicopter(80, 3);
			helicopter.TakeUpper(120);
			helicopter.TakeLower(60);
			helicopter.WriteAllProperties();
			//helicopter.WriteAllProperties2();

			var flyingObjects = new List<FlyingObject>
			{
				plane,
				helicopter
			};

			foreach(IPropertiesWriter flyingObject in flyingObjects)
			{
				flyingObject.WriteAllProperties2();
			}
		}
	}
}
