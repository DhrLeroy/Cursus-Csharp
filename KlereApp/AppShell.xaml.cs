using KlereApp.Pages.Kledingstukken;

namespace KlereApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(KledijstukDetail), typeof(KledijstukDetail));
        }
    }
}
