using MyMotorbikeStore_MAUIApp.Pages.Motorbikes;

namespace MyMotorbikeStore_MAUIApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MotorbikesOverview), typeof(MotorbikesOverview));
            Routing.RegisterRoute(nameof(CreateMotor), typeof(CreateMotor));
        }
    }
}
