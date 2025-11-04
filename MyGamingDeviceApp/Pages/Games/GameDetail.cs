using MyGaming_Classes;

namespace MyGamingDeviceApp.Pages.Games;

[QueryProperty(nameof(GameDetail.Game), nameof(GameDetail.Game))]
public class GameDetail : ContentPage
{
    public Game Game { get; set; }

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

        BindingContext = Game;

        if (Game != null)
        {
            
            var titleLayout = new HorizontalStackLayout();
            titleLayout.Add(new Label() { Text = "Titel: " });
            var titleEntry = new Entry();
            titleEntry.SetBinding(Entry.TextProperty, nameof(MyGaming_Classes.Game.Titel), BindingMode.TwoWay);
            titleLayout.Add(titleEntry);
            layout.Add(titleLayout);

            /*var ratingLayout = new HorizontalStackLayout();
            ratingLayout.Add(new Label() { Text = "Titel: " });
            var ratingEntry = new Entry();
            ratingEntry.SetBinding(Entry.TextProperty, nameof(Game.Rating), BindingMode.TwoWay);
            ratingLayout.Add(titleEntry);
            layout.Add(ratingLayout);*/
        }


    }
}