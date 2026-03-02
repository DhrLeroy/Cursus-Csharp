using Microsoft.Maui.Controls.Shapes;

namespace MauiApp1.Layouts;

public class VStackLayout : ContentPage
{
	public VStackLayout()
	{
		var layout = new VerticalStackLayout();

        var nL = new HorizontalStackLayout();
        var lblNaam = new Label();
        lblNaam.Text = "Naam: ";

        nL.Add(new Label() { Text = "Naam: " });
        nL.Add(new Entry() { Placeholder = "Vul hier jouw naam in" });
        var naamEntry = new Entry() { Placeholder = "Vul hier jouw naam in" };
        Console.WriteLine(naamEntry.Text);
        var vL = new HorizontalStackLayout();
        vL.Add(new Label() { Text = "Voornaam: " });
        vL.Add(new Entry() { Placeholder = "Voornaam" });
        var lL = new HorizontalStackLayout();
        lL.Add(new Label() { Text = "Leeftijd: " });
        lL.Add(new Entry() { Placeholder = "Leeftijd (in jaar)" });

        //layout.Add(nL);
        //layout.Add(vL);
        //layout.Add(lL);

        var btn = new Button() { Text = "_" };
        btn.Clicked += (s, e) =>
        {
            btn.Text = btn.Text + "x";
        };

        layout.Add(btn);
        layout.Add(naamEntry);

        var chck = new CheckBox();
        chck.IsChecked = true;
        layout.Add(chck);

        layout.Children.Clear();
        var hEntry = new Entry();
        hEntry.Placeholder = "Hoogte (in m): ";
        layout.Add(hEntry);

        var btnH = new Button() { Text = "Toon hoogte" };
        btnH.Clicked += (s, e) =>
        {
            var height = Convert.ToSingle(hEntry.Text);
            btnH.Text = $"{height * 2 / 2} meter";
        };
        layout.Add(btnH);
        Content = layout;
    }
}