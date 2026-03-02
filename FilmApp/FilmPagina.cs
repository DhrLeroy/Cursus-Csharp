namespace FilmApp;

public class FilmPagina : ContentPage
{
	public FilmPagina()
	{
		var vStack = new VerticalStackLayout();
        Content = vStack;//NIET VERGETEN

        var hStackTitel = new HorizontalStackLayout();
		var lblTitel = new Label();
		lblTitel.Text = "Titel: ";
		var entryTitel = new Entry();
		entryTitel.Placeholder = "Vul hier de titel in";
		hStackTitel.Add(lblTitel); //NIET VERGETEN
		hStackTitel.Add(entryTitel);//NIET VERGETEN
        vStack.Add(hStackTitel);//NIET VERGETEN

        var hStackDuurtijd = new HorizontalStackLayout();
        var lblDuurtijd = new Label();
        lblDuurtijd.Text = "Duurtijd (in minuten): ";
        var entryDuurtijd = new Entry();
        entryTitel.Placeholder = "Duurtijd (in minuten)";
        hStackDuurtijd.Add(lblDuurtijd); //NIET VERGETEN
        hStackDuurtijd.Add(entryDuurtijd);//NIET VERGETEN
        vStack.Add(hStackDuurtijd);//NIET VERGETEN

        var hStackLiveAction = new HorizontalStackLayout();
        var lblLiveAction = new Label();
        lblLiveAction.Text = "Live-action: ";
        var chckLiveAction = new CheckBox();
        chckLiveAction.IsChecked = true;
        hStackLiveAction.Add(lblLiveAction); //NIET VERGETEN
        hStackLiveAction.Add(chckLiveAction);//NIET VERGETEN
        vStack.Add(hStackLiveAction);//NIET VERGETEN

    }
}