using MyMovieApp_classes;

namespace MyMovieApp_Device.Pages.Movies.Views;

public class MovieView : ContentView
{
	public MovieView(Movie movie)
	{
		var border = new Border();
		border.BackgroundColor = Colors.LightGoldenrodYellow;
		border.Margin = new Thickness(10, 5);

		var label = new Label();
		label.Text = $"{movie.Title} ({movie.Release.Year})";

		border.Content = label;

		BindingContext = movie;

		Content = border;

	}
}