namespace dsa5.Pages;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
        InitializeComponent();
    }

    //note for myself:
    //sender is used to know which button called the method if for example multiple buttons use the same method

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
    private void Options(object sender, EventArgs e)
    {
        //Navigation.PushAsync(new Options());
    }
    private void Quit(object sender, EventArgs e)
    {
        //is this needed?
    }

}
