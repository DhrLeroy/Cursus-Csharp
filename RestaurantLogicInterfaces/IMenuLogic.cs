using MyRestaurant_Klassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLogicInterfaces
{
    public interface IMenuLogic
    {
        List<Menu> GeefAlleMenus();
    }
}
