using System;
using System.Collections.Generic;

namespace Reminder.Storage.Core
{
	public interface IReminderStorage
	{
		/// <summary>
		/// Adds new reminder item to collection.
		/// </summary>
		void Add(ReminderItem reminderItem);

		/// <summary>
		/// Updates existing reminder item.
		/// </summary>
		void Update(ReminderItem reminderItem);

		/// <summary>
		/// Gets the single reminder item by it's ID.
		/// </summary>
		ReminderItem Get(Guid id);

		/// <summary>
		/// Gets the list of reminder items by status.
		/// </summary>
		/// <param name="status">The set of statuses to be selected from the storage.</param>
		/// <param name="count">The maximum number of the items to return.</param>
		/// <param name="startPosition">The start position of the items to return.</param>
		/// <returns></returns>
		List<ReminderItem> GetList(
			IEnumerable<ReminderItemStatus> statuses,
			int count,
			int startPosition);
	}
}
