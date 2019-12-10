using System;

namespace L15_C04_generic_classes_SW
{
	class Program
	{
		static void Main(string[] args)
		{
			var accountInt = new Account<int>(12, "Andrei");
			accountInt.WriteProperties();

			var accountString = new Account<string>("A21DE9C", "Sergei");
			accountString.WriteProperties();

			var accountGuid = new Account<Guid>(Guid.NewGuid(), "Maria");
			accountGuid.WriteProperties();
		}
	}
}
