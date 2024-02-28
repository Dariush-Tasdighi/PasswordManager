namespace Domain;

public class Item : object
{
	public Item() : base()
	{
		Id = System.Guid.NewGuid();

		var now =
			System.DateTime.Now;

		InsertDateTime = now;
		UpdateDateTime = now;
	}

	[System.ComponentModel.Browsable(browsable: false)]
	public System.Guid Id { get; private set; }



	public string? Url { get; private set; }

	public string? Username { get; private set; }

	public string? Password { get; private set; }

	[System.ComponentModel.DisplayName(displayName: "Email")]
	public string? EmailAddress { get; private set; }

	[System.ComponentModel.DisplayName(displayName: "Mobile")]
	public string? CellPhoneNumber { get; private set; }

	[System.ComponentModel.Browsable(browsable: false)]
	public string? Description { get; private set; }



	[System.ComponentModel.Browsable(browsable: false)]
	public System.DateTime InsertDateTime { get; set; }

	[System.ComponentModel.Browsable(browsable: false)]
	public System.DateTime UpdateDateTime { get; set; }



	[System.ComponentModel.DisplayName(displayName: "Insert")]
	public string DisplayInsertDateTime
	{
		get
		{
			var result =
				InsertDateTime
				.ToString("yyyy/MM/dd - HH:mm:ss");

			return result;
		}
	}

	[System.ComponentModel.DisplayName(displayName: "Update")]
	public string DisplayUpdateDateTime
	{
		get
		{
			var result =
				UpdateDateTime
				.ToString("yyyy/MM/dd - HH:mm:ss");

			return result;
		}
	}



	public void UpdateUrl(string? url)
	{
		UpdateDateTime =
			System.DateTime.Now;

		Url = url;
	}

	public void UpdateUsername(string? username)
	{
		UpdateDateTime =
			System.DateTime.Now;

		Username = username;
	}

	public void UpdatePassword(string? password)
	{
		UpdateDateTime =
			System.DateTime.Now;

		Password = password;
	}

	public void UpdateEmailAddress(string? emailAddress)
	{
		UpdateDateTime =
			System.DateTime.Now;

		EmailAddress = emailAddress;
	}

	public void UpdateCellPhoneNumber(string? cellPhoneNumber)
	{
		UpdateDateTime =
			System.DateTime.Now;

		CellPhoneNumber = cellPhoneNumber;
	}

	public void UpdateDescription(string? description)
	{
		UpdateDateTime =
			System.DateTime.Now;

		Description = description;
	}

	public void Update(Item item)
	{
		Description = item.Description;

		UpdateUrl(url: item.Url);
		UpdateUsername(username: item.Username);
		UpdatePassword(password: item.Password);
		UpdateEmailAddress(emailAddress: item.EmailAddress);
		UpdateCellPhoneNumber(cellPhoneNumber: item.CellPhoneNumber);
	}
}
