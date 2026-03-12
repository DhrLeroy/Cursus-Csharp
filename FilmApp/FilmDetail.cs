using FilmApp_klassen;

namespace FilmApp;

//[QueryProperty(nameof(FilmDisplay), "film")]
public class FilmDetail : ContentPage
{
    /*private Film _filmDisplay;

    public Film FilmDisplay
    {
        get { return _filmDisplay; }
        set {
            _filmDisplay = value; }
    }*/

	public FilmDetail(Film FilmDisplay)
	{
        var vStack = new VerticalStackLayout();

        Content = vStack;


        var lblTitel = new Label();
        lblTitel.Text = $"Titel: {FilmDisplay.Titel}";
        vStack.Add(lblTitel);

        var lblDuurtijd = new Label();
        lblDuurtijd.Text = $"Duurtijd: {FilmDisplay.Duurtijd_minuten} minuten";
        vStack.Add(lblDuurtijd);

        var lblLiveAction = new Label();
        lblLiveAction.Text = $"Live-action: {(FilmDisplay.LiveAction ? "ja" : "nee")}";
        vStack.Add(lblLiveAction);
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();


        
    }
}