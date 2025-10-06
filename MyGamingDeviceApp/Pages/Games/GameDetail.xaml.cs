using MyGaming_Classes;

namespace MyGamingDeviceApp.Pages.Games;

[QueryProperty(nameof(Game), "Game")]
public partial class GameDetail : ContentPage
{
	private Game _game;

	public Game Game
	{
		get { return _game; }
		set { 
			_game = value;
			BindingContext = _game;
		}
	}


	public GameDetail()
	{
		InitializeComponent();
	}
}