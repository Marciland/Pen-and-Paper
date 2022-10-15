using Client.Abstractions;
using Client.Dataclasses;

namespace Client.Pages.CreateHero;

public partial class Step5
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
        ApBudget.Text = $"AP-Konto: {level.ApAvailable}";
        ProfessionPicker.ItemsSource = Profession.GetProfessions();
        ProfessionPicker.SelectedIndex = 0;
    }

    private void Continue(object sender, EventArgs e)
    {
        Profession selectedProfession = (Profession)ProfessionPicker.SelectedItem;
        Level newLevel = new() { Name = _level.Name, ApTotal = _level.ApTotal, ApAvailable = _level.ApAvailable - selectedProfession.Ap, ApSpent = _level.ApSpent + selectedProfession.Ap, MaxAttribute = _level.MaxAttribute, MaxSkill = _level.MaxSkill, MaxCombatSkill = _level.MaxCombatSkill, MaxAttributeTotal = _level.MaxAttributeTotal, MaxSpells = _level.MaxSpells, MaxForeignSpells = _level.MaxForeignSpells };
        Navigation.PushAsync(new Step6(selectedProfession, _culture, _species, newLevel));
    }

    private void OnProfessionPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        Profession selectedProfession = (Profession)ProfessionPicker.SelectedItem;

        ApBudget.Text = $"AP-Konto: {_level.ApAvailable - selectedProfession.Ap}";

        PreconditionsLabel.Text = "Voraussetzungen: ";
        PreconditionsLabel.Text += selectedProfession.Preconditions;

        SpecialSkillsLabel.Text = "Sonderfertigkeiten: \n";
        SpecialSkillsLabel.Text += Utility.ListToString(selectedProfession.SpecialSkills, 1);

        CombatSkillsLabel.Text = "Kampftechniken: \n";
        CombatSkillsLabel.Text += Utility.ListToString(selectedProfession.CombatSkills, 3);

        SpellsLabel.Text = "Zauber: \n";
        SpellsLabel.Text += Utility.ListToString(selectedProfession.Spells, 2);

        SkillsLabel.Text = "Fertigkeiten: \n";
        SkillsLabel.Text += Utility.ListToString(selectedProfession.Skills, 4);
    }

    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
