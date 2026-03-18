using MAUIVoorbeeld_NavigationPages.Paginas;

namespace MAUIVoorbeeld_NavigationPages;

public class Hoofdpagina : ContentPage
{
    private VerticalStackLayout hoofdStack;
	public Hoofdpagina()
	{
		Title = "Hoofdpagina";

		hoofdStack = new VerticalStackLayout();

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

		var scroll = new ScrollView();
		scroll.Orientation = ScrollOrientation.Vertical;
        scroll.Content = hoofdStack;

        Content = scroll;
	
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();


        var pokemons = new PokémonRepository().GeefAllePokémons();

        hoofdStack.Clear();

        var btnToevoegen = new Button();
        btnToevoegen.Text = "Nieuwe Pokémon toevoegen";
        hoofdStack.Add(btnToevoegen);
        btnToevoegen.Clicked += (s, e) =>
        {
            Navigation.PushAsync(new PokémonDetails(new Klassen.Pokémon() { Naam = "", Type = ""}));
        };

        foreach (var pokemon in pokemons)
        {
            var btn = new Button();
            btn.Text = $"{pokemon.Naam} ({pokemon.HP} HP)";
            hoofdStack.Add(btn);
            btn.Clicked += (s, e) =>
            {
                Navigation.PushAsync(new PokémonDetails(pokemon));
            };
        }
    }
}