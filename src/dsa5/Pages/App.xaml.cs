namespace dsa5.Pages;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new NavigationPage(new MainPage());
    }

}
