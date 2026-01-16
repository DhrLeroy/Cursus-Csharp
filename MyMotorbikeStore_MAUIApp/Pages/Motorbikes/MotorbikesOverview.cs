using MyMotorbikeStore_classes;
using MyMotorbikeStore_Services;

namespace MyMotorbikeStore_MAUIApp.Pages.Motorbikes;

public class MotorbikesOverview : ContentPage
{
	private IMotorbikeService _motorbikeService;

	public MotorbikesOverview(IMotorbikeService service)
	{
		_motorbikeService = service;
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

		foreach(var motorbike in motorbikes)
		{
			var label = new Label();
			label.Text = $"{motorbike.Merk} {motorbike.Model}: {motorbike.Prijs} euro";
			vstack.Children.Add(label);
		}

		var scroll = new ScrollView();
		scroll.Orientation = ScrollOrientation.Vertical;
		scroll.Content = vstack;
		Content = scroll;
	}
}