using System.Linq;

namespace Persistence;

public class ItemsRepository : object
{
	public ItemsRepository() : base()
	{
		_items = [];
		HasBeenChanged = false;
	}

	public bool HasBeenChanged { get; private set; }

	private System.Collections.Generic.List<Domain.Item> _items;

	public System.Collections.Generic.IReadOnlyCollection<Domain.Item> Items
	{
		get
		{
			return _items;
		}
	}

	public void Load(string pathName)
	{
		_items.Clear();

		Domain.Item item;

		item =
			new Domain.Item();

		item.UpdateUrl(url: "https://www.yahoo.com");
		item.UpdateUsername(username: "dariush");
		item.UpdatePassword(password: "1234512345");
		item.UpdateCellPhoneNumber(cellPhoneNumber: "09121087461");
		item.UpdateEmailAddress(emailAddress: "tasdighi@a.com");

		_items.Add(item: item);

		item =
			new Domain.Item();

		item.UpdateUrl(url: "https://www.google.com");
		item.UpdateUsername(username: "alireza");
		item.UpdatePassword(password: "1234512345");
		item.UpdateCellPhoneNumber(cellPhoneNumber: "09121087462");
		item.UpdateEmailAddress(emailAddress: "alavi@b.com");

		_items.Add(item: item);

		item =
			new Domain.Item();

		item.UpdateUrl(url: "https://www.ymail.com");
		item.UpdateUsername(username: "sara");
		item.UpdatePassword(password: "12345");
		item.UpdateCellPhoneNumber(cellPhoneNumber: "09121087463");
		item.UpdateEmailAddress(emailAddress: "ahmadi@c.com");

		_items.Add(item: item);
	}

	public void Add(Domain.Item item)
	{
		HasBeenChanged = true;
		_items.Add(item: item);
	}

	public void Remove(System.Guid id)
	{
		var foundedItem =
			_items
			.Where(current => current.Id == id)
			.FirstOrDefault();

		if (foundedItem is not null)
		{
			HasBeenChanged = true;
			_items.Remove(item: foundedItem);
		}
	}

	public void Update(Domain.Item item)
	{
		var foundedItem =
			_items
			.Where(current => current.Id == item.Id)
			.FirstOrDefault();

		if (foundedItem is not null)
		{
			HasBeenChanged = true;

			foundedItem.Update(item: item);
		}
	}
}
