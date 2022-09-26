using dsa5.Dataclasses;

namespace dsa5.Pages.CreateHero;

public partial class Step4 : ContentPage
{
	public Step4(Species species, Level level)
	{
		InitializeComponent();
        APBudget.Text = $"AP-Konto: {level.APAvailable}";
        CulturePicker.ItemsSource = Culture.GetCultures();
    }

    private void Continue(object sender, EventArgs e)
    {
        
    }

    void OnCulturePickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;

        if (picker.SelectedIndex != -1)
        {

        }

    }

    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
