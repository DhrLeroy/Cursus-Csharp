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
            gameRepository.AddGame(newgame);
        }

        public List<Game> GeefAlleGames()
        {
            return gameRepository.GeefAlleGames();
        }
    }
}
