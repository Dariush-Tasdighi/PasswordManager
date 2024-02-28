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

		myDataGridView.DataSource =
			Program.ItemsRepository.Items;
	}

	private void SearchTextBox_TextChanged(object sender, System.EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(value: searchTextBox.Text))
		{
			myDataGridView.DataSource =
				Program.ItemsRepository.Items;
		}
		else
		{
			var search =
				searchTextBox.Text.Trim().ToLower();

			myDataGridView.DataSource =
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
	}
}
