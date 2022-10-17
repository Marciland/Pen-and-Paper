using Client.Dataclasses;

namespace Client.Pages.CreateHero;

public partial class Step3
{
    private readonly Level _level;

    public Step3(Level level)
    {
        _level = level;
        InitializeComponent();
        ApBudget.Text = $"AP-Konto: {level.ApAvailable}";
        SpeciesPicker.ItemsSource = Species.GetSpecies();
        SpeciesPicker.SelectedIndex = 0;
    }

    private void Continue(object sender, EventArgs e)
    {
        Species selectedSpecies = (Species)SpeciesPicker.SelectedItem;
        Level newLevel = new()
        {
            Name = _level.Name,
            ApTotal = _level.ApTotal,
            ApAvailable = _level.ApAvailable - selectedSpecies.Ap,
            ApSpent = _level.ApSpent + selectedSpecies.Ap,
            MaxAttribute = _level.MaxAttribute,
            MaxSkill = _level.MaxSkill,
            MaxCombatSkill = _level.MaxCombatSkill,
            MaxAttributeTotal = _level.MaxAttributeTotal,
            MaxSpells = _level.MaxSpells,
            MaxForeignSpells = _level.MaxForeignSpells
        };
        Navigation.PushAsync(new Step4(selectedSpecies, newLevel));
    }

    private void OnSpeciesPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        Picker picker = (Picker)sender;
        if (picker.SelectedIndex == -1) return;
        Species selectedSpecies = (Species)picker.SelectedItem;

        ApBudget.Text = $"AP-Konto: {_level.ApAvailable - selectedSpecies.Ap}";
        LeLabel.Text = $"Lebensenergie-Grundwert (LE): {selectedSpecies.Le}";
        SkLabel.Text = $"Seelenkraft-Grundwert (SK): {selectedSpecies.Sk}";
        ZkLabel.Text = $"Zähigkeit-Grundwert (ZK): {selectedSpecies.Zk}";
        GsLabel.Text = $"Geschwindigkeit-Grundwert (GS): {selectedSpecies.Gs}";
        AttributeLabel.Text = selectedSpecies.Attributes;
        PerkLabel.Text = "Vorteile: ";
        foreach (PerkFlaw perk in selectedSpecies.Perks)
        {
            PerkLabel.Text += $"{perk.Name}, ";
        }
        PerkLabel.Text = selectedSpecies.Perks.Count == 0
            ? PerkLabel.Text + "Keine"
            : PerkLabel.Text.Remove(PerkLabel.Text.Length - 2);
    }

    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
