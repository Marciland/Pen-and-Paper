using Client.Dataclasses;
using Attribute = Client.Dataclasses.Attribute;

namespace Client.Pages.CreateHero;

public partial class Step7
{
    private Attribute _attributes;
    private Profession _profession;
    private Culture _culture;
    private Species _species;
    private Level _level;

    public Step7(Attribute attributes, Profession profession, Culture culture, Species species, Level level)
    {
        _attributes = attributes;
        _profession = profession;
        _culture = culture;
        _species = species;
        _level = level;
		InitializeComponent();
    }

    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    private void Continue(object sender, EventArgs e)
    {
        //step 8
    }

    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
