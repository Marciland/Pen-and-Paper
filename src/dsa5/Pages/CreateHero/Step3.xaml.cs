namespace dsa5.Pages.CreateHero;

public partial class Step3 : ContentPage
{
	public Step3(Dataclasses.Level level)
	{
		InitializeComponent();
		Console.WriteLine(level.name);
	}

    private void Continue(object sender, EventArgs e)
    {
        //Navigation.PushAsync(new Step4());
    }

    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
