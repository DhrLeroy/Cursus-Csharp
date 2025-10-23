namespace MauiApp1.Layouts;

public class MyAbsoluteLayout : ContentPage
{
	public MyAbsoluteLayout()
    {
        var layout = new AbsoluteLayout();
        layout.SetLabels();
        Content = layout;
    }
}