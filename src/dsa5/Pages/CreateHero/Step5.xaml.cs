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
        //create new level to pass on to step6, push step6 with selected profession, culture, species, newlevel
    }

    private void OnProfessionPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        Profession selectedProfession = (Profession)ProfessionPicker.SelectedItem;

        APBudget.Text = $"AP-Konto: {_level.APAvailable - selectedProfession.AP}";

        PreconditionsLabel.Text = selectedProfession.preconditions;

        SpecialSkillsLabel.Text = "Sonderfertigkeiten: \n";
        if (selectedProfession.specialSkills.Count == 0) SpecialSkillsLabel.Text += "Keine";
        else
        {
            int linebreakCounter = 0;
            foreach (string specialSkill in selectedProfession.specialSkills)
            {
                SpecialSkillsLabel.Text += $"{specialSkill}, ";
                linebreakCounter++;
                if (linebreakCounter % 2 == 0)
                {
                    SpecialSkillsLabel.Text += "\n";
                }
            }

            if (SpecialSkillsLabel.Text.EndsWith("\n")) SpecialSkillsLabel.Text = SpecialSkillsLabel.Text.Remove(SpecialSkillsLabel.Text.Length - 3);
            else SpecialSkillsLabel.Text = SpecialSkillsLabel.Text.Remove(SpecialSkillsLabel.Text.Length - 2);

        }

        CombatSkillsLabel.Text = "Kampftechniken: ";
        if (selectedProfession.combatSkills.Count == 0) CombatSkillsLabel.Text += "Keine";
        else
        {
            int linebreakCounter = 0;
            foreach (string combatSkill in selectedProfession.combatSkills)
            {
                CombatSkillsLabel.Text += $"{combatSkill}, ";
                linebreakCounter++;
                if (linebreakCounter % 2 == 0)
                {
                    CombatSkillsLabel.Text += "\n";
                }
            }

            if (CombatSkillsLabel.Text.EndsWith("\n")) CombatSkillsLabel.Text = CombatSkillsLabel.Text.Remove(CombatSkillsLabel.Text.Length - 3);
            else CombatSkillsLabel.Text = CombatSkillsLabel.Text.Remove(CombatSkillsLabel.Text.Length - 2);

        }

        SpellsLabel.Text = "Zauber: ";
        if (selectedProfession.spells.Count == 0) SpellsLabel.Text += "Keine";
        else
        {
            int linebreakCounter = 0;
            foreach(string spell in selectedProfession.spells)
            {
                SpellsLabel.Text += $"{spell}, ";
                linebreakCounter++;
                if(linebreakCounter % 3 == 0)
                {
                    SpellsLabel.Text += "\n";
                }
            }

            if (SpellsLabel.Text.EndsWith("\n")) SpellsLabel.Text = SpellsLabel.Text.Remove(SpellsLabel.Text.Length - 3);
            else SpellsLabel.Text = SpellsLabel.Text.Remove(SpellsLabel.Text.Length - 2);

        }

        //fill skillslabel

    }

    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
