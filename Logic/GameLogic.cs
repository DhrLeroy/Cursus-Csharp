using IData;
using ILogic;
using MyGaming_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class GameLogic : IGameLogic
    {
        private IGameData gameRepository;

        public GameLogic(IGameData gameRepository)
        {
            this.gameRepository = gameRepository;
        }

        public void AddGame(Game newgame)
        {
            if (string.IsNullOrWhiteSpace(newgame.Titel))
            {
                throw new ArgumentException("Titel mag niet leeg zijn.");
            }
            gameRepository.AddGame(newgame);
        }

        public List<Game> GeefAlleGames(int? leeftijd)
        {
             return gameRepository.GeefAlleGames().Where(g => !leeftijd.HasValue || g.MinimumLeeftijd <= leeftijd.Value).ToList();
        }
    }
}
