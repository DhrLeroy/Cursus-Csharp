namespace MyMovieApp_Device.Pages.Movies;

public class MoviesOverview : ContentPage
{
	public MoviesOverview()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}