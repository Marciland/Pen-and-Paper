using Client.Dataclasses;

namespace Client.Pages.CreateHero;

public partial class Step6
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
        MaxAttributes.Text = $"Insgesamt: 64/{level.maxAttributeTotal}";
    }

    private void Continue(object sender, EventArgs e)
    {
        //create new level to pass on to step 7 still needs to be refined on miro
    }

    private void AddAttribute(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        switch (button.ClassId)
        {
            case "CouragePlus":
                CourageLabel.Text = (int.Parse(CourageLabel.Text) + 1).ToString();
                break;
            case "ClevernessPlus":
                ClevernessLabel.Text = (int.Parse(ClevernessLabel.Text) + 1).ToString();
                break;
            case "IntuitionPlus":
                IntuitionLabel.Text = (int.Parse(IntuitionLabel.Text) + 1).ToString();
                break;
            case "CharismaPlus":
                CharismaLabel.Text = (int.Parse(CharismaLabel.Text) + 1).ToString();
                break;
            case "DexterityPlus":
                DexterityLabel.Text = (int.Parse(DexterityLabel.Text) + 1).ToString();
                break;
            case "AgilityPlus":
                AgilityLabel.Text = (int.Parse(AgilityLabel.Text) + 1).ToString();
                break;
            case "ConstitutionPlus":
                ConstitutionLabel.Text = (int.Parse(ConstitutionLabel.Text) + 1).ToString();
                break;
            case "StrengthPlus":
                StrengthLabel.Text = (int.Parse(StrengthLabel.Text) + 1).ToString();
                break;
        }
        //TODO: check if adding is possible (max attribute!), increment max attribute used value, remove ap cost from budget!
    }

    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
