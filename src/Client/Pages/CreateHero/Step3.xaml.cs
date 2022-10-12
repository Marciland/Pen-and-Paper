using Client.Dataclasses;

namespace Client.Pages.CreateHero;

public partial class Step3
{
    private readonly Level _level;

    public Step3(Level level)
    {
        _level = level;
        InitializeComponent();
        ApBudget.Text = $"AP-Konto: {level.apAvailable}";
        SpeciesPicker.ItemsSource = Species.GetSpecies();
        SpeciesPicker.SelectedIndex = 0;
    }

    private void Continue(object sender, EventArgs e)
    {
        Species selectedSpecies = (Species)SpeciesPicker.SelectedItem;
        Level newLevel = new()
        {
            name = _level.name,
            apTotal = _level.apTotal,
            apAvailable = _level.apAvailable - selectedSpecies.ap,
            apSpent = _level.apSpent + selectedSpecies.ap,
            maxAttribute = _level.maxAttribute,
            maxSkill = _level.maxSkill,
            maxCombatSkill = _level.maxCombatSkill,
            maxAttributeTotal = _level.maxAttributeTotal,
            maxSpells = _level.maxSpells,
            maxForeignSpells = _level.maxForeignSpells
        };
        Navigation.PushAsync(new Step4(selectedSpecies, newLevel));
    }

    private void OnSpeciesPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        Picker picker = (Picker)sender;
        if (picker.SelectedIndex == -1) return;
        Species selectedSpecies = (Species)picker.SelectedItem;

        ApBudget.Text = $"AP-Konto: {_level.apAvailable - selectedSpecies.ap}";
        LeLabel.Text = $"Lebensenergie-Grundwert (LE): {selectedSpecies.le}";
        SkLabel.Text = $"Seelenkraft-Grundwert (SK): {selectedSpecies.sk}";
        ZkLabel.Text = $"Zähigkeit-Grundwert (ZK): {selectedSpecies.zk}";
        GsLabel.Text = $"Geschwindigkeit-Grundwert (GS): {selectedSpecies.gs}";
        AttributeLabel.Text = selectedSpecies.attributes;
        PerkLabel.Text = "Vorteile: ";
        foreach (Perk perk in selectedSpecies.perks)
        {
            PerkLabel.Text += $"{perk.name}, ";
        }
        PerkLabel.Text = selectedSpecies.perks.Count == 0
            ? PerkLabel.Text + "Keine"
            : PerkLabel.Text.Remove(PerkLabel.Text.Length - 2);
    }

    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
