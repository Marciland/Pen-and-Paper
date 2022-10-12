namespace Client.Pages.CreateHero;

[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class Step1 : ContentPage
{

	public Step1()
	{
		InitializeComponent();
    }

    private void Continue(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Step2());
    }

    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
