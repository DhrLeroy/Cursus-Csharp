using MyMovieApp_classes;

namespace MyMovieApp_Device.Pages.Actors;

[QueryProperty(nameof(Actor), nameof(Actor))]
public class ActorDetails : ContentPage
{
	public Actor Actor { get; set; }

	public ActorDetails()
	{
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        BindingContext = Actor;

        Title = $"{Actor.First_name} {Actor.Last_name}";
    }
}