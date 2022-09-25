namespace dsa5.Pages.CreateHero;

public partial class Step2 : ContentPage
{

	public Step2()
	{
		InitializeComponent();
        LevelPicker.ItemsSource = Dataclasses.Level.GetLevels();
	}

    private void Continue(object sender, EventArgs e)
    {
        //fill ap budget based on EG chosen
        //Navigation.PushAsync(new Step3());
    }

    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
