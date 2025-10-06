using MyGaming_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILogic
{
    public interface IGameLogic
    {
        void AddGame(Game newgame);
        List<Game> GeefAlleGames(int? leeftijd);
    }
}
