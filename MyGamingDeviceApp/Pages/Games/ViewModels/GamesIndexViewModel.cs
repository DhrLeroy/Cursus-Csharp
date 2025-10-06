using MyGaming_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGamingDeviceApp.Pages.Games.ViewModels
{
    public class GamesIndexViewModel
    {
        public GamesIndexViewModel(List<Game> games)
        {
            Games = games;
        }

        public List<Game> Games { get; set; }
    }
}
