using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reminder.Storage.Core.Tests
{
	[TestClass]
	public class ReminderItemTests
	{
		[TestMethod]
		public void Constructor_Validly_Sets_Id_Property()
		{
			// Preparing
			Guid expected = new Guid("57BD059F-DBE3-4B6D-B418-0476D4E7FE82");

			// Running
			var reminderItem = new ReminderItem(
				expected,
				DateTimeOffset.MinValue,
				null,
				null);

			// Checking
			Assert.AreEqual(expected, reminderItem.Id);
		}

		[TestMethod]
		public void Constructor_Validly_Sets_Date_Property()
		{
			// Preparing
			var expected = DateTimeOffset.Now;

			// Running
			var reminderItem = new ReminderItem(
				Guid.Empty,
				expected,
				null,
				null);

			// Checking
			Assert.AreEqual(expected, reminderItem.Date);
		}

		[TestMethod]
		public void TimeToSend_Is_In_500_ms_Range()
		{
			var time500ms = TimeSpan.FromMilliseconds(500);
			var reminderItem = new ReminderItem(
				Guid.Empty,
				DateTimeOffset.UtcNow + time500ms,
				null,
				null);

			var actual = reminderItem.TimeToSend;

			Assert.IsTrue(actual < time500ms);
			Assert.IsTrue(actual > TimeSpan.Zero);
		}

		[TestMethod]
		public void TimeToSend_Is_Less_Than_Zero_For_Past_Date()
		{
			var reminderItem = new ReminderItem(
				Guid.Empty,
				DateTimeOffset.UtcNow - TimeSpan.FromDays(1),
				null,
				null);

			var actual = reminderItem.TimeToSend;

			Assert.IsTrue(actual < TimeSpan.Zero);
		}

		[TestMethod]
		public void Id_Set_Validly()
		{
			var reminderItem = new ReminderItem(
				Guid.Empty,
				DateTimeOffset.MinValue,
				null,
				null);

			// Preparing
			Guid expected = new Guid("57BD059F-DBE3-4B6D-B418-0476D4E7FE82");
			reminderItem.Id = expected;

			Assert.AreEqual(expected, reminderItem.Id);
		}
	}
}
