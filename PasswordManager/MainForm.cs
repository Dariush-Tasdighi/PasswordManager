using Persistence;
using System.Linq;

namespace PasswordManager;

public partial class MainForm
	: Dtat.Windows.Forms.BaseForm
{
	public MainForm()
	{
		InitializeComponent();
	}

	private void MainForm_Load
		(object sender, System.EventArgs e)
	{
	}

	private void OpenToolStripMenuItem_Click(object sender, System.EventArgs e)
	{
		Program.ItemsRepository.Load(pathName: "");

		Search();
	}

	private void SearchTextBox_TextChanged(object sender, System.EventArgs e)
	{
		Search();
	}

	private void Search()
	{
		System.Collections.Generic.IList<Domain.Item> items;

		if (string.IsNullOrWhiteSpace(value: searchTextBox.Text))
		{
			items =
				Program.ItemsRepository.Items
				.ToList()
				;
		}
		else
		{
			var search =
				searchTextBox.Text.Trim().ToLower();

			items =
				Program.ItemsRepository.Items
				.Where(current =>
					(current.Url != null && current.Url.ToLower().Contains(search))
					||
					(current.Username != null && current.Username.ToLower().Contains(search))
					||
					(current.Password != null && current.Password.ToLower().Contains(search))
					||
					(current.Description != null && current.Description.ToLower().Contains(search))
					||
					(current.EmailAddress != null && current.EmailAddress.ToLower().Contains(search))
					||
					(current.CellPhoneNumber != null && current.CellPhoneNumber.ToLower().Contains(search))
					)
				.ToList()
				;
		}

		myDataGridView.DataSource = items;

		foreach (System.Windows.Forms.DataGridViewColumn column in myDataGridView.Columns)
		{
			column.SortMode =
				System.Windows.Forms.DataGridViewColumnSortMode.Automatic;

			column.AutoSizeMode =
				System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
		}
	}
}
