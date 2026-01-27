using MyMotorbikeStore_classes;
using MyMotorbikeStore_Services;

namespace MyMotorbikeStore_MAUIApp.Pages.Motorbikes;

public class MotorbikesOverview : ContentPage
{
	private IMotorbikeService _motorbikeService;

	public MotorbikesOverview(IMotorbikeService service)
	{
		_motorbikeService = service;
		
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        List<Motorbike> motorbikes = _motorbikeService.GetAllMotorbikes();

        var vstack = new VerticalStackLayout();

        var create = new Button();
        create.Text = "Voeg motorfiets toe";
        vstack.Children.Add(create);
        var createTap = new TapGestureRecognizer();
        createTap.Tapped += (s, e) =>
        {
            AppShell.Current.GoToAsync(nameof(CreateMotor));
        };
        create.GestureRecognizers.Add(createTap);

        foreach (var motorbike in motorbikes)
        {
            var hstack = new HorizontalStackLayout();
            var label = new Label();
            label.Text = $"{motorbike.Merk} {motorbike.Model}: {motorbike.Prijs} euro";

            var verwijder = new Button();
            verwijder.Text = "X";
            verwijder.BackgroundColor = Colors.Red;
            verwijder.FontSize = 10;
            verwijder.Padding = new Thickness(1);
            verwijder.HeightRequest = 5;
            verwijder.WidthRequest = 5;
            var removeSwipe = new SwipeGestureRecognizer()
            {
                Direction = SwipeDirection.Right
            };
            removeSwipe.Swiped += (s, e) =>
            {
                _motorbikeService.DeleteMotorbike(motorbike.Id);
            };

            hstack.Children.Add(label);
            hstack.Children.Add(verwijder);
            vstack.Children.Add(hstack);
        }

        var scroll = new ScrollView();
        scroll.Orientation = ScrollOrientation.Vertical;
        scroll.Content = vstack;
        Content = scroll;
    }
}