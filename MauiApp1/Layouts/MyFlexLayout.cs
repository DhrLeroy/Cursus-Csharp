using Microsoft.Maui.Layouts;

namespace MauiApp1.Layouts;

public class MyFlexLayout : ContentPage
{
	public MyFlexLayout()
    {
        var layout = new FlexLayout();
        layout.Direction = FlexDirection.Row;
        layout.Wrap = FlexWrap.Wrap;
        layout.SetLabels();
        Content = layout;
    }
}