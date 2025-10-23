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

        BindingContext = MyGame;

        if (MyGame != null)
        {
            var titleLayout = new HorizontalStackLayout();
            titleLayout.Add(new Label() { Text = "Titel: " });
            var titleEntry = new Entry();
            titleEntry.SetBinding(Entry.TextProperty, nameof(Game.Titel), BindingMode.TwoWay);
            titleLayout.Add(titleEntry);
            layout.Add(titleLayout);
        }


    }
}