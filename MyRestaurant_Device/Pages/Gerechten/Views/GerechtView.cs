using MyRestaurant_Klassen;

namespace MyRestaurant_Device.Pages.Gerechten.Views;

public class GerechtView : ContentView
{
	public GerechtView(Gerecht gerecht)	
	{
		var hStack = new HorizontalStackLayout();

		var labelNaam = new Label
		{
			Text = gerecht.Naam,
			Margin = new Thickness(4),
			BackgroundColor = Colors.Yellow
		};

		hStack.Children.Add(labelNaam);

		foreach(var ingredient in gerecht.Ingredienten)
		{
			var labelIngredient = new Label
			{
				Text = ingredient.Naam,
				Margin = new Thickness(2),
				BackgroundColor = Colors.LightBlue
			};
			hStack.Children.Add(labelIngredient);
		}
	
		Content = hStack;
	}
}