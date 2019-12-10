using System;

namespace Reminder.Storage.Core
{
	/// <summary>
	/// The single reminder item.
	/// </summary>
	public class ReminderItem
	{
		/// <summary>
		/// Gets or sets the identifier of the remindier item.
		/// </summary>
		public Guid Id { get; internal set; }

		/// <summary>
		/// Gets or sets the date and time the reminder item scheduled for sending.
		/// </summary>
		public DateTimeOffset Date { get; set; }

		/// <summary>
		/// The message of the reminder item for sending to the recepient.
		/// </summary>
		public string Message { get; set; }
		
		/// <summary>
		/// The identifier of the recepient.
		/// </summary>
		public string ContactId { get; set; }

		/// <summary>
		/// Gets the time before the message should be sent to the recepient.
		/// </summary>
		public TimeSpan TimeToSend => Date - DateTimeOffset.UtcNow;

		/// <summary>
		/// Initializes the new instance.
		/// </summary>
		public ReminderItem(
			Guid id,
			DateTimeOffset date,
			string message,
			string contactId)
		{
			Id = id;
			Date = date;
			Message = message;
			ContactId = contactId;
		}
	}
}
