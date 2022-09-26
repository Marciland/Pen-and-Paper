using dsa5.Dataclasses;

namespace dsa5.Pages.CreateHero;

public partial class Step4 : ContentPage
{
	public Step4(Species species, Level level)
	{
		InitializeComponent();
        APBudget.Text = $"AP-Konto: {level.APAvailable}";
        CulturePicker.ItemsSource = Culture.GetCultures();
        CulturePicker.SelectedIndex = 0;
    }

    private void Continue(object sender, EventArgs e)
    {
        
    }

    void OnCulturePickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;

        if (picker.SelectedIndex != -1)
        {
            Culture selectedCulture = (Culture)picker.SelectedItem;

            LanguagesLabel.Text = $"Sprache(n): {selectedCulture.language}";
            SocialStatusLabel.Text = "Sozialer Status: ";
            foreach (string status in selectedCulture.socialStatus)
            {
                SocialStatusLabel.Text += $"{status}, ";
            }
            if(selectedCulture.socialStatus.Count != 0)
            {
                SocialStatusLabel.Text = SocialStatusLabel.Text.Remove(SocialStatusLabel.Text.Length - 2);
            }
            APLabel.Text = $"Kulturpaket Kosten: {selectedCulture.AP}";
            SkillsLabel.Text = "";
            int linebreakCounter = 0;
            foreach (string skill in selectedCulture.skills)
            {
                SkillsLabel.Text += $"{skill}, ";
                linebreakCounter++;
                if(linebreakCounter % 4 == 0)
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

    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
