using MyMovieApp_Device.Pages.Actors;
using MyMovieApp_Device.Pages.Movies;

namespace MyMovieApp_Device
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MovieCast), typeof(MovieCast));
            Routing.RegisterRoute(nameof(ActorDetails), typeof(ActorDetails));
        }
    }
}
