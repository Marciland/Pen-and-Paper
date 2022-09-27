using dsa5.Dataclasses;

namespace dsa5.Pages.CreateHero;

public partial class Step5 : ContentPage
{
    private readonly Culture _culture;
    private readonly Species _species;
    private readonly Level _level;

	public Step5(Culture culture, Species species, Level level)
	{
        _culture = culture;
        _species = species;
        _level = level;
		InitializeComponent();
        APBudget.Text = $"AP-Konto: {level.APAvailable}";
    }

    private void Continue(object sender, EventArgs e)
    {

    }

    private void OnProfessionPickerSelectedIndexChanged(object sender, EventArgs e)
    {
     
    }

    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
