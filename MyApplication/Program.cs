namespace MyApplication;

internal static class Program : object
{
	[STAThread]
	private static void Main()
	{
		ApplicationConfiguration.Initialize();

		Application.Run(new MainForm());
		//Application.Run(new TestForm());
	}
}
