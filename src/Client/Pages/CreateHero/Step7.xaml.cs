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
    private int _apSpentOnPerks;
    private int _apGainedOnFlaws;

    public Step7(Attribute attributes, Profession profession, Culture culture, Species species, Level level)
    {
        _attributes = attributes;
        _profession = profession;
        _culture = culture;
        _species = species;
        _level = level;
		InitializeComponent();
        ApBudget.Text = $"AP-Konto: {_level.ApAvailable}";
        PerkCollection.ItemsSource = PerkFlaw.GetPerks();
        FlawCollection.ItemsSource = PerkFlaw.GetFlaws();
    }

    private void OnSelectionChangedPerk(object sender, EventArgs e)
    {
        //TODO check if selection is made or undone
        CollectionView selection = (CollectionView) sender;
        PerkFlaw perk = (PerkFlaw) selection.SelectedItem; //returns null!!!! TODO fix
        _apSpentOnPerks += perk.Ap; //TODO check if maximum would be hit
        PerkLabel.Text = $"{_apSpentOnPerks}/80";
        int currentAp = _level.ApAvailable - _apSpentOnPerks + _apGainedOnFlaws;
        ApBudget.Text = $"AP-Konto: {currentAp}";
    }

    private void OnSelectionChangedFlaw(object sender, EventArgs e)
    {
        //FlawLabel.Text="_apGainedOnFlaws/80"
        //int currentAp = _level.apAvailable - _apSpentOnPerks + _apGainedOnFlaws
        //ApBudget.Text=$"AP-Konto: {currentAp}"
    }

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
