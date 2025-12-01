using MyRestaurant_Klassen;

namespace MyRestaurant_Device.Pages.Menu_pages.Views;

public class MenuView : ContentView
{
	public Menu Menu { get; set; }

    public MenuView(Menu menu)
    {
        Menu = menu;

        BindingContext = menu;

        var label = new Label();
        label.Text = menu.ToString();
        label.BackgroundColor = Colors.LightGreen;
        label.Margin = new Thickness(10, 5);
        label.Padding = new Thickness(2);

        var tapRecognizer = new TapGestureRecognizer()
        {
            NumberOfTapsRequired = 2
        };

        tapRecognizer.Tapped += async (s, e) =>
        {
            if(BindingContext is Menu m)
            {
                await AppShell.Current.GoToAsync(nameof(MenuDetail), new Dictionary<string, object>()
                {
                    { nameof(MenuDetail.Menu), m }
                });
            }
        };

        label.GestureRecognizers.Add(tapRecognizer);

        Content = label;
    }
}