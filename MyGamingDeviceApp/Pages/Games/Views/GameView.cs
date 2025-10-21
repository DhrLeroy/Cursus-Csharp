using Microsoft.Maui.Controls.Shapes;
using MyGaming_Classes;

namespace MyGamingDeviceApp.Pages.Games.Views;

public class GameView : ContentView
{
	public GameView(Game game)
	{
        BindingContext = game;

        var border = new Border()
        {
            BackgroundColor = Colors.LightBlue,
            StrokeShape = new RoundRectangle()
            {
                CornerRadius = new CornerRadius(10),
            },
            Stroke = Colors.DarkBlue,
            Margin = new Thickness(0,10)
        };


        var hlayout = new HorizontalStackLayout();
        hlayout.Margin = new Thickness(10);
        hlayout.Add(new Label() { Text = $"Titel: {game.Titel} ({game.Genre})" });
        hlayout.Add(new Label() { Text = $"Rating: {game.Rating.ToString()}/5" });

        var marginLabels = new Thickness(3, 0);
        foreach (Label label in hlayout.Children.OfType<Label>())
        {
            label.Margin = marginLabels;
        }

        border.Content = hlayout;


        border.GestureRecognizers.Add(new TapGestureRecognizer()
        {
            Command = new Command(async () => await OnTapped(this, null))
        });

        Content = border;
    }




    private async Task OnTapped(object sender, TappedEventArgs e)
    {
        if (BindingContext is Game game)
        {
            await Shell.Current.GoToAsync(nameof(Pages.Games.GameDetail),
                new Dictionary<string, object> { { nameof(GameDetail.MyGame), game } });
        }
    }
}