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
            new Game(){Naam = "Tetris", Rating = 8},
            new Game(){Naam = "Super Mario Bros", Rating = 10},
            new Game(){Naam = "Zelda", Rating = 9}
        };

        public void AddGame(Game newgame)
        {
            games.Add(newgame);
        }

        public List<Game> GeefAlleGames(int? leeftijd)
        {
            return games;
        }

        public List<Game> GeefFavorieteGames()
        {
            return new List<Game>()
            {
                new Game(){Naam = "1. Super Mario Bros", Rating = 10},
                new Game(){Naam = "2. Zelda", Rating = 9},
                new Game(){Naam = "3. Minecraft", Rating = 8.5f },
                new Game(){Naam = "4. Tetris", Rating = 8},
                new Game(){Naam = "5. Call of Duty", Rating = 7.5f },
                new Game(){Naam = "6. FIFA", Rating = 7 },
                new Game(){Naam = "7. Fortnite", Rating = 6.5f },
                new Game(){Naam = "8. Among Us", Rating = 6 },
                new Game(){Naam = "9. Candy Crush", Rating = 5.5f },
                new Game(){Naam = "10. Clash of Clans", Rating = 5 },
                new Game(){Naam = "11. Zelda", Rating = 9},
                new Game(){Naam = "12. Minecraft", Rating = 8.5f },
                new Game(){Naam = "13. Tetris", Rating = 8},
                new Game(){Naam = "14. Call of Duty", Rating = 7.5f },
                new Game(){Naam = "15. FIFA", Rating = 7 },
                new Game(){Naam = "16. Fortnite", Rating = 6.5f },
                new Game(){Naam = "17. Among Us", Rating = 6 },
                new Game(){Naam = "18. Candy Crush", Rating = 5.5f },
                new Game(){Naam = "19. Clash of Clans", Rating = 5 }
            };
        }
    }
}
