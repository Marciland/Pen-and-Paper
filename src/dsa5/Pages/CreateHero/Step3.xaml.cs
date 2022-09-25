using dsa5.Dataclasses;

namespace dsa5.Pages.CreateHero;

public partial class Step3 : ContentPage
{
    readonly Level _level;

	public Step3(Level level)
	{
        _level = level;
		InitializeComponent();
        APBudget.Text = $"AP-Konto: {level.APTotal}";
        SpeciesPicker.ItemsSource = Species.GetSpecies();
        SpeciesPicker.SelectedIndex = 0;
	}

    private void Continue(object sender, EventArgs e)
    {
        Species selectedSpecies = (Species)SpeciesPicker.SelectedItem;
        Level newLevel = new() { name = _level.name, APTotal = _level.APTotal, APAvailable = _level.APAvailable - selectedSpecies.AP,
                                              APSpent = _level.APSpent + selectedSpecies.AP, maxAttribute = _level.maxAttribute, maxSkill = _level.maxSkill, maxCombatSkill = _level.maxCombatSkill,
                                              maxAttributeTotal = _level.maxAttributeTotal, maxSpells = _level.maxSpells, maxForeignSpells = _level.maxForeignSpells }; 
        //Navigation.PushAsync(new Step4(selectedSpecies, newLevel));
    }

    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
