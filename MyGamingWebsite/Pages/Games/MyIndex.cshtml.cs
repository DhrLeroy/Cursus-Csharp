using ILogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyGaming_Classes;

namespace MyGamingWebsite.Pages.Games
{
    public class MyIndexModel : PageModel
    {
        private IGameLogic logic;
        public List<Game> MyGames { get; set; }

        public MyIndexModel(IGameLogic logic)
        {
            this.logic = logic;
        }

        public string Titel { get; set; }
        public void OnGet()
        {
            Titel = "My games";
            MyGames = logic.GeefAlleGames();
        }
    }
}
