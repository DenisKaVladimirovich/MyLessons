namespace L14_C06_static_members_in_regular_classes_demo
{
	public class StaticMembersContainer
	{
		// private static field (common)
		private static int staticField;

		// public static property (common)
		public static int StaticProperty
		{
			get { return staticField; }
			set { staticField = value; }
		}

		// regular property (instance-dependent)
		public int RegularProperty { get; set; }

		// public method (common)
		public static void StaticMethod(int valueToAdd)
		{
			StaticProperty += valueToAdd;
		}

		// regular method (instance-dependent)
		public int RegularMethod()
		{
			return StaticProperty + RegularProperty;
		}
	}
}
