namespace MauiApp1.Layouts;

public class MyGridLayout : ContentPage
{
	public MyGridLayout()
	{
        var layout = new AbsoluteLayout();
        layout.SetLabels();
        Content = layout;
    }
}