using KlereApp_klassen;

namespace KlereApp.Pages.Kledingstukken;

[QueryProperty(nameof(Kledingstuk), nameof(Kledingstuk))]
public class KledijstukDetail : ContentPage
{
    public Kledij Kledingstuk { get; set; }

    public KledijstukDetail()
	{

	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        var flex = new FlexLayout();
        flex.Direction = Microsoft.Maui.Layouts.FlexDirection.Row;
        flex.Wrap = Microsoft.Maui.Layouts.FlexWrap.Wrap;

        foreach(var maat in Kledingstuk.Maten)
        {
            flex.Add(new Label() { Text = maat.ToString(), Margin = new Thickness(20) });
        }

        Content = flex;
    }
}