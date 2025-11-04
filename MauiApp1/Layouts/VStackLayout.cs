using Microsoft.Maui.Controls.Shapes;

namespace MauiApp1.Layouts;

public class VStackLayout : ContentPage
{
	public VStackLayout()
	{
		var layout = new VerticalStackLayout();
        //layout.SetLabels();

        var border = new Border()
        {
            Stroke = Brush.BlueViolet,
            StrokeThickness = 4,
            StrokeShape = new RoundRectangle()
            {
                CornerRadius = new CornerRadius(2)
            },
            Background = Brush.LightGreen,
            Padding = new Thickness(16, 8),
            HorizontalOptions = LayoutOptions.Center
        };
        border.Stroke = Brush.DarkMagenta;

        border.MakeBackgroundBlue();

        

        var hlayout = new HorizontalStackLayout();
        hlayout.MakeBackgroundBlue();


        hlayout.Background = Brush.LightYellow;
        var l1 = new Label() { Text = "Label 1" };
        var l2 = new Label() { Text = "Label 2" };
        var l3 = new Label() { Text = "Label 3" };
        hlayout.Children.Add(l1);
        hlayout.Children.Add(l2);
        hlayout.Children.Add(l3);
        foreach(var label in hlayout.Children.OfType<Label>())
        {
            label.MakeBackgroundBlue();
        }

        border.Content = hlayout;

        layout.Children.Add(border);
		
		Content = layout;
    }
}