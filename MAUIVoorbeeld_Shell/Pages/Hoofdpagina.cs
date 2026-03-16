namespace MAUIVoorbeeld_Shell.Pages;

public class Hoofdpagina : ContentPage
{
	public Hoofdpagina()
	{
		Title = "Hoofdpagina";

		var hoofdStack = new VerticalStackLayout();

		var pokemons = new PokémonRepository().GeefAllePokémons();

		foreach(var pokemon in pokemons)
		{
			var btn = new Button();
            btn.Text = $"{pokemon.Naam} ({pokemon.HP} HP)";
			hoofdStack.Add(btn);
			btn.Clicked += (s, e) =>
			{
				Navigation.PushAsync(new PokémonDetails(pokemon));
			};
        }

		Content = hoofdStack;
	
	}

	
}