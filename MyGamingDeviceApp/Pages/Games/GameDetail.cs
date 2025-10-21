using MyGaming_Classes;

namespace MyGamingDeviceApp.Pages.Games;

[QueryProperty(nameof(MyGame), nameof(MyGame))]
public class GameDetail : ContentPage
{
    public Game MyGame { get; set; }

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

        if(MyGame != null)
        {
            layout.Add(new Label { Text = MyGame.Titel });
            layout.Add(new Label { Text = $"Rating: {MyGame.Rating}" });
            layout.Add(new Label { Text = MyGame.Genre.ToString() });
        }


    }
}