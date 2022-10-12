using Client.Dataclasses;

namespace Client.Pages.CreateHero;

public partial class Step2 : ContentPage
{

    public Step2()
    {
        InitializeComponent();
        LevelPicker.ItemsSource = Level.GetLevels();
        LevelPicker.SelectedIndex = 0;
    }

    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    private void Continue(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Step3((Level)LevelPicker.SelectedItem));
    }

    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
