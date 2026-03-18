using BotenApp.Pages.Boten;

namespace BotenApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new OverzichtBoten());
        }
    }
}