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
        //Navigation.PushAsync(new Step4((Species)SpeciesPicker.SelectedItem, _level));
    }

    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
