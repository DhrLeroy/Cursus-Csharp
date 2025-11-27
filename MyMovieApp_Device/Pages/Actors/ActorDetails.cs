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

        var vStack = new VerticalStackLayout();

        var hStackFirstname = new HorizontalStackLayout();
        var labelFirstname = new Label() { Text = "Voornaam: " };
        var entryFirstname = new Entry();
        entryFirstname.WidthRequest = 400;
        entryFirstname.Text = Actor.First_name;
        hStackFirstname.Children.Add(labelFirstname);
        hStackFirstname.Children.Add(entryFirstname);
        vStack.Children.Add(hStackFirstname);

        var hStackName = new HorizontalStackLayout();
        var labelName = new Label() { Text = "Naam: " };
        var entryName = new Entry();
        entryName.WidthRequest = 400;
        entryName.Text = Actor.Last_name;
        hStackName.Children.Add(labelName);
        hStackName.Children.Add(entryName);
        vStack.Children.Add(hStackName);

        var scroll = new ScrollView();
        scroll.Orientation = ScrollOrientation.Both;
        scroll.Content = vStack;

        Content = scroll;
    }
}