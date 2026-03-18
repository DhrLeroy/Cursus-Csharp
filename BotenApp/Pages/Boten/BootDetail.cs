using BotenApp.Klassen;

namespace BotenApp.Pages.Boten;

public class BootDetail : ContentPage
{
	public BootDetail(Boot boot)
	{
		Title = boot.Model;

		var btnTerug = new Button();
		btnTerug.Text = "Terug naar overzicht";
		btnTerug.Clicked += (s, e) =>
		{
			Navigation.PopAsync();
		};
		Content = btnTerug;
    }
}