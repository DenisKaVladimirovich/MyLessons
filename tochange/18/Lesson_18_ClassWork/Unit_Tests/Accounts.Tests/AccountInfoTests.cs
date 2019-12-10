using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Tests.L18_C01_final;

namespace Unit_Tests.L18_C01_final.Tests
{
	[TestClass]
	public class AccountInfoTests
	{
		[TestInitialize]
		public void TestIntiialize()
		{
			// dummy code
		}

		[TestCleanup]
		public void TestCleanup()
		{
			// dummy code
		}

		[ClassInitialize]
		public static void ClassInitialize(TestContext testContext)
		{
			// dummy code
		}

		[ClassCleanup]
		public static void ClassCleanup()
		{
			// dummy code
		}

		[TestMethod]
		public void Constructor_Validly_Fills_ID()
		{
			Guid expected = new Guid("5DD1BEA1-037A-4151-9EC3-BCF688CB6F6C");

			var accountInfo = new AccountInfo(
				expected,
				null,
				null,
				null);

			Guid actual = accountInfo.Id;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Constructor_Validly_Fills_Email()
		{
			const string expected = "email";

			var accountInfo = new AccountInfo(
				Guid.Empty,
				expected,
				null,
				null);

			string actual = accountInfo.Email;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Constructor_Validly_Fills_FirstName()
		{
			var expected = "firstname";

			var accountInfo = new AccountInfo(
				Guid.Empty,
				null,
				expected,
				null);

			string actual = accountInfo.FirstName;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Constructor_Validly_Fills_LastName()
		{
			const string expected = "lastname";

			var accountInfo = new AccountInfo(
				Guid.Empty,
				null,
				null,
				expected);

			string actual = accountInfo.LastName;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void FullName_Returns_Correct_String()
		{
			const string expected = "firstname lastname";

			var accountInfo = new AccountInfo(
				Guid.Empty,
				null,
				"firstname",
				"lastname");

			string actual = accountInfo.FullName;

			Assert.AreEqual(expected, actual);
		}
	}
}
