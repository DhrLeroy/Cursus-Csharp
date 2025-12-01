using Microsoft.Maui.Layouts;
using MyRestaurant_Device.Pages.Menu_pages.Views;
using MyRestaurant_Klassen;
using RestaurantLogicInterfaces;

namespace MyRestaurant_Device.Pages.Menu_pages;

public class MenuOverview : ContentPage
{
	private IMenuLogic logic;

    public MenuOverview(IMenuLogic logic)
    {
        this.logic = logic;

        List<Menu> menuList = logic.GeefAlleMenus();

        var flex = new FlexLayout();
        flex.Direction = FlexDirection.Row;
        flex.Wrap = FlexWrap.Wrap;

        foreach(var menu in menuList)
        {
            var view = new MenuView(menu);
            flex.Children.Add(view);
        }

        Content = flex;
    }
}