namespace MauiApp1.Layouts;

public class HStackLayout : ContentPage
{
	public HStackLayout()
    {
        var layout = new HorizontalStackLayout();
        layout.SetLabels();
        Content = layout;
    }
}