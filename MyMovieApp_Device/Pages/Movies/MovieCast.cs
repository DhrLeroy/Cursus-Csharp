using MyMovieApp_classes;
using MyMovieApp_Device.Pages.Actors.Views;

namespace MyMovieApp_Device.Pages.Movies;

[QueryProperty(nameof(Movie), nameof(Movie))]
public class MovieCast : ContentPage
{
	public Movie Movie { get; set; }

	public MovieCast()
	{

	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        if (Movie != null) { 
            Title = Movie.Title;

            var vStack = new VerticalStackLayout();

            foreach(var actor in Movie.Cast)
            {
                var actorView = new ActorView(actor);
                vStack.Add(actorView);
            }

            Content = vStack;
        }
    }
}