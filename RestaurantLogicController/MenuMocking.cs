using MyRestaurant_Klassen;
using RestaurantLogicInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLogicController
{
    public class MenuMocking : IMenuLogic
    {
        public List<Menu> GeefAlleMenus()
        {
            var menu1 = new Menu();

            return new List<Menu>() { menu1 };
        }
    }
}
