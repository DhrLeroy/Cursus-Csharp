using ILogic;
using MyGamingDeviceApp.Pages.Games.Views;

namespace MyGamingDeviceApp.Pages.Games;

public class GameIndex : ContentPage
{
	private IGameLogic _logic;

    public GameIndex(IGameLogic logic)
	{
		_logic = logic;
		
        var layout = new VerticalStackLayout();

		foreach(var game in logic.GeefAlleGames(null))
		{
            layout.Add(new GameView(game));
        }

		Content = layout;
	}
}