using FilmApp_databank;
using FilmApp_klassen;

namespace FilmApp;

public class FilmPagina : ContentPage
{
	public FilmPagina()
    {
        var db = new Databank();
        var vStack = new VerticalStackLayout();
        Content = vStack;//NIET VERGETEN

        var vStackFilms = new VerticalStackLayout();
        vStack.Add(vStackFilms);//NIET VERGETEN
        foreach (var film in db.Films)
        {
            var lblFilm = new Label();
            lblFilm.Text = $"{film.Titel} ({film.Duurtijd_minuten} minuten)";
            vStackFilms.Add(lblFilm);
        }

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
        entryDuurtijd.Placeholder = "Duurtijd (in minuten)";
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

        var btnOpslaan = new Button();
        vStack.Add(btnOpslaan);//NIET VERGETEN
        btnOpslaan.Text = "Opslaan";
        btnOpslaan.Clicked += (s, e) =>
        {
            var nieuweFilm = new Film();
            nieuweFilm.Titel = entryTitel.Text;
            nieuweFilm.Duurtijd_minuten = Convert.ToInt32(entryDuurtijd.Text);
            nieuweFilm.LiveAction = chckLiveAction.IsChecked;
            db.Films.Add(nieuweFilm);
            db.SaveChanges();
            entryTitel.Text = "";
            entryDuurtijd.Text = "";
            chckLiveAction.IsChecked = true;
            vStackFilms.Clear(); 
            foreach (var film in db.Films)
            {
                var lblFilm = new Label();
                lblFilm.Text = $"{film.Titel} ({film.Duurtijd_minuten} minuten)";
                vStackFilms.Add(lblFilm);
            }
        };

    }
}