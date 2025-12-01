using MyRestaurant_Device.Pages.Gerechten.Views;
using MyRestaurant_Klassen;

namespace MyRestaurant_Device.Pages.Menu_pages;

[QueryProperty(nameof(Menu), nameof(Menu))]
public class MenuDetail : ContentPage
{

    public Menu Menu { get; set; }

    public MenuDetail()
	{
		
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        var vStack = new VerticalStackLayout();
        vStack.BackgroundColor = Colors.Salmon;
        vStack.Margin = new Thickness(4);

        Title = Menu.Naam;

        var labelPrijs = new Label();
        labelPrijs.Text = $"{Menu.Prijs} euro";
        labelPrijs.Margin = new Thickness(4);
        vStack.Children.Add(labelPrijs);    

        var labelWaarde = new Label();
        labelWaarde.Text = $"{Menu.GeefTotaalprijs()} euro";
        labelWaarde.Margin = new Thickness(4);
        vStack.Children.Add(labelWaarde);

        foreach(var gerecht in Menu.Gerechten)
        {
            var gview = new GerechtView(gerecht);
            vStack.Children.Add(gview);
        }

        var scroll = new ScrollView();
        scroll.Orientation = ScrollOrientation.Both;
        scroll.Content = vStack;

        Content = scroll;

    }
}