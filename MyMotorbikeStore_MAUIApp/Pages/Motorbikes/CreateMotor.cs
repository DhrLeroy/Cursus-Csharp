namespace MyMotorbikeStore_MAUIApp.Pages.Motorbikes;

public class CreateMotor : ContentPage
{
	public CreateMotor()
	{
		var vstack = new VerticalStackLayout();

		var hstackMerk = new HorizontalStackLayout();
		hstackMerk.Add(new Label() { Text = "Merk: " });
		var merkVeld = new Entry();
		hstackMerk.Add(merkVeld);
        vstack.Add(hstackMerk);

        var hstackModel = new HorizontalStackLayout();
        hstackModel.Add(new Label() { Text = "Model: " });
        var modelVeld = new Entry();
        hstackModel.Add(modelVeld);
        vstack.Add(hstackModel);

        var hstackPrijs = new HorizontalStackLayout();
        hstackPrijs.Add(new Label() { Text = "Prijs: " });
        var prijsVeld = new Entry();
        prijsVeld.Keyboard = Keyboard.Numeric;
        hstackPrijs.Add(prijsVeld);
        vstack.Add(hstackPrijs);

        Content = vstack;
    }
}