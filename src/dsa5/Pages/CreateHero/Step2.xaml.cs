namespace dsa5.Pages.CreateHero;

public partial class Step2 : ContentPage
{

	public Step2()
	{
		InitializeComponent();
        LevelPicker.ItemsSource = new List<Dataclasses.Level>
        { new Dataclasses.Level { name = "Test", APTotal = 900, APAvailable = 900 , APSpent = 0, maxAttribute = 10, maxSkill = 5, maxCombatSkill = 7, maxAttributeTotal = 20, maxSpells = 2, maxForeignSpells = 0 } 
        //add levels
        };
	}

    private void Continue(object sender, EventArgs e)
    {
        //fill ap budget based on EG chosen
        //Navigation.PushAsync(new Step3());
    }

    private void Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

}
