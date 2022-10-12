using Client.Abstractions;
using Client.Dataclasses;

namespace Client.Pages.CreateHero;

public partial class Step4
{
    private int _selectedCulturePackCost = 0;
    private readonly Species _species;
    private readonly Level _level;

    public Step4(Species species, Level level)
    {
        _species = species;
        _level = level;
        InitializeComponent();
        ApBudget.Text = $"AP-Konto: {level.apAvailable}";
        CulturePicker.ItemsSource = Culture.GetCultures();
        CulturePicker.SelectedIndex = 0;
    }

    private void Continue(object sender, EventArgs e)
    {
        Culture selectedCulture = (Culture)CulturePicker.SelectedItem;

        if (selectedCulture.type != _species.type)
        {
            //display warning: Unübliche Kultur
        }

        if (CulturePackCheckBox.IsChecked)
        {
            Level newLevel = new() { name = _level.name, apTotal = _level.apTotal, apAvailable = _level.apAvailable - selectedCulture.ap, apSpent = _level.apSpent + selectedCulture.ap, maxAttribute = _level.maxAttribute, maxSkill = _level.maxSkill, maxCombatSkill = _level.maxCombatSkill, maxAttributeTotal = _level.maxAttributeTotal, maxSpells = _level.maxSpells, maxForeignSpells = _level.maxForeignSpells };
            Navigation.PushAsync(new Step5(selectedCulture, _species, newLevel));
            return;
        }

        Navigation.PushAsync(new Step5(selectedCulture, _species, _level));

    }

    private void OnCulturePickerSelectedIndexChanged(object sender, EventArgs e)
    {
        Picker picker = (Picker)sender;

        if (picker.SelectedIndex != -1)
        {
            Culture selectedCulture = (Culture)picker.SelectedItem;

            ApLabel.Text = $"Kulturpaket Kosten: {selectedCulture.ap}";
            SkillsLabel.Text = Utility.ListToString(selectedCulture.skills, 3);
            LanguagesLabel.Text = $"Sprache(n): {selectedCulture.language}";

            SocialStatusLabel.Text = "Sozialer Status: ";
            foreach (string status in selectedCulture.socialStatus)
            {
                SocialStatusLabel.Text += $"{status} oder ";
            }
            if (selectedCulture.socialStatus.Count >= 1)
            {
                SocialStatusLabel.Text = SocialStatusLabel.Text.Remove(SocialStatusLabel.Text.Length - 6);
            }

            CulturePackCheckBox.IsChecked = false;
            _selectedCulturePackCost = selectedCulture.ap;

        }

    }

    private void OnCulturePackCheckBoxChanged(object sender, EventArgs e)
    {
        if (CulturePackCheckBox.IsChecked) ApBudget.Text = $"AP-Konto: {_level.apAvailable - _selectedCulturePackCost}";
        if (!CulturePackCheckBox.IsChecked) ApBudget.Text = $"AP-Konto: {_level.apAvailable}";
    }

    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
