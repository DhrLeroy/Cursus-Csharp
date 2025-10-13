using MyGaming_Classes;
using MyGamingDeviceApp.Pages.Games;

namespace MyGamingDeviceApp.Components.Games;

public partial class GameView : ContentView
{
    public GameView(Game game)
	{
		InitializeComponent();
		BindingContext = game;
	}

	private async void OnTapped(object sender, TappedEventArgs e)
	{
		/*if(BindingContext is Game game)
		{
			await Shell.Current.GoToAsync(nameof(Pages.Games.GameDetail),
				new Dictionary<string, object> { { nameof(GameDetail.Game), game } });
		}*/
	}
}