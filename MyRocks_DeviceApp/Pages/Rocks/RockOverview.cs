using MyRocks_klassen;
using MyRocks_LogicInterface;

namespace MyRocks_DeviceApp.Pages.Rocks;

public class RockOverview : ContentPage
{
	public RockOverview(IRockLogic logic)
	{
		var vStack = new VerticalStackLayout();

		List<Rock> stenen = logic.GeefStenen();

		foreach(var steen in stenen)
		{
			var l = new Label();
			l.Text = steen.Type;
			vStack.Children.Add(l);
		}

		Content = vStack;
	}
}