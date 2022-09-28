using dsa5.Abstractions;
using dsa5.Dataclasses;

namespace dsa5.Pages.CreateHero;

public partial class Step5 : ContentPage
{
    private readonly Culture _culture;
    private readonly Species _species;
    private readonly Level _level;

	public Step5(Culture culture, Species species, Level level)
	{
        _culture = culture;
        _species = species;
        _level = level;
		InitializeComponent();
        APBudget.Text = $"AP-Konto: {level.APAvailable}";
        ProfessionPicker.ItemsSource = Profession.GetProfessions();
        ProfessionPicker.SelectedIndex = 0;
    }

    private void Continue(object sender, EventArgs e)
    {
        Profession selectedProfession = (Profession)ProfessionPicker.SelectedItem;
        Level newLevel = new() { name = _level.name, APTotal = _level.APTotal, APAvailable = _level.APAvailable - selectedProfession.AP, APSpent = _level.APSpent + selectedProfession.AP, maxAttribute = _level.maxAttribute, maxSkill = _level.maxSkill, maxCombatSkill = _level.maxCombatSkill, maxAttributeTotal = _level.maxAttributeTotal, maxSpells = _level.maxSpells, maxForeignSpells = _level.maxForeignSpells };
        Navigation.PushAsync(new Step6(selectedProfession, _culture, _species, newLevel));
    }

    private void OnProfessionPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        Profession selectedProfession = (Profession)ProfessionPicker.SelectedItem;

        APBudget.Text = $"AP-Konto: {_level.APAvailable - selectedProfession.AP}";

        PreconditionsLabel.Text = "Voraussetzungen: ";
        PreconditionsLabel.Text += selectedProfession.preconditions;

        SpecialSkillsLabel.Text = "Sonderfertigkeiten: \n";
        SpecialSkillsLabel.Text += Utility.ListToString(selectedProfession.specialSkills, 1);

        CombatSkillsLabel.Text = "Kampftechniken: \n";
        CombatSkillsLabel.Text += Utility.ListToString(selectedProfession.combatSkills, 3);

        SpellsLabel.Text = "Zauber: \n";
        SpellsLabel.Text += Utility.ListToString(selectedProfession.spells, 2);

        SkillsLabel.Text = "Fertigkeiten: \n";
        SkillsLabel.Text += Utility.ListToString(selectedProfession.skills, 3);
    }

    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
