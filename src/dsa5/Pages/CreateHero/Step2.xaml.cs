using dsa5.Dataclasses;

namespace dsa5.Pages.CreateHero;

public partial class Step2 : ContentPage
{

    public Step2()
    {
        InitializeComponent();
        LevelPicker.ItemsSource = Level.GetLevels();
        LevelPicker.SelectedIndex = 0;
    }

    private void Continue(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Step3((Level)LevelPicker.SelectedItem));
    }

    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
