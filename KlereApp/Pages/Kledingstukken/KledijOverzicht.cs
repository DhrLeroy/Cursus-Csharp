using KlereApp_klassen;
using KlereAppInterfaces;

namespace KlereApp.Pages.Kledingstukken;

public class KledijOverzicht : ContentPage
{
	public KledijOverzicht(IKledijLogic logic)
	{
		List<Kledij> kledijstukken = logic.GeefAlleKledij();

		var vStack = new VerticalStackLayout();

		foreach(var kledingstuk in kledijstukken)
		{
			var label = new Label()
			{
				Text = $"{kledingstuk.Merk} {kledingstuk.Type}"
			};

			var tap = new TapGestureRecognizer()
			{
				NumberOfTapsRequired = 2
			};
			tap.Tapped += async (s, e) =>
			{
				AppShell.Current.GoToAsync(nameof(KledijstukDetail), new Dictionary<string, object>
				{
					{nameof(KledijstukDetail.Kledingstuk), kledingstuk }
				});
			};
			label.GestureRecognizers.Add(tap);
			vStack.Add(label);
		}

		Content = vStack;

	}
}