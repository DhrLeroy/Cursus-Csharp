using MyRestaurant_Klassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurant_Data
{
    public interface IMenuData
    {
        List<Menu> GeefAlleMenus();
    }
}
