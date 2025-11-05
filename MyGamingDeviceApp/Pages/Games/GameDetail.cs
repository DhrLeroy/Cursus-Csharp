using MyGaming_Classes;

namespace MyGamingDeviceApp.Pages.Games;

[QueryProperty(nameof(GameDetail.Spel), nameof(GameDetail.Spel))]
public class GameDetail : ContentPage
{
    public Game Spel { get; set; }

    private VerticalStackLayout layout;

    public GameDetail()
	{
        layout = new VerticalStackLayout();
        Content = layout;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        layout.Children.Clear();

        BindingContext = Spel;

        if (Spel != null)
        {
            
            var titleLayout = new HorizontalStackLayout();
            titleLayout.Add(new Label() { Text = "Titel: " });
            var titleEntry = new Entry();
            titleEntry.SetBinding(Entry.TextProperty, nameof(MyGaming_Classes.Game.Naam), BindingMode.OneWay);
            titleLayout.Add(titleEntry);
            layout.Add(titleLayout);

            var btn = new Button();
            btn.Text = "Debug";
            btn.Clicked += (s, e) =>
            {
                var titel = Spel.Naam;
                Console.WriteLine();
            };

            layout.Add(btn);

            /*var ratingLayout = new HorizontalStackLayout();
            ratingLayout.Add(new Label() { Text = "Titel: " });
            var ratingEntry = new Entry();
            ratingEntry.SetBinding(Entry.TextProperty, nameof(Game.Rating), BindingMode.TwoWay);
            ratingLayout.Add(titleEntry);
            layout.Add(ratingLayout);*/
        }


    }

}