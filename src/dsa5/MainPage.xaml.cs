namespace dsa5;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
        InitializeComponent();
    }

    //note for myself:
    //sender is used to know which button called the method if for example multiple buttons use the same method

	private void CreateNewHero(object sender, EventArgs e) 
	{
        Navigation.PushAsync(new Step1());
    }

	private void EditHero(object sender, EventArgs e)
	{ 

	}

    private void PlayAdventure(object sender, EventArgs e)
    {

    }
    private void Options(object sender, EventArgs e)
    {

    }
    private void Quit(object sender, EventArgs e)
    {

    }

}

