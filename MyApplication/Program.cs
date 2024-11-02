namespace MyApplication;

internal static class Program
{
	[STAThread]
	static void Main()
	{
		ApplicationConfiguration.Initialize();

		Application.Run(new MainForm());
		//Application.Run(new TestForm());
	}
}
