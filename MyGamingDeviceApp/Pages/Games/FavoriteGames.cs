using ILogic;
using Microsoft.Maui.Layouts;
using MyGaming_Classes;
using MyGamingDeviceApp.Pages.Games.Views;

namespace MyGamingDeviceApp.Pages.Games;

public class FavoriteGames : ContentPage
{
    private IGameLogic _logic;

    public FavoriteGames(IGameLogic logic)
    {
        _logic = logic;

        Title = "Favoriete Games";

        
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        var scroll = new ScrollView();
        scroll.Orientation = ScrollOrientation.Horizontal;

        var layout = new FlexLayout();
        layout.Direction = FlexDirection.Row;
        layout.Wrap = FlexWrap.Wrap;

        List<Game> favorieteGames = _logic.GeefFavorieteGames();

        foreach (var game in favorieteGames)
        {
            layout.Add(new GameView(game));
        }

        scroll.Content = layout;

        Content = scroll;
    }
}