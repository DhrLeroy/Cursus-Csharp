using MyMotorbikeStore_classes;
using MyMotorbikeStore_Services;

namespace MyMotorbikeStore_MAUIApp.Pages.Motorbikes;

public class CreateMotor : ContentPage
{
    private IMotorbikeService _motorbikeService;
    public CreateMotor(IMotorbikeService service)
	{
        _motorbikeService = service;
		var vstack = new VerticalStackLayout();

		var hstackMerk = new HorizontalStackLayout();
		hstackMerk.Add(new Label() { Text = "Merk: " });
        var merkVeld = new Entry();
        merkVeld.WidthRequest = 200;
		hstackMerk.Add(merkVeld);
        vstack.Add(hstackMerk);

        var hstackModel = new HorizontalStackLayout();
        hstackModel.Add(new Label() { Text = "Model: " });
        var modelVeld = new Entry();
        modelVeld.WidthRequest = 200;
        hstackModel.Add(modelVeld);
        vstack.Add(hstackModel);

        var hstackPrijs = new HorizontalStackLayout();
        hstackPrijs.Add(new Label() { Text = "Prijs: " });
        var prijsVeld = new Entry();
        prijsVeld.Keyboard = Keyboard.Numeric;
        hstackPrijs.Add(prijsVeld);
        vstack.Add(hstackPrijs);

        var opslaan = new Button();
        opslaan.Text = "Opslaan";
        var tapOpslaan = new TapGestureRecognizer();
        tapOpslaan.Tapped += async (s, e) =>
        {
            var nieuweMotor = new Motorbike();
            nieuweMotor.Merk = merkVeld.Text;
            nieuweMotor.Model = modelVeld.Text;
            nieuweMotor.Prijs = Convert.ToSingle(prijsVeld.Text);

            _motorbikeService.AddMotorbike(nieuweMotor);
            await AppShell.Current.GoToAsync(nameof(MotorbikesOverview));
        };
        opslaan.GestureRecognizers.Add(tapOpslaan);
        vstack.Add(opslaan);

        Content = vstack;
    }
}