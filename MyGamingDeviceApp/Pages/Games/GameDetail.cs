using MyGaming_Classes;

namespace MyGamingDeviceApp.Pages.Games;

[QueryProperty(nameof(Game), nameof(Game))]
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

        if(Game != null)
        {
            layout.Add(new Label { Text = Game.Titel });
            layout.Add(new Label { Text = $"Rating: {Game.Rating}" });
            layout.Add(new Label { Text = Game.Genre.ToString() });
        }


    }
}