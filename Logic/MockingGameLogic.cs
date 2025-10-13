using ILogic;
using MyGaming_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class MockingGameLogic : IGameLogic
    {
        private List<Game> games = new List<Game>()
        {
            new Game(){Titel = "Tetris", Rating = 8},
            new Game(){Titel = "Super Mario Bros", Rating = 10}
        };

        public void AddGame(Game newgame)
        {
            games.Add(newgame);
        }

        public List<Game> GeefAlleGames(int? leeftijd)
        {
            return games;
        }
    }
}
