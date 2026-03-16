using MAUIVoorbeeld_NavigationPages.Klassen;

namespace MAUIVoorbeeld_NavigationPages.Paginas;

public class PokémonDetails : ContentPage
{
	public PokémonDetails(Pokémon pokémon)
	{
        Title = pokémon.Naam.ToUpper();

		var hoofdstack = new VerticalStackLayout();
		Content = hoofdstack;

        var naamStack = new HorizontalStackLayout();
		var lblNaam = new Label();
		lblNaam.Text = "Naam: ";
		naamStack.Add(lblNaam);
        var etrNaam = new Entry();
        etrNaam.Text = pokémon.Naam;
        etrNaam.Placeholder = "Naam van de Pokémon";
        naamStack.Add(etrNaam);
        hoofdstack.Add(naamStack);

        var hpStack = new HorizontalStackLayout();
        var lblHp = new Label();
        lblHp.Text = "HP: ";
        hpStack.Add(lblHp);
        var etrHP = new Entry();
        etrHP.Text = pokémon.HP.ToString();
        etrHP.Keyboard = Keyboard.Numeric;
        etrHP.Placeholder = "HP van de Pokémon";
        hpStack.Add(etrHP);
        hoofdstack.Add(hpStack);

        var typeStack = new HorizontalStackLayout();
        var lblType = new Label();
        lblType.Text = "Type: ";
        typeStack.Add(lblType);
        var etrType = new Entry();
        etrType.Text = pokémon.Type;
        etrType.Placeholder = "Type van de Pokémon";
        typeStack.Add(etrType);
        hoofdstack.Add(typeStack);

        var btnOpslaan = new Button();
        btnOpslaan.Text = "Opslaan";
        hoofdstack.Add(btnOpslaan);
        btnOpslaan.Clicked += (s, e) =>
        {
            pokémon.Naam = etrNaam.Text;
            pokémon.HP = Convert.ToInt32(etrHP.Text);
            pokémon.Type = etrType.Text;
            new PokémonRepository().PokémonOpslaan(pokémon);
            Navigation.PopAsync();
        };


        var btnVerwijderen = new Button();
        btnVerwijderen.Text = "Verwijderen";
        hoofdstack.Add(btnVerwijderen);
        btnVerwijderen.Clicked += (s, e) =>
        {
            pokémon.Naam = etrNaam.Text;
            pokémon.HP = Convert.ToInt32(etrHP.Text);
            pokémon.Type = etrType.Text;
            new PokémonRepository().PokémonVerwijderen(pokémon);
            Navigation.PopAsync();
        };

    }
}