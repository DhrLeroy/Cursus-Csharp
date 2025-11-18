using Microsoft.Maui.Layouts;

namespace MyGamingDeviceApp.Pages;

public class Pagina : ContentPage
{
	public Pagina()
	{
		Title = "Voorbeeld FlexLayout";

		var flex = new FlexLayout();
		flex.Direction = FlexDirection.Row;
		flex.Wrap = FlexWrap.Reverse;
		flex.FlowDirection = FlowDirection.RightToLeft;

		for(int i = 1; i <= 20; i++)
		{
			flex.Children.Add(new Label { Text = $"Label {i}", Margin = new Thickness(5) });
		}

		Content = flex;
	}
}


