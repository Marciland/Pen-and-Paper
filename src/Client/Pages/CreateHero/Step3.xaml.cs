using dsa5.Dataclasses;

namespace dsa5.Pages.CreateHero;

public partial class Step3 : ContentPage
{
    readonly Level _level;

	public Step3(Level level)
	{
        _level = level;
		InitializeComponent();
        APBudget.Text = $"AP-Konto: {level.APAvailable}";
        SpeciesPicker.ItemsSource = Species.GetSpecies();
        SpeciesPicker.SelectedIndex = 0;
	}

    private void Continue(object sender, EventArgs e)
    {
        Species selectedSpecies = (Species)SpeciesPicker.SelectedItem;
        Level newLevel = new() { name = _level.name, APTotal = _level.APTotal, APAvailable = _level.APAvailable - selectedSpecies.AP,
                                              APSpent = _level.APSpent + selectedSpecies.AP, maxAttribute = _level.maxAttribute, maxSkill = _level.maxSkill, maxCombatSkill = _level.maxCombatSkill,
                                              maxAttributeTotal = _level.maxAttributeTotal, maxSpells = _level.maxSpells, maxForeignSpells = _level.maxForeignSpells };
        Navigation.PushAsync(new Step4(selectedSpecies, newLevel));
    }

    void OnSpeciesPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;

        if (picker.SelectedIndex != -1)
        {
            Species selectedSpecies = (Species)picker.SelectedItem;

            APBudget.Text = $"AP-Konto: {_level.APAvailable - selectedSpecies.AP}";
            LELabel.Text = $"Lebensenergie-Grundwert (LE): {selectedSpecies.LE}";
            SKLabel.Text = $"Seelenkraft-Grundwert (SK): {selectedSpecies.SK}";
            ZKLabel.Text = $"Zähigkeit-Grundwert (ZK): {selectedSpecies.ZK}";
            GSLabel.Text = $"Geschwindigkeit-Grundwert (GS): {selectedSpecies.GS}";
            AttributeLabel.Text = selectedSpecies.attributes;
            PerkLabel.Text = "Vorteile: ";
            foreach (Perk perk in selectedSpecies.perks)
            {
                PerkLabel.Text += $"{perk.name}, ";
            }
            if(selectedSpecies.perks.Count != 0)
            {
                PerkLabel.Text = PerkLabel.Text.Remove(PerkLabel.Text.Length - 2);
            }
        
        }

    }

    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
