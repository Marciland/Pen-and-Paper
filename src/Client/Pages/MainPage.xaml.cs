namespace Client.Pages;

[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class MainPage : ContentPage
{

    public MainPage()
	{
        InitializeComponent();
    }

    private void CreateHero(object sender, EventArgs e) 
	{
        Navigation.PushAsync(new CreateHero.Step1());
    }

	private void EditHero(object sender, EventArgs e)
	{
        //Navigation.PushAsync(new EditHero.Step1());
    }

    private void PlayAdventure(object sender, EventArgs e)
    {
        //Navigation.PushAsync(new PlayAdventure.Step1());
    }

}
