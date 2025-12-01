using MyRestaurant_Device.Pages.Menu_pages;

namespace MyRestaurant_Device
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MenuDetail), typeof(MenuDetail));

        }
    }
}
