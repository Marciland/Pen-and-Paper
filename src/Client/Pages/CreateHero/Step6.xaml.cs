using Client.Dataclasses;

namespace Client.Pages.CreateHero;

public partial class Step6
{
    private readonly Profession _profession;
    private readonly Culture _culture;
    private readonly Species _species;
    private readonly Level _level;
    private int _attributeCounter = 64; //initially every attribute is 8, which results in an initial value of 8*8=64

    public Step6(Profession profession, Culture culture, Species species, Level level)
    {
        _profession = profession;
        _culture = culture;
        _species = species;
        _level = level;
        InitializeComponent();
        ApBudget.Text = $"AP-Konto: {_level.apAvailable}";
        MaxAttributes.Text = $"Insgesamt: {_attributeCounter}/{_level.maxAttributeTotal}";
    }

    private void Continue(object sender, EventArgs e)
    {
        //create new level to pass on to step 7 still needs to be refined on miro
    }

    private void AddAttribute(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        if (_attributeCounter == _level.maxAttributeTotal) return;
        switch (button.ClassId)
        {
            case "CouragePlus":
                if (int.Parse(CourageLabel.Text) == _level.maxAttribute) return;
                CourageLabel.Text = (int.Parse(CourageLabel.Text) + 1).ToString();
                break;
            case "ClevernessPlus":
                if (int.Parse(ClevernessLabel.Text) == _level.maxAttribute) return;
                ClevernessLabel.Text = (int.Parse(ClevernessLabel.Text) + 1).ToString();
                break;
            case "IntuitionPlus":
                if (int.Parse(IntuitionLabel.Text) == _level.maxAttribute) return;
                IntuitionLabel.Text = (int.Parse(IntuitionLabel.Text) + 1).ToString();
                break;
            case "CharismaPlus":
                if (int.Parse(CharismaLabel.Text) == _level.maxAttribute) return;
                CharismaLabel.Text = (int.Parse(CharismaLabel.Text) + 1).ToString();
                break;
            case "DexterityPlus":
                if (int.Parse(DexterityLabel.Text) == _level.maxAttribute) return;
                DexterityLabel.Text = (int.Parse(DexterityLabel.Text) + 1).ToString();
                break;
            case "AgilityPlus":
                if (int.Parse(AgilityLabel.Text) == _level.maxAttribute) return;
                AgilityLabel.Text = (int.Parse(AgilityLabel.Text) + 1).ToString();
                break;
            case "ConstitutionPlus":
                if (int.Parse(ConstitutionLabel.Text) == _level.maxAttribute) return;
                ConstitutionLabel.Text = (int.Parse(ConstitutionLabel.Text) + 1).ToString();
                break;
            case "StrengthPlus":
                if (int.Parse(StrengthLabel.Text) == _level.maxAttribute) return;
                StrengthLabel.Text = (int.Parse(StrengthLabel.Text) + 1).ToString();
                break;
        }
        _attributeCounter++;
        MaxAttributes.Text = $"Insgesamt: {_attributeCounter}/{_level.maxAttributeTotal}";
        //TODO: remove ap cost from budget!
    }

    private void SubAttribute(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        switch (button.ClassId)
        {
            case "CourageMinus":
                if (int.Parse(CourageLabel.Text) == 8) return;
                CourageLabel.Text = (int.Parse(CourageLabel.Text) - 1).ToString();
                break;
            case "ClevernessMinus":
                if (int.Parse(ClevernessLabel.Text) == 8) return;
                ClevernessLabel.Text = (int.Parse(ClevernessLabel.Text) - 1).ToString();
                break;
            case "IntuitionMinus":
                if (int.Parse(IntuitionLabel.Text) == 8) return;
                IntuitionLabel.Text = (int.Parse(IntuitionLabel.Text) - 1).ToString();
                break;
            case "CharismaMinus":
                if (int.Parse(CharismaLabel.Text) == 8) return;
                CharismaLabel.Text = (int.Parse(CharismaLabel.Text) - 1).ToString();
                break;
            case "DexterityMinus":
                if (int.Parse(DexterityLabel.Text) == 8) return;
                DexterityLabel.Text = (int.Parse(DexterityLabel.Text) - 1).ToString();
                break;
            case "AgilityMinus":
                if (int.Parse(AgilityLabel.Text) == 8) return;
                AgilityLabel.Text = (int.Parse(AgilityLabel.Text) - 1).ToString();
                break;
            case "ConstitutionMinus":
                if (int.Parse(ConstitutionLabel.Text) == 8) return;
                ConstitutionLabel.Text = (int.Parse(ConstitutionLabel.Text) - 1).ToString();
                break;
            case "StrengthMinus":
                if (int.Parse(StrengthLabel.Text) == 8) return;
                StrengthLabel.Text = (int.Parse(StrengthLabel.Text) - 1).ToString();
                break;
        }
        _attributeCounter--;
        MaxAttributes.Text = $"Insgesamt: {_attributeCounter}/{_level.maxAttributeTotal}";
        //TODO: add ap cost to budget!
    }

    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
