using BotenApp.Klassen;

namespace BotenApp.Pages.Boten;

public class OverzichtBoten : ContentPage
{
	public OverzichtBoten()
	{
		List<Boot> mijnBoten = new List<Boot>
		{
			new Boot(2.5f, "Model A", 10.0f),
			new Boot(3.0f, "Model B", 12.5f),
			new Boot(1.8f, "Model C", 8.0f)
		};

		var vStack = new VerticalStackLayout();

        foreach (var boot in mijnBoten)
		{
			var hStack = new HorizontalStackLayout();
            
			var label = new Label();
			label.Text = $"{boot.Model} ({boot.Gewicht_Ton} ton)";
            hStack.Add(label);

			var btnBootDetail = new Button();
			hStack.Add(btnBootDetail);
            btnBootDetail.Text = "Ga naar boot";
            btnBootDetail.Clicked += (s, e) =>
			{
				Navigation.PushAsync(new BootDetail(boot));
            };
            vStack.Add(hStack);
        }

        Content = vStack;
	}
}