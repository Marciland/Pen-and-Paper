using Client.Dataclasses;
using Attribute = Client.Dataclasses.Attribute;

namespace Client.Pages.CreateHero;

public partial class Step8
{
    private readonly List<PerkFlaw> _perks;
    private readonly List<PerkFlaw> _flaws;
    private readonly Attribute _attributes;
    private readonly Profession _profession;
    private readonly Culture _culture;
    private readonly Species _species;
    private readonly Level _level;

    public Step8(List<PerkFlaw> perks, List<PerkFlaw> flaws, Attribute attributes, Profession profession, Culture culture, Species species, Level level)
    {
        _perks = perks;
        _flaws = flaws;
        _attributes = attributes;
        _profession = profession;
        _culture = culture;
        _species = species;
        _level = level;
        InitializeComponent();
        ApBudget.Text = $"AP-Konto: {_level.ApAvailable}";
    }
    private void Continue(object sender, EventArgs e)
    {
        //Step9
    }

    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
