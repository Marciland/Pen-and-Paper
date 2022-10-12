using Client.Dataclasses;

namespace Client.Pages.CreateHero;

public partial class Step6 : ContentPage
{
    private readonly Profession _profession;
    private readonly Culture _culture;
    private readonly Species _species;
    private readonly Level _level;

	public Step6(Profession profession, Culture culture, Species species, Level level)
	{
        _profession = profession;
        _culture = culture;
        _species = species;
        _level = level;
        InitializeComponent();
        ApBudget.Text = $"AP-Konto: {level.apAvailable}";
    }

    private void Continue(object sender, EventArgs e)
    {
        //create new level to pass on to step 7 still needs to be refined on miro
    }

    private void AddAttribute(object sender, EventArgs e)
    {
        
    }

    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
