using MAUIVoorbeeld_NavigationPages.Klassen;
using System.Collections.ObjectModel;

namespace MAUIVoorbeeld_NavigationPages.Paginas.XAML;

public partial class HoofdpaginaXaml : ContentPage
{
    public ObservableCollection<Pokémon> Pokémons { get; set; }
    public HoofdpaginaXaml()
	{
		InitializeComponent();
		Pokémons = new ObservableCollection<Pokémon>(new PokémonRepository().GeefAllePokémons());
        BindingContext = this;
    }

    private void Pokémon_Clicked(object sender, EventArgs e)
    {
        var pokemon = (sender as Button).BindingContext as Pokémon;
        Navigation.PushAsync(new PokémonDetails(pokemon));
    }
}