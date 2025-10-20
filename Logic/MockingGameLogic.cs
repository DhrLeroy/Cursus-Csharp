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
            new Game(){Titel = "Super Mario Bros", Rating = 10},
            new Game(){Titel = "Zelda", Rating = 9}
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
                new Game(){Titel = "1. Super Mario Bros", Rating = 10},
                new Game(){Titel = "2. Zelda", Rating = 9},
                new Game(){Titel = "3. Minecraft", Rating = 8.5f },
                new Game(){Titel = "4. Tetris", Rating = 8},
                new Game(){Titel = "5. Call of Duty", Rating = 7.5f },
                new Game(){Titel = "6. FIFA", Rating = 7 },
                new Game(){Titel = "7. Fortnite", Rating = 6.5f },
                new Game(){Titel = "8. Among Us", Rating = 6 },
                new Game(){Titel = "9. Candy Crush", Rating = 5.5f },
                new Game(){Titel = "10. Clash of Clans", Rating = 5 },
                new Game(){Titel = "11. Zelda", Rating = 9},
                new Game(){Titel = "12. Minecraft", Rating = 8.5f },
                new Game(){Titel = "13. Tetris", Rating = 8},
                new Game(){Titel = "14. Call of Duty", Rating = 7.5f },
                new Game(){Titel = "15. FIFA", Rating = 7 },
                new Game(){Titel = "16. Fortnite", Rating = 6.5f },
                new Game(){Titel = "17. Among Us", Rating = 6 },
                new Game(){Titel = "18. Candy Crush", Rating = 5.5f },
                new Game(){Titel = "19. Clash of Clans", Rating = 5 }
            };
        }
    }
}
