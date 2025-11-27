using IMovieLogic;
using Microsoft.Maui.Layouts;
using MyMovieApp_classes;
using MyMovieApp_Device.Pages.Movies.Views;

namespace MyMovieApp_Device.Pages.Movies;

public class MoviesOverview : ContentPage
{
	private IMovieController movieLogic;

	public MoviesOverview(IMovieController mLogic)
	{
		movieLogic = mLogic;

		List<Movie> movies = movieLogic.GetAllMovies();

		var flex = new FlexLayout();
		flex.Direction = FlexDirection.Row;
		flex.Wrap = FlexWrap.Wrap;

		foreach (Movie movie in movies)
		{
			var movieView = new MovieView(movie);
			flex.Children.Add(movieView);

			var movieClick = new TapGestureRecognizer()
			{
				NumberOfTapsRequired = 2
			};

			movieClick.Tapped += async (s, e) =>
			{
				if (movieView.BindingContext is Movie m)
				{
					await AppShell.Current.GoToAsync(nameof(MovieCast), new Dictionary<string, object>()
					{
						{ nameof(MovieCast.Movie), m }
					});
				}
			};

			movieView.GestureRecognizers.Add(movieClick);

        }
        Content = flex;
    }
}