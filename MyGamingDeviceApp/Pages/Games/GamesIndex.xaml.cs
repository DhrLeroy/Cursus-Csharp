using ILogic;
using MyGaming_Classes;
using MyGamingDeviceApp.Components.Games;
using MyGamingDeviceApp.Pages.Games.ViewModels;

namespace MyGamingDeviceApp.Pages.Games;

public partial class GamesIndex : ContentPage
{
	private IGameLogic gameLogic;


    public GamesIndex(IGameLogic gameLogic)
    {
        InitializeComponent();
        this.gameLogic = gameLogic;
        var games = gameLogic.GeefAlleGames(null);
        games.ForEach(g => Games.Add(new GameView(g)));
    }
}