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

    private void OnSelectionChangedPerk(object sender, SelectionChangedEventArgs e)
    {
        IEnumerable<PerkFlaw> current = e.CurrentSelection.Cast<PerkFlaw>();
        _apSpentOnPerks = 0;
        foreach (PerkFlaw perk in current)
        {
            _apSpentOnPerks += perk.Ap;
        }

        if (_apSpentOnPerks > 80)
        {
            //PerkCollection.UpdateSelectedItems(e.PreviousSelection.ToList()); //TODO this does not work properly.
            //PerkCollection.SelectedItems = e.PreviousSelection.ToList();      //TODO this also does not work! 
            _apSpentOnPerks = 0;
            foreach (PerkFlaw perk in e.PreviousSelection.Cast<PerkFlaw>())
            {
                _apSpentOnPerks += perk.Ap;
            }
            return;
        }
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
