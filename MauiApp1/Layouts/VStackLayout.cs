namespace MauiApp1.Layouts;

public class VStackLayout : ContentPage
{
	public VStackLayout()
	{
		var layout = new VerticalStackLayout();
        layout.SetLabels();
		Content = layout;
    }
}