using FilmApp_databank;
using FilmApp_klassen;

namespace FilmApp;

public class FilmPagina : ContentPage
{
    private VerticalStackLayout vStackFilms = new VerticalStackLayout();
    private Databank db = new Databank();
    public FilmPagina()
    {
        Title = "Films";

        var vStack = new VerticalStackLayout();
        Content = vStack;//NIET VERGETEN

        vStack.Add(vStackFilms);//NIET VERGETEN
        ShowMovies();

        var hStackTitel = new HorizontalStackLayout();
        hStackTitel.VerticalOptions = LayoutOptions.Center;
        
		hStackTitel.Add(new Label()
        {
            VerticalTextAlignment = TextAlignment.Center,
            Text = "Titel: "
        }); //NIET VERGETEN
        var entryTitel = new Entry();
        entryTitel.Placeholder = "Vul hier de titel in";
        hStackTitel.Add(entryTitel);//NIET VERGETEN
        vStack.Add(hStackTitel);//NIET VERGETEN

        var hStackDuurtijd = new HorizontalStackLayout();
        hStackDuurtijd.VerticalOptions = LayoutOptions.Center;
        hStackDuurtijd.Add(new Label()
        {
            VerticalTextAlignment = TextAlignment.Center,
            Text = "Duurtijd: "
        }); //NIET VERGETEN
        var entryDuurtijd = new Entry();
        entryDuurtijd.Placeholder = "Duurtijd (in minuten)";
        hStackDuurtijd.Add(entryDuurtijd);//NIET VERGETEN
        vStack.Add(hStackDuurtijd);//NIET VERGETEN

        var hStackLiveAction = new HorizontalStackLayout();
        hStackLiveAction.VerticalOptions = LayoutOptions.Center;
        hStackLiveAction.Add(new Label()
        {
            VerticalTextAlignment = TextAlignment.Center,
            Text = "Live-action: "
        }); //NIET VERGETEN
        var chckLiveAction = new CheckBox();
        chckLiveAction.IsChecked = true;
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
            ShowMovies();
        };

    }

    public void ShowMovies()
    {
        vStackFilms.Clear();
        var films = db.Films.ToList();
        for(int i = 0; i < films.Count; i++)
        {
            var film = films[i];
            var lblFilm = new Label();
            lblFilm.BackgroundColor = i % 2 == 0 ? Colors.LightBlue : Colors.LightGreen;
            lblFilm.Text = $"{film.Titel} ({film.Duurtijd_minuten} minuten)";
            vStackFilms.Add(lblFilm);
        }
    }
}