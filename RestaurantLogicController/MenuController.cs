using MyRestaurant_Data;
using MyRestaurant_Klassen;
using RestaurantLogicInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLogicController
{
    public class MenuController : IMenuLogic
    {
        private IMenuData data;

        public MenuController(IMenuData data)
        {
            this.data = data;
        }

        public List<Menu> GeefAlleMenus()
        {
            return data.GeefAlleMenus();
        }
    }
}
