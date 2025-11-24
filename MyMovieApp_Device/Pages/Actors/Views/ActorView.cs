using MyMovieApp_classes;

namespace MyMovieApp_Device.Pages.Actors.Views;

public class ActorView : ContentView
{
	public ActorView(Actor actor)
	{
		var border = new Border();
		border.BackgroundColor = Colors.IndianRed;
		border.Margin = new Thickness(5, 10);

		var label = new Label();
		label.Text = $"{actor.Last_name.ToUpper()} {actor.First_name} ({actor.BepaalLeeftijd()} jaar)";

		border.Content = label;

		var onclick = new TapGestureRecognizer();

		onclick.Tapped += async (s, e) =>
		{
			await AppShell.Current.GoToAsync(nameof(ActorDetails), new Dictionary<string, object>()
			{
				{ nameof(ActorDetails.Actor), actor }
			});
		};

		border.GestureRecognizers.Add(onclick);

		Content = border;
	}
}