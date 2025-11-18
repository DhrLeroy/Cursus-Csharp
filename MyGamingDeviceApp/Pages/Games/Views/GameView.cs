using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using MyGaming_Classes;

namespace MyGamingDeviceApp.Pages.Games.Views;

public class GameView : ContentView
{
    private Border border;
    public GameView(Game game)
	{
        BindingContext = game;

        border = new Border()
        {
            BackgroundColor = Colors.LightBlue,
            StrokeShape = new RoundRectangle()
            {
                CornerRadius = new CornerRadius(10),
            },
            Stroke = Colors.DarkBlue,
            Margin = new Thickness(0,10)
        };

        UpdateView();

        Content = border;

        var swipe_rechts = new SwipeGestureRecognizer()
        {
            Direction = SwipeDirection.Right
        };
        swipe_rechts.Swiped += (s, e) =>
        {
            if (BindingContext is Game game)
            {
                //code om game te verwijderen
            }
        };
        Content.GestureRecognizers.Add(swipe_rechts);

        var swipe_links = new SwipeGestureRecognizer()
        {
            Direction = SwipeDirection.Left
        };
        swipe_links.Swiped += (s, e) =>
        {
            if (BindingContext is Game game)
            {
                //code om game toe te voegen aan favorieten
            }
        };
        Content.GestureRecognizers.Add(swipe_links);


        var aanraken = new TapGestureRecognizer()
        {
            NumberOfTapsRequired = 2
        };
        aanraken.Tapped += async (s, e) =>
        {
            if (BindingContext is Game game)
            {
                await Shell.Current.GoToAsync(nameof(GameDetail),
                    new Dictionary<string, object> { { nameof(GameDetail.Spel), game } });
            }
        };

        Content.GestureRecognizers.Add(aanraken);
    }

    public void UpdateView()
    {
        if (BindingContext is Game game)
        {
            var hlayout = new HorizontalStackLayout();
            hlayout.Margin = new Thickness(10);
            hlayout.Add(new Label() { Text = $"Titel: {game.Naam} ({game.Genre})" });
            hlayout.Add(new Label() { Text = $"Rating: {game.Rating.ToString()}/5" });

            var marginLabels = new Thickness(3, 0);
            foreach (Label label in hlayout.Children.OfType<Label>())
            {
                label.Margin = marginLabels;
            }

            border.Content = hlayout;
        }
    }
}