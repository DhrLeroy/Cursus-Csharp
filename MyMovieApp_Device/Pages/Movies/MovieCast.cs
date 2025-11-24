using MyMovieApp_classes;

namespace MyMovieApp_Device.Pages.Movies;

[QueryProperty(nameof(Movie), nameof(Movie))]
public class MovieCast : ContentPage
{
	public Movie Movie;

	public MovieCast()
	{

	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        if (Movie != null) { 
            Title = Movie.Title;

            var vStack = new VerticalStackLayout();

            Movie.
        }
    }
}