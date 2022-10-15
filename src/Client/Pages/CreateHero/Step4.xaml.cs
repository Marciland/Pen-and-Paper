using Client.Abstractions;
using Client.Dataclasses;

namespace Client.Pages.CreateHero;

public partial class Step4
{
    private int _selectedCulturePackCost;
    private readonly Species _species;
    private readonly Level _level;

    public Step4(Species species, Level level)
    {
        _species = species;
        _level = level;
        InitializeComponent();
        ApBudget.Text = $"AP-Konto: {level.ApAvailable}";
        CulturePicker.ItemsSource = Culture.GetCultures();
        CulturePicker.SelectedIndex = 0;
    }

    private void Continue(object sender, EventArgs e)
    {
        Culture selectedCulture = (Culture)CulturePicker.SelectedItem;

        if (selectedCulture.Type != _species.Type)
        {
            //display warning: Unübliche Kultur
        }

        if (CulturePackCheckBox.IsChecked)
        {
            Level newLevel = new() { Name = _level.Name, ApTotal = _level.ApTotal, ApAvailable = _level.ApAvailable - selectedCulture.Ap, ApSpent = _level.ApSpent + selectedCulture.Ap, MaxAttribute = _level.MaxAttribute, MaxSkill = _level.MaxSkill, MaxCombatSkill = _level.MaxCombatSkill, MaxAttributeTotal = _level.MaxAttributeTotal, MaxSpells = _level.MaxSpells, MaxForeignSpells = _level.MaxForeignSpells };
            Navigation.PushAsync(new Step5(selectedCulture, _species, newLevel));
            return;
        }

        Navigation.PushAsync(new Step5(selectedCulture, _species, _level));

    }

    private void OnCulturePickerSelectedIndexChanged(object sender, EventArgs e)
    {
        Picker picker = (Picker)sender;
        if (picker.SelectedIndex == -1) return;
        Culture selectedCulture = (Culture)picker.SelectedItem;

        ApLabel.Text = $"Kulturpaket Kosten: {selectedCulture.Ap}";
        SkillsLabel.Text = Utility.ListToString(selectedCulture.Skills, 3);
        LanguagesLabel.Text = $"Sprache(n): {selectedCulture.Language}";
        SocialStatusLabel.Text = "Sozialer Status: ";
        foreach (string status in selectedCulture.SocialStatus)
        {
            SocialStatusLabel.Text += $"{status} oder ";
        }
        if (selectedCulture.SocialStatus.Count >= 1)
        {
            SocialStatusLabel.Text = SocialStatusLabel.Text.Remove(SocialStatusLabel.Text.Length - 6);
        }

        CulturePackCheckBox.IsChecked = false;
        _selectedCulturePackCost = selectedCulture.Ap;
    }

    private void OnCulturePackCheckBoxChanged(object sender, EventArgs e)
    {
        ApBudget.Text = CulturePackCheckBox.IsChecked
            ? $"AP-Konto: {_level.ApAvailable - _selectedCulturePackCost}"
            : $"AP-Konto: {_level.ApAvailable}";
    }

    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
