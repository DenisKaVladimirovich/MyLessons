using System;

namespace Unit_Tests.L18_C01_final
{
	public class AccountInfo
	{
		public Guid Id { get; private set; }

		public string Email { get; private set; }

		public string FirstName { get; private set; }

		public string LastName { get; private set; }

		public string FullName { get => FirstName + " " + LastName; }

		public AccountInfo(
			Guid id, 
			string email,
			string firstName,
			string lastName)
		{
			Id = id;
			Email = email;
			FirstName = firstName;
			LastName = lastName;
		}
	}
}
