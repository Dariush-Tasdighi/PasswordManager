namespace PasswordManager;

internal static class Program : object
{
	static Program()
	{
		ItemsRepository = new();
	}

	public static Persistence.ItemsRepository ItemsRepository { get; }

	[System.STAThread]
	private static void Main()
	{
		ApplicationConfiguration.Initialize();
		System.Windows.Forms.Application.Run(new MainForm());
	}
}