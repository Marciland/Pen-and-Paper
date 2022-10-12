namespace Client.Pages;

[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class App
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new MainPage());
    }

}
