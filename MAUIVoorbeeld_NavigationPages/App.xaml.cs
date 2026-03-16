using MAUIVoorbeeld_NavigationPages.Paginas.XAML;

namespace MAUIVoorbeeld_NavigationPages
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Hoofdpagina());
        }
    }
}