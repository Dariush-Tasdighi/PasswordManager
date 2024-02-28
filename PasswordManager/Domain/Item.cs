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

	//[JsonProperty]
	[System.Text.Json.Serialization.JsonInclude]
	[System.ComponentModel.Browsable(browsable: false)]
	public System.Guid Id { get; private set; }



	[System.Text.Json.Serialization.JsonInclude]
	public string? Url { get; private set; }

	[System.Text.Json.Serialization.JsonInclude]
	public string? Username { get; private set; }

	[System.Text.Json.Serialization.JsonInclude]
	public string? Password { get; private set; }

	[System.Text.Json.Serialization.JsonInclude]
	[System.ComponentModel.DisplayName(displayName: "Email")]
	public string? EmailAddress { get; private set; }

	[System.Text.Json.Serialization.JsonInclude]
	[System.ComponentModel.DisplayName(displayName: "Mobile")]
	public string? CellPhoneNumber { get; private set; }

	[System.Text.Json.Serialization.JsonInclude]
	[System.ComponentModel.Browsable(browsable: false)]
	public string? Description { get; private set; }



	[System.Text.Json.Serialization.JsonInclude]
	[System.ComponentModel.Browsable(browsable: false)]
	public System.DateTime InsertDateTime { get; set; }

	[System.Text.Json.Serialization.JsonInclude]
	[System.ComponentModel.Browsable(browsable: false)]
	public System.DateTime UpdateDateTime { get; set; }



	[System.Text.Json.Serialization.JsonIgnore]
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

	[System.Text.Json.Serialization.JsonIgnore]
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
		if(string.IsNullOrWhiteSpace(value: url))
		{
			var errorMessage =
				string.Format(format: Dtat.ErrorMessages.Required, url);

			throw new System.Exception(message: errorMessage);
		}

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
