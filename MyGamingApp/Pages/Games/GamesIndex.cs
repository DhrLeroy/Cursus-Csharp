using ILogic;

namespace MyGamingApp.Pages.Games;

public class GamesIndex : ContentPage
{
	private IGameLogic gameLogic;

	public GamesIndex(IGameLogic logic)
	{
		gameLogic = logic;
		var games = logic.GeefAlleGames(null);

        var layout = new VerticalStackLayout();
        foreach (var game in games)
		{
			layout.Add(new Label { Text = game.Naam });
		}

		Content = new VerticalStackLayout
		{
			Children = {
				layout
			}
		};
	}
}