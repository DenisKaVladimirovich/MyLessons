using System;

namespace Reminder.Storage.Core
{
	/// <summary>
	/// The status of the single reminder item.
	/// </summary>
	public enum ReminderItemStatus
	{
		/// <summary>
		/// Awaiting the time to be sent in fututre.
		/// </summary>
		Awaiting,

		/// <summary>
		/// The time of sending came and it is ready to be sent.
		/// </summary>
		ReadyToSend,

		/// <summary>
		/// The item was successfully sent to the recepient.
		/// </summary>
		SuccessfullySent,

		/// <summary>
		/// There was an attempt to send the item but it was failed.
		/// </summary>
		Failed
	}
}
