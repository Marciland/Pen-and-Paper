namespace dsa5.Pages;

[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new NavigationPage(new MainPage());
    }

}
