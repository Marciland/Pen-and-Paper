using Client.Dataclasses;
using Attribute = Client.Dataclasses.Attribute;

namespace Client.Pages.CreateHero;

public partial class Step7
{
    private readonly Attribute _attributes;
    private readonly Profession _profession;
    private readonly Culture _culture;
    private readonly Species _species;
    private readonly Level _level;
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
        PerkCollection.ItemsSource = PerkFlaw.GetAllPerks();
        FlawCollection.ItemsSource = PerkFlaw.GetAllFlaws();
        // TODO add a multi - pre selection based on species(elf has 2 perks already) and figure out if they count towards the limit
    }

    private void OnSelectionChangedPerk(object sender, SelectionChangedEventArgs e)
    {
        IEnumerable<PerkFlaw> previous = e.PreviousSelection.Cast<PerkFlaw>();
        IEnumerable<PerkFlaw> current = e.CurrentSelection.Cast<PerkFlaw>();
        _apSpentOnPerks = 0;
        foreach (PerkFlaw perk in current)
        {
            _apSpentOnPerks += perk.Ap;
        }
        if (_apSpentOnPerks > 80)
        {
            //https://github.com/dotnet/maui/issues/10595
            //PerkCollection.UpdateSelectedItems(e.PreviousSelection.ToList());
            //PerkCollection.SelectedItems = e.PreviousSelection.ToList();
            //PerkCollection.SelectedItems.Remove(PerkCollection.SelectedItems.Count - 1);
            _apSpentOnPerks = 0;
            foreach (PerkFlaw perk in previous)
            {
                _apSpentOnPerks += perk.Ap;
            }
            return;
        }
        PerkLabel.Text = $"{_apSpentOnPerks}/80";
        int currentAp = _level.ApAvailable - _apSpentOnPerks + _apGainedOnFlaws;
        ApBudget.Text = $"AP-Konto: {currentAp}";
    }

    private void OnSelectionChangedFlaw(object sender, SelectionChangedEventArgs e)
    {
        IEnumerable<PerkFlaw> previous = e.PreviousSelection.Cast<PerkFlaw>();
        IEnumerable<PerkFlaw> current = e.CurrentSelection.Cast<PerkFlaw>();
        _apGainedOnFlaws = 0;
        foreach (PerkFlaw flaw in current)
        {
            _apGainedOnFlaws += flaw.Ap;
        }
        if (_apGainedOnFlaws > 80)
        {
            //https://github.com/dotnet/maui/issues/10595
            //PerkCollection.UpdateSelectedItems(e.PreviousSelection.ToList());
            //PerkCollection.SelectedItems = e.PreviousSelection.ToList();
            //PerkCollection.SelectedItems.Remove(PerkCollection.SelectedItems.Count - 1);
            _apGainedOnFlaws = 0;
            foreach (PerkFlaw perk in previous)
            {
                _apGainedOnFlaws += perk.Ap;
            }
            return;
        }
        FlawLabel.Text = $"{_apGainedOnFlaws}/80";
        int currentAp = _level.ApAvailable - _apSpentOnPerks + _apGainedOnFlaws;
        ApBudget.Text = $"AP-Konto: {currentAp}";
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
