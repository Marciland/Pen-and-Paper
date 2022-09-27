using dsa5.Dataclasses;

namespace dsa5.Pages.CreateHero;

public partial class Step4 : ContentPage
{
    private readonly int remainingAP = 0;
    private int selectedCulturePackCost = 0;
    private Species _species;
    private Level _level;

	public Step4(Species species, Level level)
	{
        _species = species;
        _level = level;
        remainingAP = level.APAvailable;
		InitializeComponent();
        APBudget.Text = $"AP-Konto: {remainingAP}";
        CulturePicker.ItemsSource = Culture.GetCultures();
        CulturePicker.SelectedIndex = 0;
    }

    private void Continue(object sender, EventArgs e)
    {
        //Navigation.PushAsync(new Step5(selectedCulture, _species, _level));
    }

    private void OnCulturePickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;

        if (picker.SelectedIndex != -1)
        {
            Culture selectedCulture = (Culture)picker.SelectedItem;

            LanguagesLabel.Text = $"Sprache(n): {selectedCulture.language}";
            SocialStatusLabel.Text = "Sozialer Status: ";
            foreach (string status in selectedCulture.socialStatus)
            {
                SocialStatusLabel.Text += $"{status} oder ";
            }
            if(selectedCulture.socialStatus.Count != 0)
            {
                SocialStatusLabel.Text = SocialStatusLabel.Text.Remove(SocialStatusLabel.Text.Length - 6);
            }
            CulturePackCheckBox.IsChecked = false;
            APLabel.Text = $"Kulturpaket Kosten: {selectedCulture.AP}";
            selectedCulturePackCost = selectedCulture.AP;
            SkillsLabel.Text = "";
            int linebreakCounter = 0;
            foreach (string skill in selectedCulture.skills)
            {
                SkillsLabel.Text += $"{skill}, ";
                linebreakCounter++;
                if(linebreakCounter % 3 == 0)
                {
                    SkillsLabel.Text += "\n";
                }
            }
            if(selectedCulture.skills.Count != 0)
            {
                SkillsLabel.Text = SkillsLabel.Text.Remove(SkillsLabel.Text.Length - 2);
            }

        }

    }

    private void OnCulturePackCheckBoxChanged(object sender, EventArgs e)
    {
        if (CulturePackCheckBox.IsChecked == true)  APBudget.Text = $"AP-Konto: {remainingAP - selectedCulturePackCost}";
        if (CulturePackCheckBox.IsChecked == false) APBudget.Text = $"AP-Konto: {remainingAP}";
    }

    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
