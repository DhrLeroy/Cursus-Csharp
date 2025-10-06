namespace MyGamingDeviceApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Pages.Games.GameDetail), typeof(Pages.Games.GameDetail));
        }
    }
}
